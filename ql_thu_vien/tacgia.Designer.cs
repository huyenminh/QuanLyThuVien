namespace ql_thu_vien
{
    partial class tacgia
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.grpnhap = new System.Windows.Forms.GroupBox();
            this.butnhap = new System.Windows.Forms.Button();
            this.labnhap = new System.Windows.Forms.Label();
            this.txttimkiem = new System.Windows.Forms.TextBox();
            this.txtdc = new System.Windows.Forms.TextBox();
            this.txtten = new System.Windows.Forms.TextBox();
            this.txtma = new System.Windows.Forms.TextBox();
            this.butthoat = new System.Windows.Forms.Button();
            this.butluu = new System.Windows.Forms.Button();
            this.butxoa = new System.Windows.Forms.Button();
            this.butsua = new System.Windows.Forms.Button();
            this.butthem = new System.Windows.Forms.Button();
            this.dgv_tacgia = new System.Windows.Forms.DataGridView();
            this.grpnhap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tacgia)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Tác Giả";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên Tác Giả";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Địa Chỉ";
            // 
            // grpnhap
            // 
            this.grpnhap.Controls.Add(this.butnhap);
            this.grpnhap.Controls.Add(this.labnhap);
            this.grpnhap.Controls.Add(this.txttimkiem);
            this.grpnhap.Location = new System.Drawing.Point(397, 26);
            this.grpnhap.Name = "grpnhap";
            this.grpnhap.Size = new System.Drawing.Size(200, 100);
            this.grpnhap.TabIndex = 3;
            this.grpnhap.TabStop = false;
            this.grpnhap.Text = "Tìm Kiếm ";
            // 
            // butnhap
            // 
            this.butnhap.Location = new System.Drawing.Point(61, 59);
            this.butnhap.Name = "butnhap";
            this.butnhap.Size = new System.Drawing.Size(75, 23);
            this.butnhap.TabIndex = 3;
            this.butnhap.Text = "Tìm kiếm";
            this.butnhap.UseVisualStyleBackColor = true;
            this.butnhap.Click += new System.EventHandler(this.butnhap_Click);
            // 
            // labnhap
            // 
            this.labnhap.AutoSize = true;
            this.labnhap.Location = new System.Drawing.Point(141, 33);
            this.labnhap.Name = "labnhap";
            this.labnhap.Size = new System.Drawing.Size(33, 13);
            this.labnhap.TabIndex = 1;
            this.labnhap.Text = "Nhập";
            // 
            // txttimkiem
            // 
            this.txttimkiem.Location = new System.Drawing.Point(15, 26);
            this.txttimkiem.Name = "txttimkiem";
            this.txttimkiem.Size = new System.Drawing.Size(100, 20);
            this.txttimkiem.TabIndex = 0;
            this.txttimkiem.Click += new System.EventHandler(this.txttimkiem_Click);
            // 
            // txtdc
            // 
            this.txtdc.Location = new System.Drawing.Point(111, 106);
            this.txtdc.Name = "txtdc";
            this.txtdc.Size = new System.Drawing.Size(181, 20);
            this.txtdc.TabIndex = 1;
            // 
            // txtten
            // 
            this.txtten.Location = new System.Drawing.Point(111, 63);
            this.txtten.Name = "txtten";
            this.txtten.Size = new System.Drawing.Size(181, 20);
            this.txtten.TabIndex = 2;
            // 
            // txtma
            // 
            this.txtma.Location = new System.Drawing.Point(111, 23);
            this.txtma.Name = "txtma";
            this.txtma.Size = new System.Drawing.Size(181, 20);
            this.txtma.TabIndex = 3;
            // 
            // butthoat
            // 
            this.butthoat.Location = new System.Drawing.Point(551, 162);
            this.butthoat.Name = "butthoat";
            this.butthoat.Size = new System.Drawing.Size(75, 23);
            this.butthoat.TabIndex = 4;
            this.butthoat.Text = "thoát";
            this.butthoat.UseVisualStyleBackColor = true;
            this.butthoat.Click += new System.EventHandler(this.butthoat_Click);
            // 
            // butluu
            // 
            this.butluu.Location = new System.Drawing.Point(437, 162);
            this.butluu.Name = "butluu";
            this.butluu.Size = new System.Drawing.Size(75, 23);
            this.butluu.TabIndex = 5;
            this.butluu.Text = "lưu";
            this.butluu.UseVisualStyleBackColor = true;
            this.butluu.Click += new System.EventHandler(this.butluu_Click);
            // 
            // butxoa
            // 
            this.butxoa.Location = new System.Drawing.Point(304, 162);
            this.butxoa.Name = "butxoa";
            this.butxoa.Size = new System.Drawing.Size(75, 23);
            this.butxoa.TabIndex = 6;
            this.butxoa.Text = "xóa";
            this.butxoa.UseVisualStyleBackColor = true;
            this.butxoa.Click += new System.EventHandler(this.butxoa_Click);
            // 
            // butsua
            // 
            this.butsua.Location = new System.Drawing.Point(166, 162);
            this.butsua.Name = "butsua";
            this.butsua.Size = new System.Drawing.Size(75, 23);
            this.butsua.TabIndex = 7;
            this.butsua.Text = "sửa";
            this.butsua.UseVisualStyleBackColor = true;
            this.butsua.Click += new System.EventHandler(this.butsua_Click);
            // 
            // butthem
            // 
            this.butthem.Location = new System.Drawing.Point(33, 162);
            this.butthem.Name = "butthem";
            this.butthem.Size = new System.Drawing.Size(75, 23);
            this.butthem.TabIndex = 8;
            this.butthem.Text = "thêm";
            this.butthem.UseVisualStyleBackColor = true;
            this.butthem.Click += new System.EventHandler(this.butthem_Click);
            // 
            // dgv_tacgia
            // 
            this.dgv_tacgia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_tacgia.Location = new System.Drawing.Point(1, 230);
            this.dgv_tacgia.Name = "dgv_tacgia";
            this.dgv_tacgia.Size = new System.Drawing.Size(649, 190);
            this.dgv_tacgia.TabIndex = 4;
            this.dgv_tacgia.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_tacgia_CellContentClick);
            // 
            // tacgia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 420);
            this.Controls.Add(this.dgv_tacgia);
            this.Controls.Add(this.butthoat);
            this.Controls.Add(this.butluu);
            this.Controls.Add(this.butxoa);
            this.Controls.Add(this.butsua);
            this.Controls.Add(this.butthem);
            this.Controls.Add(this.txtdc);
            this.Controls.Add(this.txtten);
            this.Controls.Add(this.txtma);
            this.Controls.Add(this.grpnhap);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "tacgia";
            this.Text = "tacgia";
            this.Load += new System.EventHandler(this.tacgia_Load);
            this.grpnhap.ResumeLayout(false);
            this.grpnhap.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tacgia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox grpnhap;
        private System.Windows.Forms.DataGridView dgv_tacgia;
        private System.Windows.Forms.Button butnhap;
        private System.Windows.Forms.Label labnhap;
        private System.Windows.Forms.TextBox txttimkiem;
        private System.Windows.Forms.TextBox txtdc;
        private System.Windows.Forms.TextBox txtten;
        private System.Windows.Forms.TextBox txtma;
        private System.Windows.Forms.Button butthoat;
        private System.Windows.Forms.Button butluu;
        private System.Windows.Forms.Button butxoa;
        private System.Windows.Forms.Button butsua;
        private System.Windows.Forms.Button butthem;
    }
}