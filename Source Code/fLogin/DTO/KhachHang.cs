using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fLogin.DTO
{
    public class KhachHang
    {
        public string CMND { get; set; }
        public string Ten { get; set; }
        public string SoDienThoai { get; set; }
        public KhachHang() { }
        public KhachHang(string cmnd,string ten,string sodienthoai)
        {
            CMND = cmnd;
            Ten = ten;
            SoDienThoai = sodienthoai;
        }
        public KhachHang(DataRow row)
        {
            CMND = row["CMND"].ToString();
            Ten = row["Ten"].ToString();
            SoDienThoai = row["SoDienThoai"].ToString();
        }
    }
}
