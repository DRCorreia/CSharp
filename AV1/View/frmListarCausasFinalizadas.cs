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
    public partial class frmListarCausasFinalizadas : Form
    {
        public frmListarCausasFinalizadas()
        {
            InitializeComponent();
        }

        private void CarregarMapaCausas()
        {
            CausasController c = new CausasController();
            List<CausasFinalizadas> listaCausas = c.ExecutarOpBD('t');
            foreach (CausasFinalizadas o in Lista.Values)
            {
                dgvCausasFinalizadas.Rows.Add(o.Processo.Id_processo,o.Veredito);
            }
        }
        
        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
