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
    public partial class frmAlterarCliente : Form
    {
        public frmAlterarCliente()
        {
            InitializeComponent();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Cliente c = new Cliente();
            c.Id = txbCpf;
            c.Email = txbEmail;
            c.Telefone = txbTelefone;

            ClienteController c = new ClienteController();
            c.ExecutarOpBD('a', c);
            this.Close();
        }
    }
}
