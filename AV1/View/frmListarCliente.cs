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
    public partial class frmListarCliente : Form
    {
        public frmListarCliente()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmListarCliente_Load(object sender, EventArgs e)
        {
            Cliente cli = new Cliente();
            ClienteController c = new ClienteController();
            Dictionary<Int64, Cliente> mapaClientes = c.ExecutarOpBD('t',cli);
            foreach (Cliente o in mapaClientes.Values)
            {
                dgvCliente.Rows.Add(o.Id_cli, o.Nome_cli, o.Email_cli, o.Telefone_cli);
            }
        }
    }
}
