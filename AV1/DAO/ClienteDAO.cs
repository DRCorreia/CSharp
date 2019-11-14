using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace DAO
{
    public class ClienteDAO
    {
        public Cliente BuscarPorID(Int64 _id)
        {
            Cliente c  = null;
            try
            {
                String SQL = String.Format("SELECT * FROM cliente WHERE id = {0} ", _id);

                SqlCeDataReader data = BD.ExecutarSelect(SQL);

                if (data.Read())
                {
                    c = new Advogado();

                    c.Id_cli = data.GetInt32(0);
                    c.Nome_cli = data.GetString(1);
                    c.Email_cli = data.GetString(2);
                    c.Telefone_cli = data.GetString(3);
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

        public Boolean InserirBD(Cliente _objeto)
        {
            bool resultado = false;
            try
            {
                String SQL = String.Format("INSERT INTO cliente (id,nome, email, telefone) VALUES ('{0}', '{1}', '{2}', '{3}')",
                    _objeto.Id_cli,
                    _objeto.Nome_cli,
                    _objeto.Email_cli,
                    _objeto.Telefone_cli);

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

        public Boolean AlterarBD(Cliente _objeto)
        {
            bool resultado = false;
            try
            {
                String SQL = String.Format("UPDATE cliente SET email = '{0}', telefone = '{1}' WHERE id = {2};",
                    _objeto.Email_cli,
                    _objeto.Telefone_cli,
                    _objeto.Id_cli);

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
                String SQL = String.Format("DELETE FROM cliente WHERE id = {0};", _id);

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

        public List<Cliente> ListarTodos()
        {
            List<Cliente> listaCliente = new List<Cliente>();
            try
            {
                String SQL = "SELECT * FROM advogado;";

                SqlCeDataReader data = BD.ExecutarSelect(SQL);

                while (data.Read())
                {
                   Cliente c = new Cliente();

                    c.Id_cli = data.GetInt32(0);
                    c.Nome_cli = data.GetString(1);
                    c.Email_cli = data.GetString(2);
                    c.Telefone_cli = data.GetString(3);

                    listaCliente.Add(c);
                }

                data.Close();
                BD.FecharConexao();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return listaCliente;
        }
    }
}
