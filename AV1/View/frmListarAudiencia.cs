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
using Model;

namespace View
{
    public partial class frmListarAudiencia : Form
    {
        public frmListarAudiencia()
        {
            InitializeComponent();
        }

        private void dgvAudiencia_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        
        private void CarregarMapaAudiencia()
        {
            AudienciaController a = new AudienciaController();
            List<Audiencia> listaAudiencia = a.ExecutarOpBD('t');
            foreach (Audiencia o in listaAudiencia.Values)
            {
                dgvAudiencia.Rows.Add(o.Id_audiencia, o.Advogado.Nome_adv, o.Cliente.Nome_cli ,o.Processo.Id_processo,o.Data_audiencia);
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
