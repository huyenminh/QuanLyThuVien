using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ql_thu_vien
{
    public partial class xupahat : Form
    {
        public string ma;
        public xupahat()
        {
            InitializeComponent();
        }
        public xupahat(string _ma) : this()
        {
            ma = _ma;
            txtmp.Text = ma;
        }


        private void xupahat_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtmacs.Text = DataAccessLayer.DataProvider.GetValues("select macs from cuonsach where maphieu ='" + txtmp.Text + "'");
            txtquahan.Text = DataAccessLayer.DataProvider.GetValues("select songayhethan from chitietphieumuon pm , cuonsach cs where cs.macs=pm.macs and @songayhethan=songayhethan and   maphieu ='" + txtmp.Text + "'");
           
        }

        private void txttien_Click(object sender, EventArgs e)
        {
            int songayhethan = Convert.ToInt32(txtquahan.Text);
            txttien.Text = (float.Parse(txtquahan.Text) * 3000).ToString(); ;
        }
    }
}
