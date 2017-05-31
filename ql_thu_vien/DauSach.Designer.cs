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
            this.txttaiban = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxmaxb = new System.Windows.Forms.ComboBox();
            this.cbxngonngu = new System.Windows.Forms.ComboBox();
            this.cbxnganhhoc = new System.Windows.Forms.ComboBox();
            this.txttinhtrang = new System.Windows.Forms.TextBox();
            this.label59 = new System.Windows.Forms.Label();
            this.txtgiabia = new System.Windows.Forms.TextBox();
            this.label64 = new System.Windows.Forms.Label();
            this.label67 = new System.Windows.Forms.Label();
            this.label69 = new System.Windows.Forms.Label();
            this.label71 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtsotrang = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txttendausach = new System.Windows.Forms.TextBox();
            this.txtmadausach = new System.Windows.Forms.TextBox();
            this.lblTendausach = new System.Windows.Forms.Label();
            this.lblMadausach = new System.Windows.Forms.Label();
            this.cbxManxb = new System.Windows.Forms.ComboBox();
            this.lblManxb = new System.Windows.Forms.Label();
            this.lblThongtindausach = new System.Windows.Forms.Label();
            this.dgvDausach = new System.Windows.Forms.DataGridView();
            this.gbxTimkiem = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtTimkiem = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxmatg = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.datenamxb = new System.Windows.Forms.DateTimePicker();
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
            this.toolStrip1.Size = new System.Drawing.Size(735, 25);
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
            this.gbxThongtin.Controls.Add(this.datenamxb);
            this.gbxThongtin.Controls.Add(this.cbxmatg);
            this.gbxThongtin.Controls.Add(this.label3);
            this.gbxThongtin.Controls.Add(this.txttaiban);
            this.gbxThongtin.Controls.Add(this.label2);
            this.gbxThongtin.Controls.Add(this.cbxmaxb);
            this.gbxThongtin.Controls.Add(this.cbxngonngu);
            this.gbxThongtin.Controls.Add(this.cbxnganhhoc);
            this.gbxThongtin.Controls.Add(this.txttinhtrang);
            this.gbxThongtin.Controls.Add(this.label59);
            this.gbxThongtin.Controls.Add(this.txtgiabia);
            this.gbxThongtin.Controls.Add(this.label64);
            this.gbxThongtin.Controls.Add(this.label67);
            this.gbxThongtin.Controls.Add(this.label69);
            this.gbxThongtin.Controls.Add(this.label71);
            this.gbxThongtin.Controls.Add(this.label11);
            this.gbxThongtin.Controls.Add(this.txtsotrang);
            this.gbxThongtin.Controls.Add(this.label8);
            this.gbxThongtin.Controls.Add(this.txttendausach);
            this.gbxThongtin.Controls.Add(this.txtmadausach);
            this.gbxThongtin.Controls.Add(this.lblTendausach);
            this.gbxThongtin.Controls.Add(this.lblMadausach);
            this.gbxThongtin.Location = new System.Drawing.Point(12, 28);
            this.gbxThongtin.Name = "gbxThongtin";
            this.gbxThongtin.Size = new System.Drawing.Size(710, 175);
            this.gbxThongtin.TabIndex = 1;
            this.gbxThongtin.TabStop = false;
            this.gbxThongtin.Text = "Thông tin đầu sách";
            // 
            // txttaiban
            // 
            this.txttaiban.Location = new System.Drawing.Point(119, 70);
            this.txttaiban.Name = "txttaiban";
            this.txttaiban.Size = new System.Drawing.Size(141, 20);
            this.txttaiban.TabIndex = 125;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 14);
            this.label2.TabIndex = 124;
            this.label2.Text = "số lượng tái bản:";
            // 
            // cbxmaxb
            // 
            this.cbxmaxb.FormattingEnabled = true;
            this.cbxmaxb.Location = new System.Drawing.Point(439, 104);
            this.cbxmaxb.Name = "cbxmaxb";
            this.cbxmaxb.Size = new System.Drawing.Size(176, 21);
            this.cbxmaxb.TabIndex = 123;
            // 
            // cbxngonngu
            // 
            this.cbxngonngu.FormattingEnabled = true;
            this.cbxngonngu.Location = new System.Drawing.Point(119, 122);
            this.cbxngonngu.Name = "cbxngonngu";
            this.cbxngonngu.Size = new System.Drawing.Size(141, 21);
            this.cbxngonngu.TabIndex = 122;
            // 
            // cbxnganhhoc
            // 
            this.cbxnganhhoc.FormattingEnabled = true;
            this.cbxnganhhoc.Location = new System.Drawing.Point(119, 95);
            this.cbxnganhhoc.Name = "cbxnganhhoc";
            this.cbxnganhhoc.Size = new System.Drawing.Size(141, 21);
            this.cbxnganhhoc.TabIndex = 121;
            // 
            // txttinhtrang
            // 
            this.txttinhtrang.Location = new System.Drawing.Point(439, 134);
            this.txttinhtrang.Name = "txttinhtrang";
            this.txttinhtrang.Size = new System.Drawing.Size(176, 20);
            this.txttinhtrang.TabIndex = 118;
            // 
            // label59
            // 
            this.label59.AutoSize = true;
            this.label59.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label59.Location = new System.Drawing.Point(346, 134);
            this.label59.Name = "label59";
            this.label59.Size = new System.Drawing.Size(66, 14);
            this.label59.TabIndex = 117;
            this.label59.Text = "Tình trạng:";
            // 
            // txtgiabia
            // 
            this.txtgiabia.Location = new System.Drawing.Point(439, 79);
            this.txtgiabia.Name = "txtgiabia";
            this.txtgiabia.Size = new System.Drawing.Size(176, 20);
            this.txtgiabia.TabIndex = 116;
            this.txtgiabia.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label64
            // 
            this.label64.AutoSize = true;
            this.label64.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label64.Location = new System.Drawing.Point(356, 87);
            this.label64.Name = "label64";
            this.label64.Size = new System.Drawing.Size(46, 14);
            this.label64.TabIndex = 115;
            this.label64.Text = "Giá bìa:";
            // 
            // label67
            // 
            this.label67.AutoSize = true;
            this.label67.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label67.Location = new System.Drawing.Point(328, 110);
            this.label67.Name = "label67";
            this.label67.Size = new System.Drawing.Size(79, 14);
            this.label67.TabIndex = 108;
            this.label67.Text = "Nhà xuất bản:";
            // 
            // label69
            // 
            this.label69.AutoSize = true;
            this.label69.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label69.Location = new System.Drawing.Point(26, 125);
            this.label69.Name = "label69";
            this.label69.Size = new System.Drawing.Size(63, 14);
            this.label69.TabIndex = 107;
            this.label69.Text = "Ngôn ngữ:";
            // 
            // label71
            // 
            this.label71.AutoSize = true;
            this.label71.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label71.Location = new System.Drawing.Point(26, 101);
            this.label71.Name = "label71";
            this.label71.Size = new System.Drawing.Size(67, 14);
            this.label71.TabIndex = 106;
            this.label71.Text = "Ngành học:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(356, 24);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 14);
            this.label11.TabIndex = 86;
            this.label11.Text = "Số trang:";
            // 
            // txtsotrang
            // 
            this.txtsotrang.Location = new System.Drawing.Point(439, 25);
            this.txtsotrang.Name = "txtsotrang";
            this.txtsotrang.Size = new System.Drawing.Size(176, 20);
            this.txtsotrang.TabIndex = 82;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(356, 56);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 14);
            this.label8.TabIndex = 85;
            this.label8.Text = "Năm XB:";
            // 
            // txttendausach
            // 
            this.txttendausach.Location = new System.Drawing.Point(119, 41);
            this.txttendausach.Name = "txttendausach";
            this.txttendausach.Size = new System.Drawing.Size(146, 20);
            this.txttendausach.TabIndex = 6;
            // 
            // txtmadausach
            // 
            this.txtmadausach.Location = new System.Drawing.Point(119, 15);
            this.txtmadausach.Name = "txtmadausach";
            this.txtmadausach.Size = new System.Drawing.Size(146, 20);
            this.txtmadausach.TabIndex = 5;
            // 
            // lblTendausach
            // 
            this.lblTendausach.AutoSize = true;
            this.lblTendausach.Location = new System.Drawing.Point(19, 47);
            this.lblTendausach.Name = "lblTendausach";
            this.lblTendausach.Size = new System.Drawing.Size(74, 13);
            this.lblTendausach.TabIndex = 1;
            this.lblTendausach.Text = "Tên đầu sách";
            // 
            // lblMadausach
            // 
            this.lblMadausach.AutoSize = true;
            this.lblMadausach.Location = new System.Drawing.Point(19, 22);
            this.lblMadausach.Name = "lblMadausach";
            this.lblMadausach.Size = new System.Drawing.Size(70, 13);
            this.lblMadausach.TabIndex = 0;
            this.lblMadausach.Text = "Mã đầu sách";
            // 
            // cbxManxb
            // 
            this.cbxManxb.FormattingEnabled = true;
            this.cbxManxb.Location = new System.Drawing.Point(507, 31);
            this.cbxManxb.Name = "cbxManxb";
            this.cbxManxb.Size = new System.Drawing.Size(146, 21);
            this.cbxManxb.TabIndex = 7;
            // 
            // lblManxb
            // 
            this.lblManxb.AutoSize = true;
            this.lblManxb.Location = new System.Drawing.Point(309, 31);
            this.lblManxb.Name = "lblManxb";
            this.lblManxb.Size = new System.Drawing.Size(87, 13);
            this.lblManxb.TabIndex = 2;
            this.lblManxb.Text = "Mã nhà xuất bản";
            // 
            // lblThongtindausach
            // 
            this.lblThongtindausach.AutoSize = true;
            this.lblThongtindausach.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThongtindausach.Location = new System.Drawing.Point(298, 285);
            this.lblThongtindausach.Name = "lblThongtindausach";
            this.lblThongtindausach.Size = new System.Drawing.Size(139, 19);
            this.lblThongtindausach.TabIndex = 2;
            this.lblThongtindausach.Text = "Thông tin đầu sách";
            // 
            // dgvDausach
            // 
            this.dgvDausach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDausach.Location = new System.Drawing.Point(0, 307);
            this.dgvDausach.Name = "dgvDausach";
            this.dgvDausach.Size = new System.Drawing.Size(736, 164);
            this.dgvDausach.TabIndex = 3;
            this.dgvDausach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDausach_CellClick);
            // 
            // gbxTimkiem
            // 
            this.gbxTimkiem.Controls.Add(this.btnSearch);
            this.gbxTimkiem.Controls.Add(this.cbxManxb);
            this.gbxTimkiem.Controls.Add(this.txtTimkiem);
            this.gbxTimkiem.Controls.Add(this.label1);
            this.gbxTimkiem.Controls.Add(this.lblManxb);
            this.gbxTimkiem.Location = new System.Drawing.Point(23, 209);
            this.gbxTimkiem.Name = "gbxTimkiem";
            this.gbxTimkiem.Size = new System.Drawing.Size(699, 73);
            this.gbxTimkiem.TabIndex = 4;
            this.gbxTimkiem.TabStop = false;
            this.gbxTimkiem.Text = "Tìm kiếm";
            // 
            // btnSearch
            // 
            this.btnSearch.Image = global::ql_thu_vien.Properties.Resources.Search_icon1;
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(417, 28);
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
            this.txtTimkiem.Location = new System.Drawing.Point(108, 28);
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
            // cbxmatg
            // 
            this.cbxmatg.FormattingEnabled = true;
            this.cbxmatg.Location = new System.Drawing.Point(119, 148);
            this.cbxmatg.Name = "cbxmatg";
            this.cbxmatg.Size = new System.Drawing.Size(141, 21);
            this.cbxmatg.TabIndex = 127;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 14);
            this.label3.TabIndex = 126;
            this.label3.Text = "Tác Giả :";
            // 
            // datenamxb
            // 
            this.datenamxb.Location = new System.Drawing.Point(439, 50);
            this.datenamxb.Name = "datenamxb";
            this.datenamxb.Size = new System.Drawing.Size(176, 20);
            this.datenamxb.TabIndex = 128;
            // 
            // frmDauSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 483);
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
        private System.Windows.Forms.ComboBox cbxManxb;
        private System.Windows.Forms.TextBox txttendausach;
        private System.Windows.Forms.TextBox txtmadausach;
        private System.Windows.Forms.Label lblManxb;
        private System.Windows.Forms.Label lblTendausach;
        private System.Windows.Forms.Label lblMadausach;
        private System.Windows.Forms.Label lblThongtindausach;
        private System.Windows.Forms.DataGridView dgvDausach;
        private System.Windows.Forms.GroupBox gbxTimkiem;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtTimkiem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtgiabia;
        private System.Windows.Forms.Label label64;
        private System.Windows.Forms.Label label67;
        private System.Windows.Forms.Label label69;
        private System.Windows.Forms.Label label71;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtsotrang;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txttinhtrang;
        private System.Windows.Forms.Label label59;
        private System.Windows.Forms.ComboBox cbxmaxb;
        private System.Windows.Forms.ComboBox cbxngonngu;
        private System.Windows.Forms.ComboBox cbxnganhhoc;
        private System.Windows.Forms.TextBox txttaiban;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxmatg;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker datenamxb;
    }
}