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
    public partial class frmCausasFinalizadas : Form
    {
        public frmCausasFinalizadas()
        {
            InitializeComponent();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            frmInserirCausaFinalizada c = new frmInserirCausaFinalizada();
            c.ShowDialog();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            frmListarCausaFinalizada c = new frmListarCausaFinalizada();
            c.ShowDialog();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            frmExcluirCausaFinalizada c = new frmExcluirCausaFinalizada();
            c.ShowDialog();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            frmAlterarCausaFinalizada c = new frmAlterarCausaFinalizada();
            c.ShowDialog();
        }

        private void btnProcurar_Click(object sender, EventArgs e)
        {
            frmProcurarCausaFinalizada c = new frmProcurarCausaFinalizada();
            c.ShowDialog();
        }
    }
}
