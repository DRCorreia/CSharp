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
    public partial class frmAudiencia : Form
    {
        public frmAudiencia()
        {
            InitializeComponent();
        }

        private void frmAudiencia_Load(object sender, EventArgs e)
        {

        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            frmInserirAudiencia a = new frmInserirAudiencia();
            a.ShowDialog();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            frmListarAudiencia a = new frmListarAudiencia();
            a.ShowDialog();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            frmExcluirAudiencia a = new frmExcluirAudiencia();
            a.ShowDialog();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            frmAlterarAudiencia a = new frmAlterarAudiencia();
            a.ShowDialog();
        }
        
         private void btnProcurar_Click(object sender, EventArgs e)
        {
            frmProcurarAudiencia a = new frmProcurarAudiencia();
            a.ShowDialog();
        }


    }
}
