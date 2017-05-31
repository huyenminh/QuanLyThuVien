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
            dgvDausach.Columns["manxb"].HeaderText = "Mã NXB";
            dgvDausach.Columns["sotrang"].HeaderText = "số trang";
            dgvDausach.Columns["giabia"].HeaderText = "giá bìa";
            dgvDausach.Columns["nganhhoc"].HeaderText = "ngành học ";
            dgvDausach.Columns["ngonngu"].HeaderText = "ngôn ngữ";
            dgvDausach.Columns["namxuatban"].HeaderText = "Năm NXB";
            dgvDausach.Columns["tinhtrang"].HeaderText = "Tình Trạng";
            dgvDausach.Columns["matg"].HeaderText = "Tác Giả";
            dgvDausach.Columns["soluongtaiban"].HeaderText = "Số Lượng Tái Bản";

            dgvDausach.Columns["tensach"].Width = 250;
            //heinthi ln 
            cbxmaxb.DataSource = Bus.GetListNXB();
            cbxmaxb.ValueMember = "manxb";
            cbxmatg.DataSource = Bus.GetListtacgia();
            cbxmatg.ValueMember = "matg";
            cbxnganhhoc.DataSource = Bus.GetListnganhhoc();
            cbxnganhhoc.ValueMember = "tennganh";
            cbxngonngu.DataSource = Bus.GetListngonngu();
            cbxngonngu.ValueMember = "tenngonngu";

        }

        private void tsbAdd_Click(object sender, EventArgs e)
        {
            txtmadausach.Text = string.Empty;
            txttendausach.Text = string.Empty;
            datenamxb.Value =DateTime.Now;
            txtsotrang.Text = string.Empty;
            txttaiban.Text = string.Empty;
            txttinhtrang.Text = string.Empty;
            txtgiabia.Text = string.Empty;
            cbxmatg.Text = string.Empty;
            cbxmaxb.Text = string.Empty;
            cbxnganhhoc.Text = string.Empty;
            cbxngonngu.Text = string.Empty;
            
        }

        private void tsbSave_Click(object sender, EventArgs e)
        {
            if (txttendausach.Text == "" || txtmadausach.Text == "")
            {
                MessageBox.Show("Chưa nhập đủ thông tin!");
                return;
            }
            DauSach ds = new DauSach();
            ds.maSach = txtmadausach.Text;
            ds.tenSach = txttendausach.Text;
            ds.giabia = txtgiabia.Text;
            ds.manxb = cbxmaxb.Text;
            ds.nganhhoc = cbxnganhhoc.Text;
            ds.ngonngu = cbxngonngu.Text;
            ds.sotrang = txtsotrang.Text;
            ds.namxuatban = datenamxb.Value;
            ds.matg = cbxmatg.Text;
            ds.tinhtrang = txttinhtrang.Text;
            ds.soluongtaiban = txttaiban.Text;

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
            txtmadausach.Text = dgvDausach.CurrentRow.Cells["masach"].Value.ToString();
            txttendausach.Text = dgvDausach.CurrentRow.Cells["tensach"].Value.ToString();
            cbxmaxb.Text = dgvDausach.CurrentRow.Cells["manxb"].Value.ToString();
            datenamxb.Text = dgvDausach.CurrentRow.Cells["namxuatban"].Value.ToString();
            cbxmatg.Text = dgvDausach.CurrentRow.Cells["matg"].Value.ToString();
            cbxnganhhoc.Text = dgvDausach.CurrentRow.Cells["nganhhoc"].Value.ToString();
            cbxngonngu.Text = dgvDausach.CurrentRow.Cells["ngonngu"].Value.ToString();
            txtsotrang.Text = dgvDausach.CurrentRow.Cells["sotrang"].Value.ToString();
            txttaiban.Text = dgvDausach.CurrentRow.Cells["soluongtaiban"].Value.ToString();
            txtgiabia.Text = dgvDausach.CurrentRow.Cells["giabia"].Value.ToString();
            txttinhtrang.Text= dgvDausach.CurrentRow.Cells["tinhtrang"].Value.ToString();
        }

        private void tsbEdit_Click(object sender, EventArgs e)
        {
            if (txttendausach.Text == "" || txtmadausach.Text == "")
            {
                MessageBox.Show("Chưa nhập đủ thông tin!");
                return;
            }
            DauSach ds = new DauSach();
            ds.maSach = txtmadausach.Text;
            ds.tenSach = txttendausach.Text;
            ds.giabia = txtgiabia.Text;
            ds.manxb = cbxmaxb.Text;
            ds.nganhhoc = cbxnganhhoc.Text;
            ds.ngonngu = cbxngonngu.Text;
            ds.sotrang = txtsotrang.Text;
            ds.namxuatban = datenamxb.Value;
            ds.matg = cbxmatg.Text;
            ds.tinhtrang = txttinhtrang.Text;
            ds.soluongtaiban = txttaiban.Text;


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
            if(txtmadausach.Text=="")
            {
                MessageBox.Show("Chưa nhập thông tin đầy đủ");
                return;  
            }
            DauSach ds = new DauSach();
            ds.maSach = txtmadausach.Text;
            ds.tenSach = txttendausach.Text;
            ds.giabia = txtgiabia.Text;
            ds.manxb = cbxmaxb.Text;
            ds.nganhhoc = cbxnganhhoc.Text;
            ds.ngonngu = cbxngonngu.Text;
            ds.sotrang = txtsotrang.Text;
            ds.namxuatban = datenamxb.Value;
            ds.matg = cbxmatg.Text;
            ds.tinhtrang = txttinhtrang.Text;
            ds.soluongtaiban = txttaiban.Text;


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
            Hienthi("where tensach like N'%"+txtTimkiem.Text+"%'");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
