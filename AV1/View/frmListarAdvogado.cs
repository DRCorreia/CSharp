using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using Controller1;

namespace View
{
    public partial class frmListarAdvogado : Form
    {
        public frmListarAdvogado()
        {
            InitializeComponent();
        }

        private void CarregarMapaAdvogados()
        {
            AdvogadoController a = new AdvogadoController();
            List<Advogado> listaAdvogados = a.ExecutarOpBD('t');
            foreach (Advogado o in listaAdvogados.Values)
            {
                dgvAdvogado.Rows.Add(o.Id_adv, o.Nome_adv, o.Email_adv,o.Tel_adv);
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

