namespace ql_thu_vien
{
    partial class xupahat
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
            this.txtmp = new System.Windows.Forms.TextBox();
            this.txtmacs = new System.Windows.Forms.TextBox();
            this.txtquahan = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txttien = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã  Phiếu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã Cuỗn Sách :";
            // 
            // txtmp
            // 
            this.txtmp.Location = new System.Drawing.Point(153, 92);
            this.txtmp.Name = "txtmp";
            this.txtmp.Size = new System.Drawing.Size(142, 20);
            this.txtmp.TabIndex = 2;
            // 
            // txtmacs
            // 
            this.txtmacs.Location = new System.Drawing.Point(162, 140);
            this.txtmacs.Name = "txtmacs";
            this.txtmacs.Size = new System.Drawing.Size(142, 20);
            this.txtmacs.TabIndex = 3;
            // 
            // txtquahan
            // 
            this.txtquahan.Location = new System.Drawing.Point(162, 188);
            this.txtquahan.Name = "txtquahan";
            this.txtquahan.Size = new System.Drawing.Size(142, 20);
            this.txtquahan.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ngày Quá Hạn :";
            // 
            // txttien
            // 
            this.txttien.Location = new System.Drawing.Point(162, 234);
            this.txttien.Name = "txttien";
            this.txttien.Size = new System.Drawing.Size(142, 20);
            this.txttien.TabIndex = 7;
            this.txttien.Click += new System.EventHandler(this.txttien_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(67, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tiền Phạt :";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(162, 276);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Nộp Phạt";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // xupahat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 322);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txttien);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtquahan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtmacs);
            this.Controls.Add(this.txtmp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "xupahat";
            this.Text = "xupahat";
            this.Load += new System.EventHandler(this.xupahat_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtmp;
        private System.Windows.Forms.TextBox txtmacs;
        private System.Windows.Forms.TextBox txtquahan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txttien;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
    }
}