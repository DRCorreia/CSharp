using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using Model;

namespace Controller1
{
        public class AudienciaController
        {
            public Object ExecutarOpBD(char _c, Audiencia _o)
            {
                try
                {
                    AudienciaDAO dao = new AudienciaDAO();
                    switch (_c)
                    {
                        case 'i':
                            return dao.Inserir(_o);
                        case 'd':
                            return dao.Deletar(_o.Id_audiencia);
                        case 'a':
                            return dao.Atualizar(_o);
                        case 't':
                            return dao.ListarTodos();
                        case 'o':
                            return dao.BuscarPorID(_o.Id_audiencia);
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
