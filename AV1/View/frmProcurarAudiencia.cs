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
    public partial class frmProcurarAudiencia : Form
    {
        public frmProcurarAudiencia()
        {
            InitializeComponent();
        }

        private void btnProcurar_Click(object sender, EventArgs e)
        {
            Audiencia a = new Audiencia();
            a.Id_audiencia = txbID;
            AudienciaController ctrl = new AudienciaController();
            ctrl.ExecutarOpBD('o', a);
            this.Close();
        }
    }
}
