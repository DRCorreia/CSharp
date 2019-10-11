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

namespace View
{
    public partial class frmPaginaInicial : Form
    {
        private Dictionary<Int64, Processo> mapaProcesso;

        public frmPaginaInicial()
        {
            InitializeComponent();
        }

        private void lblAdvogado_Click(object sender, EventArgs e)
        {
            frmAdvogado a = new frmAdvogado();
            a.ShowDialog();
        }

        private void lblAudiencia_Click(object sender, EventArgs e)
        {
            frmAudiencia a = new frmAudiencia();
            a.ShowDialog();
        }

        private void lblCausasFinalizadas_Click(object sender, EventArgs e)
        {
            frmCausasFinalizadas c = new frmCausasFinalizadas();
            c.ShowDialog();
        }

        private void lblCli_Click(object sender, EventArgs e)
        {
            frmCliente c = new frmCliente();
            c.ShowDialog();
        }

        private void lblProcessos_Click(object sender, EventArgs e)
        {
            frmProcesso p = new frmProcesso();
            p.ShowDialog();
        }

        private void frmPaginaInicial_Load(object sender, EventArgs e)
        {

        }


    }
}
