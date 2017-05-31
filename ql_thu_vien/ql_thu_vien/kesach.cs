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
    public partial class kesach : Form
    {
        public kesach()
        {
            InitializeComponent();
        }

        private void kesach_Load(object sender, EventArgs e)
        {
            dgvkesach.DataSource = Bus.Getlistkesach();
        }

        private void dgvkesach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtvitri.Text = dgvkesach.CurrentRow.Cells["vitri"].Value.ToString();
            txtsongan.Text = dgvkesach.CurrentRow.Cells["songan"].Value.ToString();
            txtmatt.Text = dgvkesach.CurrentRow.Cells["matt"].Value.ToString();
        }

        private void butthem_Click(object sender, EventArgs e)
        {
            txtvitri.Text = string.Empty;
            txtmatt.Text = string.Empty;
            txtsongan.Text = string.Empty;
        }

        private void butsua_Click(object sender, EventArgs e)
        {
            if (txtvitri.Text == "" || txtsongan.Text == "")
            {
                MessageBox.Show("Chưa nhập đủ thông tin");
                return;
            }
            Kesach ks = new Kesach();
            ks.vitri = txtvitri.Text;
            ks.songan = txtsongan.Text;
            ks.matt = txtmatt.Text;
            if (MessageBox.Show(string.Format("Sửa kệ sách"), "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (Bus.UpdateProfile(ks) > 0)
                {
                    MessageBox.Show("Đã sửa");
                    kesach_Load(sender, e);
                }
                else MessageBox.Show("Thông tin chưa được sửa");
            }
        }

        private void butxoa_Click(object sender, EventArgs e)
        {
            if (txtvitri.Text == "" || txtsongan.Text == "")
            {
                MessageBox.Show("Chưa chọn thông tin");
                return;
            }
            Kesach ks = new Kesach();
            ks.vitri = txtvitri.Text;
            ks.songan = txtsongan.Text;
            ks.matt = txtmatt.Text;
            if (MessageBox.Show(string.Format("Xóa kệ sách "), "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (Bus.DeleteProfile(ks) > 0)
                {
                    MessageBox.Show("Đã xóa");
                    kesach_Load(sender, e);
                }
                else MessageBox.Show("Thông tin chưa được xóa");
            }
        }

        private void butluu_Click(object sender, EventArgs e)
        {
            if (txtvitri.Text == "" || txtsongan.Text == "")
            {
                MessageBox.Show("Chưa nhập đủ thông tin");
                return;
            }
            Kesach ks = new Kesach();
            ks.vitri = txtvitri.Text;
            ks.songan = txtsongan.Text;
            ks.matt = txtmatt.Text;
            if (MessageBox.Show(string.Format("thêm kệ sách"), "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (Bus.InsertProfile(ks) > 0)
                {
                    MessageBox.Show("Đã thêm");
                    kesach_Load(sender, e);
                }
                else MessageBox.Show("vị trí  đã tồn tại");
            }
        }

        private void butthoat_Click(object sender, EventArgs e)
        {
             if (MessageBox.Show("Bạn có muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                Dispose();
            }
        }
        public void Hienthi(string ma)
        {
            dgvkesach.DataSource = Bus.Timkiem_ks(ma);
        }

        private void buttimkiem_Click(object sender, EventArgs e)
        {
            Hienthi(" where vitri like '%" + txttimkiem.Text+ "'");
        }

        private void txttimkiem_Click(object sender, EventArgs e)
        {
            txttimkiem.Text = string.Empty;
        }
    }
}
