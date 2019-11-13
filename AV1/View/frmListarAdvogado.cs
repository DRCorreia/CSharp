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
            Dictionary<Int64, Advogado> mapaAdvogados = a.ExecutarOpBD('t');
            foreach (Advogado o in mapaAdvogados.Values)
            {
                dgvAdvogado.Rows.Add(o.Id, o.Nome, o.Email,o.Telefone);
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

