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
    public partial class FGiangVien : Form
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);

        public FGiangVien()
        {
            InitializeComponent();
        }

        GiangVienDao gvDao = new GiangVienDao();
        BDConnection bDConn = new BDConnection();

        private void FGiangVien_Load(object sender, EventArgs e)
        {
            gvDGV.DataSource = bDConn.GetAllData();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            GiangVien gv = new GiangVien(txtHoTen.Text, txtDiaChi.Text, txtCmnd.Text, dtpNgaySinh.Value);
            gvDao.Them(gv);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            GiangVien gv = new GiangVien(txtHoTen.Text, txtDiaChi.Text, txtCmnd.Text, dtpNgaySinh.Value);
            gvDao.Xoa(gv);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            GiangVien gv = new GiangVien(txtHoTen.Text, txtDiaChi.Text, txtCmnd.Text, dtpNgaySinh.Value);
            gvDao.Sua(gv);
        }
    }
}
