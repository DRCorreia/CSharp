namespace View
{
    partial class frmListarAudiencia
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
            this.dgvAudiencia = new System.Windows.Forms.DataGridView();
            this.btnFechar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAudiencia)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAudiencia
            // 
            this.dgvAudiencia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAudiencia.Location = new System.Drawing.Point(42, 59);
            this.dgvAudiencia.Name = "dgvAudiencia";
            this.dgvAudiencia.RowTemplate.Height = 24;
            this.dgvAudiencia.Size = new System.Drawing.Size(340, 150);
            this.dgvAudiencia.TabIndex = 0;
            this.dgvAudiencia.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAudiencia_CellContentClick);
            // 
            // btnFechar
            // 
            this.btnFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.Location = new System.Drawing.Point(175, 254);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(75, 27);
            this.btnFechar.TabIndex = 1;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // frmListarAudiencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 328);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.dgvAudiencia);
            this.Name = "frmListarAudiencia";
            this.Text = "frmListarAudiencia";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAudiencia)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAudiencia;
        private System.Windows.Forms.Button btnFechar;
    }
}