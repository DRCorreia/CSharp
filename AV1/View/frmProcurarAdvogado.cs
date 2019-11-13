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
using Controlle1;

namespace View
{
    public partial class frmProcurarAdvogado : Form
    {
        public frmProcurarAdvogado()
        {
            InitializeComponent();
        }

        private void btnProcurar_Click(object sender, EventArgs e)
        {
            Advogado a = new Advogado();
            a.Id_Adv = txbID;
            AdvogadoController ctrl = new AdvogadoController();
            ctrl.ExecutarOpBD('o', a);
            this.Close();
        }

    }
}
