using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    class Processo
    {

        public Int32 Id_processo { set; get; }
        public Cliente Cliente { set; get; }
        public Advogado Advogado { set; get; }
        public String Tipo_processo { set; get; }
        public String Situacao_processo { set; get; }
    }
}
