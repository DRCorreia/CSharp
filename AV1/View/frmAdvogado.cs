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
    public partial class frmAdvogado : Form
    {
        public frmAdvogado()
        {
            InitializeComponent();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            frmInserirAdvogado f = new frmInserirAdvogado();
            f.ShowDialog();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            frmListarAdvogado f = new frmListarAdvogado();
            f.ShowDialog();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            frmExcluirAdvogado f = new frmExcluirAdvogado();
            f.ShowDialog();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            frmAlterarAdvogado f = new frmAlterarAdvogado();
            f.ShowDialog();
        }

    }
}
