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

namespace View
{
    public partial class frmAlterarAudiencia : Form
    {
        public frmAlterarAudiencia()
        {
            InitializeComponent();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Audiencia a = new Audiencia();
            a.Id_audiencia= txbID;
            a.Data_audiencia = txbData;
            
            CausasController ctrl = new CausasController();
            ctrl.ExecutarOpBD('a', a);
            this.Close();
        }
    }
}
