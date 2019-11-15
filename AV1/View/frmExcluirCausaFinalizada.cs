using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            c.Id_processo = txbID;

            CausasController ctrl = new CausasController();
            ctrl.ExecutarOpBD('e', a);
            this.Close();
        }
    }
}
