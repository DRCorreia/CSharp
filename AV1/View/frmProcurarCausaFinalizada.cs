using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controller1;
using Model;

namespace View
{
    public partial class frmProcurarCausaFinalizada : Form
    {
        public frmProcurarCausaFinalizada()
        {
            InitializeComponent();
        }

        private void btnProcurar_Click(object sender, EventArgs e)
        {
            CausasFinalizadas c = new CausasFinalizadas();
            c.Id_processo = txbID;
            CausasController ctrl = new CausasController();
            ctrl.ExecutarOpBD('o', ctrl);
            this.Close();
        }
    }
}
