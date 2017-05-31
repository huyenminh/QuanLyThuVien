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
            this.cmbmacs = new System.Windows.Forms.ComboBox();
            this.groupdocgia = new System.Windows.Forms.GroupBox();
            this.txttacgia = new System.Windows.Forms.TextBox();
            this.txttensach = new System.Windows.Forms.TextBox();
            this.txtsoluongcon = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txttinhtrang = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtgiabia = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bútach = new System.Windows.Forms.Button();
            this.txtsauchomuon = new System.Windows.Forms.TextBox();
            this.txttruocchomuon = new System.Windows.Forms.TextBox();
            this.txtsongayqua = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lab_ngayhentra = new System.Windows.Forms.Label();
            this.lab_ngaytra = new System.Windows.Forms.Label();
            this.lab_ngaymuon = new System.Windows.Forms.Label();
            this.datengaymuon = new System.Windows.Forms.DateTimePicker();
            this.datengaytra = new System.Windows.Forms.DateTimePicker();
            this.datengayhentra = new System.Windows.Forms.DateTimePicker();
            this.txtsocuon = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbmaphieu = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChitietmuon)).BeginInit();
            this.grp_timkiem.SuspendLayout();
            this.groupdocgia.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lab_macs
            // 
            this.lab_macs.AutoSize = true;
            this.lab_macs.Location = new System.Drawing.Point(23, 90);
            this.lab_macs.Name = "lab_macs";
            this.lab_macs.Size = new System.Drawing.Size(75, 13);
            this.lab_macs.TabIndex = 0;
            this.lab_macs.Text = "Mã cuốn sách";
            // 
            // lab_tinhtrangsau
            // 
            this.lab_tinhtrangsau.AutoSize = true;
            this.lab_tinhtrangsau.Location = new System.Drawing.Point(16, 61);
            this.lab_tinhtrangsau.Name = "lab_tinhtrangsau";
            this.lab_tinhtrangsau.Size = new System.Drawing.Size(125, 13);
            this.lab_tinhtrangsau.TabIndex = 25;
            this.lab_tinhtrangsau.Text = "Tình trạng sau cho mượn";
            // 
            // lab_tinhtrangtruoc
            // 
            this.lab_tinhtrangtruoc.AutoSize = true;
            this.lab_tinhtrangtruoc.Location = new System.Drawing.Point(16, 34);
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
            this.but_them.Location = new System.Drawing.Point(797, 19);
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
            this.but_thoat.Location = new System.Drawing.Point(797, 157);
            this.but_thoat.Name = "but_thoat";
            this.but_thoat.Size = new System.Drawing.Size(75, 23);
            this.but_thoat.TabIndex = 31;
            this.but_thoat.Text = "Thoát";
            this.but_thoat.UseVisualStyleBackColor = true;
            this.but_thoat.Click += new System.EventHandler(this.but_thoat_Click);
            // 
            // but_luu
            // 
            this.but_luu.Location = new System.Drawing.Point(797, 122);
            this.but_luu.Name = "but_luu";
            this.but_luu.Size = new System.Drawing.Size(75, 23);
            this.but_luu.TabIndex = 32;
            this.but_luu.Text = "Lưu";
            this.but_luu.UseVisualStyleBackColor = true;
            this.but_luu.Click += new System.EventHandler(this.but_luu_Click);
            // 
            // but_xoa
            // 
            this.but_xoa.Location = new System.Drawing.Point(797, 53);
            this.but_xoa.Name = "but_xoa";
            this.but_xoa.Size = new System.Drawing.Size(75, 23);
            this.but_xoa.TabIndex = 33;
            this.but_xoa.Text = "Xóa";
            this.but_xoa.UseVisualStyleBackColor = true;
            this.but_xoa.Click += new System.EventHandler(this.but_xoa_Click);
            // 
            // but_sua
            // 
            this.but_sua.Location = new System.Drawing.Point(797, 90);
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
            this.grp_timkiem.Location = new System.Drawing.Point(38, 194);
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
            // cmbmacs
            // 
            this.cmbmacs.FormattingEnabled = true;
            this.cmbmacs.Location = new System.Drawing.Point(167, 95);
            this.cmbmacs.Name = "cmbmacs";
            this.cmbmacs.Size = new System.Drawing.Size(87, 21);
            this.cmbmacs.TabIndex = 36;
            this.cmbmacs.SelectionChangeCommitted += new System.EventHandler(this.cmbmacs_SelectionChangeCommitted);
            this.cmbmacs.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.cmbmacs_MouseDoubleClick);
            // 
            // groupdocgia
            // 
            this.groupdocgia.Controls.Add(this.txttacgia);
            this.groupdocgia.Controls.Add(this.txttensach);
            this.groupdocgia.Controls.Add(this.txtsoluongcon);
            this.groupdocgia.Controls.Add(this.label13);
            this.groupdocgia.Controls.Add(this.txttinhtrang);
            this.groupdocgia.Controls.Add(this.label12);
            this.groupdocgia.Controls.Add(this.txtgiabia);
            this.groupdocgia.Controls.Add(this.label2);
            this.groupdocgia.Controls.Add(this.label5);
            this.groupdocgia.Controls.Add(this.label9);
            this.groupdocgia.Location = new System.Drawing.Point(495, 19);
            this.groupdocgia.Name = "groupdocgia";
            this.groupdocgia.Size = new System.Drawing.Size(268, 169);
            this.groupdocgia.TabIndex = 122;
            this.groupdocgia.TabStop = false;
            this.groupdocgia.Text = "Thông Tin Sách";
            // 
            // txttacgia
            // 
            this.txttacgia.Enabled = false;
            this.txttacgia.Location = new System.Drawing.Point(99, 38);
            this.txttacgia.Name = "txttacgia";
            this.txttacgia.Size = new System.Drawing.Size(141, 20);
            this.txttacgia.TabIndex = 86;
            // 
            // txttensach
            // 
            this.txttensach.Enabled = false;
            this.txttensach.Location = new System.Drawing.Point(99, 12);
            this.txttensach.Name = "txttensach";
            this.txttensach.Size = new System.Drawing.Size(141, 20);
            this.txttensach.TabIndex = 85;
            // 
            // txtsoluongcon
            // 
            this.txtsoluongcon.Enabled = false;
            this.txtsoluongcon.Location = new System.Drawing.Point(112, 116);
            this.txtsoluongcon.Name = "txtsoluongcon";
            this.txtsoluongcon.Size = new System.Drawing.Size(128, 20);
            this.txtsoluongcon.TabIndex = 82;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(21, 119);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(83, 14);
            this.label13.TabIndex = 79;
            this.label13.Text = "Số lượng còn:";
            // 
            // txttinhtrang
            // 
            this.txttinhtrang.Enabled = false;
            this.txttinhtrang.Location = new System.Drawing.Point(112, 90);
            this.txttinhtrang.Name = "txttinhtrang";
            this.txttinhtrang.Size = new System.Drawing.Size(128, 20);
            this.txttinhtrang.TabIndex = 83;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(21, 93);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 14);
            this.label12.TabIndex = 80;
            this.label12.Text = "Tình Trạng:";
            // 
            // txtgiabia
            // 
            this.txtgiabia.Enabled = false;
            this.txtgiabia.Location = new System.Drawing.Point(112, 64);
            this.txtgiabia.Name = "txtgiabia";
            this.txtgiabia.Size = new System.Drawing.Size(128, 20);
            this.txtgiabia.TabIndex = 84;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 14);
            this.label2.TabIndex = 81;
            this.label2.Text = "Giá bìa:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 14);
            this.label5.TabIndex = 77;
            this.label5.Text = "Tác giả:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(21, 15);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 14);
            this.label9.TabIndex = 76;
            this.label9.Text = "Tên sách:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 123;
            this.label1.Text = "Mã phiếu";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbmaphieu);
            this.groupBox1.Controls.Add(this.bútach);
            this.groupBox1.Controls.Add(this.txtsauchomuon);
            this.groupBox1.Controls.Add(this.txttruocchomuon);
            this.groupBox1.Controls.Add(this.txtsongayqua);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lab_ngayhentra);
            this.groupBox1.Controls.Add(this.lab_ngaytra);
            this.groupBox1.Controls.Add(this.lab_ngaymuon);
            this.groupBox1.Controls.Add(this.datengaymuon);
            this.groupBox1.Controls.Add(this.datengaytra);
            this.groupBox1.Controls.Add(this.datengayhentra);
            this.groupBox1.Controls.Add(this.txtsocuon);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lab_tinhtrangtruoc);
            this.groupBox1.Controls.Add(this.lab_tinhtrangsau);
            this.groupBox1.Controls.Add(this.cmbmacs);
            this.groupBox1.Controls.Add(this.lab_macs);
            this.groupBox1.Location = new System.Drawing.Point(12, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(477, 166);
            this.groupBox1.TabIndex = 124;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chi Tiết Phiếu";
            // 
            // bútach
            // 
            this.bútach.Location = new System.Drawing.Point(361, 137);
            this.bútach.Name = "bútach";
            this.bútach.Size = new System.Drawing.Size(88, 23);
            this.bútach.TabIndex = 33;
            this.bútach.Text = "Sách";
            this.bútach.UseVisualStyleBackColor = true;
            this.bútach.Click += new System.EventHandler(this.bútach_Click);
            // 
            // txtsauchomuon
            // 
            this.txtsauchomuon.Location = new System.Drawing.Point(167, 61);
            this.txtsauchomuon.Name = "txtsauchomuon";
            this.txtsauchomuon.Size = new System.Drawing.Size(87, 20);
            this.txtsauchomuon.TabIndex = 136;
            // 
            // txttruocchomuon
            // 
            this.txttruocchomuon.Location = new System.Drawing.Point(167, 35);
            this.txttruocchomuon.Name = "txttruocchomuon";
            this.txttruocchomuon.Size = new System.Drawing.Size(87, 20);
            this.txttruocchomuon.TabIndex = 135;
            // 
            // txtsongayqua
            // 
            this.txtsongayqua.Location = new System.Drawing.Point(361, 107);
            this.txtsongayqua.Name = "txtsongayqua";
            this.txtsongayqua.Size = new System.Drawing.Size(88, 20);
            this.txtsongayqua.TabIndex = 134;
            this.txtsongayqua.Click += new System.EventHandler(this.txtsongayqua_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(263, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 133;
            this.label4.Text = "Số ngày Quá Hạn";
            // 
            // lab_ngayhentra
            // 
            this.lab_ngayhentra.AutoSize = true;
            this.lab_ngayhentra.Location = new System.Drawing.Point(282, 77);
            this.lab_ngayhentra.Name = "lab_ngayhentra";
            this.lab_ngayhentra.Size = new System.Drawing.Size(68, 13);
            this.lab_ngayhentra.TabIndex = 127;
            this.lab_ngayhentra.Text = "Ngày hẹn trả";
            // 
            // lab_ngaytra
            // 
            this.lab_ngaytra.AutoSize = true;
            this.lab_ngaytra.Location = new System.Drawing.Point(296, 42);
            this.lab_ngaytra.Name = "lab_ngaytra";
            this.lab_ngaytra.Size = new System.Drawing.Size(47, 13);
            this.lab_ngaytra.TabIndex = 128;
            this.lab_ngaytra.Text = "Ngày trả";
            // 
            // lab_ngaymuon
            // 
            this.lab_ngaymuon.AutoSize = true;
            this.lab_ngaymuon.Location = new System.Drawing.Point(282, 13);
            this.lab_ngaymuon.Name = "lab_ngaymuon";
            this.lab_ngaymuon.Size = new System.Drawing.Size(61, 13);
            this.lab_ngaymuon.TabIndex = 129;
            this.lab_ngaymuon.Text = "Ngày mượn";
            // 
            // datengaymuon
            // 
            this.datengaymuon.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datengaymuon.Location = new System.Drawing.Point(358, 7);
            this.datengaymuon.Name = "datengaymuon";
            this.datengaymuon.Size = new System.Drawing.Size(87, 20);
            this.datengaymuon.TabIndex = 130;
            // 
            // datengaytra
            // 
            this.datengaytra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datengaytra.Location = new System.Drawing.Point(358, 40);
            this.datengaytra.Name = "datengaytra";
            this.datengaytra.Size = new System.Drawing.Size(87, 20);
            this.datengaytra.TabIndex = 131;
            // 
            // datengayhentra
            // 
            this.datengayhentra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datengayhentra.Location = new System.Drawing.Point(361, 71);
            this.datengayhentra.Name = "datengayhentra";
            this.datengayhentra.Size = new System.Drawing.Size(87, 20);
            this.datengayhentra.TabIndex = 132;
            // 
            // txtsocuon
            // 
            this.txtsocuon.Location = new System.Drawing.Point(167, 122);
            this.txtsocuon.Name = "txtsocuon";
            this.txtsocuon.Size = new System.Drawing.Size(87, 20);
            this.txtsocuon.TabIndex = 126;
            this.txtsocuon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtsocuon_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 125;
            this.label3.Text = "số cuốn";
            // 
            // cmbmaphieu
            // 
            this.cmbmaphieu.FormattingEnabled = true;
            this.cmbmaphieu.Location = new System.Drawing.Point(167, 10);
            this.cmbmaphieu.Name = "cmbmaphieu";
            this.cmbmaphieu.Size = new System.Drawing.Size(87, 21);
            this.cmbmaphieu.TabIndex = 137;
//            this.cmbmaphieu.SelectionChangeCommitted += new System.EventHandler(this.cmbmaphieu_SelectionChangeCommitted);
            // 
            // Chitietphieumuon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 376);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupdocgia);
            this.Controls.Add(this.grp_timkiem);
            this.Controls.Add(this.but_sua);
            this.Controls.Add(this.but_xoa);
            this.Controls.Add(this.but_luu);
            this.Controls.Add(this.but_thoat);
            this.Controls.Add(this.but_them);
            this.Controls.Add(this.dgvChitietmuon);
            this.Name = "Chitietphieumuon";
            this.Text = "Chi tiết phiếu mượn";
            this.Load += new System.EventHandler(this.Chitietphieumuon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChitietmuon)).EndInit();
            this.grp_timkiem.ResumeLayout(false);
            this.grp_timkiem.PerformLayout();
            this.groupdocgia.ResumeLayout(false);
            this.groupdocgia.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lab_macs;
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
        private System.Windows.Forms.ComboBox cmbmacs;
        private System.Windows.Forms.GroupBox groupdocgia;
        private System.Windows.Forms.TextBox txttacgia;
        private System.Windows.Forms.TextBox txttensach;
        private System.Windows.Forms.TextBox txtsoluongcon;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txttinhtrang;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtgiabia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtsocuon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lab_ngayhentra;
        private System.Windows.Forms.Label lab_ngaytra;
        private System.Windows.Forms.Label lab_ngaymuon;
        private System.Windows.Forms.DateTimePicker datengaymuon;
        private System.Windows.Forms.DateTimePicker datengaytra;
        private System.Windows.Forms.DateTimePicker datengayhentra;
        private System.Windows.Forms.TextBox txtsongayqua;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtsauchomuon;
        private System.Windows.Forms.TextBox txttruocchomuon;
        private System.Windows.Forms.Button bútach;
        private System.Windows.Forms.ComboBox cmbmaphieu;
    }
}