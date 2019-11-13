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
            c.Id = txbCpf;
            c.Nome = txbNome;
            c.Email = txbEmail;
            c.Telefone = txbTelefone;

            ClienteController ctrlCli = ClienteController();

            ctrlCli.ExecutarOpBD('i', c);

            this.Close();
        }
    }
}
