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
    public partial class frmDauSach : Form
    {
        public frmDauSach()
        {
            InitializeComponent();
        }

        private void frmDauSach_Load(object sender, EventArgs e)
        {
            dgvDausach.DataSource = Bus.GetListDausach();
            //chinh sua giao dien
            dgvDausach.Columns["masach"].HeaderText = "Mã sách";
            dgvDausach.Columns["tensach"].HeaderText = "Tến sách";
            dgvDausach.Columns["mahd"].HeaderText = "Mã hóa đơn";
            dgvDausach.Columns["manxb"].HeaderText = "Mã NXB";
            dgvDausach.Columns["vitri"].HeaderText = "Vị trí";
            dgvDausach.Columns["tensach"].Width = 250;
            //heinthi ln 
            cbxManxb.DataSource = Bus.GetListNXB();
            cbxManxb.ValueMember = "manxb";
            cbxmahoadon.DataSource = Bus.GetListHoadon();
            cbxmahoadon.ValueMember = "mahd";
            cbxVitri.DataSource = Bus.GetListKesach();
            cbxVitri.ValueMember = "vitri";
        }

        private void tsbAdd_Click(object sender, EventArgs e)
        {
            txtMadausach.Text = string.Empty;
            txtTendausach.Text = string.Empty;
        }

        private void tsbSave_Click(object sender, EventArgs e)
        {
            if (txtTendausach.Text == "" || txtMadausach.Text == "")
            {
                MessageBox.Show("Chưa nhập đủ thông tin!");
                return;
            }
            DauSach ds = new DauSach();
            ds.maSach = txtMadausach.Text;
            ds.tenSach = txtTendausach.Text;
            ds.maHoadon = cbxmahoadon.Text;
            ds.maNXB = cbxManxb.Text;
            ds.vitri = cbxVitri.Text;
            if (MessageBox.Show(string.Format("Bạn có muốn thêm đầu sách {0} tên đầu sách {1}", ds.maSach, ds.tenSach),
                "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (Bus.InsertDausach(ds) > 0)
                {
                    MessageBox.Show("Thêm thành công!");
                    frmDauSach_Load(sender, e);
                }
                else
                    MessageBox.Show("Lỗi");          
            }


        }

        private void dgvDausach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMadausach.Text = dgvDausach.CurrentRow.Cells["masach"].Value.ToString();
            txtTendausach.Text = dgvDausach.CurrentRow.Cells["tensach"].Value.ToString();
            cbxmahoadon.Text = dgvDausach.CurrentRow.Cells["mahd"].Value.ToString();
            cbxManxb.Text = dgvDausach.CurrentRow.Cells["manxb"].Value.ToString();
            cbxVitri.Text = dgvDausach.CurrentRow.Cells["vitri"].Value.ToString();
        }

        private void tsbEdit_Click(object sender, EventArgs e)
        {
            if (txtTendausach.Text == "" || txtMadausach.Text == "")
            {
                MessageBox.Show("Chưa nhập đủ thông tin!");
                return;
            }
            DauSach ds = new DauSach();
            ds.maSach = txtMadausach.Text;
            ds.tenSach = txtTendausach.Text;
            ds.maHoadon = cbxmahoadon.Text;
            ds.maNXB = cbxManxb.Text;
            ds.vitri = cbxVitri.Text;
            if (MessageBox.Show(string.Format("Bạn có muốn chỉnh sửa đầu sách {0} tên đầu sách {1}", ds.maSach, ds.tenSach),
                "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (Bus.UpdateDausach(ds) > 0)
                {
                    MessageBox.Show("Chỉnh sửa thành công!");
                    frmDauSach_Load(sender, e);
                }
                else
                    MessageBox.Show("Lỗi");
            }
        }
        //loi
        private void tsbDelete_Click(object sender, EventArgs e)
        {
            if(txtMadausach.Text=="")
            {
                MessageBox.Show("Chưa nhập thông tin đầy đủ");
                return;  
            }
            DauSach ds = new DauSach();
            ds.maSach = txtMadausach.Text;
            ds.tenSach = txtTendausach.Text;
            ds.maHoadon = cbxmahoadon.Text;
            ds.maNXB = cbxManxb.Text;
            ds.vitri = cbxVitri.Text;
            if (MessageBox.Show(string.Format("Bạn có muốn xóa mã đầu sách {0} ", ds.maSach),
                "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (Bus.DeleteDausach(ds) > 0)
                {
                    MessageBox.Show("Xóa thành công!");
                    frmDauSach_Load(sender, e);
                }
                else MessageBox.Show("Xóa thất bại");
            
            }
        }

        private void tsbHome_Click(object sender, EventArgs e)
        {
            Dispose();
            //Trangchu trangchu = new Trangchu();
            //trangchu.Show();
        }

        public void Hienthi(string dausach)
        {
            dgvDausach.DataSource = Bus.SearchDauSach(dausach);
        }

        private void txtTimkiem_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtTimkiem_Click(object sender, EventArgs e)
        {
            txtTimkiem.Text = string.Empty;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Hienthi("where tensach like N'"+txtTimkiem.Text+"'");
        }


    }
}
