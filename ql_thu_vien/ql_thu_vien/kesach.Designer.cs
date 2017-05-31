namespace ql_thu_vien
{
    partial class kesach
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
            this.grptimkiem = new System.Windows.Forms.GroupBox();
            this.txttimkiem = new System.Windows.Forms.TextBox();
            this.labtimkiem = new System.Windows.Forms.Label();
            this.buttimkiem = new System.Windows.Forms.Button();
            this.txtvitri = new System.Windows.Forms.TextBox();
            this.txtsongan = new System.Windows.Forms.TextBox();
            this.txtmatt = new System.Windows.Forms.TextBox();
            this.butthem = new System.Windows.Forms.Button();
            this.butthoat = new System.Windows.Forms.Button();
            this.butluu = new System.Windows.Forms.Button();
            this.butxoa = new System.Windows.Forms.Button();
            this.butsua = new System.Windows.Forms.Button();
            this.dgvkesach = new System.Windows.Forms.DataGridView();
            this.labvitri = new System.Windows.Forms.Label();
            this.labmatt = new System.Windows.Forms.Label();
            this.labsongan = new System.Windows.Forms.Label();
            this.grptimkiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvkesach)).BeginInit();
            this.SuspendLayout();
            // 
            // grptimkiem
            // 
            this.grptimkiem.Controls.Add(this.txttimkiem);
            this.grptimkiem.Controls.Add(this.labtimkiem);
            this.grptimkiem.Controls.Add(this.buttimkiem);
            this.grptimkiem.Location = new System.Drawing.Point(513, 12);
            this.grptimkiem.Name = "grptimkiem";
            this.grptimkiem.Size = new System.Drawing.Size(197, 142);
            this.grptimkiem.TabIndex = 0;
            this.grptimkiem.TabStop = false;
            this.grptimkiem.Text = "Tìm kiếm";
            // 
            // txttimkiem
            // 
            this.txttimkiem.Location = new System.Drawing.Point(25, 56);
            this.txttimkiem.Name = "txttimkiem";
            this.txttimkiem.Size = new System.Drawing.Size(134, 20);
            this.txttimkiem.TabIndex = 12;
            this.txttimkiem.Click += new System.EventHandler(this.txttimkiem_Click);
            // 
            // labtimkiem
            // 
            this.labtimkiem.AutoSize = true;
            this.labtimkiem.Location = new System.Drawing.Point(6, 31);
            this.labtimkiem.Name = "labtimkiem";
            this.labtimkiem.Size = new System.Drawing.Size(49, 13);
            this.labtimkiem.TabIndex = 11;
            this.labtimkiem.Text = "Tìm kiếm";
            // 
            // buttimkiem
            // 
            this.buttimkiem.Location = new System.Drawing.Point(62, 107);
            this.buttimkiem.Name = "buttimkiem";
            this.buttimkiem.Size = new System.Drawing.Size(75, 23);
            this.buttimkiem.TabIndex = 10;
            this.buttimkiem.Text = "Tìm kiếm";
            this.buttimkiem.UseVisualStyleBackColor = true;
            this.buttimkiem.Click += new System.EventHandler(this.buttimkiem_Click);
            // 
            // txtvitri
            // 
            this.txtvitri.Location = new System.Drawing.Point(135, 12);
            this.txtvitri.Name = "txtvitri";
            this.txtvitri.Size = new System.Drawing.Size(100, 20);
            this.txtvitri.TabIndex = 1;
            // 
            // txtsongan
            // 
            this.txtsongan.Location = new System.Drawing.Point(135, 58);
            this.txtsongan.Name = "txtsongan";
            this.txtsongan.Size = new System.Drawing.Size(100, 20);
            this.txtsongan.TabIndex = 2;
            // 
            // txtmatt
            // 
            this.txtmatt.Location = new System.Drawing.Point(135, 104);
            this.txtmatt.Name = "txtmatt";
            this.txtmatt.Size = new System.Drawing.Size(100, 20);
            this.txtmatt.TabIndex = 4;
            // 
            // butthem
            // 
            this.butthem.Location = new System.Drawing.Point(294, 12);
            this.butthem.Name = "butthem";
            this.butthem.Size = new System.Drawing.Size(75, 23);
            this.butthem.TabIndex = 5;
            this.butthem.Text = "Thêm";
            this.butthem.UseVisualStyleBackColor = true;
            this.butthem.Click += new System.EventHandler(this.butthem_Click);
            // 
            // butthoat
            // 
            this.butthoat.Location = new System.Drawing.Point(345, 102);
            this.butthoat.Name = "butthoat";
            this.butthoat.Size = new System.Drawing.Size(75, 23);
            this.butthoat.TabIndex = 6;
            this.butthoat.Text = "Thoát";
            this.butthoat.UseVisualStyleBackColor = true;
            this.butthoat.Click += new System.EventHandler(this.butthoat_Click);
            // 
            // butluu
            // 
            this.butluu.Location = new System.Drawing.Point(390, 58);
            this.butluu.Name = "butluu";
            this.butluu.Size = new System.Drawing.Size(75, 23);
            this.butluu.TabIndex = 7;
            this.butluu.Text = "Lưu";
            this.butluu.UseVisualStyleBackColor = true;
            this.butluu.Click += new System.EventHandler(this.butluu_Click);
            // 
            // butxoa
            // 
            this.butxoa.Location = new System.Drawing.Point(294, 58);
            this.butxoa.Name = "butxoa";
            this.butxoa.Size = new System.Drawing.Size(75, 23);
            this.butxoa.TabIndex = 8;
            this.butxoa.Text = "Xóa";
            this.butxoa.UseVisualStyleBackColor = true;
            this.butxoa.Click += new System.EventHandler(this.butxoa_Click);
            // 
            // butsua
            // 
            this.butsua.Location = new System.Drawing.Point(390, 12);
            this.butsua.Name = "butsua";
            this.butsua.Size = new System.Drawing.Size(75, 23);
            this.butsua.TabIndex = 9;
            this.butsua.Text = "Sửa";
            this.butsua.UseVisualStyleBackColor = true;
            this.butsua.Click += new System.EventHandler(this.butsua_Click);
            // 
            // dgvkesach
            // 
            this.dgvkesach.BackgroundColor = System.Drawing.Color.White;
            this.dgvkesach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvkesach.Location = new System.Drawing.Point(46, 163);
            this.dgvkesach.Name = "dgvkesach";
            this.dgvkesach.Size = new System.Drawing.Size(419, 88);
            this.dgvkesach.TabIndex = 10;
            this.dgvkesach.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvkesach_CellContentClick);
            // 
            // labvitri
            // 
            this.labvitri.AutoSize = true;
            this.labvitri.Location = new System.Drawing.Point(37, 19);
            this.labvitri.Name = "labvitri";
            this.labvitri.Size = new System.Drawing.Size(29, 13);
            this.labvitri.TabIndex = 11;
            this.labvitri.Text = "Vị trí";
            // 
            // labmatt
            // 
            this.labmatt.AutoSize = true;
            this.labmatt.Location = new System.Drawing.Point(37, 112);
            this.labmatt.Name = "labmatt";
            this.labmatt.Size = new System.Drawing.Size(58, 13);
            this.labmatt.TabIndex = 13;
            this.labmatt.Text = "Mã thủ thư";
            // 
            // labsongan
            // 
            this.labsongan.AutoSize = true;
            this.labsongan.Location = new System.Drawing.Point(37, 68);
            this.labsongan.Name = "labsongan";
            this.labsongan.Size = new System.Drawing.Size(47, 13);
            this.labsongan.TabIndex = 15;
            this.labsongan.Text = "Số ngăn";
            // 
            // kesach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 277);
            this.Controls.Add(this.labsongan);
            this.Controls.Add(this.labmatt);
            this.Controls.Add(this.labvitri);
            this.Controls.Add(this.dgvkesach);
            this.Controls.Add(this.butsua);
            this.Controls.Add(this.butxoa);
            this.Controls.Add(this.butluu);
            this.Controls.Add(this.butthoat);
            this.Controls.Add(this.butthem);
            this.Controls.Add(this.txtmatt);
            this.Controls.Add(this.txtsongan);
            this.Controls.Add(this.txtvitri);
            this.Controls.Add(this.grptimkiem);
            this.Name = "kesach";
            this.Text = "Kệ sách";
            this.Load += new System.EventHandler(this.kesach_Load);
            this.grptimkiem.ResumeLayout(false);
            this.grptimkiem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvkesach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grptimkiem;
        private System.Windows.Forms.Button buttimkiem;
        private System.Windows.Forms.TextBox txtvitri;
        private System.Windows.Forms.TextBox txtsongan;
        private System.Windows.Forms.TextBox txtmatt;
        private System.Windows.Forms.Button butthem;
        private System.Windows.Forms.Button butthoat;
        private System.Windows.Forms.Button butluu;
        private System.Windows.Forms.Button butxoa;
        private System.Windows.Forms.Button butsua;
        private System.Windows.Forms.DataGridView dgvkesach;
        private System.Windows.Forms.Label labvitri;
        private System.Windows.Forms.Label labmatt;
        private System.Windows.Forms.Label labsongan;
        private System.Windows.Forms.TextBox txttimkiem;
        private System.Windows.Forms.Label labtimkiem;
    }
}