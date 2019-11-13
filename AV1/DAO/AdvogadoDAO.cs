using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace DAO
{
    public class AdvogadoDAO
    {
        public Advogado BuscarPorID(Int64 _id)
        {
            Advogado a = null;
            try
            {
                String SQL = String.Format("SELECT * FROM advogado WHERE id = {0} ", _id);

                SqlCeDataReader data = BD.ExecutarSelect(SQL);

                if (data.Read())
                {
                    a = new Advogado();

                    a.Id = data.GetInt32(0);
                    a.Nome = data.GetString(1);
                    a.Email = data.GetString(2);
                    a.Telefone = data.GetString(3);
                }

                data.Close();
                BD.FecharConexao();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return a;
        }

        public Boolean InserirBD(Advogado _objeto)
        {
            bool resultado = false;
            try
            {
                String SQL = String.Format("INSERT INTO advogado (id,nome, email, telefone) VALUES ('{0}', '{1}', '{2}', '{3}')",
                    _objeto.Id,
                    _objeto.Nome,
                    _objeto.Email,
                    _objeto.Telefone);

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

        public Boolean AlterarBD(Advogado _objeto)
        {
            bool resultado = false;
            try
            {
                String SQL = String.Format("UPDATE advogado SET email = '{0}', telefone = '{1}' WHERE id = {2};",
                    _objeto.Email,
                    _objeto.Telefone,
                    _objeto.Id);

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
                String SQL = String.Format("DELETE FROM advogado WHERE id = {0};", _id);

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

        public List<Advogado> ListarTodos()
        {
            List<Advogado> listaAdvogado = new List<Advogado>();
            try
            {
                String SQL = "SELECT * FROM advogado;";

                SqlCeDataReader data = BD.ExecutarSelect(SQL);

                while (data.Read())
                {
                    Advogado a = new Advogado();

                    a.Id = data.GetInt32(0);
                    a.Nome = data.GetString(1);
                    a.Email = data.GetString(2);
                    a.Telefone = data.GetString(3);

                    listaAdvogado.Add(a);
                }

                data.Close();
                BD.FecharConexao();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return listaAdvogado;
        }
    }
}

