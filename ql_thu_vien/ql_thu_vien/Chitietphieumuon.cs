using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ql_thu_vien.ValueObject;
using ql_thu_vien.BusinessLogicLayer;
using ql_thu_vien.DataAccessLayer;
using System.Data.SqlClient;

namespace ql_thu_vien
{
    public partial class Chitietphieumuon : Form
    {
        public Chitietphieumuon()
        {
            InitializeComponent();
        }

        private void Chitietphieumuon_Load(object sender, EventArgs e)
        {
            dgvChitietmuon.DataSource = Bus.Getlistchitietphieumuon();
        }

        private void dgvChitietmuon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_macs.Text = dgvChitietmuon.CurrentRow.Cells["macs"].Value.ToString();
            txt_maphieu.Text = dgvChitietmuon.CurrentRow.Cells["maphieu"].Value.ToString();
            txt_tinhtrangtruoc.Text = dgvChitietmuon.CurrentRow.Cells["tinhtrangtruocchomuon"].Value.ToString();
            txt_tinhtrangsau.Text = dgvChitietmuon.CurrentRow.Cells["tinhtrangsauchomuon"].Value.ToString();
        }

        private void but_them_Click(object sender, EventArgs e)
        {
            txt_maphieu.Text = string.Empty;
            txt_macs.Text = string.Empty;
            txt_tinhtrangtruoc.Text = string.Empty;
            txt_tinhtrangsau.Text = string.Empty;
        }

        private void but_sua_Click(object sender, EventArgs e)
        {
            if (txt_macs.Text == "" || txt_maphieu.Text == "")
            {
                MessageBox.Show("chưa nhập thông tin");
                return;
            }
            chitietphieumuon ctpm = new chitietphieumuon();
            ctpm.macs = txt_macs.Text;
            ctpm.maphieu = txt_maphieu.Text;
            ctpm.tinhtrangtruocchomuon = txt_tinhtrangtruoc.Text;
            ctpm.tinhtrangsauchomuon = txt_tinhtrangsau.Text;
            if (MessageBox.Show(string.Format("sửa thông tin chi tiết phiếu"), "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (Bus.UpdateProfile(ctpm) > 0)
                {
                    MessageBox.Show("Đã sửa");
                    Chitietphieumuon_Load(sender, e);
                }
                else
                    MessageBox.Show("Lỗi");
            }

        }

        private void but_xoa_Click(object sender, EventArgs e)
        {
            if (txt_macs.Text == "" || txt_maphieu.Text == "")
            {
                MessageBox.Show("chưa có thông tin");
                return;
            }
            chitietphieumuon ctpm = new chitietphieumuon();
            ctpm.maphieu = txt_maphieu.Text;
            ctpm.macs = txt_macs.Text;
            ctpm.tinhtrangtruocchomuon = txt_tinhtrangtruoc.Text;
            ctpm.tinhtrangsauchomuon = txt_tinhtrangsau.Text;
            if (MessageBox.Show(string.Format("xóa chi tiết phiếu"), "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (Bus.DeleteProfile(ctpm) > 0)
                {
                    MessageBox.Show("Đã xóa");
                    Chitietphieumuon_Load(sender, e);
                }
                else
                    MessageBox.Show("Lỗi");
            }

        }

        private void but_luu_Click(object sender, EventArgs e)
        {
            if (txt_macs.Text == "" || txt_maphieu.Text == "")
            {
                MessageBox.Show("chưa nhập thông tin");
                return;
            }
            chitietphieumuon ctpm = new chitietphieumuon();
            ctpm.macs = txt_macs.Text;
            ctpm.maphieu = txt_maphieu.Text;
            ctpm.tinhtrangtruocchomuon = txt_tinhtrangtruoc.Text;
            ctpm.tinhtrangsauchomuon = txt_tinhtrangsau.Text;
            if (MessageBox.Show(string.Format("Thêm chi tiết phiếu"), "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (Bus.InsertProfile(ctpm) > 0)
                {
                    MessageBox.Show("Đã thêm");
                    Chitietphieumuon_Load(sender, e);
                }
                else
                    MessageBox.Show("Lỗi");
            }
        }

        private void but_thoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                Dispose();
            }
        }

        public  void Hienthi(string ma)
        {
            dgvChitietmuon.DataSource = Bus.Timkiemctpm(ma);
        }
        private void but_timkiem_Click(object sender, EventArgs e)
        {
            Hienthi(" where maphieu like '%" +  txt_timkiem.Text +  "'" );
        }

        private void txt_timkiem_Click(object sender, EventArgs e)
        {
            txt_timkiem.Text = string.Empty;
        }
    }
}
