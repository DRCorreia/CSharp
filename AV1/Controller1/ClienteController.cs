using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;

namespace Controller1
{
        public class ClienteController
        {
            public Object ExecutarOpBD(char _c, Cliente _o)
            {
                try
                {
                    ClienteDAO dao = new ClienteDAO();
                    switch (_c)
                    {
                        case 'i':
                            return dao.Inserir(_o);
                        case 'd':
                            return dao.Deletar(_o.Id_cli);
                        case 'a':
                            return dao.Atualizar(_o);
                        case 't':
                            return dao.ListarTodos();
                        case 'o':
                            return dao.BuscarPorID(_o.Id_cli);
                        default:
                            return null;
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }
        }
}
