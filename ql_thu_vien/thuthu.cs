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
using ql_thu_vien.ValueObject;

namespace ql_thu_vien
{
    public partial class thuthu : Form
    {
        public thuthu()
        {
            InitializeComponent();
        }

        private void thuthu_Load(object sender, EventArgs e)
        {
            dgvthuthu.DataSource = Bus.Getlistthuthu();
        }
        private void dgvthuthu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtmatt.Text = dgvthuthu.CurrentRow.Cells["matt"].Value.ToString();
            txttentt.Text = dgvthuthu.CurrentRow.Cells["tentt"].Value.ToString();
            datengaysinh.Text = dgvthuthu.CurrentRow.Cells["ngaysinh"].Value.ToString();
            txtdiachi.Text = dgvthuthu.CurrentRow.Cells["diachi"].Value.ToString();
            txtmags.Text = dgvthuthu.CurrentRow.Cells["mags"].Value.ToString();
        }
        private void butthem_Click(object sender, EventArgs e)
        {
            txtmatt.Text = string.Empty;
            txttentt.Text = string.Empty;
            datengaysinh.Value = DateTime.Now;
            txtdiachi.Text = string.Empty;
            txtmags.Text = string.Empty;
        }

        private void butsua_Click(object sender, EventArgs e)
        {
            if (txtmatt.Text == "" || txttentt.Text == "")
            {
                MessageBox.Show("Chưa nhập đủ thông tin");
                return;
            }
            Thuthu tt = new Thuthu();
            tt.matt = txtmatt.Text;
            tt.tentt = txttentt.Text;
            tt.ngaysinh = datengaysinh.Value;
            tt.diachi = txtdiachi.Text;
            tt.mags = txtmags.Text;
            if (MessageBox.Show(string.Format("Sửa  thủ thư"), "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (Bus.UpdateProfile(tt) > 0)
                {
                    MessageBox.Show("Đã sửa");
                    thuthu_Load(sender, e);
                }
                else MessageBox.Show("Thông tin chưa được sửa");
            }
        }

        private void butxoa_Click(object sender, EventArgs e)
        {
            if (txtmatt.Text == "" || txttentt.Text == "")
            {
                MessageBox.Show("Chưa chọn thông tin");
                return;
            }
            Thuthu tt = new Thuthu();
            tt.matt = txtmatt.Text;
            tt.tentt = txttentt.Text;
            tt.ngaysinh = datengaysinh.Value;
            tt.diachi = txtdiachi.Text;
            tt.mags = txtmags.Text;
            if (MessageBox.Show(string.Format("Xóa thủ thư "), "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (Bus.DeleteProfile(tt) > 0)
                {
                    MessageBox.Show("Đã xóa");
                    thuthu_Load(sender, e);
                }
                else MessageBox.Show("Thông tin chưa được xóa");
            }
        }

        private void butluu_Click(object sender, EventArgs e)
        {
            if (txtmatt.Text == "" || txttentt.Text == "")
            {
                MessageBox.Show("Chưa nhập đủ thông tin");
                return;
            }
            Thuthu tt = new Thuthu();
            tt.matt = txtmatt.Text;
            tt.tentt = txttentt.Text;
            tt.ngaysinh = datengaysinh.Value;
            tt.diachi = txtdiachi.Text;
            tt.mags = txtmags.Text;

            if (MessageBox.Show(string.Format("thêm thủ thư"), "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (Bus.InsertProfile(tt) > 0)
                {
                    MessageBox.Show("Đã thêm");
                    thuthu_Load(sender, e);
                }
                else MessageBox.Show("Mã thủ thư đã tồn tại");
            }
        }

        private void butthoat_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Bạn có muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                Dispose();
            }
        }

        public void Hienthi(string ten)
        {
            dgvthuthu.DataSource = Bus.Timkiem_tt(ten);
        }
        private void buttimkiem_Click(object sender, EventArgs e)
        {
            Hienthi(" where tentt like N'%" + txttimkiem.Text + "%'");
        }

        private void txttimkiem_Click(object sender, EventArgs e)
        {
            txttimkiem.Text = string.Empty;
        }
    }
}
