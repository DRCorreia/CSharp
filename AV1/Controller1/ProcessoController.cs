using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DAO;

namespace Controller1
{
    public class ProcessoController
    {
        public Object ExecutarOpBD(char _c, Processo _o)
        {
            try
            {
                ProcessoDAO dao = new ProcessoDAO();
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