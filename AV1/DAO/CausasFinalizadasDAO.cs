using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DAO;

namespace DAO
{
    public class CausasFinalizadasDAO
    {
        public CausasFinalizadas BuscarPorID(Int64 _id)
        {
            CausasFinalizadas c = null;
            try
            {
                String SQL = String.Format("SELECT * FROM causasfinalizadas WHERE id_processo = {0} ", _id);

                SqlCeDataReader data = BD.ExecutarSelect(SQL);

                if (data.Read())
                {
                    c = new CausasFinalizadas();

                    c.Id_processo = data.GetInt32(0);
                    c.Veredito = data.GetString(1);
                }

                data.Close();
                BD.FecharConexao();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return c;
        }

        public Boolean InserirBD(CausasFinalizadas _objeto)
        {
            bool resultado = false;
            try
            {
                String SQL = String.Format("INSERT INTO causasfinalizadas (id_processo,veredito) VALUES ('{0}', '{1}')",
                    _objeto.Id_processo,
                    _objeto.Veredito);

                int linhaAfetadas = BD.ExecutarIDU(SQL);

                if (linhaAfetadas > 0)
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return resultado;
        }

        public Boolean AlterarBD(CausasFinalizadas _objeto)
        {
            bool resultado = false;
            try
            {
                String SQL = String.Format("UPDATE causasfinalizadas SET veredito = {0} WHERE id_processo = {1};",
                    _objeto.Veredito,
                    _objeto.Id_processo);

                int linhaAfetadas = BD.ExecutarIDU(SQL);

                if (linhaAfetadas > 0)
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return resultado;
        }

        public Boolean DeletarBD(Int64 _id)
        {
            bool resultado = false;
            try
            {
                String SQL = String.Format("DELETE FROM causasfinalizadas WHERE id_processo = {0};", _id);

                int linhaAfetadas = BD.ExecutarIDU(SQL);

                if (linhaAfetadas > 0)
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return resultado;
        }

        public List<CausasFinalizadas> ListarTodos()
        {
            List<CausasFinalizadas> listaCausas = new List<CausasFinalizadas>();
            try
            {
                String SQL = "SELECT * FROM causasfinalizadas;";

                SqlCeDataReader data = BD.ExecutarSelect(SQL);

                while (data.Read())
                {
                    CausasFinalizadas c = new CausasFinalizadas();

                    c.Id_processo = data.GetInt32(0);
                    c.Veredito = data.GetString(1);
                    listaCausas.Add(c);
                }

                data.Close();
                BD.FecharConexao();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return listaCausas;
        }
    }
}
