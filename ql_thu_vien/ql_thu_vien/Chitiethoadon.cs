using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using ql_thu_vien.BusinessLogicLayer;
using ql_thu_vien.ValueObject;
using ql_thu_vien.DataAccessLayer;

namespace ql_thu_vien
{
    public partial class Chitiethoadon : Form
    {
        public string ma;
        string sql = @"Server=DESKTOP-MJKVIGJ\SQLEXPRESS;Database=TTCSDL;Trusted_Connection=true ";
        SqlConnection conn;

        public Chitiethoadon()
        {
            InitializeComponent();
        }

        public Chitiethoadon(string _ma):this()
        { 
            ma=_ma;
            txtMahd.Text= ma;
        }

        private void Chitiethoadon_Load(object sender, EventArgs e)
        {
            conn= new SqlConnection(sql);
            conn.Open();
            SqlCommand cmd= new SqlCommand("xemchitiethoadon", conn);
            cmd.CommandType= CommandType.StoredProcedure;
            SqlParameter p= new SqlParameter("@ma", ma);
            cmd.Parameters.Add(p);
            SqlDataAdapter dg= new SqlDataAdapter(cmd);
            DataTable dt= new DataTable();
            dg.Fill(dt);
            dgvChitiethoadon.DataSource= dt;
        }

    }
}
