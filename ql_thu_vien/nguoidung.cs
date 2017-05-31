using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ql_thu_vien.BusinessLogicLayer;
using ql_thu_vien.DataAccessLayer;
using ql_thu_vien.ValueObject;

namespace ql_thu_vien
{
    public partial class Nguoidung : Form
    {
        public Nguoidung()
        {
            InitializeComponent();
        }

        private void nguoidung_Load(object sender, EventArgs e)
        {
            dgvnguoidung.DataSource = Bus.Getlistnguoidung();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtstt.Text = dgvnguoidung.CurrentRow.Cells["STT"].Value.ToString();
            txttaikhoan.Text = dgvnguoidung.CurrentRow.Cells["tendangnhap"].Value.ToString();
            txtmatkhau.Text = dgvnguoidung.CurrentRow.Cells["matkhau"].Value.ToString();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
           
            txttaikhoan.Text = string.Empty;
            txtmatkhau.Text = string.Empty;
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            if (txttaikhoan.Text == "")
            {
                MessageBox.Show("thông tin chưa được nhập");
                return;
            }
            nguoidung nd = new nguoidung();
            nd.tendangnhap = txttaikhoan.Text;
            nd.matkhau = txtmatkhau.Text;
          

            if (MessageBox.Show(string.Format("thêm người dùng"), "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (Bus.InsertProfile(nd) > 0)
                {
                    MessageBox.Show("thông tin đã thêm");
                    nguoidung_Load(sender, e);
                }
                else
                    MessageBox.Show("Lỗi");
            }
        }

        private void brnsua_Click(object sender, EventArgs e)
        {
            if (txttaikhoan.Text == "")
            {
                MessageBox.Show("thông tin chưa được nhập");
                return;
            }
            nguoidung nd = new nguoidung();
            nd.STT = txtstt.Text;
            nd.tendangnhap = txttaikhoan.Text;
            nd.matkhau = txtmatkhau.Text;


            if (MessageBox.Show(string.Format("Sửa người dùng"), "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (Bus.UpdateProfile(nd) > 0)
                {
                    MessageBox.Show("thông tin đã sửa");
                    nguoidung_Load(sender, e);
                }
                else
                    MessageBox.Show("Lỗi");
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (txttaikhoan.Text == "")
            {
                MessageBox.Show("thông tin chưa được nhập");
                return;
            }
            nguoidung nd = new nguoidung();
            nd.STT = txtstt.Text;
            nd.tendangnhap = txttaikhoan.Text;
            nd.matkhau = txtmatkhau.Text;


            if (MessageBox.Show(string.Format("xóa người dùng"), "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (Bus.DeleteProfile(nd) > 0)
                {
                    MessageBox.Show("thông tin đã xóa");
                    nguoidung_Load(sender, e);
                }
                else
                    MessageBox.Show("Lỗi");
            }
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("bạn có muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                Dispose();
            }
        }
    }
}
