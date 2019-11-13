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
    public partial class frmExcluirCliente : Form
    {
        public frmExcluirCliente()
        {
            InitializeComponent();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Cliente c = new Cliente();
            c.Id = txbCpf;

            ClienteController ctrl = new ClienteController();
            ctrl.ExecutarOpBD('e', ctrl);
            this.Close();
        }
    }
}
