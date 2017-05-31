using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ql_thu_vien
{
    public partial class dangnhap : Form
    {

        public partial class Login : Form
        {
            private SqlConnection conn;
            private DataTable dt = new DataTable("Tên Đăng Nhập");
            private SqlDataAdapter da = new SqlDataAdapter();
            private void connect()
            {
                string sql = @"Server=DESKTOP-8J03LKB;Database=QLTV;Integrated Security=True";
                try
                {
                    conn = new SqlConnection(sql);
                    conn.Open();//mở kết nối

                }
                catch (SqlException)
                {
                    MessageBox.Show("không thể kết nối đến csdl!", "error", MessageBoxButtons.OK);
                }
            }
            private void disconnect()
            {
                conn.Close();//đóng kết nối
                conn.Dispose();//giải phóng tài nguyeen
                conn = null;//hủy đối tượng
            }



            private void butthoat_Click(object sender, EventArgs e)
            {
                if (MessageBox.Show("Bạn có muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    Dispose();

                }
            }


         


            private void butdangnhap_Click(object sender, EventArgs e)
            {

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = @"select * from admin 
                                        where (tendangnhap=@tendangnhap)
                                         And (matkhau=@matkhau)";
        //        cmd.Parameters.Add("@tendangnhap", SqlDbType.NVarChar, 50).Value = txtusername.Text;
        //        cmd.Parameters.Add("@matkhau", SqlDbType.NVarChar, 50).Value = txtpass.Text;
                da.SelectCommand = cmd;
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    Trangchu _trangchu = new Trangchu();
                    _trangchu.Show();
                    Hide();
                }
                else
                {
                    MessageBox.Show("Bạn sai tài khoản hoặc quên mật khẩu", "đăng nhập", MessageBoxButtons.OK);
                }
            }


            private void dangnhap_Load(object sender, EventArgs e)
            {
                connect();
          //      txtusername.Text = "";
          //      this.AcceptButton = butdangnhap;
            }
        }

        private void dangnhap_Load(object sender, EventArgs e)
        {

        }
    }
}
