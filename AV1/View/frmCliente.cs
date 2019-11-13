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
    public partial class frmCliente : Form
    {
        public frmCliente()
        {
            InitializeComponent();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            frmInserirCliente f = new frmInserirCliente();
            f.ShowDialog();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            frmListarCliente f = new frmListarCliente();
            f.ShowDialog();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            frmExcluirCliente f = new frmExcluirCliente();
            f.ShowDialog();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            frmAlterarCliente f = new frmAlterarCliente();
            f.ShowDialog();
        }

        private void btnProcurar_Click(object sender, EventArgs e)
        {
            frmProcurarCliente f = new frmProcurarCliente();
            f.ShowDialog();
        }

    }
}
