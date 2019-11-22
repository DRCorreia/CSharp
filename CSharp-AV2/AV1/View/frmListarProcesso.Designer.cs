namespace View
{
    partial class frmListarProcesso
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
            this.dgvProcesso = new System.Windows.Forms.DataGridView();
            this.btnFechar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProcesso)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProcesso
            // 
            this.dgvProcesso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProcesso.Location = new System.Drawing.Point(112, 41);
            this.dgvProcesso.Name = "dgvProcesso";
            this.dgvProcesso.RowTemplate.Height = 24;
            this.dgvProcesso.Size = new System.Drawing.Size(438, 226);
            this.dgvProcesso.TabIndex = 0;
            this.dgvProcesso.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProcesso_CellContentClick);
            // 
            // btnFechar
            // 
            this.btnFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.Location = new System.Drawing.Point(314, 317);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(81, 27);
            this.btnFechar.TabIndex = 1;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // frmListarProcesso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 413);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.dgvProcesso);
            this.Name = "frmListarProcesso";
            this.Text = "frmListarProcesso";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProcesso)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProcesso;
        private System.Windows.Forms.Button btnFechar;
    }
}