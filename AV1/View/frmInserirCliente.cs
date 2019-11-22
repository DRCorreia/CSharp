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
    public partial class frmInserirCliente : Form
    {
        public frmInserirCliente()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Cliente c = new Cliente();
            c.Id_cli = txbCpf;
            c.Nome_cli = txbNome;
            c.Email_cli = txbEmail;
            c.Tel_cli = txbTelefone;

            ClienteController ctrlCli = ClienteController();

            ctrlCli.ExecutarOpBD('i', c);

            this.Close();
        }
    }
}
