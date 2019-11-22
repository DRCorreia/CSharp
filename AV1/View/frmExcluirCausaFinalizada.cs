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
using Controller1;

namespace View
{
    public partial class frmExcluirCausaFinalizada : Form
    {
        public frmExcluirCausaFinalizada()
        {
            InitializeComponent();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            CausasFinalizadas c = new CausasFinalizadas();
            c.Processo.Id_processo = txbID;

            CausasController ctrl = new CausasController();
            ctrl.ExecutarOpBD('e', c);
            this.Close();
        }
    }
}
