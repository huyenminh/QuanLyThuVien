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
    public partial class thedocgia : Form
    {
        public thedocgia()
        {
            InitializeComponent();
        }

        private void thedocgia_Load(object sender, EventArgs e)
        {
            dgvthedocgia.DataSource = Bus.Getlistthedocgia();
        }
        private void dgvthedocgia_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtsothe.Text = dgvthedocgia.CurrentRow.Cells["sothe"].Value.ToString();
            datengaylam.Text = dgvthedocgia.CurrentRow.Cells["ngaylam"].Value.ToString();
            datengayhethan.Text = dgvthedocgia.CurrentRow.Cells["ngayhethan"].Value.ToString();
            txtmatt.Text = dgvthedocgia.CurrentRow.Cells["matt"].Value.ToString();
            txtmadg.Text = dgvthedocgia.CurrentRow.Cells["madg"].Value.ToString();
        }

        private void butthem_Click(object sender, EventArgs e)
        {
            txtsothe.Text = string.Empty;
            datengayhethan.Value = DateTime.Now;
            datengaylam.Value = DateTime.Now;
            txtmatt.Text = string.Empty;
            txtmadg.Text = string.Empty;
        }

        private void butsua_Click(object sender, EventArgs e)
        {
            if (txtsothe.Text == "" || txtmadg.Text == "")
            {
                MessageBox.Show("Chưa nhập đủ thông tin");
                return;
            }
          Thedocgia tdg = new Thedocgia();
            tdg.sothe = txtsothe.Text;
            tdg.ngaylam = datengaylam.Value;
            tdg.ngayhethan = datengaylam.Value;
            tdg.matt = txtmatt.Text;
            tdg.madg = txtmadg.Text;
            if (MessageBox.Show(string.Format("Sửa thẻ độc giả"), "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (Bus.UpdateProfile(tdg) > 0)
                {
                    MessageBox.Show("Đã sửa");
                    thedocgia_Load(sender, e);
                }
                else MessageBox.Show("Thông tin chưa được sửa");
            }
        }

        private void butxoa_Click(object sender, EventArgs e)
        {

            if (txtsothe.Text == "" || txtmadg.Text == "")
            {
                MessageBox.Show("Chưa chọn thông tin");
                return;
            }
            Thedocgia tdg = new Thedocgia();
            tdg.sothe = txtsothe.Text;
            tdg.ngaylam = datengaylam.Value;
            tdg.ngayhethan = datengaylam.Value;
            tdg.matt = txtmatt.Text;
            tdg.madg = txtmadg.Text;
            if (MessageBox.Show(string.Format("Xóa thẻ độc giả "), "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (Bus.DeleteProfile(tdg) > 0)
                {
                    MessageBox.Show("Đã xóa");
                    thedocgia_Load(sender, e);
                }
                else MessageBox.Show("Thông tin chưa được xóa");
            }
        }

        private void butluu_Click(object sender, EventArgs e)
        {
            if (txtsothe.Text == "" || txtmadg.Text == "")
            {
                MessageBox.Show("Chưa nhập đủ thông tin");
                return;
            }
            Thedocgia tdg = new Thedocgia();
            tdg.sothe = txtsothe.Text;
            tdg.ngaylam = datengaylam.Value;
            tdg.ngayhethan = datengaylam.Value;
            tdg.matt = txtmatt.Text;
            tdg.madg = txtmadg.Text;
            if (MessageBox.Show(string.Format("thêm thẻ độc giả"), "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (Bus.InsertProfile(tdg) > 0)
                {
                    MessageBox.Show("Đã thêm");
                    thedocgia_Load(sender, e);
                }
                else MessageBox.Show("Mã thủ thư đã tồn tại");
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
            dgvthedocgia.DataSource = Bus.Timkiem_tdg(ma);
        }

        private void buttimkiem_Click(object sender, EventArgs e)
        {
            Hienthi(" where sothe like '%" + txttimkiem.Text + "'");
        }

        private void txttimkiem_Click(object sender, EventArgs e)
        {
            txttimkiem.Text = string.Empty;
        }

        
    }
}
