using Model;
using System;
using System.Collections.Generic;
using System.Data.SqlServerCe;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    class ProcessoDAO
    {
        public Processo BuscarPorID(Int64 _id)
        {
            Processo p = null;
            try
            {
                String SQL = String.Format("SELECT * FROM processo WHERE id_processo = {0} ", _id);

                SqlCeDataReader data = BD.ExecutarSelect(SQL);

                if (data.Read())
                {
                    Processo p = new Processo();

                    p.Id_processo = data.GetInt32(0);
                    p.Nome_cli = data.GetString(1);
                    p.Nome_adv = data.GetString(2);
                    p.Tipo_processo = data.GetInt32(3);
                    p.Situacao_processo = data.GetDate(4);
                }

                data.Close();
                BD.FecharConexao();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return p;
        }

        public Boolean InserirBD(Processo _objeto)
        {
            bool resultado = false;
            try
            {
                String SQL = String.Format("INSERT INTO processo (id_processo,nome_cli,nome_adv, tipo_processo , situacao_processo) VALUES ('{0}', '{1}', '{2}', '{3}','{4}')",
                    _objeto.Id_processo,
                    _objeto.Nome_cli,
                    _objeto.Nome_adv,
                    _objeto.Tipo_processo,
                    _objeto.Situacao_processo);

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

        public Boolean AlterarBD(Processo _objeto)
        {
            bool resultado = false;
            try
            {
                String SQL = String.Format("UPDATE processo SET situacao_processo = '{0}' WHERE id_processo = {1};",
                    _objeto.Situacao_processo,
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
                String SQL = String.Format("DELETE FROM processo WHERE id_processo = {0};", _id);

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

        public List<Processo> ListarTodos()
        {
            List<Processo> listaProcesso = new List<Processo>();
            try
            {
                String SQL = "SELECT * FROM processo;";

                SqlCeDataReader data = BD.ExecutarSelect(SQL);

                while (data.Read())
                {
                    Processo p = new Processo();

                    p.Id_processo = data.GetInt32(0);
                    p.Nome_cli = data.GetString(1);
                    p.Nome_adv = data.GetString(2);
                    p.Tipo_processo = data.GetInt32(3);
                    p.Situacao_processo = data.GetDate(4);

                    listaProcesso.Add(p);
                }

                data.Close();
                BD.FecharConexao();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return listaProcesso;
        }
    }
}
