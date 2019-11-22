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
    public partial class frmInserirProcesso : Form
    {
        public frmInserirProcesso()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Processo p = new Processo();
            p.Id_processo = txbProcesso;
            p.Cliente.Nome_cli = txbCliente;
            p.Advogado.Nome_adv = txbAdvogado;
            p.Tipo_processo = txbTipo;
            p.Situacao_processo = txbSituacao;

            ProcessoController ctrl = ProcessoController();

            ctrl.ExecutarOpBD('i', p);

            this.Close();
        }
    }
}
