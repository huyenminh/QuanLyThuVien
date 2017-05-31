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
        phieumuontra pmt = new phieumuontra();
        private void Phieumuontra_Load(object sender, EventArgs e)
        {
            dgvPhieumuontra.DataSource = Bus.Getlistphieumuontra();
            cmbmatt.DataSource = Bus.Getlistthuthu();
            cmbmatt.ValueMember = "matt";
            cmbmadg.DataSource = Bus.Getlistdocgia();
            cmbmadg.ValueMember = "madg";
           ComboBox1();
        }
        public void ComboBox1()
        {   

        }
        private void dgvPhieumuontra_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtmaphieu.Text = dgvPhieumuontra.CurrentRow.Cells["maphieu"].Value.ToString(); 
            cmbmatt.Text=dgvPhieumuontra.CurrentRow.Cells["matt"].Value.ToString();
            cmbmadg.Text = dgvPhieumuontra.CurrentRow.Cells["madg"].Value.ToString();
            txtsocuonmuonve.Text= dgvPhieumuontra.CurrentRow.Cells["socuonmuonve"].Value.ToString();
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
            Hienthi(" where maphieu like '%" + txttimkiempm.Text + "'");
        }

        private void txt_timkiempm_Click(object sender, EventArgs e)
        {
            txttimkiempm.Text = string.Empty;
        }

        private void butsang_Click(object sender, EventArgs e)
        {
            Chitietphieumuon c = new Chitietphieumuon(txtmaphieu.Text);
            
            c.Show();
            this.Hide();
        }

        private void btnmuon_Click(object sender, EventArgs e)
        {
            txtmaphieu.Text = string.Empty;
            cmbmatt.Text = string.Empty;
            cmbmadg.Text = string.Empty;
            txtsocuonmuonve.Text = string.Empty;
        }
     //   public void Hienthi1(string ma)
       // {
      //      dgvdocgia.DataSource = Bus.TimkiemDG(ma);
      //  }
       
       // private void btnXemDG_Click(object sender, EventArgs e)
      //  {
        //    if (txtMaDG.Text)
      //      Hienthi1(" where tendg like N'%" + txtMaDG.Text + "%'");
      //  }

        private void txtMaDG_Click(object sender, EventArgs e)
        {
            txtMaDG.Text = string.Empty;
        }

        private void btnXemDG_Click(object sender, EventArgs e)
        {
            Docgia dg = new Docgia(txtMaDG.Text);
            dg.Show();
        }

        private void butluu_Click(object sender, EventArgs e)
        {
            if (txtmaphieu.Text == "")
            {
                MessageBox.Show("thông tin chưa được nhập");
                return;
            }
            phieumuontra pmt = new phieumuontra();
            pmt.maphieu = txtmaphieu.Text;
            pmt.matt = cmbmatt.Text;
            pmt.madg = cmbmadg.Text;
            pmt.socuonmuonve = Convert.ToInt32(txtsocuonmuonve.Text);

            if (MessageBox.Show(string.Format("thêm thông tin phiếu mượn trả"), "", MessageBoxButtons.OKCancel) == DialogResult.OK)
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

        private void butsua_Click(object sender, EventArgs e)
        {
            if (txtmaphieu.Text == "")
            {
                MessageBox.Show("Thông tin chưa được nhập");
                return;
            }
            phieumuontra pmt = new phieumuontra();
            pmt.maphieu = txtmaphieu.Text;
            pmt.matt = cmbmatt.Text;
            pmt.madg = cmbmadg.Text;
            pmt.socuonmuonve = Convert.ToInt32(txtsocuonmuonve.Text);

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

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (txtmaphieu.Text == "")
            {
                MessageBox.Show("Thông tin chưa được chọn");
                return;
            }
            phieumuontra pmt = new phieumuontra();
            pmt.maphieu = txtmaphieu.Text;
            pmt.matt = cmbmatt.Text;
            pmt.madg = cmbmadg.Text;
            pmt.socuonmuonve = Convert.ToInt32(txtsocuonmuonve.Text);

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
    }
    }
    

