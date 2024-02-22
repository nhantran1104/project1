using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Common;

namespace Tuan1
{
    internal class HocSinhDao
    {
        BDConnection bDConn = new BDConnection();

        public void Them(HocSinh hs)
        {
            bDConn.ThucThi(string.Format("INSERT INTO HocSinh(Ten , Diachi, Cmnd, Ngaysinh) VALUES ('{0}', '{1}', '{2}', '{3}')", hs.Ten, hs.Diachi, hs.Cmnd, hs.Ngaysinh));
        }

        public void Xoa(HocSinh hs)
        {
            bDConn.ThucThi(string.Format("DELETE FROM HocSinh WHERE Cmnd = '{0}'", hs.Cmnd));
        }

        public void Sua(HocSinh hs)
        {
            bDConn.ThucThi(string.Format("UPDATE HocSinh SET Ten = '{0}', DiaChi = '{1}' WHERE Cmnd = '{2}'", hs.Ten, hs.Diachi, hs.Cmnd));
        }
    }
}
