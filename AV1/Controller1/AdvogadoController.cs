using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Controller1
{
    class AdvogadoController
    {
        public class AdvogadoController
        {
            public Object ExecutarOpBD(char _c, Advogado _o)
            {
                try
                {
                    AdvogadoDAO dao = new AdvogadoDAO();
                    switch (_c)
                    {
                        case 'i':
                            return dao.Inserir(_o);
                        case 'd':
                            return dao.Deletar(_o.Id);
                        case 'a':
                            return dao.Atualizar(_o);
                        case 't':
                            return dao.ListarTodos();
                        case 'o':
                            return dao.BuscarPorID(_o.Id);
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
}
