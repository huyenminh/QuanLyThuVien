namespace ql_thu_vien
{
    partial class nxb
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
            this.grpnhap = new System.Windows.Forms.GroupBox();
            this.txttimkiem = new System.Windows.Forms.TextBox();
            this.labnhap = new System.Windows.Forms.Label();
            this.buttim = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtdc = new System.Windows.Forms.TextBox();
            this.txtten = new System.Windows.Forms.TextBox();
            this.txtma = new System.Windows.Forms.TextBox();
            this.butthoat = new System.Windows.Forms.Button();
            this.butluu = new System.Windows.Forms.Button();
            this.butxoa = new System.Windows.Forms.Button();
            this.butsua = new System.Windows.Forms.Button();
            this.butthem = new System.Windows.Forms.Button();
            this.dgv_nxb = new System.Windows.Forms.DataGridView();
            this.grpnhap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_nxb)).BeginInit();
            this.SuspendLayout();
            // 
            // grpnhap
            // 
            this.grpnhap.Controls.Add(this.txttimkiem);
            this.grpnhap.Controls.Add(this.labnhap);
            this.grpnhap.Controls.Add(this.buttim);
            this.grpnhap.Location = new System.Drawing.Point(471, 27);
            this.grpnhap.Name = "grpnhap";
            this.grpnhap.Size = new System.Drawing.Size(248, 119);
            this.grpnhap.TabIndex = 0;
            this.grpnhap.TabStop = false;
            this.grpnhap.Text = "Tìm Kiếm";
            // 
            // txttimkiem
            // 
            this.txttimkiem.Location = new System.Drawing.Point(31, 28);
            this.txttimkiem.Name = "txttimkiem";
            this.txttimkiem.Size = new System.Drawing.Size(100, 20);
            this.txttimkiem.TabIndex = 11;
            this.txttimkiem.Click += new System.EventHandler(this.txttimkiem_Click);
            // 
            // labnhap
            // 
            this.labnhap.AutoSize = true;
            this.labnhap.Location = new System.Drawing.Point(175, 31);
            this.labnhap.Name = "labnhap";
            this.labnhap.Size = new System.Drawing.Size(31, 13);
            this.labnhap.TabIndex = 10;
            this.labnhap.Text = "nhập";
            // 
            // buttim
            // 
            this.buttim.Location = new System.Drawing.Point(93, 73);
            this.buttim.Name = "buttim";
            this.buttim.Size = new System.Drawing.Size(75, 23);
            this.buttim.TabIndex = 9;
            this.buttim.Text = "Tìm Kiếm";
            this.buttim.UseVisualStyleBackColor = true;
            this.buttim.Click += new System.EventHandler(this.buttim_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã nxb";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên nxb";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Địa Chỉ";
            // 
            // txtdc
            // 
            this.txtdc.Location = new System.Drawing.Point(106, 114);
            this.txtdc.Name = "txtdc";
            this.txtdc.Size = new System.Drawing.Size(174, 20);
            this.txtdc.TabIndex = 0;
            // 
            // txtten
            // 
            this.txtten.Location = new System.Drawing.Point(106, 71);
            this.txtten.Name = "txtten";
            this.txtten.Size = new System.Drawing.Size(174, 20);
            this.txtten.TabIndex = 1;
            // 
            // txtma
            // 
            this.txtma.Location = new System.Drawing.Point(106, 27);
            this.txtma.Name = "txtma";
            this.txtma.Size = new System.Drawing.Size(174, 20);
            this.txtma.TabIndex = 2;
            // 
            // butthoat
            // 
            this.butthoat.Location = new System.Drawing.Point(620, 162);
            this.butthoat.Name = "butthoat";
            this.butthoat.Size = new System.Drawing.Size(75, 23);
            this.butthoat.TabIndex = 4;
            this.butthoat.Text = "Thoát";
            this.butthoat.UseVisualStyleBackColor = true;
            this.butthoat.Click += new System.EventHandler(this.butthoat_Click);
            // 
            // butluu
            // 
            this.butluu.Location = new System.Drawing.Point(502, 162);
            this.butluu.Name = "butluu";
            this.butluu.Size = new System.Drawing.Size(75, 23);
            this.butluu.TabIndex = 5;
            this.butluu.Text = "Lưu";
            this.butluu.UseVisualStyleBackColor = true;
            this.butluu.Click += new System.EventHandler(this.butluu_Click);
            // 
            // butxoa
            // 
            this.butxoa.Location = new System.Drawing.Point(355, 162);
            this.butxoa.Name = "butxoa";
            this.butxoa.Size = new System.Drawing.Size(75, 23);
            this.butxoa.TabIndex = 6;
            this.butxoa.Text = "Xóa";
            this.butxoa.UseVisualStyleBackColor = true;
            this.butxoa.Click += new System.EventHandler(this.butxoa_Click);
            // 
            // butsua
            // 
            this.butsua.Location = new System.Drawing.Point(196, 162);
            this.butsua.Name = "butsua";
            this.butsua.Size = new System.Drawing.Size(75, 23);
            this.butsua.TabIndex = 7;
            this.butsua.Text = "Sửa";
            this.butsua.UseVisualStyleBackColor = true;
            this.butsua.Click += new System.EventHandler(this.butsua_Click);
            // 
            // butthem
            // 
            this.butthem.Location = new System.Drawing.Point(51, 162);
            this.butthem.Name = "butthem";
            this.butthem.Size = new System.Drawing.Size(75, 23);
            this.butthem.TabIndex = 8;
            this.butthem.Text = "Thêm";
            this.butthem.UseVisualStyleBackColor = true;
            this.butthem.Click += new System.EventHandler(this.butthem_Click);
            // 
            // dgv_nxb
            // 
            this.dgv_nxb.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_nxb.Location = new System.Drawing.Point(-7, 202);
            this.dgv_nxb.Name = "dgv_nxb";
            this.dgv_nxb.Size = new System.Drawing.Size(740, 184);
            this.dgv_nxb.TabIndex = 9;
            this.dgv_nxb.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_nxb_CellContentClick);
            // 
            // nxb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 386);
            this.Controls.Add(this.dgv_nxb);
            this.Controls.Add(this.butthem);
            this.Controls.Add(this.butsua);
            this.Controls.Add(this.butxoa);
            this.Controls.Add(this.butluu);
            this.Controls.Add(this.butthoat);
            this.Controls.Add(this.txtdc);
            this.Controls.Add(this.txtten);
            this.Controls.Add(this.txtma);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.grpnhap);
            this.Name = "nxb";
            this.Text = "nhaxuatban";
            this.Load += new System.EventHandler(this.nhaxuatban_Load);
            this.grpnhap.ResumeLayout(false);
            this.grpnhap.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_nxb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpnhap;
        private System.Windows.Forms.Button buttim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtdc;
        private System.Windows.Forms.TextBox txtten;
        private System.Windows.Forms.TextBox txtma;
        private System.Windows.Forms.Button butthoat;
        private System.Windows.Forms.Button butluu;
        private System.Windows.Forms.Button butxoa;
        private System.Windows.Forms.Button butsua;
        private System.Windows.Forms.Button butthem;
        private System.Windows.Forms.DataGridView dgv_nxb;
        private System.Windows.Forms.TextBox txttimkiem;
        private System.Windows.Forms.Label labnhap;
    }
}