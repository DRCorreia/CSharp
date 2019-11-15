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
    public partial class frmAlterarProcesso : Form
    {
        public frmAlterarProcesso()
        {
            InitializeComponent();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Processo p = new Processo();
            p.Id_processo = txbID;
            p.Situacao = txbSituacao;

            ProcessoController ctrl = new ProcessoController();
            ctrl.ExecutarOpBD('a', p);
            this.Close();
        }

    }
}
