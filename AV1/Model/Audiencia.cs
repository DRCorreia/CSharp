using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    class Audiencia
    {


        public Int32 Id_audiencia { set; get; }
        public Advogado Adv { set; get; }
        public Cliente Cli { set; get; }
        public Processo Processo { set; get; }
        public DateTime Data_audiencia { set; get; }
    
    }
}
