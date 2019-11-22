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
    public partial class frmListarProcesso : Form
    {
        public frmListarProcesso()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmListarProcesso_Load(object sender, EventArgs e)
        {
            Processo p = new Processo();
            ProcessoController ctrl = new ProcessoController();
            List<Processo> listaProcessos = ctrl.ExecutarOpBD('t', p);
            foreach (Processo o in listaProcessos.Values)
            {
                dgvProcesso.Rows.Add(o.Id_processo, o.Cliente.Nome_cli, o.Advogado.Nome_adv,o.Tipo_processo, o.Situacao_processo);
            }
        }


     }

}

