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
    public partial class Docgia : Form
    {
        private string madg;
        public Docgia()
        {
            InitializeComponent();
        }
        public Docgia(string Ma) : this()
        {
            madg = Ma;
            txtma.Text = madg;
        }
        private void Docgia_Load(object sender, EventArgs e)
        {
            dgvDocgia.DataSource = Bus.Getlistdocgia();
            cbxlop.DataSource = Bus.GetListlop();
            cbxlop.ValueMember = "tenlop";
            cbxnganh.DataSource = Bus.GetListnganhhoc();
            cbxnganh.ValueMember = "tennganh"; 
            cbxloaidg.DataSource = Bus.GetListloaidocgia();
            cbxloaidg.ValueMember = "loaidg";
        }

        private void dgvDocgia_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtmadg.Text = dgvDocgia.CurrentRow.Cells["madg"].Value.ToString();
            txttendg.Text = dgvDocgia.CurrentRow.Cells["tendg"].Value.ToString();
            datengaysinh.Text = dgvDocgia.CurrentRow.Cells["ngaysinh"].Value.ToString();
            txtdiachi.Text = dgvDocgia.CurrentRow.Cells["diachi"].Value.ToString();
            cbxloaidg.Text = dgvDocgia.CurrentRow.Cells["loaidg"].Value.ToString();
            cbxnganh.Text = dgvDocgia.CurrentRow.Cells["nganh"].Value.ToString();
            cbxlop.Text = dgvDocgia.CurrentRow.Cells["loaidg"].Value.ToString();
            txtkhoahoc.Text = dgvDocgia.CurrentRow.Cells["khoahoc"].Value.ToString();
            datengaycapnhat.Text = dgvDocgia.CurrentRow.Cells["ngaycapnhat"].Value.ToString();
        } 
         
        public void Hienthi(string ten)
        {
            dgvDocgia.DataSource = Bus.Timkiemdg(ten);
        }
        private void txttimkiem_Click(object sender, EventArgs e)
        {
            txttimkiem.Text = string.Empty;
        }

        private void buttimkiem_Click(object sender, EventArgs e)
        {
            Hienthi(" where tendg like N'%" + txttimkiem.Text + "%'");
        }

        private void grptimkiem_Enter(object sender, EventArgs e)
        {

        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            txtmadg.Text = string.Empty;
            txttendg.Text = string.Empty;
            txtdiachi.Text = string.Empty;
            datengaysinh.Value = DateTime.Now;
            cbxloaidg.Text = string.Empty;
            cbxlop.Text = string.Empty;
            cbxnganh.Text = string.Empty;
            txtkhoahoc.Text = string.Empty;
            datengaycapnhat.Value = DateTime.Now;
        }
        public void Hienthidocgia(string ma)
        {
            dgvDocgia.DataSource = Bus.Hienthidg(ma);
        }

        private void btnhienthi_Click(object sender, EventArgs e)
        {
            Hienthi(" where madg like N'%" + txtmadg.Text + "%'");
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("bạn có muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                Dispose();
            }
        }
         

        private void brnsua_Click(object sender, EventArgs e)
        {
            if (txtmadg.Text == "" || txttendg.Text == "")
            {
                MessageBox.Show("Chưa nhập đủ thông tin");
                return;
            }
            docgia dg = new docgia();
            dg.madg = txtmadg.Text;
            dg.tendg = txttendg.Text;
            dg.diachi = txtdiachi.Text;
            dg.loaidg = cbxloaidg.Text;
            dg.nganh = cbxnganh.Text;
            dg.Lop = cbxlop.Text;
            dg.khoahoc = txtkhoahoc.Text;
            dg.ngaysinh = datengaysinh.Value;
            dg.ngaycapnhat = datengaycapnhat.Value;

            if (MessageBox.Show(string.Format("Sửa độc giả "), "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (Bus.UpdateProfile(dg) > 0)
                {
                    MessageBox.Show("Đã sửa");
                    Docgia_Load(sender, e);
                }
                else MessageBox.Show("Thông tin chưa được sửa");
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {

            if (txtmadg.Text == "")
            {
                MessageBox.Show("Chưa chọn thông tin");
                return;
            }
            docgia dg = new docgia();
            dg.madg = txtmadg.Text;
            dg.tendg = txttendg.Text;
            dg.diachi = txtdiachi.Text;
            dg.loaidg = cbxloaidg.Text;
            dg.nganh = cbxnganh.Text;
            dg.Lop = cbxlop.Text;
            dg.khoahoc = txtkhoahoc.Text;
            dg.ngaysinh = datengaysinh.Value;
            dg.ngaycapnhat = datengaycapnhat.Value;

            if (MessageBox.Show(string.Format("Xóa độc giả"), "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (Bus.DeleteProfile(dg) > 0)
                {
                    MessageBox.Show("Đã xóa");
                    Docgia_Load(sender, e);
                }
                else MessageBox.Show("Thông tin chưa được xóa");
            }
        }

        private void btnluu_Click_1(object sender, EventArgs e)
        {
            if (txtmadg.Text == "" || txttendg.Text == "")
            {
                MessageBox.Show("Chưa nhập đủ thông tin");
                return;
            }
            docgia dg = new docgia();
            dg.madg = txtmadg.Text;
            dg.tendg = txttendg.Text;
            dg.diachi = txtdiachi.Text;
            dg.loaidg = cbxloaidg.Text;
            dg.nganh = cbxnganh.Text;
            dg.Lop = cbxlop.Text;
            dg.khoahoc = txtkhoahoc.Text;
            dg.ngaysinh = datengaysinh.Value;
            dg.ngaycapnhat = datengaycapnhat.Value;

            if (MessageBox.Show(string.Format("Thêm độc giả"), "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (Bus.InsertProfile(dg) > 0)
                {
                    MessageBox.Show("Đã thêm");
                    Docgia_Load(sender, e);
                }
                else MessageBox.Show("Lỗi");
            }
        }
    }
}
