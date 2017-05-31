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
    public partial class CuonSach : Form
    {
        public CuonSach()
        {
            InitializeComponent();
        }

        private void CuonSach_Load(object sender, EventArgs e)
        {
            dgvThongtinCS.DataSource = Bus.GetListCuonSach();

            cbxMaphieu.DataSource = Bus.GetListPhieumuontra();
            cbxMaphieu.ValueMember = "maphieu";

            cbxMasach.DataSource = Bus.GetListDausach();
            cbxMasach.ValueMember = "masach";

            dgvThongtinCS.Columns["macs"].HeaderText = "Mã cuốn sách";
            dgvThongtinCS.Columns["tinhtrang"].HeaderText = "tình trạng";
            dgvThongtinCS.Columns["maphieu"].HeaderText = "Mã phiếu";
            dgvThongtinCS.Columns["masach"].HeaderText = "Mã sách";
        }

        private void tsbAdd_Click(object sender, EventArgs e)
        {
            txtMacuonsach.Text = string.Empty;
            txtTinhtrang.Text = string.Empty;
        }

        private void tsbSave_Click(object sender, EventArgs e)
        {
            if(txtMacuonsach.Text==""|| txtTinhtrang.Text=="")
            {
                MessageBox.Show("bạn chưa nhập thông tin!");
                return;
            }

            Cuonsach cs = new Cuonsach();
            cs.maCuonsach = txtMacuonsach.Text;
            cs.tinhTrang = txtTinhtrang.Text;
            cs.maPhieu = cbxMaphieu.Text;
            cs.maSach = cbxMasach.Text;
            if (MessageBox.Show(string.Format("Bạn có muốn thêm mã cuốn sách {0} không?", cs.maCuonsach),
                "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (Bus.InsertCuonsach(cs) > 0)
                {
                    MessageBox.Show("Thêm thành công!");
                    CuonSach_Load(sender, e);
                }
                else
                    MessageBox.Show("Lỗi!");
            }
        }

        private void dgvThongtinCS_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMacuonsach.Text= dgvThongtinCS.CurrentRow.Cells["macs"].Value.ToString();
            txtTinhtrang.Text = dgvThongtinCS.CurrentRow.Cells["tinhtrang"].Value.ToString();
            cbxMaphieu.Text = dgvThongtinCS.CurrentRow.Cells["maphieu"].Value.ToString();
            cbxMasach.Text = dgvThongtinCS.CurrentRow.Cells["masach"].Value.ToString();
        }

        private void tsbEdit_Click(object sender, EventArgs e)
        {
            if (txtMacuonsach.Text == "" || txtTinhtrang.Text == "")
            {
                MessageBox.Show("bạn chưa nhập thông tin!");
                return;
            }

            Cuonsach cs = new Cuonsach();
            cs.maCuonsach = txtMacuonsach.Text;
            cs.tinhTrang = txtTinhtrang.Text;
            cs.maPhieu = cbxMaphieu.Text;
            cs.maSach = cbxMasach.Text;
            if (MessageBox.Show(string.Format("Bạn có muốn sửa mã cuốn sách {0} không?", cs.maCuonsach),
                "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (Bus.UpdateCuonsach(cs) > 0)
                {
                    MessageBox.Show("Chỉnh sửa thành công!");
                    CuonSach_Load(sender, e);
                }
                else
                    MessageBox.Show("Lỗi!");
            }
        }

        private void tsbHome_Click(object sender, EventArgs e)
        {
            Dispose();
            //Trangchu trangchu = new Trangchu();
            //trangchu.Show();
        }

        public void Hienthi(string cuonsach)
        {
            dgvThongtinCS.DataSource = Bus.SearchCuonSach(cuonsach);
        }

        private void txtSearch_Click(object sender, EventArgs e)
        {
            txtSearch.Text = string.Empty;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Hienthi(" Where macs like '%"+txtSearch.Text+"'");
        }

        private void tsbDelete_Click(object sender, EventArgs e)
        {
            if (txtMacuonsach.Text == "" )
            {
                MessageBox.Show("bạn chưa nhập thông tin!");
                return;
            }

            Cuonsach cs = new Cuonsach();
            cs.maCuonsach = txtMacuonsach.Text;
            cs.tinhTrang = txtTinhtrang.Text;
            cs.maPhieu = cbxMaphieu.Text;
            cs.maSach = cbxMasach.Text;
            if (MessageBox.Show(string.Format("Bạn có muốn xóa mã cuốn sách {0} không?", cs.maCuonsach),
                "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (Bus.DeleteCuonsach(cs)>0)
                {
                    MessageBox.Show(" Xóa thành công!");
                    CuonSach_Load(sender, e);
                }
                else
                    MessageBox.Show("Lỗi!");
            }
        }





    }
}
