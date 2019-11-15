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
    public partial class frmProcesso : Form
    {
        public frmProcesso()
        {
            InitializeComponent();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            frmInserirProcesso p = new frmInserirProcesso();
            p.ShowDialog();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            frmListarProcesso p = new frmListarProcesso();
            p.ShowDialog();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            frmExcluirProcesso p = new frmExcluirProcesso();
            p.ShowDialog();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            frmAlterarProcesso p = new frmAlterarProcesso();
            p.ShowDialog();
        }

        private void btnProcurar_Click(object sender, EventArgs e)
        {
            frmProcurarProcesso p = new frmProcurarProcesso();
            p.ShowDialog();
        }
    }
}
