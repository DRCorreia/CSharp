namespace View
{
    partial class frmPaginaInicial
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.lblCli = new System.Windows.Forms.Label();
            this.lblAdvogado = new System.Windows.Forms.Label();
            this.lblAudiencia = new System.Windows.Forms.Label();
            this.lblCausasFinalizadas = new System.Windows.Forms.Label();
            this.lblProcessos = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(248, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Página Inicial";
            // 
            // lblCli
            // 
            this.lblCli.AutoSize = true;
            this.lblCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCli.Location = new System.Drawing.Point(292, 339);
            this.lblCli.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblCli.Name = "lblCli";
            this.lblCli.Size = new System.Drawing.Size(96, 29);
            this.lblCli.TabIndex = 1;
            this.lblCli.Text = "Cliente";
            this.lblCli.Click += new System.EventHandler(this.lblCli_Click);
            // 
            // lblAdvogado
            // 
            this.lblAdvogado.AutoSize = true;
            this.lblAdvogado.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdvogado.Location = new System.Drawing.Point(292, 157);
            this.lblAdvogado.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblAdvogado.Name = "lblAdvogado";
            this.lblAdvogado.Size = new System.Drawing.Size(143, 29);
            this.lblAdvogado.TabIndex = 2;
            this.lblAdvogado.Text = "Advogados";
            this.lblAdvogado.Click += new System.EventHandler(this.lblAdvogado_Click);
            // 
            // lblAudiencia
            // 
            this.lblAudiencia.AutoSize = true;
            this.lblAudiencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAudiencia.Location = new System.Drawing.Point(292, 220);
            this.lblAudiencia.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblAudiencia.Name = "lblAudiencia";
            this.lblAudiencia.Size = new System.Drawing.Size(128, 29);
            this.lblAudiencia.TabIndex = 3;
            this.lblAudiencia.Text = "Audiência";
            this.lblAudiencia.Click += new System.EventHandler(this.lblAudiencia_Click);
            // 
            // lblCausasFinalizadas
            // 
            this.lblCausasFinalizadas.AutoSize = true;
            this.lblCausasFinalizadas.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCausasFinalizadas.Location = new System.Drawing.Point(292, 281);
            this.lblCausasFinalizadas.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblCausasFinalizadas.Name = "lblCausasFinalizadas";
            this.lblCausasFinalizadas.Size = new System.Drawing.Size(239, 29);
            this.lblCausasFinalizadas.TabIndex = 4;
            this.lblCausasFinalizadas.Text = "Causas Finalizadas";
            this.lblCausasFinalizadas.Click += new System.EventHandler(this.lblCausasFinalizadas_Click);
            // 
            // lblProcessos
            // 
            this.lblProcessos.AutoSize = true;
            this.lblProcessos.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProcessos.Location = new System.Drawing.Point(292, 395);
            this.lblProcessos.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblProcessos.Name = "lblProcessos";
            this.lblProcessos.Size = new System.Drawing.Size(136, 29);
            this.lblProcessos.TabIndex = 5;
            this.lblProcessos.Text = "Processos";
            this.lblProcessos.Click += new System.EventHandler(this.lblProcessos_Click);
            // 
            // frmPaginaInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 532);
            this.Controls.Add(this.lblProcessos);
            this.Controls.Add(this.lblCausasFinalizadas);
            this.Controls.Add(this.lblAudiencia);
            this.Controls.Add(this.lblAdvogado);
            this.Controls.Add(this.lblCli);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmPaginaInicial";
            this.Text = "PaginaInicial";
            this.Load += new System.EventHandler(this.frmPaginaInicial_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCli;
        private System.Windows.Forms.Label lblAdvogado;
        private System.Windows.Forms.Label lblAudiencia;
        private System.Windows.Forms.Label lblCausasFinalizadas;
        private System.Windows.Forms.Label lblProcessos;
    }
}