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
    public partial class Trangchu : Form
    {
        public Trangchu()
        {
            InitializeComponent();
        }

        private void đầuSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDauSach frmDausach = new frmDauSach();
            frmDausach.Show();
        }

        private void cuốnSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CuonSach cuonsach = new CuonSach();
            cuonsach.Show();
        }

        private void hóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HoaDon hoadon = new HoaDon();
            hoadon.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void độcGiảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Docgia docgia = new Docgia();
            docgia.Show();
        }

        private void phiếuMượnTrảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Phieumuontra pmt = new Phieumuontra();
            pmt.Show();
        }

        private void chiTiếtPhiếuMượnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Chitietphieumuon ctp = new Chitietphieumuon();
            ctp.Show();
        }

        private void thuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            thuthu thuthu = new thuthu();
            thuthu.Show();
        }

        private void thẻĐộcGiảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            thedocgia tdg = new thedocgia();
            tdg.Show();
        }

        private void kệSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kesach ks = new kesach();
            ks.Show();
        }

        private void tácGiảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tacgia tacgia = new tacgia();
            tacgia.Show();
        }

        private void nhàXuấtBảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            nxb nhaxb = new nxb();
            nhaxb.Show();
        }

        private void danhSáchSángTácToolStripMenuItem_Click(object sender, EventArgs e)
        {
            danhsachsangtac danhsach = new danhsachsangtac();
            danhsach.Show();
        }
    }
}
