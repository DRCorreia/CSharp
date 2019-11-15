using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using Controller1

namespace View
{
    public partial class frmInserirCausaFinalizada : Form
    {
        public frmInserirCausaFinalizada()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            CausasFinalizadas c = new CausasFinalizadas();
            c.Id_processo = txbProcesso;
            c.Veredito = txbVeredito;
            
                CausasController ctrl = CausasController();

            ctrl.ExecutarOpBD('i', c);

            this.Close();
        }
    }
}
