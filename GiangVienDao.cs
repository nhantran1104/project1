using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuan1
{
    internal class GiangVienDao
    {
        BDConnection bDConn = new BDConnection();

        public void Them(GiangVien gv)
        {
            bDConn.ThucThi(string.Format("INSERT INTO HocSinh(Ten , Diachi, Cmnd, Ngaysinh) VALUES ('{0}', '{1}', '{2}', '{3}')", gv.Ten, gv.Diachi, gv.Cmnd, gv.Ngaysinh));
        }

        public void Xoa(GiangVien gv)
        {
            bDConn.ThucThi(string.Format("DELETE FROM HocSinh WHERE Cmnd = '{0}'", gv.Cmnd));
        }

        public void Sua(GiangVien gv)
        {
            bDConn.ThucThi(string.Format("UPDATE HocSinh SET Ten = '{0}', DiaChi = '{1}' WHERE Cmnd = '{2}'", gv.Ten, gv.Diachi, gv.Cmnd));
        }
    }
}
