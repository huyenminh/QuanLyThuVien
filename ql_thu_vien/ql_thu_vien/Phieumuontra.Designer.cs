namespace ql_thu_vien
{
    partial class Phieumuontra
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
            this.lab_maphieu = new System.Windows.Forms.Label();
            this.lab_ngayhentra = new System.Windows.Forms.Label();
            this.lab_ngaytra = new System.Windows.Forms.Label();
            this.lab_ngaymuon = new System.Windows.Forms.Label();
            this.lab_matt = new System.Windows.Forms.Label();
            this.lab_madg = new System.Windows.Forms.Label();
            this.datengaymuon = new System.Windows.Forms.DateTimePicker();
            this.datengaytra = new System.Windows.Forms.DateTimePicker();
            this.datengayhentra = new System.Windows.Forms.DateTimePicker();
            this.txt_maphieu = new System.Windows.Forms.TextBox();
            this.txt_matt = new System.Windows.Forms.TextBox();
            this.txt_madg = new System.Windows.Forms.TextBox();
            this.but_them = new System.Windows.Forms.Button();
            this.but_sua = new System.Windows.Forms.Button();
            this.but_thoat = new System.Windows.Forms.Button();
            this.but_xoa = new System.Windows.Forms.Button();
            this.but_luu = new System.Windows.Forms.Button();
            this.but_timkiem = new System.Windows.Forms.Button();
            this.grp_timkiem = new System.Windows.Forms.GroupBox();
            this.txt_timkiempm = new System.Windows.Forms.TextBox();
            this.lab_timkiempm = new System.Windows.Forms.Label();
            this.dgvPhieumuontra = new System.Windows.Forms.DataGridView();
            this.grp_timkiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieumuontra)).BeginInit();
            this.SuspendLayout();
            // 
            // lab_maphieu
            // 
            this.lab_maphieu.AutoSize = true;
            this.lab_maphieu.Location = new System.Drawing.Point(43, 24);
            this.lab_maphieu.Name = "lab_maphieu";
            this.lab_maphieu.Size = new System.Drawing.Size(51, 13);
            this.lab_maphieu.TabIndex = 0;
            this.lab_maphieu.Text = "Mã phiếu";
            // 
            // lab_ngayhentra
            // 
            this.lab_ngayhentra.AutoSize = true;
            this.lab_ngayhentra.Location = new System.Drawing.Point(374, 125);
            this.lab_ngayhentra.Name = "lab_ngayhentra";
            this.lab_ngayhentra.Size = new System.Drawing.Size(68, 13);
            this.lab_ngayhentra.TabIndex = 2;
            this.lab_ngayhentra.Text = "Ngày hẹn trả";
            // 
            // lab_ngaytra
            // 
            this.lab_ngaytra.AutoSize = true;
            this.lab_ngaytra.Location = new System.Drawing.Point(374, 74);
            this.lab_ngaytra.Name = "lab_ngaytra";
            this.lab_ngaytra.Size = new System.Drawing.Size(47, 13);
            this.lab_ngaytra.TabIndex = 4;
            this.lab_ngaytra.Text = "Ngày trả";
            // 
            // lab_ngaymuon
            // 
            this.lab_ngaymuon.AutoSize = true;
            this.lab_ngaymuon.Location = new System.Drawing.Point(374, 24);
            this.lab_ngaymuon.Name = "lab_ngaymuon";
            this.lab_ngaymuon.Size = new System.Drawing.Size(61, 13);
            this.lab_ngaymuon.TabIndex = 6;
            this.lab_ngaymuon.Text = "Ngày mượn";
            // 
            // lab_matt
            // 
            this.lab_matt.AutoSize = true;
            this.lab_matt.Location = new System.Drawing.Point(43, 124);
            this.lab_matt.Name = "lab_matt";
            this.lab_matt.Size = new System.Drawing.Size(58, 13);
            this.lab_matt.TabIndex = 8;
            this.lab_matt.Text = "Mã thủ thư";
            // 
            // lab_madg
            // 
            this.lab_madg.AutoSize = true;
            this.lab_madg.Location = new System.Drawing.Point(43, 74);
            this.lab_madg.Name = "lab_madg";
            this.lab_madg.Size = new System.Drawing.Size(61, 13);
            this.lab_madg.TabIndex = 10;
            this.lab_madg.Text = "Mã độc giả";
            // 
            // datengaymuon
            // 
            this.datengaymuon.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datengaymuon.Location = new System.Drawing.Point(452, 18);
            this.datengaymuon.Name = "datengaymuon";
            this.datengaymuon.Size = new System.Drawing.Size(200, 20);
            this.datengaymuon.TabIndex = 11;
            // 
            // datengaytra
            // 
            this.datengaytra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datengaytra.Location = new System.Drawing.Point(452, 67);
            this.datengaytra.Name = "datengaytra";
            this.datengaytra.Size = new System.Drawing.Size(200, 20);
            this.datengaytra.TabIndex = 13;
            // 
            // datengayhentra
            // 
            this.datengayhentra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datengayhentra.Location = new System.Drawing.Point(452, 118);
            this.datengayhentra.Name = "datengayhentra";
            this.datengayhentra.Size = new System.Drawing.Size(200, 20);
            this.datengayhentra.TabIndex = 15;
            // 
            // txt_maphieu
            // 
            this.txt_maphieu.Location = new System.Drawing.Point(140, 17);
            this.txt_maphieu.Name = "txt_maphieu";
            this.txt_maphieu.Size = new System.Drawing.Size(200, 20);
            this.txt_maphieu.TabIndex = 16;
            // 
            // txt_matt
            // 
            this.txt_matt.Location = new System.Drawing.Point(140, 121);
            this.txt_matt.Name = "txt_matt";
            this.txt_matt.Size = new System.Drawing.Size(200, 20);
            this.txt_matt.TabIndex = 17;
            // 
            // txt_madg
            // 
            this.txt_madg.Location = new System.Drawing.Point(140, 67);
            this.txt_madg.Name = "txt_madg";
            this.txt_madg.Size = new System.Drawing.Size(200, 20);
            this.txt_madg.TabIndex = 18;
            // 
            // but_them
            // 
            this.but_them.Location = new System.Drawing.Point(677, 7);
            this.but_them.Name = "but_them";
            this.but_them.Size = new System.Drawing.Size(75, 34);
            this.but_them.TabIndex = 19;
            this.but_them.Text = "Thêm";
            this.but_them.UseVisualStyleBackColor = true;
            this.but_them.Click += new System.EventHandler(this.but_them_Click);
            // 
            // but_sua
            // 
            this.but_sua.Location = new System.Drawing.Point(677, 47);
            this.but_sua.Name = "but_sua";
            this.but_sua.Size = new System.Drawing.Size(75, 33);
            this.but_sua.TabIndex = 21;
            this.but_sua.Text = "Sửa";
            this.but_sua.UseVisualStyleBackColor = true;
            this.but_sua.Click += new System.EventHandler(this.but_sua_Click);
            // 
            // but_thoat
            // 
            this.but_thoat.Location = new System.Drawing.Point(677, 158);
            this.but_thoat.Name = "but_thoat";
            this.but_thoat.Size = new System.Drawing.Size(75, 36);
            this.but_thoat.TabIndex = 23;
            this.but_thoat.Text = "Thoát";
            this.but_thoat.UseVisualStyleBackColor = true;
            this.but_thoat.Click += new System.EventHandler(this.but_thoat_Click);
            // 
            // but_xoa
            // 
            this.but_xoa.Location = new System.Drawing.Point(677, 86);
            this.but_xoa.Name = "but_xoa";
            this.but_xoa.Size = new System.Drawing.Size(75, 30);
            this.but_xoa.TabIndex = 25;
            this.but_xoa.Text = "Xóa";
            this.but_xoa.UseVisualStyleBackColor = true;
            this.but_xoa.Click += new System.EventHandler(this.but_xoa_Click);
            // 
            // but_luu
            // 
            this.but_luu.Location = new System.Drawing.Point(677, 122);
            this.but_luu.Name = "but_luu";
            this.but_luu.Size = new System.Drawing.Size(75, 30);
            this.but_luu.TabIndex = 27;
            this.but_luu.Text = "Lưu";
            this.but_luu.UseVisualStyleBackColor = true;
            this.but_luu.Click += new System.EventHandler(this.but_luu_Click);
            // 
            // but_timkiem
            // 
            this.but_timkiem.Location = new System.Drawing.Point(389, 19);
            this.but_timkiem.Name = "but_timkiem";
            this.but_timkiem.Size = new System.Drawing.Size(75, 26);
            this.but_timkiem.TabIndex = 29;
            this.but_timkiem.Text = "Tìm kiếm";
            this.but_timkiem.UseVisualStyleBackColor = true;
            this.but_timkiem.Click += new System.EventHandler(this.but_timkiem_Click);
            // 
            // grp_timkiem
            // 
            this.grp_timkiem.Controls.Add(this.txt_timkiempm);
            this.grp_timkiem.Controls.Add(this.lab_timkiempm);
            this.grp_timkiem.Controls.Add(this.but_timkiem);
            this.grp_timkiem.Location = new System.Drawing.Point(46, 158);
            this.grp_timkiem.Name = "grp_timkiem";
            this.grp_timkiem.Size = new System.Drawing.Size(495, 64);
            this.grp_timkiem.TabIndex = 32;
            this.grp_timkiem.TabStop = false;
            this.grp_timkiem.Text = "Tìm kiếm";
            // 
            // txt_timkiempm
            // 
            this.txt_timkiempm.Location = new System.Drawing.Point(119, 16);
            this.txt_timkiempm.Name = "txt_timkiempm";
            this.txt_timkiempm.Size = new System.Drawing.Size(175, 20);
            this.txt_timkiempm.TabIndex = 31;
            this.txt_timkiempm.Click += new System.EventHandler(this.txt_timkiempm_Click);
            // 
            // lab_timkiempm
            // 
            this.lab_timkiempm.AutoSize = true;
            this.lab_timkiempm.Location = new System.Drawing.Point(6, 23);
            this.lab_timkiempm.Name = "lab_timkiempm";
            this.lab_timkiempm.Size = new System.Drawing.Size(107, 13);
            this.lab_timkiempm.TabIndex = 30;
            this.lab_timkiempm.Text = "Tìm kiếm phiếu mượn";
            // 
            // dgvPhieumuontra
            // 
            this.dgvPhieumuontra.BackgroundColor = System.Drawing.Color.White;
            this.dgvPhieumuontra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhieumuontra.Location = new System.Drawing.Point(46, 249);
            this.dgvPhieumuontra.Name = "dgvPhieumuontra";
            this.dgvPhieumuontra.Size = new System.Drawing.Size(706, 88);
            this.dgvPhieumuontra.TabIndex = 33;
            this.dgvPhieumuontra.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhieumuontra_CellContentClick);
            // 
            // Phieumuontra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 362);
            this.Controls.Add(this.dgvPhieumuontra);
            this.Controls.Add(this.grp_timkiem);
            this.Controls.Add(this.but_luu);
            this.Controls.Add(this.but_xoa);
            this.Controls.Add(this.but_thoat);
            this.Controls.Add(this.but_sua);
            this.Controls.Add(this.but_them);
            this.Controls.Add(this.txt_madg);
            this.Controls.Add(this.txt_matt);
            this.Controls.Add(this.txt_maphieu);
            this.Controls.Add(this.datengayhentra);
            this.Controls.Add(this.datengaytra);
            this.Controls.Add(this.datengaymuon);
            this.Controls.Add(this.lab_madg);
            this.Controls.Add(this.lab_matt);
            this.Controls.Add(this.lab_ngaymuon);
            this.Controls.Add(this.lab_ngaytra);
            this.Controls.Add(this.lab_ngayhentra);
            this.Controls.Add(this.lab_maphieu);
            this.Name = "Phieumuontra";
            this.Text = "Phiếu mượn trả";
            this.Load += new System.EventHandler(this.Phieumuontra_Load);
            this.grp_timkiem.ResumeLayout(false);
            this.grp_timkiem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieumuontra)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lab_maphieu;
        private System.Windows.Forms.Label lab_ngayhentra;
        private System.Windows.Forms.Label lab_ngaytra;
        private System.Windows.Forms.Label lab_ngaymuon;
        private System.Windows.Forms.Label lab_matt;
        private System.Windows.Forms.Label lab_madg;
        private System.Windows.Forms.DateTimePicker datengaymuon;
        private System.Windows.Forms.DateTimePicker datengaytra;
        private System.Windows.Forms.DateTimePicker datengayhentra;
        private System.Windows.Forms.TextBox txt_maphieu;
        private System.Windows.Forms.TextBox txt_matt;
        private System.Windows.Forms.TextBox txt_madg;
        private System.Windows.Forms.Button but_them;
        private System.Windows.Forms.Button but_sua;
        private System.Windows.Forms.Button but_thoat;
        private System.Windows.Forms.Button but_xoa;
        private System.Windows.Forms.Button but_luu;
        private System.Windows.Forms.Button but_timkiem;
        private System.Windows.Forms.GroupBox grp_timkiem;
        private System.Windows.Forms.TextBox txt_timkiempm;
        private System.Windows.Forms.Label lab_timkiempm;
        private System.Windows.Forms.DataGridView dgvPhieumuontra;
    }
}