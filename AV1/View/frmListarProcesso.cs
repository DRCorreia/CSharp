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

        private void dgvProcesso_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
             try
            {
                Int64 idProcesso = Convert.ToInt64(dgvProcesso.SelectedRows[0].Cells[0].Value);

                Dictionary<Int64, Processo> mapaProcesso = (Dictionary<Int64, Processo>);

                Processo p = mapaProcesso[idProcesso];

                frmInserirProcesso form = new frmInserirProcesso();

                form.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO AO SELECIONAR LINHA: " + ex.Message);
            }
        }
        private void CarregarMapaProcesso()
        {
            Dictionary<Int64, Processo> mapaProcesso = (Dictionary<Int64, Processo>);
            foreach (Processo o in mapaProcesso.Values)
            {
                dgvProcesso.Rows.Add(o.Id, o.NomeCli, o.NomeAdv,o.Tipo,o.Situacao);
            }
        }

     }

}

