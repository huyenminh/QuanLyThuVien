namespace ql_thu_vien
{
    partial class HoaDon
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbHome = new System.Windows.Forms.ToolStripButton();
            this.tsbAdd = new System.Windows.Forms.ToolStripButton();
            this.tsbSave = new System.Windows.Forms.ToolStripButton();
            this.tsbEdit = new System.Windows.Forms.ToolStripButton();
            this.tsbDelete = new System.Windows.Forms.ToolStripButton();
            this.gbxHoadon = new System.Windows.Forms.GroupBox();
            this.btnXemchitiet = new System.Windows.Forms.Button();
            this.cbxMathuthu = new System.Windows.Forms.ComboBox();
            this.dateNgaynhap = new System.Windows.Forms.DateTimePicker();
            this.txtMahoadon = new System.Windows.Forms.TextBox();
            this.lblMathuthu = new System.Windows.Forms.Label();
            this.lblNgaynhap = new System.Windows.Forms.Label();
            this.lblMahoadon = new System.Windows.Forms.Label();
            this.dgvHoadon = new System.Windows.Forms.DataGridView();
            this.gbxTimkiem = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.gbxHoadon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoadon)).BeginInit();
            this.gbxTimkiem.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbHome,
            this.tsbAdd,
            this.tsbSave,
            this.tsbEdit,
            this.tsbDelete});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(541, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbHome
            // 
            this.tsbHome.Image = global::ql_thu_vien.Properties.Resources.home_icon;
            this.tsbHome.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbHome.Name = "tsbHome";
            this.tsbHome.Size = new System.Drawing.Size(60, 22);
            this.tsbHome.Text = "Home";
            this.tsbHome.Click += new System.EventHandler(this.tsbHome_Click);
            // 
            // tsbAdd
            // 
            this.tsbAdd.Image = global::ql_thu_vien.Properties.Resources.Add_icon;
            this.tsbAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAdd.Name = "tsbAdd";
            this.tsbAdd.Size = new System.Drawing.Size(49, 22);
            this.tsbAdd.Text = "Add";
            this.tsbAdd.Click += new System.EventHandler(this.tsbAdd_Click);
            // 
            // tsbSave
            // 
            this.tsbSave.Image = global::ql_thu_vien.Properties.Resources.Save_icon;
            this.tsbSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSave.Name = "tsbSave";
            this.tsbSave.Size = new System.Drawing.Size(51, 22);
            this.tsbSave.Text = "Save";
            this.tsbSave.Click += new System.EventHandler(this.tsbSave_Click);
            // 
            // tsbEdit
            // 
            this.tsbEdit.Image = global::ql_thu_vien.Properties.Resources.edit_icon;
            this.tsbEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEdit.Name = "tsbEdit";
            this.tsbEdit.Size = new System.Drawing.Size(47, 22);
            this.tsbEdit.Text = "Edit";
            this.tsbEdit.Click += new System.EventHandler(this.tsbEdit_Click);
            // 
            // tsbDelete
            // 
            this.tsbDelete.Image = global::ql_thu_vien.Properties.Resources.Delete_icon;
            this.tsbDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDelete.Name = "tsbDelete";
            this.tsbDelete.Size = new System.Drawing.Size(60, 22);
            this.tsbDelete.Text = "Delete";
            this.tsbDelete.Click += new System.EventHandler(this.tsbDelete_Click);
            // 
            // gbxHoadon
            // 
            this.gbxHoadon.Controls.Add(this.btnXemchitiet);
            this.gbxHoadon.Controls.Add(this.cbxMathuthu);
            this.gbxHoadon.Controls.Add(this.dateNgaynhap);
            this.gbxHoadon.Controls.Add(this.txtMahoadon);
            this.gbxHoadon.Controls.Add(this.lblMathuthu);
            this.gbxHoadon.Controls.Add(this.lblNgaynhap);
            this.gbxHoadon.Controls.Add(this.lblMahoadon);
            this.gbxHoadon.Location = new System.Drawing.Point(12, 42);
            this.gbxHoadon.Name = "gbxHoadon";
            this.gbxHoadon.Size = new System.Drawing.Size(518, 124);
            this.gbxHoadon.TabIndex = 1;
            this.gbxHoadon.TabStop = false;
            this.gbxHoadon.Text = "Thông tin hóa đơn";
            // 
            // btnXemchitiet
            // 
            this.btnXemchitiet.Location = new System.Drawing.Point(363, 55);
            this.btnXemchitiet.Name = "btnXemchitiet";
            this.btnXemchitiet.Size = new System.Drawing.Size(75, 23);
            this.btnXemchitiet.TabIndex = 6;
            this.btnXemchitiet.Text = "Xem chi tiết";
            this.btnXemchitiet.UseVisualStyleBackColor = true;
            this.btnXemchitiet.Click += new System.EventHandler(this.btnXemchitiet_Click);
            // 
            // cbxMathuthu
            // 
            this.cbxMathuthu.FormattingEnabled = true;
            this.cbxMathuthu.Location = new System.Drawing.Point(120, 93);
            this.cbxMathuthu.Name = "cbxMathuthu";
            this.cbxMathuthu.Size = new System.Drawing.Size(200, 21);
            this.cbxMathuthu.TabIndex = 5;
            // 
            // dateNgaynhap
            // 
            this.dateNgaynhap.Location = new System.Drawing.Point(120, 59);
            this.dateNgaynhap.Name = "dateNgaynhap";
            this.dateNgaynhap.Size = new System.Drawing.Size(200, 20);
            this.dateNgaynhap.TabIndex = 4;
            // 
            // txtMahoadon
            // 
            this.txtMahoadon.Location = new System.Drawing.Point(120, 32);
            this.txtMahoadon.Name = "txtMahoadon";
            this.txtMahoadon.Size = new System.Drawing.Size(200, 20);
            this.txtMahoadon.TabIndex = 3;
            // 
            // lblMathuthu
            // 
            this.lblMathuthu.AutoSize = true;
            this.lblMathuthu.Location = new System.Drawing.Point(22, 93);
            this.lblMathuthu.Name = "lblMathuthu";
            this.lblMathuthu.Size = new System.Drawing.Size(58, 13);
            this.lblMathuthu.TabIndex = 2;
            this.lblMathuthu.Text = "Mã thủ thư";
            // 
            // lblNgaynhap
            // 
            this.lblNgaynhap.AutoSize = true;
            this.lblNgaynhap.Location = new System.Drawing.Point(22, 61);
            this.lblNgaynhap.Name = "lblNgaynhap";
            this.lblNgaynhap.Size = new System.Drawing.Size(59, 13);
            this.lblNgaynhap.TabIndex = 1;
            this.lblNgaynhap.Text = "Ngày nhập";
            // 
            // lblMahoadon
            // 
            this.lblMahoadon.AutoSize = true;
            this.lblMahoadon.Location = new System.Drawing.Point(22, 32);
            this.lblMahoadon.Name = "lblMahoadon";
            this.lblMahoadon.Size = new System.Drawing.Size(65, 13);
            this.lblMahoadon.TabIndex = 0;
            this.lblMahoadon.Text = "Mã hóa đơn";
            // 
            // dgvHoadon
            // 
            this.dgvHoadon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHoadon.Location = new System.Drawing.Point(12, 269);
            this.dgvHoadon.Name = "dgvHoadon";
            this.dgvHoadon.Size = new System.Drawing.Size(518, 150);
            this.dgvHoadon.TabIndex = 2;
            this.dgvHoadon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHoadon_CellClick);
            // 
            // gbxTimkiem
            // 
            this.gbxTimkiem.Controls.Add(this.btnSearch);
            this.gbxTimkiem.Controls.Add(this.txtSearch);
            this.gbxTimkiem.Controls.Add(this.lblSearch);
            this.gbxTimkiem.Location = new System.Drawing.Point(12, 181);
            this.gbxTimkiem.Name = "gbxTimkiem";
            this.gbxTimkiem.Size = new System.Drawing.Size(517, 68);
            this.gbxTimkiem.TabIndex = 3;
            this.gbxTimkiem.TabStop = false;
            this.gbxTimkiem.Text = "Tìm kiếm";
            // 
            // btnSearch
            // 
            this.btnSearch.Image = global::ql_thu_vien.Properties.Resources.Search_icon11;
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(385, 19);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(131, 23);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(189, 20);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.Text = "Nhập thông tin tìm kiếm";
            this.txtSearch.Click += new System.EventHandler(this.txtSearch_Click);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(16, 30);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(109, 13);
            this.lblSearch.TabIndex = 0;
            this.lblSearch.Text = "Tìm kiếm mã hóa đơn";
            // 
            // HoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 431);
            this.Controls.Add(this.gbxTimkiem);
            this.Controls.Add(this.dgvHoadon);
            this.Controls.Add(this.gbxHoadon);
            this.Controls.Add(this.toolStrip1);
            this.Name = "HoaDon";
            this.Text = "HoaDon";
            this.Load += new System.EventHandler(this.HoaDon_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.gbxHoadon.ResumeLayout(false);
            this.gbxHoadon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoadon)).EndInit();
            this.gbxTimkiem.ResumeLayout(false);
            this.gbxTimkiem.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbHome;
        private System.Windows.Forms.ToolStripButton tsbAdd;
        private System.Windows.Forms.ToolStripButton tsbEdit;
        private System.Windows.Forms.ToolStripButton tsbSave;
        private System.Windows.Forms.ToolStripButton tsbDelete;
        private System.Windows.Forms.GroupBox gbxHoadon;
        private System.Windows.Forms.Button btnXemchitiet;
        private System.Windows.Forms.ComboBox cbxMathuthu;
        private System.Windows.Forms.DateTimePicker dateNgaynhap;
        private System.Windows.Forms.TextBox txtMahoadon;
        private System.Windows.Forms.Label lblMathuthu;
        private System.Windows.Forms.Label lblNgaynhap;
        private System.Windows.Forms.Label lblMahoadon;
        private System.Windows.Forms.DataGridView dgvHoadon;
        private System.Windows.Forms.GroupBox gbxTimkiem;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSearch;
    }
}