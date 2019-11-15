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
            Dictionary<Int64, Processo> mapaProcessos = ctrl.ExecutarOpBD('t', p);
            foreach (Processo o in mapaProcessos.Values)
            {
                dgvProcesso.Rows.Add(o.Id_processo, o.Nome_cli, o.Nome_adv,o.Tipo_processo, o.Situacao_processo);
            }
        }


     }

}

