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
    public partial class frmInserirAdvogado : Form
    {
        public frmInserirAdvogado()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
           Advogado a = new Advogado();
            a.Id_adv = txbCpf;
            a.Nome_adv = txbNome;
            a.Email_adv = txbEmail;
            a.Tel_adv = txbTelefone;

            AdvogadoController ctrlAdv = AdvogadoController();

            ctrlAdv.ExecutarOpBD('i', a);

            this.Close();
        }
    }
}

