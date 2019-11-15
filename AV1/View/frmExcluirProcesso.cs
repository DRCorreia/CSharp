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
    public partial class frmExcluirProcesso : Form
    {
        public frmExcluirProcesso()
        {
            InitializeComponent();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Processo p = new Processo();
            p.Id_processo = txbID;

            ProcessoController ctrl = new ProcessoController();
            ctrl.ExecutarOpBD('e', p);
            this.Close();
        }
    }
}
