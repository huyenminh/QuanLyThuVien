namespace ql_thu_vien
{
    partial class thuthu
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
            this.labtentt = new System.Windows.Forms.Label();
            this.labmags = new System.Windows.Forms.Label();
            this.labngaysinh = new System.Windows.Forms.Label();
            this.labdiachi = new System.Windows.Forms.Label();
            this.datengaysinh = new System.Windows.Forms.DateTimePicker();
            this.txtmatt = new System.Windows.Forms.TextBox();
            this.txtdiachi = new System.Windows.Forms.TextBox();
            this.txtmags = new System.Windows.Forms.TextBox();
            this.txttentt = new System.Windows.Forms.TextBox();
            this.butluu = new System.Windows.Forms.Button();
            this.butthem = new System.Windows.Forms.Button();
            this.butxoa = new System.Windows.Forms.Button();
            this.butsua = new System.Windows.Forms.Button();
            this.butthoat = new System.Windows.Forms.Button();
            this.dgvthuthu = new System.Windows.Forms.DataGridView();
            this.grptimkiem = new System.Windows.Forms.GroupBox();
            this.labtimkiem = new System.Windows.Forms.Label();
            this.txttimkiem = new System.Windows.Forms.TextBox();
            this.buttimkiem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvthuthu)).BeginInit();
            this.grptimkiem.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã thủ thư";
            // 
            // labtentt
            // 
            this.labtentt.AutoSize = true;
            this.labtentt.Location = new System.Drawing.Point(37, 43);
            this.labtentt.Name = "labtentt";
            this.labtentt.Size = new System.Drawing.Size(62, 13);
            this.labtentt.TabIndex = 2;
            this.labtentt.Text = "Tên thủ thư";
            // 
            // labmags
            // 
            this.labmags.AutoSize = true;
            this.labmags.Location = new System.Drawing.Point(37, 72);
            this.labmags.Name = "labmags";
            this.labmags.Size = new System.Drawing.Size(64, 13);
            this.labmags.TabIndex = 4;
            this.labmags.Text = "Mã giám sát";
            // 
            // labngaysinh
            // 
            this.labngaysinh.AutoSize = true;
            this.labngaysinh.Location = new System.Drawing.Point(37, 137);
            this.labngaysinh.Name = "labngaysinh";
            this.labngaysinh.Size = new System.Drawing.Size(54, 13);
            this.labngaysinh.TabIndex = 6;
            this.labngaysinh.Text = "Ngày sinh";
            // 
            // labdiachi
            // 
            this.labdiachi.AutoSize = true;
            this.labdiachi.Location = new System.Drawing.Point(37, 105);
            this.labdiachi.Name = "labdiachi";
            this.labdiachi.Size = new System.Drawing.Size(40, 13);
            this.labdiachi.TabIndex = 8;
            this.labdiachi.Text = "Địa chỉ";
            // 
            // datengaysinh
            // 
            this.datengaysinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datengaysinh.Location = new System.Drawing.Point(151, 130);
            this.datengaysinh.Name = "datengaysinh";
            this.datengaysinh.Size = new System.Drawing.Size(159, 20);
            this.datengaysinh.TabIndex = 9;
            // 
            // txtmatt
            // 
            this.txtmatt.Location = new System.Drawing.Point(151, 10);
            this.txtmatt.Name = "txtmatt";
            this.txtmatt.Size = new System.Drawing.Size(159, 20);
            this.txtmatt.TabIndex = 10;
            // 
            // txtdiachi
            // 
            this.txtdiachi.Location = new System.Drawing.Point(151, 98);
            this.txtdiachi.Name = "txtdiachi";
            this.txtdiachi.Size = new System.Drawing.Size(159, 20);
            this.txtdiachi.TabIndex = 12;
            // 
            // txtmags
            // 
            this.txtmags.Location = new System.Drawing.Point(151, 65);
            this.txtmags.Name = "txtmags";
            this.txtmags.Size = new System.Drawing.Size(159, 20);
            this.txtmags.TabIndex = 14;
            // 
            // txttentt
            // 
            this.txttentt.Location = new System.Drawing.Point(151, 36);
            this.txttentt.Name = "txttentt";
            this.txttentt.Size = new System.Drawing.Size(159, 20);
            this.txttentt.TabIndex = 16;
            // 
            // butluu
            // 
            this.butluu.Location = new System.Drawing.Point(572, 80);
            this.butluu.Name = "butluu";
            this.butluu.Size = new System.Drawing.Size(62, 38);
            this.butluu.TabIndex = 18;
            this.butluu.Text = "Lưu";
            this.butluu.UseVisualStyleBackColor = true;
            this.butluu.Click += new System.EventHandler(this.butluu_Click);
            // 
            // butthem
            // 
            this.butthem.Location = new System.Drawing.Point(455, 10);
            this.butthem.Name = "butthem";
            this.butthem.Size = new System.Drawing.Size(63, 40);
            this.butthem.TabIndex = 19;
            this.butthem.Text = "Thêm";
            this.butthem.UseVisualStyleBackColor = true;
            this.butthem.Click += new System.EventHandler(this.butthem_Click);
            // 
            // butxoa
            // 
            this.butxoa.Location = new System.Drawing.Point(455, 80);
            this.butxoa.Name = "butxoa";
            this.butxoa.Size = new System.Drawing.Size(63, 38);
            this.butxoa.TabIndex = 21;
            this.butxoa.Text = "Xóa";
            this.butxoa.UseVisualStyleBackColor = true;
            this.butxoa.Click += new System.EventHandler(this.butxoa_Click);
            // 
            // butsua
            // 
            this.butsua.Location = new System.Drawing.Point(572, 10);
            this.butsua.Name = "butsua";
            this.butsua.Size = new System.Drawing.Size(62, 40);
            this.butsua.TabIndex = 23;
            this.butsua.Text = "Sửa";
            this.butsua.UseVisualStyleBackColor = true;
            this.butsua.Click += new System.EventHandler(this.butsua_Click);
            // 
            // butthoat
            // 
            this.butthoat.Location = new System.Drawing.Point(516, 137);
            this.butthoat.Name = "butthoat";
            this.butthoat.Size = new System.Drawing.Size(66, 43);
            this.butthoat.TabIndex = 25;
            this.butthoat.Text = "Thoát";
            this.butthoat.UseVisualStyleBackColor = true;
            this.butthoat.Click += new System.EventHandler(this.butthoat_Click);
            // 
            // dgvthuthu
            // 
            this.dgvthuthu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvthuthu.Location = new System.Drawing.Point(40, 265);
            this.dgvthuthu.Name = "dgvthuthu";
            this.dgvthuthu.Size = new System.Drawing.Size(594, 108);
            this.dgvthuthu.TabIndex = 26;
            this.dgvthuthu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvthuthu_CellContentClick);
            // 
            // grptimkiem
            // 
            this.grptimkiem.Controls.Add(this.labtimkiem);
            this.grptimkiem.Controls.Add(this.txttimkiem);
            this.grptimkiem.Controls.Add(this.buttimkiem);
            this.grptimkiem.Location = new System.Drawing.Point(40, 175);
            this.grptimkiem.Name = "grptimkiem";
            this.grptimkiem.Size = new System.Drawing.Size(433, 68);
            this.grptimkiem.TabIndex = 27;
            this.grptimkiem.TabStop = false;
            this.grptimkiem.Text = "Tìm kiếm";
            // 
            // labtimkiem
            // 
            this.labtimkiem.AutoSize = true;
            this.labtimkiem.Location = new System.Drawing.Point(16, 35);
            this.labtimkiem.Name = "labtimkiem";
            this.labtimkiem.Size = new System.Drawing.Size(49, 13);
            this.labtimkiem.TabIndex = 3;
            this.labtimkiem.Text = "Tìm kiếm";
            // 
            // txttimkiem
            // 
            this.txttimkiem.Location = new System.Drawing.Point(111, 28);
            this.txttimkiem.Name = "txttimkiem";
            this.txttimkiem.Size = new System.Drawing.Size(159, 20);
            this.txttimkiem.TabIndex = 2;
            this.txttimkiem.Click += new System.EventHandler(this.txttimkiem_Click);
            // 
            // buttimkiem
            // 
            this.buttimkiem.Location = new System.Drawing.Point(336, 28);
            this.buttimkiem.Name = "buttimkiem";
            this.buttimkiem.Size = new System.Drawing.Size(75, 23);
            this.buttimkiem.TabIndex = 1;
            this.buttimkiem.Text = "Tìm kiếm";
            this.buttimkiem.UseVisualStyleBackColor = true;
            this.buttimkiem.Click += new System.EventHandler(this.buttimkiem_Click);
            // 
            // thuthu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 385);
            this.Controls.Add(this.grptimkiem);
            this.Controls.Add(this.dgvthuthu);
            this.Controls.Add(this.butthoat);
            this.Controls.Add(this.butsua);
            this.Controls.Add(this.butxoa);
            this.Controls.Add(this.butthem);
            this.Controls.Add(this.butluu);
            this.Controls.Add(this.txttentt);
            this.Controls.Add(this.txtmags);
            this.Controls.Add(this.txtdiachi);
            this.Controls.Add(this.txtmatt);
            this.Controls.Add(this.datengaysinh);
            this.Controls.Add(this.labdiachi);
            this.Controls.Add(this.labngaysinh);
            this.Controls.Add(this.labmags);
            this.Controls.Add(this.labtentt);
            this.Controls.Add(this.label1);
            this.Name = "thuthu";
            this.Text = "Thủ thư";
            this.Load += new System.EventHandler(this.thuthu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvthuthu)).EndInit();
            this.grptimkiem.ResumeLayout(false);
            this.grptimkiem.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labtentt;
        private System.Windows.Forms.Label labmags;
        private System.Windows.Forms.Label labngaysinh;
        private System.Windows.Forms.Label labdiachi;
        private System.Windows.Forms.DateTimePicker datengaysinh;
        private System.Windows.Forms.TextBox txtmatt;
        private System.Windows.Forms.TextBox txtdiachi;
        private System.Windows.Forms.TextBox txtmags;
        private System.Windows.Forms.TextBox txttentt;
        private System.Windows.Forms.Button butluu;
        private System.Windows.Forms.Button butthem;
        private System.Windows.Forms.Button butxoa;
        private System.Windows.Forms.Button butsua;
        private System.Windows.Forms.Button butthoat;
        private System.Windows.Forms.DataGridView dgvthuthu;
        private System.Windows.Forms.GroupBox grptimkiem;
        private System.Windows.Forms.Label labtimkiem;
        private System.Windows.Forms.TextBox txttimkiem;
        private System.Windows.Forms.Button buttimkiem;
    }
}