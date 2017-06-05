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
         
        public string ma;
        string sql = @"Server=ADMINS\SQLEXPRESS;Database=QLTV;Trusted_Connection=true";
        SqlConnection conn;

        public Chitietphieumuon()
        {
            InitializeComponent();
        }
        public Chitietphieumuon(string _ma) : this()
        {
            ma = _ma;
            cmbmaphieu.Text = ma;
        }
       
        private void Chitietphieumuon_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(sql);
            conn.Open();
            SqlCommand cmd = new SqlCommand("xemchitietmuontra", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter p = new SqlParameter("@ma", ma);
            cmd.Parameters.Add(p);
            SqlDataAdapter dg = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            dg.Fill(dt);
            dgvChitietmuon.DataSource = dt;
            cmbmacs.DataSource = Bus.GetListCuonSach();
            cmbmacs.ValueMember = "macs";
        }

        private void dgvChitietmuon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            cmbmacs.Text = dgvChitietmuon.CurrentRow.Cells["macs"].Value.ToString();
            cmbmaphieu.Text= dgvChitietmuon.CurrentRow.Cells["maphieu"].Value.ToString();
            txttruocchomuon.Text = dgvChitietmuon.CurrentRow.Cells["tinhtrangtruocchomuon"].Value.ToString();
            txtsauchomuon.Text = dgvChitietmuon.CurrentRow.Cells["tinhtrangsauchomuon"].Value.ToString();
            datengaymuon.Text = dgvChitietmuon.CurrentRow.Cells["ngaymuon"].Value.ToString();
            datengaytra.Text = dgvChitietmuon.CurrentRow.Cells["ngaytra"].Value.ToString();
            datengayhentra.Text = dgvChitietmuon.CurrentRow.Cells["ngayhentra"].Value.ToString();
            txtsongayqua.Text= dgvChitietmuon.CurrentRow.Cells["songayhethan"].Value.ToString();
            txtsocuon.Text= dgvChitietmuon.CurrentRow.Cells["socuon"].Value.ToString();
        }

        private void but_them_Click(object sender, EventArgs e)
        {
            cmbmacs.Text = string.Empty;
            cmbmaphieu.Text = string.Empty;
            txttruocchomuon.Text = string.Empty;
            txtsauchomuon.Text = string.Empty;
            txtsongayqua.Text = string.Empty;
            txtsocuon.Text = string.Empty;
            datengaymuon.Value = DateTime.Now;
            datengaytra.Value = DateTime.Now;
            datengayhentra.Value = DateTime.Now;
        }

        private void but_sua_Click(object sender, EventArgs e)
        {
            if ( cmbmacs.Text == "")
            {
                MessageBox.Show("chưa nhập thông tin");
                return;
            }
            chitietphieumuon ctpm = new chitietphieumuon();
            ctpm.macs = cmbmacs.Text;
            ctpm.maphieu = cmbmaphieu.Text;
            ctpm.tinhtrangtruocchomuon = txttruocchomuon.Text;
            ctpm.tinhtrangsauchomuon = txtsauchomuon.Text;
            ctpm.songayhethan = txtsongayqua.Text;
            ctpm.socuon = txtsocuon.Text;
            ctpm.ngaymuon = datengaymuon.Value;
            ctpm.ngaytra = datengayhentra.Value;
            ctpm.ngayhentra = datengayhentra.Value;
            
            if (MessageBox.Show(string.Format("sửa thông tin chi tiết phiếu"), "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (Bus.UpdateProfile(ctpm) > 0)
                {
                    MessageBox.Show("Đã sửa");
                    Chitietphieumuon_Load(sender, e);
                }

                else MessageBox.Show("Lỗi");
            }

        }

        private void but_xoa_Click(object sender, EventArgs e)
        {
            if ( cmbmacs.Text == "")
            {
                MessageBox.Show("chưa có thông tin");
                return;
            }
            chitietphieumuon ctpm = new chitietphieumuon();
            ctpm.macs = cmbmacs.Text;
            ctpm.maphieu = cmbmaphieu.Text;
            ctpm.tinhtrangtruocchomuon = txttruocchomuon.Text;
            ctpm.tinhtrangsauchomuon = txtsauchomuon.Text;
            ctpm.songayhethan = txtsongayqua.Text;
            ctpm.socuon = txtsocuon.Text;
            ctpm.ngaymuon = datengaymuon.Value;
            ctpm.ngaytra = datengayhentra.Value;
            ctpm.ngayhentra = datengayhentra.Value;

            if (MessageBox.Show(string.Format("xóa chi tiết phiếu"), "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (Bus.DeleteProfile(ctpm) > 0)
                {
                    MessageBox.Show("Đã xóa");
                    Chitietphieumuon_Load(sender, e);
                }

                else  MessageBox.Show("Lỗi");
            }

        }

        private void but_luu_Click(object sender, EventArgs e)
        {
            if (cmbmacs.Text == "" )
            {
                MessageBox.Show("chưa nhập thông tin");
                return;
            }
            chitietphieumuon ctpm = new chitietphieumuon();
            ctpm.macs = cmbmacs.Text;
            ctpm.maphieu = cmbmaphieu.Text;
            ctpm.tinhtrangtruocchomuon = txttruocchomuon.Text;
            ctpm.tinhtrangsauchomuon = txtsauchomuon.Text;
            ctpm.songayhethan = txtsongayqua.Text;
            ctpm.socuon = txtsocuon.Text;
            ctpm.ngaymuon = datengaymuon.Value;
            ctpm.ngaytra = datengayhentra.Value;
            ctpm.ngayhentra = datengayhentra.Value;

            if (MessageBox.Show(string.Format("Bạn có muốn thêm chhi tiết phiếu "),
                 "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (Bus.InsertProfile(ctpm) > 0)
                {
                    MessageBox.Show("Đã thêm");
                    Chitietphieumuon_Load(sender, e);
                }
                 
                  else  MessageBox.Show("Lỗi");
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

        

        private void txtsongayqua_Click(object sender, EventArgs e)
        { 
            DateTime ngayhentra = Convert.ToDateTime(datengayhentra.Value);
            DateTime ngaytra = Convert.ToDateTime(datengaytra.Value);
            TimeSpan Time = ngaytra - ngayhentra;
            int songayhethan= Time.Days; 

            if (songayhethan != 0)
            {
                xupahat xp = new xupahat(cmbmaphieu.Text);
                xp.ShowDialog();
            }

        }

        private void txtsocuon_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar; //nhan ki tu vua nhap
            if (char.IsDigit(c) == true) // neu ki tu vua nhap la 1 so
            {
                int i = Convert.ToInt32(c.ToString()); 
                if (i > 3)
                {
                    e.Handled = true; //xoa ki tu sai.
                    MessageBox.Show("loi nhap sai");
                }
            }
            else
            {
                e.Handled = true; //xoa ki tu sai.
                MessageBox.Show("loi nhap sai");
            }
        }

        private void cmbmacs_MouseDoubleClick(object sender, MouseEventArgs e)
        { 
        }

        private void bútach_Click(object sender, EventArgs e)
        {

            txttensach.Text = DataAccessLayer.DataProvider.GetValues("select tensach from dausach ds ,cuonsach cs   where ds.masach = cs.masach and macs ='" + cmbmacs.Text + "'");
            txttinhtrang.Text = DataAccessLayer.DataProvider.GetValues("select tinhtrang from cuonsach  where macs='" + cmbmacs.Text + "'");
            txtsoluongcon.Text = DataAccessLayer.DataProvider.GetValues("select coluongcon from cuonsach  where macs ='" + cmbmacs.Text + "'");
            txttacgia.Text = DataAccessLayer.DataProvider.GetValues("select tentg from cuonsach where macs ='" + cmbmacs.Text + "'");
            txtgiabia.Text = DataAccessLayer.DataProvider.GetValues("select giabia from dausach ds ,cuonsach cs where ds.masach = cs.masach and macs ='" + cmbmacs.Text + "'");

        }

        private void cmbmacs_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }

        
    }
    }
