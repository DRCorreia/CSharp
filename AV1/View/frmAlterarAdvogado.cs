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
using DAO;

namespace View
{
    public partial class frmAlterarCliente : Form
    {
        public frmAlterarCliente()
        {
            InitializeComponent();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Advogado a = new Advogado();
            a.Id_Adv = txbCpf;
            a.Email_Adv = txbEmail;
            a.Telefone_Adv = txbTelefone;

            ClienteController ctrl = new ClienteController();
            ctrl.ExecutarOpBD('a', ctrl);
            this.Close();
        }
    }
}
