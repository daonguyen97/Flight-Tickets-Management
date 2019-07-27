using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fLogin.DTO
{
    public class QuanLyVe
    {
        public string MaDatVe { get; set; }
        public string MaChuyenBay { get; set; }
        public string CMND { get; set; }
        public string HangVe { get; set; }
        public int GiaVe { get; set; }
        public string NgayBan { get; set; }
        public string Thang { get; set; }
        public QuanLyVe() { }
        public QuanLyVe(string madatve,string machuyenbay,string cmnd,string hangve,int giave,string ngayban,string thang)
        {
            MaDatVe = madatve;
            MaChuyenBay = machuyenbay;
            CMND = cmnd;
            HangVe = hangve;
            GiaVe = giave;
            NgayBan = ngayban;
            Thang = thang;
        }
        public QuanLyVe(DataRow row)
        {
            MaDatVe = row["MaDatVe"].ToString();
            MaChuyenBay = row["MaChuyenBay"].ToString();
            CMND = row["CMND"].ToString();
            HangVe = row["HangVe"].ToString();
            GiaVe = (int)row["GiaVe"];
            NgayBan = row["NgayBan"].ToString();
            Thang = row["Thang"].ToString();
        }
    }
}
