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
        private void CarregarMapaCliente()
        {
            Dictionary<Int64, Cliente> mapaClientes = (Dictionary<Int64, Cliente>)this.Tag;
            foreach (Cliente o in mapaClientes.Values)
            {
                dgvCliente.Rows.Add(o.Id, o.Nome, o.Email,o.Telefone);
            }
        }
    }
}
