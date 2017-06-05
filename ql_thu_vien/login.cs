using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ql_thu_vien
{
    public partial class login : Form
    {
        private SqlConnection conn;
        private DataTable dt = new DataTable("tên đăng nhập");
        private SqlDataAdapter da = new SqlDataAdapter();
        private void connect ()
        {
            string sql = @"Server=ADMINS\SQLEXPRESS;Database=QLTV;Trusted_Connection=true ";
            try
            {
                conn = new SqlConnection(sql);
                conn.Open();//mở kết nối
            }
            catch(SqlException)
            {
                MessageBox.Show("không thể kết nối đến csdl!", "error", MessageBoxButtons.OK);
            }
        }
        public void disconnect()
        {
            conn.Close();//đóng kết nối
            conn.Dispose();//giải  phóng tài nguyên
            conn = null;//hủy đối tượng
        }
        public login()
        {
            InitializeComponent();
        }

        private void login_Load(object sender, EventArgs e)
        {
            connect();
            txttaikhoan.Text = "";
            this.AcceptButton = butdn;
        }

        private void butdn_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = @"select * from nguoidung
                                        where (tendangnhap = @tendangnhap)
                                             And  (matkhau=@matkhau)";
            cmd.Parameters.Add("@tendangnhap", SqlDbType.NVarChar, 50).Value = txttaikhoan.Text;
            cmd.Parameters.Add("@matkhau", SqlDbType.NVarChar, 50).Value = txtmatkhau.Text;
            da.SelectCommand = cmd;
            da.Fill(dt);

            if(dt.Rows.Count>0)
            {
                Trangchu tc = new Trangchu();
                tc.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("bạn sai tài khoản hoặc quên mật khẩu", "đăng nhập", MessageBoxButtons.OK);
            }
        }

        private void butthoat_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("bạn có muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                Dispose();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                txtmatkhau.UseSystemPasswordChar = false;
            }
            else
            {
                txtmatkhau.UseSystemPasswordChar = true;
            }
        }
    }
}
