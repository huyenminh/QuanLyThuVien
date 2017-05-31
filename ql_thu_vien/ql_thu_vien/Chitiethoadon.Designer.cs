namespace ql_thu_vien
{
    partial class Chitiethoadon
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
            this.txtMahd = new System.Windows.Forms.TextBox();
            this.dgvChitiethoadon = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChitiethoadon)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMahd
            // 
            this.txtMahd.Location = new System.Drawing.Point(139, 27);
            this.txtMahd.Name = "txtMahd";
            this.txtMahd.Size = new System.Drawing.Size(100, 20);
            this.txtMahd.TabIndex = 0;
            // 
            // dgvChitiethoadon
            // 
            this.dgvChitiethoadon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChitiethoadon.Location = new System.Drawing.Point(29, 74);
            this.dgvChitiethoadon.Name = "dgvChitiethoadon";
            this.dgvChitiethoadon.Size = new System.Drawing.Size(327, 170);
            this.dgvChitiethoadon.TabIndex = 1;
            // 
            // Chitiethoadon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 261);
            this.Controls.Add(this.dgvChitiethoadon);
            this.Controls.Add(this.txtMahd);
            this.Name = "Chitiethoadon";
            this.Text = "Chitiethoadon";
            this.Load += new System.EventHandler(this.Chitiethoadon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChitiethoadon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMahd;
        private System.Windows.Forms.DataGridView dgvChitiethoadon;
    }
}