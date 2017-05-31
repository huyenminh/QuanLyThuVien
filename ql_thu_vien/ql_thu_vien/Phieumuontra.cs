using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ql_thu_vien.DataAccessLayer;
using ql_thu_vien.BusinessLogicLayer;
using ql_thu_vien.ValueObject;

namespace ql_thu_vien
{
    public partial class Phieumuontra : Form
    {
        public Phieumuontra()
        {
            InitializeComponent();
        }

        private void Phieumuontra_Load(object sender, EventArgs e)
        {
            dgvPhieumuontra.DataSource = Bus.Getlistphieumuontra();
        }


        private void dgvPhieumuontra_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_maphieu.Text = dgvPhieumuontra.CurrentRow.Cells["maphieu"].Value.ToString();
            datengaymuon.Text = dgvPhieumuontra.CurrentRow.Cells["ngaymuon"].Value.ToString();
            datengaytra.Text = dgvPhieumuontra.CurrentRow.Cells["ngaytra"].Value.ToString();
            datengayhentra.Text = dgvPhieumuontra.CurrentRow.Cells["ngayhentra"].Value.ToString();
            txt_matt.Text=dgvPhieumuontra.CurrentRow.Cells["matt"].Value.ToString();
            txt_madg.Text = dgvPhieumuontra.CurrentRow.Cells["madg"].Value.ToString();
        }

        private void but_them_Click(object sender, EventArgs e)
        {
            txt_maphieu.Text = string.Empty;
            datengaymuon.Value = DateTime.Now;
            datengaytra.Value = DateTime.Now;
            datengayhentra.Value = DateTime.Now;
            txt_matt.Text = string.Empty;
            txt_madg.Text = string.Empty;
        }

        private void but_sua_Click(object sender, EventArgs e)
        {
            if (txt_maphieu.Text == "")
            {
                MessageBox.Show("Thông tin chưa được nhập");
                return;
            }
            phieumuontra pmt = new phieumuontra();
            pmt.maphieu = txt_maphieu.Text;
            pmt.matt = txt_matt.Text;
            pmt.madg = txt_madg.Text;
            pmt.ngaymuon = datengaymuon.Value;
            pmt.ngaytra = datengaytra.Value;
            pmt.ngayhentra = datengayhentra.Value;
            if (MessageBox.Show(string.Format("Sửa thông tin phiếu mượn trả"), "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (Bus.UpdateProfile(pmt) > 0)
                {
                    MessageBox.Show("Đã Sửa");
                    Phieumuontra_Load(sender, e);
                }
                else
                    MessageBox.Show("Lỗi");
            }
        }

        private void but_xoa_Click(object sender, EventArgs e)
        {
            if (txt_maphieu.Text == "")
            {
                MessageBox.Show("Thông tin chưa được chọn");
                return;
            }
            phieumuontra pmt = new phieumuontra();
            pmt.maphieu = txt_maphieu.Text;
            pmt.ngaymuon = datengaymuon.Value;
            pmt.madg = txt_madg.Text;
            pmt.matt = txt_matt.Text;
            pmt.ngaytra = datengaytra.Value;
            pmt.ngayhentra = datengayhentra.Value;
            if (MessageBox.Show(string.Format("Xóa thông tin phiếu mượn trả"), "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (Bus.DeleteProfile(pmt) > 0)
                {
                    MessageBox.Show("Đã Xóa");
                    Phieumuontra_Load(sender, e);
                }
                else
                    MessageBox.Show("Lỗi");
            }

        }

        private void but_luu_Click(object sender, EventArgs e)
        {
            if (txt_maphieu.Text == "")
            {
                MessageBox.Show("thông tin chưa được nhập");
                return;
            }
            phieumuontra pmt = new phieumuontra();
            pmt.maphieu = txt_maphieu.Text;
            pmt.ngaymuon = datengaymuon.Value;
            pmt.ngaytra = datengaytra.Value;
            pmt.ngayhentra = datengaytra.Value;
            pmt.madg = txt_madg.Text;
            pmt.matt = txt_matt.Text;
            if(MessageBox.Show(string.Format("thêm thông tin phiếu mượn trả"),"",MessageBoxButtons.OKCancel)==DialogResult.OK)
            {
                if (Bus.InsertProfile(pmt) > 0)
                {
                    MessageBox.Show("thông tin đã thêm");
                    Phieumuontra_Load(sender, e);
                }
                else
                    MessageBox.Show("Lỗi");
            }
        }

        private void but_thoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("bạn có muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                Dispose();
            }
        }
        public void Hienthi(string ma)
        {
            dgvPhieumuontra.DataSource = Bus.Timkiempmt(ma);
        }

        private void but_timkiem_Click(object sender, EventArgs e)
        {
            Hienthi(" where maphieu like '%" + txt_timkiempm.Text + "'");
        }

        private void txt_timkiempm_Click(object sender, EventArgs e)
        {
            txt_timkiempm.Text = string.Empty;
        }

      

    }
}
