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
    public partial class frmAlterarCausaFinalizada : Form
    {
        public frmAlterarCausaFinalizada()
        {
            InitializeComponent();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
           CausasFinalizadas c = new CausasFinalizadas();
            c.Id_processo = txbID;
            c.Veredito = txbVeredito;
            
            CausasController ctrl = new CausasController();
            ctrl.ExecutarOpBD('a', c);
            this.Close();
        }
    }
}
