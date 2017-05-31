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
    public partial class tacgia : Form
    {
        public tacgia()
        {
            InitializeComponent();
        }

        private void tacgia_Load(object sender, EventArgs e)
        {
            dgv_tacgia.DataSource = Bus.GetListtacgia();
        }

        private void dgv_tacgia_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtma.Text = dgv_tacgia.CurrentRow.Cells["matg"].Value.ToString();
            txtten.Text = dgv_tacgia.CurrentRow.Cells["tentg"].Value.ToString();
            txtdc.Text = dgv_tacgia.CurrentRow.Cells["diachi"].Value.ToString();
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
           Tacgia tg = new Tacgia();
            tg.matg = txtma.Text;
            tg.tentg = txtten.Text;
            tg.diachi = txtdc.Text;
            if (MessageBox.Show(string.Format("sửa tác giả"), "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (Bus.UpdateProfile(tg) > 0)
                {
                    MessageBox.Show("Đã sửa");
                    tacgia_Load(sender, e);
                }
                else MessageBox.Show(" lỗi ");
            }
        }

        private void butxoa_Click(object sender, EventArgs e)
        {
            if (txtma.Text == "" || txtten.Text == "")
            {

                MessageBox.Show("Chưa chọn thông tin");
                return;
            }
            Tacgia tg = new Tacgia();
            tg.matg = txtma.Text;
            tg.tentg = txtten.Text;
            tg.diachi = txtdc.Text;

            if (MessageBox.Show(string.Format("Xóa tác giả"), "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (Bus.DeleteProfile(tg) > 0)
                {
                    MessageBox.Show("Đã xóa");
                    tacgia_Load(sender, e);
                }
                else
                    MessageBox.Show("lỗi");
            }

        }

        private void butluu_Click(object sender, EventArgs e)
        {
            if (txtma.Text == "" || txtten.Text == "")
            {
                MessageBox.Show("Chưa nhập đủ thông tin");
                return;
            }
            Tacgia tg = new Tacgia();
            tg.matg = txtma.Text;
            tg.tentg = txtten.Text;
            tg.diachi = txtdc.Text;
            if (MessageBox.Show(string.Format("thêm tác giả"), "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (Bus.InsertProfile(tg)> 0)
                {
                    MessageBox.Show("Đã lưu");
                    tacgia_Load(sender, e);
                }
                else MessageBox.Show(" chưa lưu");
            }

        }

        private void butthoat_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                Application.Exit();
            }
        }
        public void Hienthi(string ten)
        {
            dgv_tacgia.DataSource = Bus.Timkiem_tg(ten);
        }

        private void butnhap_Click(object sender, EventArgs e)
        {
            Hienthi("where tentg like N'" +txttimkiem.Text + "'");
        }

        private void txttimkiem_Click(object sender, EventArgs e)
        {
            txttimkiem.Text = string.Empty;
        }


    }
}
