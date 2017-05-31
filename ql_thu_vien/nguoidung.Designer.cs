namespace ql_thu_vien
{
    partial class Nguoidung
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Nguoidung));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txttaikhoan = new System.Windows.Forms.TextBox();
            this.txtmatkhau = new System.Windows.Forms.TextBox();
            this.dgvnguoidung = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnthem = new System.Windows.Forms.ToolStripButton();
            this.btnluu = new System.Windows.Forms.ToolStripButton();
            this.brnsua = new System.Windows.Forms.ToolStripButton();
            this.btnxoa = new System.Windows.Forms.ToolStripButton();
            this.btnthoat = new System.Windows.Forms.ToolStripButton();
            this.STT = new System.Windows.Forms.Label();
            this.txtstt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvnguoidung)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(105, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tài khoản";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(108, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mật khẩu";
            // 
            // txttaikhoan
            // 
            this.txttaikhoan.Location = new System.Drawing.Point(182, 67);
            this.txttaikhoan.Name = "txttaikhoan";
            this.txttaikhoan.Size = new System.Drawing.Size(140, 20);
            this.txttaikhoan.TabIndex = 2;
            // 
            // txtmatkhau
            // 
            this.txtmatkhau.Location = new System.Drawing.Point(182, 95);
            this.txtmatkhau.Name = "txtmatkhau";
            this.txtmatkhau.Size = new System.Drawing.Size(140, 20);
            this.txtmatkhau.TabIndex = 3;
            // 
            // dgvnguoidung
            // 
            this.dgvnguoidung.BackgroundColor = System.Drawing.Color.White;
            this.dgvnguoidung.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvnguoidung.Location = new System.Drawing.Point(88, 128);
            this.dgvnguoidung.Name = "dgvnguoidung";
            this.dgvnguoidung.Size = new System.Drawing.Size(363, 150);
            this.dgvnguoidung.TabIndex = 4;
            this.dgvnguoidung.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnthem,
            this.btnluu,
            this.brnsua,
            this.btnxoa,
            this.btnthoat});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(510, 25);
            this.toolStrip1.TabIndex = 27;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnthem
            // 
            this.btnthem.AutoSize = false;
            this.btnthem.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnthem.Image = ((System.Drawing.Image)(resources.GetObject("btnthem.Image")));
            this.btnthem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(70, 22);
            this.btnthem.Text = "add";
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btnluu
            // 
            this.btnluu.AutoSize = false;
            this.btnluu.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnluu.Image = ((System.Drawing.Image)(resources.GetObject("btnluu.Image")));
            this.btnluu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(65, 22);
            this.btnluu.Text = "Save";
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // brnsua
            // 
            this.brnsua.AutoSize = false;
            this.brnsua.BackColor = System.Drawing.SystemColors.ControlLight;
            this.brnsua.Image = ((System.Drawing.Image)(resources.GetObject("brnsua.Image")));
            this.brnsua.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.brnsua.Name = "brnsua";
            this.brnsua.Size = new System.Drawing.Size(65, 22);
            this.brnsua.Text = "edit";
            this.brnsua.Click += new System.EventHandler(this.brnsua_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.AutoSize = false;
            this.btnxoa.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnxoa.Image = ((System.Drawing.Image)(resources.GetObject("btnxoa.Image")));
            this.btnxoa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(65, 22);
            this.btnxoa.Text = "delete ";
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.AutoSize = false;
            this.btnthoat.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnthoat.Image = ((System.Drawing.Image)(resources.GetObject("btnthoat.Image")));
            this.btnthoat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(65, 22);
            this.btnthoat.Text = "close ";
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // STT
            // 
            this.STT.AutoSize = true;
            this.STT.Location = new System.Drawing.Point(121, 42);
            this.STT.Name = "STT";
            this.STT.Size = new System.Drawing.Size(28, 13);
            this.STT.TabIndex = 28;
            this.STT.Text = "STT";
            // 
            // txtstt
            // 
            this.txtstt.Location = new System.Drawing.Point(182, 35);
            this.txtstt.Name = "txtstt";
            this.txtstt.Size = new System.Drawing.Size(140, 20);
            this.txtstt.TabIndex = 29;
            // 
            // nguoidung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 290);
            this.Controls.Add(this.txtstt);
            this.Controls.Add(this.STT);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dgvnguoidung);
            this.Controls.Add(this.txtmatkhau);
            this.Controls.Add(this.txttaikhoan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "nguoidung";
            this.Text = "nguoidung";
            this.Load += new System.EventHandler(this.nguoidung_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvnguoidung)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txttaikhoan;
        private System.Windows.Forms.TextBox txtmatkhau;
        private System.Windows.Forms.DataGridView dgvnguoidung;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnthem;
        private System.Windows.Forms.ToolStripButton btnluu;
        private System.Windows.Forms.ToolStripButton brnsua;
        private System.Windows.Forms.ToolStripButton btnxoa;
        private System.Windows.Forms.ToolStripButton btnthoat;
        private System.Windows.Forms.Label STT;
        private System.Windows.Forms.TextBox txtstt;
    }
}