namespace View
{
    partial class frmListarCausasFinalizadas
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
            this.dgvCausasFinalizadas = new System.Windows.Forms.DataGridView();
            this.btnFechar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCausasFinalizadas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCausasFinalizadas
            // 
            this.dgvCausasFinalizadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCausasFinalizadas.Location = new System.Drawing.Point(59, 36);
            this.dgvCausasFinalizadas.Name = "dgvCausasFinalizadas";
            this.dgvCausasFinalizadas.RowTemplate.Height = 24;
            this.dgvCausasFinalizadas.Size = new System.Drawing.Size(562, 241);
            this.dgvCausasFinalizadas.TabIndex = 0;
            // 
            // btnFechar
            // 
            this.btnFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.Location = new System.Drawing.Point(279, 324);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(100, 26);
            this.btnFechar.TabIndex = 1;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // frmListarCausasFinalizadas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 392);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.dgvCausasFinalizadas);
            this.Name = "frmListarCausasFinalizadas";
            this.Text = "frmListarCausasFinalizadas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCausasFinalizadas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCausasFinalizadas;
        private System.Windows.Forms.Button btnFechar;
    }
}