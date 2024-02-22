using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuan1
{
    internal class nguoiDAO
    {
        private String ten;
        private String diaChi;
        private String cmnd;
        private DateTime ngaySinh;

        public nguoiDAO() 
        {

        }

        public nguoiDAO(string ten, string diaChi, string cmnd, DateTime ngaySinh)
        {
            this.ten = ten;
            this.diaChi = diaChi;
            this.cmnd = cmnd;
            this.ngaySinh = ngaySinh;
        }

        public String Ten
        {
            get { return ten; }
            set { ten = value; }
        }

        public String Diachi
        {
            get { return diaChi; }
            set { diaChi = value; }
        }

        public String Cmnd
        {
            get { return cmnd; }
            set { cmnd = value; } 
        }

        public DateTime Ngaysinh
        {
            get { return ngaySinh; }
            set { ngaySinh = value; }
        }
    }
}
