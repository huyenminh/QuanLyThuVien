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

namespace ql_thu_vien
{
    public partial class danhsachsangtac : Form
    {
        public danhsachsangtac()
        {
            InitializeComponent();
        }

        private void danhsachsangtac_Load(object sender, EventArgs e)
        {
            dgvdsst.DataSource = Bus.GetListdsst();
        }

        private void dgvdsst_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtmatg.Text = dgvdsst.CurrentRow.Cells["masach"].Value.ToString();
            txtmasach.Text = dgvdsst.CurrentRow.Cells["matg"].Value.ToString();
            txtsotrang.Text = dgvdsst.CurrentRow.Cells["sotrang"].Value.ToString();
        }

        private void butthem_Click(object sender, EventArgs e)
        {
            txtmatg.Text = string.Empty;
            txtmasach.Text = string.Empty;
            txtsotrang.Text = string.Empty;
        }

        private void butsua_Click(object sender, EventArgs e)
        {
            if (txtmatg.Text == "" || txtmasach.Text == "")
            {
                MessageBox.Show("Chưa nhập đủ thông tin");
                return;
            }
            Danhsachsangtac dt = new Danhsachsangtac();
            dt.masach = txtmasach.Text;
            dt.matg = txtmatg.Text;
            dt.sotrang = txtsotrang.Text;
            if (MessageBox.Show(string.Format("sửa danh sach sang tac "), "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (Bus.UpdateProfile(dt) > 0)
                {
                    MessageBox.Show("Đã sửa");
                    danhsachsangtac_Load(sender, e);
                }
                else MessageBox.Show("Thông tin chưa được sửa");
            }
        }

        private void butxoa_Click(object sender, EventArgs e)
        {
            if (txtmatg.Text == "" || txtmasach.Text == "")
            {
                MessageBox.Show("Chưa nhập đủ thông tin");
                return;
            }
            Danhsachsangtac dt = new Danhsachsangtac();
            dt.masach = txtmasach.Text;
            dt.matg = txtmatg.Text;
            dt.sotrang = txtsotrang.Text;
            if (MessageBox.Show(string.Format("xóa thông tin đi"), "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (Bus.DeleteProfile(dt) > 0)
                {
                    MessageBox.Show("Đã xóa");
                    danhsachsangtac_Load(sender, e);
                }
                else MessageBox.Show("Thông tin chưa được xóa");
            }
        }

        private void butluu_Click(object sender, EventArgs e)
        {
            if (txtmatg.Text == "" || txtmasach.Text == "")
            {
                MessageBox.Show("Chưa nhập đủ thông tin");
                return;
            }
            Danhsachsangtac dt = new Danhsachsangtac();
            dt.masach = txtmasach.Text;
            dt.matg = txtmatg.Text;
            dt.sotrang = txtsotrang.Text;
            if (MessageBox.Show(string.Format("lưu thông tin đi"), "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (Bus.InsertProfile(dt) > 0)
                {
                    MessageBox.Show("Đã lưu");
                    danhsachsangtac_Load(sender, e);
                }
                else MessageBox.Show("Thông tin chưa được lưu");
            }
        }

        private void butthoat_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                Application.Exit();
            }
        }

        public void Hienthi(string ma)
        {
            dgvdsst.DataSource = Bus.Timkiem_dsst(ma);
        }

        private void txttimkiem_Click(object sender, EventArgs e)
        {
            txttimkiem.Text = string.Empty;
        }

        private void buttimkiem_Click(object sender, EventArgs e)
        {
            Hienthi(" where matg like '%" + txttimkiem.Text + "'");
        }
    }
}
