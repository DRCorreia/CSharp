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
    public partial class frmInserirAudiencia : Form
    {
        public frmInserirAudiencia()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Audiencia a = new Audiencia();
            a.Id_audiencia = txbID;
            a.Nome_adv = txbAdv;
            a.Nome_cli = txbCli;
            a.Id_processo = txbProcesso;
            a.Data_audiencia = txbData;

            AudienciaController ctrl = AudienciaController();

            ctrl.ExecutarOpBD('i', a);

            this.Close();
        }
    }
}
