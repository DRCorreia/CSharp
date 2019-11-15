using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller1
{
    public class CausasController
    {
        public Object ExecutarOpBD(char _c, CausasFinalizadas _o)
        {
            try
            {
                CausasFinalizadasDAO dao = new CausasFinalizadasDAO();
                switch (_c)
                {
                    case 'i':
                        return dao.Inserir(_o);
                    case 'd':
                        return dao.Deletar(_o.Id_processo);
                    case 'a':
                        return dao.Atualizar(_o);
                    case 't':
                        return dao.ListarTodos();
                    case 'o':
                        return dao.BuscarPorID(_o.Id_processo);
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
