namespace ql_thu_vien
{
    partial class CuonSach
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
            this.tsbEdit = new System.Windows.Forms.ToolStripButton();
            this.tsbSave = new System.Windows.Forms.ToolStripButton();
            this.tsbDelete = new System.Windows.Forms.ToolStripButton();
            this.gbxThongtincs = new System.Windows.Forms.GroupBox();
            this.cbxMasach = new System.Windows.Forms.ComboBox();
            this.cbxMaphieu = new System.Windows.Forms.ComboBox();
            this.txtTinhtrang = new System.Windows.Forms.TextBox();
            this.txtMacuonsach = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvThongtinCS = new System.Windows.Forms.DataGridView();
            this.gbxTimkiem = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblTimkiem = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.gbxThongtincs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongtinCS)).BeginInit();
            this.gbxTimkiem.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbHome,
            this.tsbAdd,
            this.tsbEdit,
            this.tsbSave,
            this.tsbDelete});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(555, 25);
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
            // tsbEdit
            // 
            this.tsbEdit.Image = global::ql_thu_vien.Properties.Resources.edit_icon;
            this.tsbEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEdit.Name = "tsbEdit";
            this.tsbEdit.Size = new System.Drawing.Size(47, 22);
            this.tsbEdit.Text = "Edit";
            this.tsbEdit.Click += new System.EventHandler(this.tsbEdit_Click);
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
            // tsbDelete
            // 
            this.tsbDelete.Image = global::ql_thu_vien.Properties.Resources.Delete_icon;
            this.tsbDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDelete.Name = "tsbDelete";
            this.tsbDelete.Size = new System.Drawing.Size(60, 22);
            this.tsbDelete.Text = "Delete";
            this.tsbDelete.Click += new System.EventHandler(this.tsbDelete_Click);
            // 
            // gbxThongtincs
            // 
            this.gbxThongtincs.Controls.Add(this.cbxMasach);
            this.gbxThongtincs.Controls.Add(this.cbxMaphieu);
            this.gbxThongtincs.Controls.Add(this.txtTinhtrang);
            this.gbxThongtincs.Controls.Add(this.txtMacuonsach);
            this.gbxThongtincs.Controls.Add(this.label4);
            this.gbxThongtincs.Controls.Add(this.label3);
            this.gbxThongtincs.Controls.Add(this.label2);
            this.gbxThongtincs.Controls.Add(this.label1);
            this.gbxThongtincs.Location = new System.Drawing.Point(13, 44);
            this.gbxThongtincs.Name = "gbxThongtincs";
            this.gbxThongtincs.Size = new System.Drawing.Size(500, 100);
            this.gbxThongtincs.TabIndex = 1;
            this.gbxThongtincs.TabStop = false;
            this.gbxThongtincs.Text = "Thông tin cuốn sách";
            // 
            // cbxMasach
            // 
            this.cbxMasach.FormattingEnabled = true;
            this.cbxMasach.Location = new System.Drawing.Point(326, 59);
            this.cbxMasach.Name = "cbxMasach";
            this.cbxMasach.Size = new System.Drawing.Size(121, 21);
            this.cbxMasach.TabIndex = 7;
            // 
            // cbxMaphieu
            // 
            this.cbxMaphieu.FormattingEnabled = true;
            this.cbxMaphieu.Location = new System.Drawing.Point(326, 19);
            this.cbxMaphieu.Name = "cbxMaphieu";
            this.cbxMaphieu.Size = new System.Drawing.Size(121, 21);
            this.cbxMaphieu.TabIndex = 6;
            // 
            // txtTinhtrang
            // 
            this.txtTinhtrang.Location = new System.Drawing.Point(100, 60);
            this.txtTinhtrang.Name = "txtTinhtrang";
            this.txtTinhtrang.Size = new System.Drawing.Size(100, 20);
            this.txtTinhtrang.TabIndex = 5;
            // 
            // txtMacuonsach
            // 
            this.txtMacuonsach.Location = new System.Drawing.Point(100, 19);
            this.txtMacuonsach.Name = "txtMacuonsach";
            this.txtMacuonsach.Size = new System.Drawing.Size(100, 20);
            this.txtMacuonsach.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(238, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mã sách";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(238, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã phiếu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tình trạng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã cuốn sách";
            // 
            // dgvThongtinCS
            // 
            this.dgvThongtinCS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThongtinCS.Location = new System.Drawing.Point(13, 282);
            this.dgvThongtinCS.Name = "dgvThongtinCS";
            this.dgvThongtinCS.Size = new System.Drawing.Size(489, 150);
            this.dgvThongtinCS.TabIndex = 2;
            this.dgvThongtinCS.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvThongtinCS_CellClick);
            // 
            // gbxTimkiem
            // 
            this.gbxTimkiem.Controls.Add(this.btnSearch);
            this.gbxTimkiem.Controls.Add(this.txtSearch);
            this.gbxTimkiem.Controls.Add(this.lblTimkiem);
            this.gbxTimkiem.Location = new System.Drawing.Point(13, 150);
            this.gbxTimkiem.Name = "gbxTimkiem";
            this.gbxTimkiem.Size = new System.Drawing.Size(500, 76);
            this.gbxTimkiem.TabIndex = 3;
            this.gbxTimkiem.TabStop = false;
            this.gbxTimkiem.Text = "Tìm kiếm";
            // 
            // btnSearch
            // 
            this.btnSearch.Image = global::ql_thu_vien.Properties.Resources.Search_icon11;
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(395, 31);
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
            this.txtSearch.Location = new System.Drawing.Point(160, 31);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(186, 20);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.Text = "Nhập thông tin tìm kiếm";
            this.txtSearch.Click += new System.EventHandler(this.txtSearch_Click);
            // 
            // lblTimkiem
            // 
            this.lblTimkiem.AutoSize = true;
            this.lblTimkiem.Location = new System.Drawing.Point(21, 31);
            this.lblTimkiem.Name = "lblTimkiem";
            this.lblTimkiem.Size = new System.Drawing.Size(119, 13);
            this.lblTimkiem.TabIndex = 0;
            this.lblTimkiem.Text = "Tìm kiếm mã cuốn sách";
            // 
            // CuonSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 454);
            this.Controls.Add(this.gbxTimkiem);
            this.Controls.Add(this.dgvThongtinCS);
            this.Controls.Add(this.gbxThongtincs);
            this.Controls.Add(this.toolStrip1);
            this.Name = "CuonSach";
            this.Text = "CuonSach";
            this.Load += new System.EventHandler(this.CuonSach_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.gbxThongtincs.ResumeLayout(false);
            this.gbxThongtincs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongtinCS)).EndInit();
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
        private System.Windows.Forms.GroupBox gbxThongtincs;
        private System.Windows.Forms.ComboBox cbxMasach;
        private System.Windows.Forms.ComboBox cbxMaphieu;
        private System.Windows.Forms.TextBox txtTinhtrang;
        private System.Windows.Forms.TextBox txtMacuonsach;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvThongtinCS;
        private System.Windows.Forms.GroupBox gbxTimkiem;
        private System.Windows.Forms.Label lblTimkiem;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
    }
}