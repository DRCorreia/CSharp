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
    public partial class frmExcluirAudiencia : Form
    {
        public frmExcluirAudiencia()
        {
            InitializeComponent();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Audiencia a = new Audiencia();
            a.Id_audiencia = txbID;

            AudienciaController ctrl = new AudienciaController();
            ctrl.ExecutarOpBD('e', a);
            this.Close();
        }

    }
}
