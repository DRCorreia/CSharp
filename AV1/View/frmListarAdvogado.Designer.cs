namespace View
{
    partial class frmListarAdvogado
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
            this.dgvAdvogado = new System.Windows.Forms.DataGridView();
            this.btnFechar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdvogado)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAdvogado
            // 
            this.dgvAdvogado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAdvogado.Location = new System.Drawing.Point(35, 21);
            this.dgvAdvogado.Name = "dgvAdvogado";
            this.dgvAdvogado.RowTemplate.Height = 24;
            this.dgvAdvogado.Size = new System.Drawing.Size(411, 220);
            this.dgvAdvogado.TabIndex = 0;
            this.dgvAdvogado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAdvogado_CellContentClick);
            // 
            // btnFechar
            // 
            this.btnFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.Location = new System.Drawing.Point(207, 252);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(85, 31);
            this.btnFechar.TabIndex = 1;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // frmListarAdvogado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 295);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.dgvAdvogado);
            this.Name = "frmListarAdvogado";
            this.Text = "frmListarAdvogado";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdvogado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAdvogado;
        private System.Windows.Forms.Button btnFechar;
    }
}