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
    public partial class HoaDon : Form
    {
        public HoaDon()
        {
            InitializeComponent();
        }

        private void tsbAdd_Click(object sender, EventArgs e)
        {
            txtMahoadon.Text = string.Empty;
            dateNgaynhap.Value = DateTime.Now;
            cbxMathuthu.Text = string.Empty;
        }

        private void tsbSave_Click(object sender, EventArgs e)
        {
            if (txtMahoadon.Text == "")
            {
                MessageBox.Show("Chưa nhập đủ thông tin!");
                return;
            }

            Hoadon hd = new Hoadon();
            hd.mahd = txtMahoadon.Text;
            hd.ngaynhap = dateNgaynhap.Value;
            hd.matt = cbxMathuthu.Text;

            if (MessageBox.Show(string.Format("Bạn có muốn thêm mã hóa đơn {0} ", hd.mahd),
                "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (Bus.InsertHoadon(hd) > 0)
                {
                    MessageBox.Show("Thêm thành công!");
                    HoaDon_Load(sender, e);
                }
                else MessageBox.Show("Lỗi");
            }
        }


        private void HoaDon_Load(object sender, EventArgs e)
        {
            dgvHoadon.DataSource = Bus.GetListHoadon();
            cbxMathuthu.DataSource = Bus.GetListThuthu();
            cbxMathuthu.ValueMember = "matt";
        }

        private void dgvHoadon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMahoadon.Text = dgvHoadon.CurrentRow.Cells["mahd"].Value.ToString();
            dateNgaynhap.Text = dgvHoadon.CurrentRow.Cells["ngaynhap"].Value.ToString();
            cbxMathuthu.Text = dgvHoadon.CurrentRow.Cells["matt"].Value.ToString();
        }

        private void tsbEdit_Click(object sender, EventArgs e)
        {
            if (txtMahoadon.Text == "")
            {
                MessageBox.Show("Chưa nhập đủ thông tin!");
                return;
            }

            Hoadon hd = new Hoadon();
            hd.mahd = txtMahoadon.Text;
            hd.ngaynhap = dateNgaynhap.Value;
            hd.matt = cbxMathuthu.Text;

            if (MessageBox.Show(string.Format("Bạn có muốn sửa mã hóa đơn {0} ", hd.mahd),
                "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (Bus.UpdateHoadon(hd) > 0)
                {
                    MessageBox.Show("Sửa thành công!");
                    HoaDon_Load(sender, e);
                }
                else MessageBox.Show("Lỗi");
            }
        }

        private void btnXemchitiet_Click(object sender, EventArgs e)
        {
            this.Hide();
            Chitiethoadon frmChitiethoadon = new Chitiethoadon(txtMahoadon.Text);
            frmChitiethoadon.Show();
        }

        private void tsbHome_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        public void Hienthi(string hoadon)
        {
            dgvHoadon.DataSource = Bus.SearchHoadon(hoadon);
        }

        private void txtSearch_Click(object sender, EventArgs e)
        {
            txtSearch.Text = string.Empty;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Hienthi(" Where mahd like '%" + txtSearch.Text + "'");
        }

        private void tsbDelete_Click(object sender, EventArgs e)
        {
            if(txtMahoadon.Text=="")
            {
                MessageBox.Show("Chưa nhập thông tin đầy đủ");
                return;  
            }

            Hoadon hd = new Hoadon();
            hd.mahd = txtMahoadon.Text;
            hd.ngaynhap = dateNgaynhap.Value;
            hd.matt = cbxMathuthu.Text;

            if (MessageBox.Show(string.Format("Bạn có muốn xóa mã hóa đơn {0} ", hd.mahd),
                "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (Bus.DeleteHoadon(hd) > 0)
                {
                    MessageBox.Show("Xóa thành công!");
                    HoaDon_Load(sender, e);
                }
                else MessageBox.Show("Lỗi");
            }
        }

        




    }
}
