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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Phieumuontra));
            this.lab_maphieu = new System.Windows.Forms.Label();
            this.lab_matt = new System.Windows.Forms.Label();
            this.lab_madg = new System.Windows.Forms.Label();
            this.btnthoat = new System.Windows.Forms.Button();
            this.buttimkiem = new System.Windows.Forms.Button();
            this.grp_timkiem = new System.Windows.Forms.GroupBox();
            this.txttimkiempm = new System.Windows.Forms.TextBox();
            this.lab_timkiempm = new System.Windows.Forms.Label();
            this.dgvPhieumuontra = new System.Windows.Forms.DataGridView();
            this.cmbmatt = new System.Windows.Forms.ComboBox();
            this.cmbmadg = new System.Windows.Forms.ComboBox();
            this.btnsang = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtmaphieu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtsocuonmuonve = new System.Windows.Forms.TextBox();
            this.btnxoa = new System.Windows.Forms.Button();
            this.txtMaDG = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnXemDG = new System.Windows.Forms.Button();
            this.butsua = new System.Windows.Forms.Button();
            this.butthem = new System.Windows.Forms.Button();
            this.butluu = new System.Windows.Forms.Button();
            this.grp_timkiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieumuontra)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lab_maphieu
            // 
            this.lab_maphieu.AutoSize = true;
            this.lab_maphieu.Location = new System.Drawing.Point(37, 95);
            this.lab_maphieu.Name = "lab_maphieu";
            this.lab_maphieu.Size = new System.Drawing.Size(51, 13);
            this.lab_maphieu.TabIndex = 0;
            this.lab_maphieu.Text = "Mã phiếu";
            // 
            // lab_matt
            // 
            this.lab_matt.AutoSize = true;
            this.lab_matt.Location = new System.Drawing.Point(30, 53);
            this.lab_matt.Name = "lab_matt";
            this.lab_matt.Size = new System.Drawing.Size(58, 13);
            this.lab_matt.TabIndex = 8;
            this.lab_matt.Text = "Mã thủ thư";
            // 
            // lab_madg
            // 
            this.lab_madg.AutoSize = true;
            this.lab_madg.Location = new System.Drawing.Point(30, 24);
            this.lab_madg.Name = "lab_madg";
            this.lab_madg.Size = new System.Drawing.Size(61, 13);
            this.lab_madg.TabIndex = 10;
            this.lab_madg.Text = "Mã độc giả";
            // 
            // btnthoat
            // 
            this.btnthoat.Image = ((System.Drawing.Image)(resources.GetObject("btnthoat.Image")));
            this.btnthoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnthoat.Location = new System.Drawing.Point(332, 166);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(105, 25);
            this.btnthoat.TabIndex = 23;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.but_thoat_Click);
            // 
            // buttimkiem
            // 
            this.buttimkiem.Location = new System.Drawing.Point(314, 12);
            this.buttimkiem.Name = "buttimkiem";
            this.buttimkiem.Size = new System.Drawing.Size(75, 26);
            this.buttimkiem.TabIndex = 29;
            this.buttimkiem.Text = "Tìm kiếm";
            this.buttimkiem.UseVisualStyleBackColor = true;
            this.buttimkiem.Click += new System.EventHandler(this.but_timkiem_Click);
            // 
            // grp_timkiem
            // 
            this.grp_timkiem.Controls.Add(this.txttimkiempm);
            this.grp_timkiem.Controls.Add(this.lab_timkiempm);
            this.grp_timkiem.Controls.Add(this.buttimkiem);
            this.grp_timkiem.Location = new System.Drawing.Point(5, 208);
            this.grp_timkiem.Name = "grp_timkiem";
            this.grp_timkiem.Size = new System.Drawing.Size(432, 64);
            this.grp_timkiem.TabIndex = 32;
            this.grp_timkiem.TabStop = false;
            this.grp_timkiem.Text = "Tìm kiếm";
            // 
            // txttimkiempm
            // 
            this.txttimkiempm.Location = new System.Drawing.Point(119, 16);
            this.txttimkiempm.Name = "txttimkiempm";
            this.txttimkiempm.Size = new System.Drawing.Size(175, 20);
            this.txttimkiempm.TabIndex = 31;
            this.txttimkiempm.Click += new System.EventHandler(this.txt_timkiempm_Click);
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
            this.dgvPhieumuontra.Location = new System.Drawing.Point(12, 285);
            this.dgvPhieumuontra.Name = "dgvPhieumuontra";
            this.dgvPhieumuontra.Size = new System.Drawing.Size(439, 211);
            this.dgvPhieumuontra.TabIndex = 33;
            this.dgvPhieumuontra.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhieumuontra_CellContentClick);
            // 
            // cmbmatt
            // 
            this.cmbmatt.FormattingEnabled = true;
            this.cmbmatt.Location = new System.Drawing.Point(115, 50);
            this.cmbmatt.Name = "cmbmatt";
            this.cmbmatt.Size = new System.Drawing.Size(104, 21);
            this.cmbmatt.TabIndex = 34;
            // 
            // cmbmadg
            // 
            this.cmbmadg.FormattingEnabled = true;
            this.cmbmadg.Location = new System.Drawing.Point(115, 23);
            this.cmbmadg.Name = "cmbmadg";
            this.cmbmadg.Size = new System.Drawing.Size(104, 21);
            this.cmbmadg.TabIndex = 35;
            // 
            // btnsang
            // 
            this.btnsang.Location = new System.Drawing.Point(332, 5);
            this.btnsang.Name = "btnsang";
            this.btnsang.Size = new System.Drawing.Size(105, 28);
            this.btnsang.TabIndex = 36;
            this.btnsang.Text = "sang chi tiết mượn";
            this.btnsang.UseVisualStyleBackColor = true;
            this.btnsang.Click += new System.EventHandler(this.butsang_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtmaphieu);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtsocuonmuonve);
            this.groupBox1.Controls.Add(this.lab_maphieu);
            this.groupBox1.Controls.Add(this.cmbmadg);
            this.groupBox1.Controls.Add(this.cmbmatt);
            this.groupBox1.Controls.Add(this.lab_matt);
            this.groupBox1.Controls.Add(this.lab_madg);
            this.groupBox1.Location = new System.Drawing.Point(5, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(267, 152);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Độc Giả";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(272, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(10, 13);
            this.label4.TabIndex = 42;
            this.label4.Text = " ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(272, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(10, 13);
            this.label2.TabIndex = 40;
            this.label2.Text = " ";
            // 
            // txtmaphieu
            // 
            this.txtmaphieu.Location = new System.Drawing.Point(115, 91);
            this.txtmaphieu.Name = "txtmaphieu";
            this.txtmaphieu.Size = new System.Drawing.Size(104, 20);
            this.txtmaphieu.TabIndex = 39;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 36;
            this.label3.Text = "Số Cuốn Mượn Về";
            // 
            // txtsocuonmuonve
            // 
            this.txtsocuonmuonve.Location = new System.Drawing.Point(115, 119);
            this.txtsocuonmuonve.Name = "txtsocuonmuonve";
            this.txtsocuonmuonve.Size = new System.Drawing.Size(101, 20);
            this.txtsocuonmuonve.TabIndex = 37;
            // 
            // btnxoa
            // 
            this.btnxoa.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxoa.Image = ((System.Drawing.Image)(resources.GetObject("btnxoa.Image")));
            this.btnxoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnxoa.Location = new System.Drawing.Point(332, 134);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(105, 27);
            this.btnxoa.TabIndex = 119;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // txtMaDG
            // 
            this.txtMaDG.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMaDG.Location = new System.Drawing.Point(126, 6);
            this.txtMaDG.Name = "txtMaDG";
            this.txtMaDG.Size = new System.Drawing.Size(95, 21);
            this.txtMaDG.TabIndex = 122;
            this.txtMaDG.Click += new System.EventHandler(this.txtMaDG_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(80, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 14);
            this.label1.TabIndex = 124;
            this.label1.Text = "Mã ĐG:";
            // 
            // btnXemDG
            // 
            this.btnXemDG.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXemDG.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXemDG.Location = new System.Drawing.Point(227, 5);
            this.btnXemDG.Name = "btnXemDG";
            this.btnXemDG.Size = new System.Drawing.Size(77, 24);
            this.btnXemDG.TabIndex = 123;
            this.btnXemDG.Text = "Xem";
            this.btnXemDG.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnXemDG.UseVisualStyleBackColor = true;
            this.btnXemDG.Click += new System.EventHandler(this.btnXemDG_Click);
            // 
            // butsua
            // 
            this.butsua.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butsua.Image = ((System.Drawing.Image)(resources.GetObject("butsua.Image")));
            this.butsua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butsua.Location = new System.Drawing.Point(332, 101);
            this.butsua.Name = "butsua";
            this.butsua.Size = new System.Drawing.Size(105, 27);
            this.butsua.TabIndex = 120;
            this.butsua.Text = "Sửa";
            this.butsua.UseVisualStyleBackColor = true;
            this.butsua.Click += new System.EventHandler(this.butsua_Click);
            // 
            // butthem
            // 
            this.butthem.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butthem.Image = ((System.Drawing.Image)(resources.GetObject("butthem.Image")));
            this.butthem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butthem.Location = new System.Drawing.Point(332, 39);
            this.butthem.Name = "butthem";
            this.butthem.Size = new System.Drawing.Size(105, 27);
            this.butthem.TabIndex = 121;
            this.butthem.Text = "Thêm";
            this.butthem.UseVisualStyleBackColor = true;
            this.butthem.Click += new System.EventHandler(this.btnmuon_Click);
            // 
            // butluu
            // 
            this.butluu.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butluu.Image = ((System.Drawing.Image)(resources.GetObject("butluu.Image")));
            this.butluu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butluu.Location = new System.Drawing.Point(332, 72);
            this.butluu.Name = "butluu";
            this.butluu.Size = new System.Drawing.Size(105, 27);
            this.butluu.TabIndex = 125;
            this.butluu.Text = "Lưu";
            this.butluu.UseVisualStyleBackColor = true;
            this.butluu.Click += new System.EventHandler(this.butluu_Click);
            // 
            // Phieumuontra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 508);
            this.Controls.Add(this.butluu);
            this.Controls.Add(this.txtMaDG);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnXemDG);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.butsua);
            this.Controls.Add(this.butthem);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnsang);
            this.Controls.Add(this.dgvPhieumuontra);
            this.Controls.Add(this.grp_timkiem);
            this.Controls.Add(this.btnthoat);
            this.Name = "Phieumuontra";
            this.Text = "Phiếu mượn trả";
            this.Load += new System.EventHandler(this.Phieumuontra_Load);
            this.grp_timkiem.ResumeLayout(false);
            this.grp_timkiem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieumuontra)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lab_maphieu;
        private System.Windows.Forms.Label lab_matt;
        private System.Windows.Forms.Label lab_madg;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Button buttimkiem;
        private System.Windows.Forms.GroupBox grp_timkiem;
        private System.Windows.Forms.TextBox txttimkiempm;
        private System.Windows.Forms.Label lab_timkiempm;
        private System.Windows.Forms.DataGridView dgvPhieumuontra;
        private System.Windows.Forms.ComboBox cmbmatt;
        private System.Windows.Forms.ComboBox cmbmadg;
        private System.Windows.Forms.Button btnsang;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.TextBox txtMaDG;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnXemDG;
        private System.Windows.Forms.TextBox txtmaphieu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtsocuonmuonve;
        private System.Windows.Forms.Button butsua;
        private System.Windows.Forms.Button butthem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button butluu;
    }
}