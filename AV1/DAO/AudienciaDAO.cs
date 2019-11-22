using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DAO;

namespace DAO
{
    public class AudienciaDAO
    {
        public Audiencia BuscarPorID(Int64 _id)
        {
            Audiencia a = null;
            try
            {
                String SQL = String.Format("SELECT * FROM audiencia WHERE id_audiencia = {0} ", _id);

                SqlCeDataReader data = BD.ExecutarSelect(SQL);

                if (data.Read())
                {
                    a = new Audiencia();

                    a.Id_audiencia = data.GetInt32(0);
                    a.Advogado.Nome_adv = data.GetString(1);
                    a.Cliente.Nome_cli = data.GetString(2);
                    a.Id_processo = data.GetInt32(3);
                    a.Data_audiencia = data.GetDate(4);
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

        public Boolean InserirBD(Audiencia _objeto)
        {
            bool resultado = false;
            try
            {
                String SQL = String.Format("INSERT INTO audiencia (id_audiencia,nome_adv,nome_cli, id_processo , data_audiencia) VALUES ('{0}', '{1}', '{2}', '{3}','{4}')",
                    _objeto.Id_audiencia,
                    _objeto.Advogado.Nome_adv,
                    _objeto.Cliente.Nome_cli,
                    _objeto.Id_processo,
                    _objeto.Data_audiencia);

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

        public Boolean AlterarBD(Audiencia _objeto)
        {
            bool resultado = false;
            try
            {
                String SQL = String.Format("UPDATE audiencia SET data_audiencia = '{0}' WHERE id_audiencia = {1};",
                    _objeto.Data_audiencia,
                    _objeto.Id_audiencia);

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
                String SQL = String.Format("DELETE FROM audiencia WHERE id_audiencia = {0};", _id);

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

        public List<Audiencia> ListarTodos()
        {
            List<Audiencia> listaAudiencia = new List<Audiencia>();
            try
            {
                String SQL = "SELECT * FROM audiencia;";

                SqlCeDataReader data = BD.ExecutarSelect(SQL);

                while (data.Read())
                {
                    Audiencia a = new Audiencia();

                    a.Id_audiencia = data.GetInt32(0);
                    a.Advogado.Nome_adv = data.GetString(1);
                    a.Cliente.Nome_cli = data.GetString(2);
                    a.Id_processo = data.GetInt32(3);
                    a.Data_audiencia = data.GetDate(4);

                    listaAudiencia.Add(a);
                }

                data.Close();
                BD.FecharConexao();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return listaAudiencia;
        }
    }
}
