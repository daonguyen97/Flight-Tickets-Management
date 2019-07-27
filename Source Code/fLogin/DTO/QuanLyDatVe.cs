using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace fLogin.DTO
{
    public class QuanLyDatVe
    {
        public string MaDatVe { get; set; }
        public string MaChuyenBay { get; set; }
        public string CMND { get; set; }
        public string HangVe { get; set; }
        public int GiaVe { get; set; }
        public string NgayHuyVe { get; set; }
        public QuanLyDatVe() { }
        public QuanLyDatVe(string madatve,string machuyenbay,string cmnd,string hangve,int giave,string ngayhuyve)
        {
            MaDatVe = madatve;
            MaChuyenBay = machuyenbay;
            CMND = cmnd;
            HangVe = hangve;
            GiaVe = giave;
            NgayHuyVe = ngayhuyve;
        }
        public QuanLyDatVe(DataRow row)
        {
            MaDatVe = row["MaDatVe"].ToString();
            MaChuyenBay = row["MaChuyenBay"].ToString();
            CMND = row["CMND"].ToString();
            HangVe = row["HangVe"].ToString();
            GiaVe = (int)row["GiaVe"];
            NgayHuyVe = row["ThoiGianHuyVe"].ToString();
        }
    }
}
