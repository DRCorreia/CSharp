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
    public partial class frmExcluirAdvogado : Form
    {
        public frmExcluirAdvogado()
        {
            InitializeComponent();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Advogado a = new Advogado();
            a.Id_adv = txbCpf;

            AdvogadoController ctrl = new AdvogadoController();
            ctrl.ExecutarOpBD('e', a);
            this.Close();
        }
    }
}
