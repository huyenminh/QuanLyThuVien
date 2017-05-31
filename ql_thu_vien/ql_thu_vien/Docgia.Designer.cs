namespace ql_thu_vien
{
    partial class Docgia
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
            this.butthem = new System.Windows.Forms.Button();
            this.buttimkiem = new System.Windows.Forms.Button();
            this.butthoat = new System.Windows.Forms.Button();
            this.butluu = new System.Windows.Forms.Button();
            this.butxoa = new System.Windows.Forms.Button();
            this.butsua = new System.Windows.Forms.Button();
            this.labmadg = new System.Windows.Forms.Label();
            this.labtendg = new System.Windows.Forms.Label();
            this.labngaysinh = new System.Windows.Forms.Label();
            this.labdiachi = new System.Windows.Forms.Label();
            this.txtmadg = new System.Windows.Forms.TextBox();
            this.txtdiachi = new System.Windows.Forms.TextBox();
            this.txttendg = new System.Windows.Forms.TextBox();
            this.datengaysinh = new System.Windows.Forms.DateTimePicker();
            this.grptimkiem = new System.Windows.Forms.GroupBox();
            this.labtimkiem = new System.Windows.Forms.Label();
            this.txttimkiem = new System.Windows.Forms.TextBox();
            this.dgvDocgia = new System.Windows.Forms.DataGridView();
            this.grptimkiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocgia)).BeginInit();
            this.SuspendLayout();
            // 
            // butthem
            // 
            this.butthem.Location = new System.Drawing.Point(297, 9);
            this.butthem.Name = "butthem";
            this.butthem.Size = new System.Drawing.Size(75, 23);
            this.butthem.TabIndex = 0;
            this.butthem.Text = "Thêm";
            this.butthem.UseVisualStyleBackColor = true;
            this.butthem.Click += new System.EventHandler(this.butthem_Click);
            // 
            // buttimkiem
            // 
            this.buttimkiem.Location = new System.Drawing.Point(77, 94);
            this.buttimkiem.Name = "buttimkiem";
            this.buttimkiem.Size = new System.Drawing.Size(75, 23);
            this.buttimkiem.TabIndex = 2;
            this.buttimkiem.Text = "Tìm kiếm";
            this.buttimkiem.UseVisualStyleBackColor = true;
            this.buttimkiem.Click += new System.EventHandler(this.buttimkiem_Click);
            // 
            // butthoat
            // 
            this.butthoat.Location = new System.Drawing.Point(348, 89);
            this.butthoat.Name = "butthoat";
            this.butthoat.Size = new System.Drawing.Size(75, 23);
            this.butthoat.TabIndex = 4;
            this.butthoat.Text = "Thoát";
            this.butthoat.UseVisualStyleBackColor = true;
            this.butthoat.Click += new System.EventHandler(this.butthoat_Click);
            // 
            // butluu
            // 
            this.butluu.Location = new System.Drawing.Point(400, 48);
            this.butluu.Name = "butluu";
            this.butluu.Size = new System.Drawing.Size(75, 23);
            this.butluu.TabIndex = 6;
            this.butluu.Text = "Lưu";
            this.butluu.UseVisualStyleBackColor = true;
            this.butluu.Click += new System.EventHandler(this.butluu_Click);
            // 
            // butxoa
            // 
            this.butxoa.Location = new System.Drawing.Point(297, 48);
            this.butxoa.Name = "butxoa";
            this.butxoa.Size = new System.Drawing.Size(75, 23);
            this.butxoa.TabIndex = 8;
            this.butxoa.Text = "Xóa";
            this.butxoa.UseVisualStyleBackColor = true;
            this.butxoa.Click += new System.EventHandler(this.butxoa_Click);
            // 
            // butsua
            // 
            this.butsua.Location = new System.Drawing.Point(400, 10);
            this.butsua.Name = "butsua";
            this.butsua.Size = new System.Drawing.Size(75, 23);
            this.butsua.TabIndex = 10;
            this.butsua.Text = "Sửa";
            this.butsua.UseVisualStyleBackColor = true;
            this.butsua.Click += new System.EventHandler(this.butsua_Click);
            // 
            // labmadg
            // 
            this.labmadg.AutoSize = true;
            this.labmadg.Location = new System.Drawing.Point(32, 19);
            this.labmadg.Name = "labmadg";
            this.labmadg.Size = new System.Drawing.Size(61, 13);
            this.labmadg.TabIndex = 11;
            this.labmadg.Text = "Mã độc giả";
            // 
            // labtendg
            // 
            this.labtendg.AutoSize = true;
            this.labtendg.Location = new System.Drawing.Point(32, 58);
            this.labtendg.Name = "labtendg";
            this.labtendg.Size = new System.Drawing.Size(65, 13);
            this.labtendg.TabIndex = 13;
            this.labtendg.Text = "Tên độc giả";
            // 
            // labngaysinh
            // 
            this.labngaysinh.AutoSize = true;
            this.labngaysinh.Location = new System.Drawing.Point(32, 96);
            this.labngaysinh.Name = "labngaysinh";
            this.labngaysinh.Size = new System.Drawing.Size(54, 13);
            this.labngaysinh.TabIndex = 15;
            this.labngaysinh.Text = "Ngày sinh";
            // 
            // labdiachi
            // 
            this.labdiachi.AutoSize = true;
            this.labdiachi.Location = new System.Drawing.Point(32, 132);
            this.labdiachi.Name = "labdiachi";
            this.labdiachi.Size = new System.Drawing.Size(40, 13);
            this.labdiachi.TabIndex = 17;
            this.labdiachi.Text = "Địa chỉ";
            // 
            // txtmadg
            // 
            this.txtmadg.Location = new System.Drawing.Point(106, 12);
            this.txtmadg.Name = "txtmadg";
            this.txtmadg.Size = new System.Drawing.Size(133, 20);
            this.txtmadg.TabIndex = 18;
            // 
            // txtdiachi
            // 
            this.txtdiachi.Location = new System.Drawing.Point(106, 125);
            this.txtdiachi.Name = "txtdiachi";
            this.txtdiachi.Size = new System.Drawing.Size(133, 20);
            this.txtdiachi.TabIndex = 20;
            // 
            // txttendg
            // 
            this.txttendg.Location = new System.Drawing.Point(106, 51);
            this.txttendg.Name = "txttendg";
            this.txttendg.Size = new System.Drawing.Size(133, 20);
            this.txttendg.TabIndex = 22;
            // 
            // datengaysinh
            // 
            this.datengaysinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datengaysinh.Location = new System.Drawing.Point(106, 89);
            this.datengaysinh.Name = "datengaysinh";
            this.datengaysinh.Size = new System.Drawing.Size(133, 20);
            this.datengaysinh.TabIndex = 23;
            // 
            // grptimkiem
            // 
            this.grptimkiem.Controls.Add(this.txttimkiem);
            this.grptimkiem.Controls.Add(this.labtimkiem);
            this.grptimkiem.Controls.Add(this.buttimkiem);
            this.grptimkiem.Location = new System.Drawing.Point(496, 12);
            this.grptimkiem.Name = "grptimkiem";
            this.grptimkiem.Size = new System.Drawing.Size(200, 123);
            this.grptimkiem.TabIndex = 24;
            this.grptimkiem.TabStop = false;
            this.grptimkiem.Text = "Tìm kiếm";
            // 
            // labtimkiem
            // 
            this.labtimkiem.AutoSize = true;
            this.labtimkiem.Location = new System.Drawing.Point(10, 29);
            this.labtimkiem.Name = "labtimkiem";
            this.labtimkiem.Size = new System.Drawing.Size(49, 13);
            this.labtimkiem.TabIndex = 3;
            this.labtimkiem.Text = "Tìm kiếm";
            // 
            // txttimkiem
            // 
            this.txttimkiem.Location = new System.Drawing.Point(65, 57);
            this.txttimkiem.Name = "txttimkiem";
            this.txttimkiem.Size = new System.Drawing.Size(108, 20);
            this.txttimkiem.TabIndex = 4;
            this.txttimkiem.Click += new System.EventHandler(this.txttimkiem_Click);
            // 
            // dgvDocgia
            // 
            this.dgvDocgia.BackgroundColor = System.Drawing.Color.White;
            this.dgvDocgia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDocgia.Location = new System.Drawing.Point(35, 171);
            this.dgvDocgia.Name = "dgvDocgia";
            this.dgvDocgia.Size = new System.Drawing.Size(440, 115);
            this.dgvDocgia.TabIndex = 25;
            this.dgvDocgia.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDocgia_CellContentClick);
            // 
            // Docgia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 298);
            this.Controls.Add(this.dgvDocgia);
            this.Controls.Add(this.grptimkiem);
            this.Controls.Add(this.datengaysinh);
            this.Controls.Add(this.txttendg);
            this.Controls.Add(this.txtdiachi);
            this.Controls.Add(this.txtmadg);
            this.Controls.Add(this.labdiachi);
            this.Controls.Add(this.labngaysinh);
            this.Controls.Add(this.labtendg);
            this.Controls.Add(this.labmadg);
            this.Controls.Add(this.butsua);
            this.Controls.Add(this.butxoa);
            this.Controls.Add(this.butluu);
            this.Controls.Add(this.butthoat);
            this.Controls.Add(this.butthem);
            this.Name = "Docgia";
            this.Text = "Độc giả";
            this.Load += new System.EventHandler(this.Docgia_Load);
            this.grptimkiem.ResumeLayout(false);
            this.grptimkiem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocgia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butthem;
        private System.Windows.Forms.Button buttimkiem;
        private System.Windows.Forms.Button butthoat;
        private System.Windows.Forms.Button butluu;
        private System.Windows.Forms.Button butxoa;
        private System.Windows.Forms.Button butsua;
        private System.Windows.Forms.Label labmadg;
        private System.Windows.Forms.Label labtendg;
        private System.Windows.Forms.Label labngaysinh;
        private System.Windows.Forms.Label labdiachi;
        private System.Windows.Forms.TextBox txtmadg;
        private System.Windows.Forms.TextBox txtdiachi;
        private System.Windows.Forms.TextBox txttendg;
        private System.Windows.Forms.DateTimePicker datengaysinh;
        private System.Windows.Forms.GroupBox grptimkiem;
        private System.Windows.Forms.TextBox txttimkiem;
        private System.Windows.Forms.Label labtimkiem;
        private System.Windows.Forms.DataGridView dgvDocgia;
    }
}