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

namespace Tuan1
{
    public partial class FHocSinh : Form
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);

        public FHocSinh()
        {
            InitializeComponent();
        }

        HocSinhDao hsDao = new HocSinhDao();
        BDConnection bDConn = new BDConnection();

        private void FHocSinh_Load(object sender, EventArgs e)
        {
            gvDGV.DataSource = bDConn.GetAllData();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            HocSinh hs = new HocSinh(txtHoTen.Text, txtDiaChi.Text, txtCmnd.Text, dtpNgaySinh.Value);
            hsDao.Them(hs);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            HocSinh hs = new HocSinh(txtHoTen.Text, txtDiaChi.Text, txtCmnd.Text, dtpNgaySinh.Value);
            hsDao.Xoa(hs);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            HocSinh hs = new HocSinh(txtHoTen.Text, txtDiaChi.Text, txtCmnd.Text, dtpNgaySinh.Value);
            hsDao.Sua(hs);
        }
    }
}
