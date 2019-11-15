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
    public partial class frmProcurarCliente : Form
    {
        public frmProcurarCliente()
        {
            InitializeComponent();
        }

        private void btnProcurar_Click(object sender, EventArgs e)
        {
            Cliente c = new Cliente();
            c.Id_Cli = txbID;
            ClienteController ctrl = new ClienteController();
            ctrl.ExecutarOpBD('o', ctrl);
            this.Close();
        }
    }
}
