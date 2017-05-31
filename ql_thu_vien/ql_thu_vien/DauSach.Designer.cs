namespace ql_thu_vien
{
    partial class frmDauSach
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
            this.gbxThongtin = new System.Windows.Forms.GroupBox();
            this.cbxVitri = new System.Windows.Forms.ComboBox();
            this.cbxmahoadon = new System.Windows.Forms.ComboBox();
            this.cbxManxb = new System.Windows.Forms.ComboBox();
            this.txtTendausach = new System.Windows.Forms.TextBox();
            this.txtMadausach = new System.Windows.Forms.TextBox();
            this.lblVitri = new System.Windows.Forms.Label();
            this.lblHoadon = new System.Windows.Forms.Label();
            this.lblManxb = new System.Windows.Forms.Label();
            this.lblTendausach = new System.Windows.Forms.Label();
            this.lblMadausach = new System.Windows.Forms.Label();
            this.lblThongtindausach = new System.Windows.Forms.Label();
            this.dgvDausach = new System.Windows.Forms.DataGridView();
            this.gbxTimkiem = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtTimkiem = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.gbxThongtin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDausach)).BeginInit();
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
            this.toolStrip1.Size = new System.Drawing.Size(731, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
          
            // 
            // tsbHome
            // 
            this.tsbHome.Image = global::ql_thu_vien.Properties.Resources.home_icon1;
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
            // gbxThongtin
            // 
            this.gbxThongtin.Controls.Add(this.cbxVitri);
            this.gbxThongtin.Controls.Add(this.cbxmahoadon);
            this.gbxThongtin.Controls.Add(this.cbxManxb);
            this.gbxThongtin.Controls.Add(this.txtTendausach);
            this.gbxThongtin.Controls.Add(this.txtMadausach);
            this.gbxThongtin.Controls.Add(this.lblVitri);
            this.gbxThongtin.Controls.Add(this.lblHoadon);
            this.gbxThongtin.Controls.Add(this.lblManxb);
            this.gbxThongtin.Controls.Add(this.lblTendausach);
            this.gbxThongtin.Controls.Add(this.lblMadausach);
            this.gbxThongtin.Location = new System.Drawing.Point(12, 42);
            this.gbxThongtin.Name = "gbxThongtin";
            this.gbxThongtin.Size = new System.Drawing.Size(695, 149);
            this.gbxThongtin.TabIndex = 1;
            this.gbxThongtin.TabStop = false;
            this.gbxThongtin.Text = "Thông tin đầu sách";
            // 
            // cbxVitri
            // 
            this.cbxVitri.FormattingEnabled = true;
            this.cbxVitri.Location = new System.Drawing.Point(412, 79);
            this.cbxVitri.Name = "cbxVitri";
            this.cbxVitri.Size = new System.Drawing.Size(146, 21);
            this.cbxVitri.TabIndex = 9;
            // 
            // cbxmahoadon
            // 
            this.cbxmahoadon.FormattingEnabled = true;
            this.cbxmahoadon.Location = new System.Drawing.Point(412, 32);
            this.cbxmahoadon.Name = "cbxmahoadon";
            this.cbxmahoadon.Size = new System.Drawing.Size(146, 21);
            this.cbxmahoadon.TabIndex = 8;
            // 
            // cbxManxb
            // 
            this.cbxManxb.FormattingEnabled = true;
            this.cbxManxb.Location = new System.Drawing.Point(119, 108);
            this.cbxManxb.Name = "cbxManxb";
            this.cbxManxb.Size = new System.Drawing.Size(146, 21);
            this.cbxManxb.TabIndex = 7;
            // 
            // txtTendausach
            // 
            this.txtTendausach.Location = new System.Drawing.Point(119, 62);
            this.txtTendausach.Name = "txtTendausach";
            this.txtTendausach.Size = new System.Drawing.Size(146, 20);
            this.txtTendausach.TabIndex = 6;
            // 
            // txtMadausach
            // 
            this.txtMadausach.Location = new System.Drawing.Point(119, 27);
            this.txtMadausach.Name = "txtMadausach";
            this.txtMadausach.Size = new System.Drawing.Size(146, 20);
            this.txtMadausach.TabIndex = 5;
            // 
            // lblVitri
            // 
            this.lblVitri.AutoSize = true;
            this.lblVitri.Location = new System.Drawing.Point(341, 82);
            this.lblVitri.Name = "lblVitri";
            this.lblVitri.Size = new System.Drawing.Size(29, 13);
            this.lblVitri.TabIndex = 4;
            this.lblVitri.Text = "Vị trí";
            // 
            // lblHoadon
            // 
            this.lblHoadon.AutoSize = true;
            this.lblHoadon.Location = new System.Drawing.Point(341, 35);
            this.lblHoadon.Name = "lblHoadon";
            this.lblHoadon.Size = new System.Drawing.Size(65, 13);
            this.lblHoadon.TabIndex = 3;
            this.lblHoadon.Text = "Mã hóa đơn";
            // 
            // lblManxb
            // 
            this.lblManxb.AutoSize = true;
            this.lblManxb.Location = new System.Drawing.Point(19, 111);
            this.lblManxb.Name = "lblManxb";
            this.lblManxb.Size = new System.Drawing.Size(87, 13);
            this.lblManxb.TabIndex = 2;
            this.lblManxb.Text = "Mã nhà xuất bản";
            // 
            // lblTendausach
            // 
            this.lblTendausach.AutoSize = true;
            this.lblTendausach.Location = new System.Drawing.Point(19, 69);
            this.lblTendausach.Name = "lblTendausach";
            this.lblTendausach.Size = new System.Drawing.Size(74, 13);
            this.lblTendausach.TabIndex = 1;
            this.lblTendausach.Text = "Tên đầu sách";
            // 
            // lblMadausach
            // 
            this.lblMadausach.AutoSize = true;
            this.lblMadausach.Location = new System.Drawing.Point(19, 35);
            this.lblMadausach.Name = "lblMadausach";
            this.lblMadausach.Size = new System.Drawing.Size(70, 13);
            this.lblMadausach.TabIndex = 0;
            this.lblMadausach.Text = "Mã đầu sách";
            // 
            // lblThongtindausach
            // 
            this.lblThongtindausach.AutoSize = true;
            this.lblThongtindausach.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThongtindausach.Location = new System.Drawing.Point(294, 290);
            this.lblThongtindausach.Name = "lblThongtindausach";
            this.lblThongtindausach.Size = new System.Drawing.Size(139, 19);
            this.lblThongtindausach.TabIndex = 2;
            this.lblThongtindausach.Text = "Thông tin đầu sách";
            // 
            // dgvDausach
            // 
            this.dgvDausach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDausach.Location = new System.Drawing.Point(0, 321);
            this.dgvDausach.Name = "dgvDausach";
            this.dgvDausach.Size = new System.Drawing.Size(707, 150);
            this.dgvDausach.TabIndex = 3;
            this.dgvDausach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDausach_CellClick);
            // 
            // gbxTimkiem
            // 
            this.gbxTimkiem.Controls.Add(this.btnSearch);
            this.gbxTimkiem.Controls.Add(this.txtTimkiem);
            this.gbxTimkiem.Controls.Add(this.label1);
            this.gbxTimkiem.Location = new System.Drawing.Point(23, 209);
            this.gbxTimkiem.Name = "gbxTimkiem";
            this.gbxTimkiem.Size = new System.Drawing.Size(684, 73);
            this.gbxTimkiem.TabIndex = 4;
            this.gbxTimkiem.TabStop = false;
            this.gbxTimkiem.Text = "Tìm kiếm";
            // 
            // btnSearch
            // 
            this.btnSearch.Image = global::ql_thu_vien.Properties.Resources.Search_icon1;
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(442, 26);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtTimkiem
            // 
            this.txtTimkiem.Location = new System.Drawing.Point(135, 26);
            this.txtTimkiem.Name = "txtTimkiem";
            this.txtTimkiem.Size = new System.Drawing.Size(186, 20);
            this.txtTimkiem.TabIndex = 1;
            this.txtTimkiem.Text = "Nhập thông tin cần tìm kiếm";
            this.txtTimkiem.Click += new System.EventHandler(this.txtTimkiem_Click);
            this.txtTimkiem.TextChanged += new System.EventHandler(this.txtTimkiem_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tìm kiếm tên sách";
            // 
            // frmDauSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 483);
            this.Controls.Add(this.gbxTimkiem);
            this.Controls.Add(this.dgvDausach);
            this.Controls.Add(this.lblThongtindausach);
            this.Controls.Add(this.gbxThongtin);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmDauSach";
            this.Text = "DauSach";
            this.Load += new System.EventHandler(this.frmDauSach_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.gbxThongtin.ResumeLayout(false);
            this.gbxThongtin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDausach)).EndInit();
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
        private System.Windows.Forms.GroupBox gbxThongtin;
        private System.Windows.Forms.ComboBox cbxVitri;
        private System.Windows.Forms.ComboBox cbxmahoadon;
        private System.Windows.Forms.ComboBox cbxManxb;
        private System.Windows.Forms.TextBox txtTendausach;
        private System.Windows.Forms.TextBox txtMadausach;
        private System.Windows.Forms.Label lblVitri;
        private System.Windows.Forms.Label lblHoadon;
        private System.Windows.Forms.Label lblManxb;
        private System.Windows.Forms.Label lblTendausach;
        private System.Windows.Forms.Label lblMadausach;
        private System.Windows.Forms.Label lblThongtindausach;
        private System.Windows.Forms.DataGridView dgvDausach;
        private System.Windows.Forms.GroupBox gbxTimkiem;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtTimkiem;
        private System.Windows.Forms.Label label1;
    }
}