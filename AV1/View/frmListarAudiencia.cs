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
            Dictionary<Int64, Audiencia> mapaAudiencia = a.ExecutarOpBD('t');
            foreach (Audiencia o in mapaAudiencia.Values)
            {
                dgvAudiencia.Rows.Add(o.Id_audiencia, o.Nome_adv, o.Nome_cli ,o.Id_processo,o.Data_audiencia);
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
