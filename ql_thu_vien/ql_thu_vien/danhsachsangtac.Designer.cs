namespace ql_thu_vien
{
    partial class danhsachsangtac
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
            this.labmatg = new System.Windows.Forms.Label();
            this.labsotrang = new System.Windows.Forms.Label();
            this.labmasach = new System.Windows.Forms.Label();
            this.txtmatg = new System.Windows.Forms.TextBox();
            this.txtsotrang = new System.Windows.Forms.TextBox();
            this.txtmasach = new System.Windows.Forms.TextBox();
            this.grptimkiem = new System.Windows.Forms.GroupBox();
            this.labtimkiem = new System.Windows.Forms.Label();
            this.txttimkiem = new System.Windows.Forms.TextBox();
            this.buttimkiem = new System.Windows.Forms.Button();
            this.butthem = new System.Windows.Forms.Button();
            this.butthoat = new System.Windows.Forms.Button();
            this.butluu = new System.Windows.Forms.Button();
            this.butxoa = new System.Windows.Forms.Button();
            this.butsua = new System.Windows.Forms.Button();
            this.dgvdsst = new System.Windows.Forms.DataGridView();
            this.grptimkiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdsst)).BeginInit();
            this.SuspendLayout();
            // 
            // labmatg
            // 
            this.labmatg.AutoSize = true;
            this.labmatg.Location = new System.Drawing.Point(44, 33);
            this.labmatg.Name = "labmatg";
            this.labmatg.Size = new System.Drawing.Size(57, 13);
            this.labmatg.TabIndex = 0;
            this.labmatg.Text = "Mã tác giả";
            // 
            // labsotrang
            // 
            this.labsotrang.AutoSize = true;
            this.labsotrang.Location = new System.Drawing.Point(44, 119);
            this.labsotrang.Name = "labsotrang";
            this.labsotrang.Size = new System.Drawing.Size(47, 13);
            this.labsotrang.TabIndex = 2;
            this.labsotrang.Text = "Số trang";
            // 
            // labmasach
            // 
            this.labmasach.AutoSize = true;
            this.labmasach.Location = new System.Drawing.Point(44, 72);
            this.labmasach.Name = "labmasach";
            this.labmasach.Size = new System.Drawing.Size(48, 13);
            this.labmasach.TabIndex = 4;
            this.labmasach.Text = "Mã sách";
            // 
            // txtmatg
            // 
            this.txtmatg.Location = new System.Drawing.Point(138, 26);
            this.txtmatg.Name = "txtmatg";
            this.txtmatg.Size = new System.Drawing.Size(100, 20);
            this.txtmatg.TabIndex = 5;
            // 
            // txtsotrang
            // 
            this.txtsotrang.Location = new System.Drawing.Point(138, 112);
            this.txtsotrang.Name = "txtsotrang";
            this.txtsotrang.Size = new System.Drawing.Size(100, 20);
            this.txtsotrang.TabIndex = 7;
            // 
            // txtmasach
            // 
            this.txtmasach.Location = new System.Drawing.Point(138, 72);
            this.txtmasach.Name = "txtmasach";
            this.txtmasach.Size = new System.Drawing.Size(100, 20);
            this.txtmasach.TabIndex = 9;
            // 
            // grptimkiem
            // 
            this.grptimkiem.Controls.Add(this.labtimkiem);
            this.grptimkiem.Controls.Add(this.txttimkiem);
            this.grptimkiem.Controls.Add(this.buttimkiem);
            this.grptimkiem.Location = new System.Drawing.Point(507, 23);
            this.grptimkiem.Name = "grptimkiem";
            this.grptimkiem.Size = new System.Drawing.Size(245, 109);
            this.grptimkiem.TabIndex = 10;
            this.grptimkiem.TabStop = false;
            this.grptimkiem.Text = "Tìm kiếm";
            // 
            // labtimkiem
            // 
            this.labtimkiem.AutoSize = true;
            this.labtimkiem.Location = new System.Drawing.Point(15, 44);
            this.labtimkiem.Name = "labtimkiem";
            this.labtimkiem.Size = new System.Drawing.Size(49, 13);
            this.labtimkiem.TabIndex = 15;
            this.labtimkiem.Text = "Tìm kiếm";
            // 
            // txttimkiem
            // 
            this.txttimkiem.Location = new System.Drawing.Point(106, 41);
            this.txttimkiem.Name = "txttimkiem";
            this.txttimkiem.Size = new System.Drawing.Size(100, 20);
            this.txttimkiem.TabIndex = 14;
            this.txttimkiem.Click += new System.EventHandler(this.txttimkiem_Click);
            // 
            // buttimkiem
            // 
            this.buttimkiem.Location = new System.Drawing.Point(83, 80);
            this.buttimkiem.Name = "buttimkiem";
            this.buttimkiem.Size = new System.Drawing.Size(75, 23);
            this.buttimkiem.TabIndex = 13;
            this.buttimkiem.Text = "Tìm kiếm";
            this.buttimkiem.UseVisualStyleBackColor = true;
            this.buttimkiem.Click += new System.EventHandler(this.buttimkiem_Click);
            // 
            // butthem
            // 
            this.butthem.Location = new System.Drawing.Point(284, 23);
            this.butthem.Name = "butthem";
            this.butthem.Size = new System.Drawing.Size(75, 23);
            this.butthem.TabIndex = 11;
            this.butthem.Text = "Thêm";
            this.butthem.UseVisualStyleBackColor = true;
            this.butthem.Click += new System.EventHandler(this.butthem_Click);
            // 
            // butthoat
            // 
            this.butthoat.Location = new System.Drawing.Point(346, 109);
            this.butthoat.Name = "butthoat";
            this.butthoat.Size = new System.Drawing.Size(75, 23);
            this.butthoat.TabIndex = 12;
            this.butthoat.Text = "Thoát";
            this.butthoat.UseVisualStyleBackColor = true;
            this.butthoat.Click += new System.EventHandler(this.butthoat_Click);
            // 
            // butluu
            // 
            this.butluu.Location = new System.Drawing.Point(393, 67);
            this.butluu.Name = "butluu";
            this.butluu.Size = new System.Drawing.Size(75, 23);
            this.butluu.TabIndex = 14;
            this.butluu.Text = "Lưu";
            this.butluu.UseVisualStyleBackColor = true;
            this.butluu.Click += new System.EventHandler(this.butluu_Click);
            // 
            // butxoa
            // 
            this.butxoa.Location = new System.Drawing.Point(284, 67);
            this.butxoa.Name = "butxoa";
            this.butxoa.Size = new System.Drawing.Size(75, 23);
            this.butxoa.TabIndex = 15;
            this.butxoa.Text = "Xóa";
            this.butxoa.UseVisualStyleBackColor = true;
            this.butxoa.Click += new System.EventHandler(this.butxoa_Click);
            // 
            // butsua
            // 
            this.butsua.Location = new System.Drawing.Point(393, 23);
            this.butsua.Name = "butsua";
            this.butsua.Size = new System.Drawing.Size(75, 23);
            this.butsua.TabIndex = 16;
            this.butsua.Text = "Sửa";
            this.butsua.UseVisualStyleBackColor = true;
            this.butsua.Click += new System.EventHandler(this.butsua_Click);
            // 
            // dgvdsst
            // 
            this.dgvdsst.BackgroundColor = System.Drawing.Color.White;
            this.dgvdsst.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdsst.Location = new System.Drawing.Point(47, 171);
            this.dgvdsst.Name = "dgvdsst";
            this.dgvdsst.Size = new System.Drawing.Size(421, 88);
            this.dgvdsst.TabIndex = 17;
            this.dgvdsst.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvdsst_CellContentClick);
            // 
            // danhsachsangtac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 283);
            this.Controls.Add(this.dgvdsst);
            this.Controls.Add(this.butsua);
            this.Controls.Add(this.butxoa);
            this.Controls.Add(this.butluu);
            this.Controls.Add(this.butthoat);
            this.Controls.Add(this.butthem);
            this.Controls.Add(this.grptimkiem);
            this.Controls.Add(this.txtmasach);
            this.Controls.Add(this.txtsotrang);
            this.Controls.Add(this.txtmatg);
            this.Controls.Add(this.labmasach);
            this.Controls.Add(this.labsotrang);
            this.Controls.Add(this.labmatg);
            this.Name = "danhsachsangtac";
            this.Text = "Danh sách sáng tác";
            this.Load += new System.EventHandler(this.danhsachsangtac_Load);
            this.grptimkiem.ResumeLayout(false);
            this.grptimkiem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdsst)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labmatg;
        private System.Windows.Forms.Label labsotrang;
        private System.Windows.Forms.Label labmasach;
        private System.Windows.Forms.TextBox txtmatg;
        private System.Windows.Forms.TextBox txtsotrang;
        private System.Windows.Forms.TextBox txtmasach;
        private System.Windows.Forms.GroupBox grptimkiem;
        private System.Windows.Forms.Label labtimkiem;
        private System.Windows.Forms.TextBox txttimkiem;
        private System.Windows.Forms.Button buttimkiem;
        private System.Windows.Forms.Button butthem;
        private System.Windows.Forms.Button butthoat;
        private System.Windows.Forms.Button butluu;
        private System.Windows.Forms.Button butxoa;
        private System.Windows.Forms.Button butsua;
        private System.Windows.Forms.DataGridView dgvdsst;
    }
}