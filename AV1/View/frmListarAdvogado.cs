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
    public partial class frmListarAdvogado : Form
    {
        private Advogado a;
        public frmListarAdvogado()
        {
            InitializeComponent();
        }
        
        
        private void documento_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            StringBuilder data = new StringBuilder();
            StringWriter escritor = new StringWriter(data);

            Advogado _advogado = a;

            escritor.WriteLine(_advogado.Id + ";");
            escritor.WriteLine(_advogado.Nome + ";");
            escritor.WriteLine(_advogado.Email + ";");
            escritor.WriteLine(_advogado.Telefone + ";");

            escritor.WriteLine(String.Format("\n\n\nData/Hora do Cadastro: {0}", DateTime.Now.ToString()));

            escritor.Close();

            float leftMargin = e.MarginBounds.Left;
            float topMargin = e.MarginBounds.Top;
            float yPos = 0;

            Font printFont = new Font("Arial", 12);
            yPos = topMargin + printFont.GetHeight(e.Graphics);
            e.HasMorePages = false;
            e.Graphics.DrawString(data.ToString(), printFont, Brushes.Black, leftMargin, yPos, new StringFormat());
        }


        private void dgvAdvogado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
