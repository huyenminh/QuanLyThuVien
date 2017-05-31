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
using ql_thu_vien.DataAccessLayer;

namespace ql_thu_vien
{
    public partial class nxb : Form
    {
        public nxb()
        {
            InitializeComponent();
        }

        private void nhaxuatban_Load(object sender, EventArgs e)
        {
            dgv_nxb.DataSource = Bus.GetListnxb();
        }

        private void dgv_nxb_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtma.Text = dgv_nxb.CurrentRow.Cells["manxb"].Value.ToString();
            txtten.Text = dgv_nxb.CurrentRow.Cells["tennxb"].Value.ToString();
            txtdc.Text = dgv_nxb.CurrentRow.Cells["diachi"].Value.ToString();
        }

        private void butthem_Click(object sender, EventArgs e)
        {
            txtten.Text = string.Empty;
            txtma.Text = string.Empty;
            txtdc.Text = string.Empty;
        }

        private void butsua_Click(object sender, EventArgs e)
        {

            if (txtma.Text == "" || txtten.Text == "")
            {
                MessageBox.Show("Chưa nhập đủ thông tin");
                return;
            }
            Nxb n = new Nxb();
            n.manxb = txtma.Text;
            n.tennxb = txtten.Text;
            n.diachi = txtdc.Text;
            if (MessageBox.Show(string.Format("sửa nxb"), "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (Bus.UpdateProfile(n) > 0)
                {
                    MessageBox.Show("Đã sửa");
                    nhaxuatban_Load(sender, e);
                }
                else MessageBox.Show("Thông tin chưa được sửa");
            }
        }

        private void butxoa_Click(object sender, EventArgs e)
        {
            if (txtma.Text == "" || txtten.Text == "")
            {

                MessageBox.Show("Chưa chọn thông tin");
                return;
            }
            Nxb n = new Nxb();
            n.manxb = txtma.Text;
            n.tennxb = txtten.Text;
            n.diachi = txtdc.Text;
            if (MessageBox.Show(string.Format("Xóa nhà xuất bản"), "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (Bus.DeleteProfile(n) > 0)
                {
                    MessageBox.Show("Đã xóa");
                    nhaxuatban_Load(sender, e);
                }
                else
                    MessageBox.Show("sai rồi xóa sao duoc");
            }
        }

        private void butluu_Click(object sender, EventArgs e)
        {

            if (txtma.Text == "" || txtten.Text == "")
            {
                MessageBox.Show("Chưa nhập đủ thông tin");
                return;
            }
            Nxb n = new Nxb();
            n.manxb = txtma.Text;
            n.tennxb = txtten.Text;
            n.diachi = txtdc.Text;
            if (MessageBox.Show(string.Format("lưu nhà xuất bản đi "), "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (Bus.InsertProfile(n) > 0)
                {
                    MessageBox.Show("Đã lưu rồi nhé");
                    nhaxuatban_Load(sender, e);
                }
                else MessageBox.Show("lỗi rồi à");
            }

        }

        private void butthoat_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                Dispose();
            }
        }

        public void Hienthi(string ten)
        {
            dgv_nxb.DataSource = Bus.Timkiem_nxb(ten);
        }
        private void buttim_Click(object sender, EventArgs e)
        {
            Hienthi(" where tennxb like N'%" + txttimkiem.Text + "%'");
        }

        private void txttimkiem_Click(object sender, EventArgs e)
        {
            txttimkiem.Text = string.Empty;
        }
    }
}
