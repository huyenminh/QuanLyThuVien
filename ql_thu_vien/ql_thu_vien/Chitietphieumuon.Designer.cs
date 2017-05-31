namespace ql_thu_vien
{
    partial class Chitietphieumuon
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
            this.lab_macs = new System.Windows.Forms.Label();
            this.txt_macs = new System.Windows.Forms.TextBox();
            this.txt_tinhtrangsau = new System.Windows.Forms.TextBox();
            this.txt_tinhtrangtruoc = new System.Windows.Forms.TextBox();
            this.txt_maphieu = new System.Windows.Forms.TextBox();
            this.lab_maphieu = new System.Windows.Forms.Label();
            this.lab_tinhtrangsau = new System.Windows.Forms.Label();
            this.lab_tinhtrangtruoc = new System.Windows.Forms.Label();
            this.dgvChitietmuon = new System.Windows.Forms.DataGridView();
            this.but_them = new System.Windows.Forms.Button();
            this.but_timkiem = new System.Windows.Forms.Button();
            this.but_thoat = new System.Windows.Forms.Button();
            this.but_luu = new System.Windows.Forms.Button();
            this.but_xoa = new System.Windows.Forms.Button();
            this.but_sua = new System.Windows.Forms.Button();
            this.grp_timkiem = new System.Windows.Forms.GroupBox();
            this.txt_timkiem = new System.Windows.Forms.TextBox();
            this.lab_timkiem = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChitietmuon)).BeginInit();
            this.grp_timkiem.SuspendLayout();
            this.SuspendLayout();
            // 
            // lab_macs
            // 
            this.lab_macs.AutoSize = true;
            this.lab_macs.Location = new System.Drawing.Point(35, 28);
            this.lab_macs.Name = "lab_macs";
            this.lab_macs.Size = new System.Drawing.Size(75, 13);
            this.lab_macs.TabIndex = 0;
            this.lab_macs.Text = "Mã cuốn sách";
            // 
            // txt_macs
            // 
            this.txt_macs.Location = new System.Drawing.Point(190, 21);
            this.txt_macs.Name = "txt_macs";
            this.txt_macs.Size = new System.Drawing.Size(200, 20);
            this.txt_macs.TabIndex = 19;
            // 
            // txt_tinhtrangsau
            // 
            this.txt_tinhtrangsau.Location = new System.Drawing.Point(190, 143);
            this.txt_tinhtrangsau.Name = "txt_tinhtrangsau";
            this.txt_tinhtrangsau.Size = new System.Drawing.Size(200, 20);
            this.txt_tinhtrangsau.TabIndex = 20;
            // 
            // txt_tinhtrangtruoc
            // 
            this.txt_tinhtrangtruoc.Location = new System.Drawing.Point(190, 104);
            this.txt_tinhtrangtruoc.Name = "txt_tinhtrangtruoc";
            this.txt_tinhtrangtruoc.Size = new System.Drawing.Size(200, 20);
            this.txt_tinhtrangtruoc.TabIndex = 21;
            // 
            // txt_maphieu
            // 
            this.txt_maphieu.Location = new System.Drawing.Point(190, 62);
            this.txt_maphieu.Name = "txt_maphieu";
            this.txt_maphieu.Size = new System.Drawing.Size(200, 20);
            this.txt_maphieu.TabIndex = 22;
            // 
            // lab_maphieu
            // 
            this.lab_maphieu.AutoSize = true;
            this.lab_maphieu.Location = new System.Drawing.Point(35, 69);
            this.lab_maphieu.Name = "lab_maphieu";
            this.lab_maphieu.Size = new System.Drawing.Size(51, 13);
            this.lab_maphieu.TabIndex = 23;
            this.lab_maphieu.Text = "Mã phiếu";
            // 
            // lab_tinhtrangsau
            // 
            this.lab_tinhtrangsau.AutoSize = true;
            this.lab_tinhtrangsau.Location = new System.Drawing.Point(35, 150);
            this.lab_tinhtrangsau.Name = "lab_tinhtrangsau";
            this.lab_tinhtrangsau.Size = new System.Drawing.Size(125, 13);
            this.lab_tinhtrangsau.TabIndex = 25;
            this.lab_tinhtrangsau.Text = "Tình trạng sau cho mượn";
            // 
            // lab_tinhtrangtruoc
            // 
            this.lab_tinhtrangtruoc.AutoSize = true;
            this.lab_tinhtrangtruoc.Location = new System.Drawing.Point(35, 111);
            this.lab_tinhtrangtruoc.Name = "lab_tinhtrangtruoc";
            this.lab_tinhtrangtruoc.Size = new System.Drawing.Size(132, 13);
            this.lab_tinhtrangtruoc.TabIndex = 27;
            this.lab_tinhtrangtruoc.Text = "Tình trạng trước cho mượn";
            // 
            // dgvChitietmuon
            // 
            this.dgvChitietmuon.BackgroundColor = System.Drawing.Color.White;
            this.dgvChitietmuon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChitietmuon.Location = new System.Drawing.Point(38, 266);
            this.dgvChitietmuon.Name = "dgvChitietmuon";
            this.dgvChitietmuon.Size = new System.Drawing.Size(671, 98);
            this.dgvChitietmuon.TabIndex = 28;
            this.dgvChitietmuon.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChitietmuon_CellContentClick);
            // 
            // but_them
            // 
            this.but_them.Location = new System.Drawing.Point(510, 12);
            this.but_them.Name = "but_them";
            this.but_them.Size = new System.Drawing.Size(75, 23);
            this.but_them.TabIndex = 29;
            this.but_them.Text = "Thêm";
            this.but_them.UseVisualStyleBackColor = true;
            this.but_them.Click += new System.EventHandler(this.but_them_Click);
            // 
            // but_timkiem
            // 
            this.but_timkiem.Location = new System.Drawing.Point(559, 19);
            this.but_timkiem.Name = "but_timkiem";
            this.but_timkiem.Size = new System.Drawing.Size(75, 23);
            this.but_timkiem.TabIndex = 30;
            this.but_timkiem.Text = "Tìm kiếm";
            this.but_timkiem.UseVisualStyleBackColor = true;
            this.but_timkiem.Click += new System.EventHandler(this.but_timkiem_Click);
            // 
            // but_thoat
            // 
            this.but_thoat.Location = new System.Drawing.Point(580, 106);
            this.but_thoat.Name = "but_thoat";
            this.but_thoat.Size = new System.Drawing.Size(75, 23);
            this.but_thoat.TabIndex = 31;
            this.but_thoat.Text = "Thoát";
            this.but_thoat.UseVisualStyleBackColor = true;
            this.but_thoat.Click += new System.EventHandler(this.but_thoat_Click);
            // 
            // but_luu
            // 
            this.but_luu.Location = new System.Drawing.Point(634, 60);
            this.but_luu.Name = "but_luu";
            this.but_luu.Size = new System.Drawing.Size(75, 23);
            this.but_luu.TabIndex = 32;
            this.but_luu.Text = "Lưu";
            this.but_luu.UseVisualStyleBackColor = true;
            this.but_luu.Click += new System.EventHandler(this.but_luu_Click);
            // 
            // but_xoa
            // 
            this.but_xoa.Location = new System.Drawing.Point(510, 60);
            this.but_xoa.Name = "but_xoa";
            this.but_xoa.Size = new System.Drawing.Size(75, 23);
            this.but_xoa.TabIndex = 33;
            this.but_xoa.Text = "Xóa";
            this.but_xoa.UseVisualStyleBackColor = true;
            this.but_xoa.Click += new System.EventHandler(this.but_xoa_Click);
            // 
            // but_sua
            // 
            this.but_sua.Location = new System.Drawing.Point(634, 12);
            this.but_sua.Name = "but_sua";
            this.but_sua.Size = new System.Drawing.Size(75, 23);
            this.but_sua.TabIndex = 34;
            this.but_sua.Text = "Sửa";
            this.but_sua.UseVisualStyleBackColor = true;
            this.but_sua.Click += new System.EventHandler(this.but_sua_Click);
            // 
            // grp_timkiem
            // 
            this.grp_timkiem.Controls.Add(this.txt_timkiem);
            this.grp_timkiem.Controls.Add(this.lab_timkiem);
            this.grp_timkiem.Controls.Add(this.but_timkiem);
            this.grp_timkiem.Location = new System.Drawing.Point(38, 184);
            this.grp_timkiem.Name = "grp_timkiem";
            this.grp_timkiem.Size = new System.Drawing.Size(671, 53);
            this.grp_timkiem.TabIndex = 35;
            this.grp_timkiem.TabStop = false;
            this.grp_timkiem.Text = "Tìm kiếm";
            // 
            // txt_timkiem
            // 
            this.txt_timkiem.Location = new System.Drawing.Point(152, 16);
            this.txt_timkiem.Name = "txt_timkiem";
            this.txt_timkiem.Size = new System.Drawing.Size(200, 20);
            this.txt_timkiem.TabIndex = 32;
            this.txt_timkiem.Click += new System.EventHandler(this.txt_timkiem_Click);
            
            // 
            // lab_timkiem
            // 
            this.lab_timkiem.AutoSize = true;
            this.lab_timkiem.Location = new System.Drawing.Point(57, 19);
            this.lab_timkiem.Name = "lab_timkiem";
            this.lab_timkiem.Size = new System.Drawing.Size(49, 13);
            this.lab_timkiem.TabIndex = 31;
            this.lab_timkiem.Text = "Tìm kiếm";
            // 
            // Chitietphieumuon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 376);
            this.Controls.Add(this.grp_timkiem);
            this.Controls.Add(this.but_sua);
            this.Controls.Add(this.but_xoa);
            this.Controls.Add(this.but_luu);
            this.Controls.Add(this.but_thoat);
            this.Controls.Add(this.but_them);
            this.Controls.Add(this.dgvChitietmuon);
            this.Controls.Add(this.lab_tinhtrangtruoc);
            this.Controls.Add(this.lab_tinhtrangsau);
            this.Controls.Add(this.lab_maphieu);
            this.Controls.Add(this.txt_maphieu);
            this.Controls.Add(this.txt_tinhtrangtruoc);
            this.Controls.Add(this.txt_tinhtrangsau);
            this.Controls.Add(this.txt_macs);
            this.Controls.Add(this.lab_macs);
            this.Name = "Chitietphieumuon";
            this.Text = "Chi tiết phiếu mượn";
            this.Load += new System.EventHandler(this.Chitietphieumuon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChitietmuon)).EndInit();
            this.grp_timkiem.ResumeLayout(false);
            this.grp_timkiem.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lab_macs;
        private System.Windows.Forms.TextBox txt_macs;
        private System.Windows.Forms.TextBox txt_tinhtrangsau;
        private System.Windows.Forms.TextBox txt_tinhtrangtruoc;
        private System.Windows.Forms.TextBox txt_maphieu;
        private System.Windows.Forms.Label lab_maphieu;
        private System.Windows.Forms.Label lab_tinhtrangsau;
        private System.Windows.Forms.Label lab_tinhtrangtruoc;
        private System.Windows.Forms.DataGridView dgvChitietmuon;
        private System.Windows.Forms.Button but_them;
        private System.Windows.Forms.Button but_timkiem;
        private System.Windows.Forms.Button but_thoat;
        private System.Windows.Forms.Button but_luu;
        private System.Windows.Forms.Button but_xoa;
        private System.Windows.Forms.Button but_sua;
        private System.Windows.Forms.GroupBox grp_timkiem;
        private System.Windows.Forms.TextBox txt_timkiem;
        private System.Windows.Forms.Label lab_timkiem;
    }
}