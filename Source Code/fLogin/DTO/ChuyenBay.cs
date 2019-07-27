using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fLogin.DTO
{
    public class ChuyenBay
    {
        public string MaChuyenBay { get; set; }
        public string NgayBay { get; set; }
        public string GioBay { get; set; }
        public string ThoiGianBay { get; set; }
        public string SanBayDen { get; set; }
        public string SanBayDi { get; set; }
        public int SoLuongGheHang1 { get; set; }
        public int SoLuongGheHang1DaDat { get; set; }
        public int SoLuongGheHang2 { get; set; }
        public int SoLuongGheHang2DaDat { get; set; }
        public int GiaVe { get; set; }
        public ChuyenBay() { }
        public ChuyenBay(string ma,string day,string time,string fltime,string sbden,string sbdi,int ghe1,int ghe1dd,int ghe2,int ghe2dd,int giave)
        {

            MaChuyenBay = ma;
            NgayBay = day;
            GioBay = time;
            ThoiGianBay = fltime;
            SanBayDi = sbdi;
            SanBayDen = sbden;
            SoLuongGheHang1 = ghe1;
            SoLuongGheHang1DaDat = ghe1dd;
            SoLuongGheHang2 = ghe2;
            SoLuongGheHang2DaDat = ghe2dd;
            GiaVe = giave;


        }
        public ChuyenBay(DataRow row)
        {
            MaChuyenBay = row["MaChuyenBay"].ToString();
            NgayBay = row["NgayBay"].ToString();
            GioBay = row["GioBay"].ToString();
            ThoiGianBay = row["ThoiGianBay"].ToString();
            SanBayDen = row["SanBayDen"].ToString();
            SanBayDi = row["SanBayDi"].ToString();
            SoLuongGheHang1 =(int) row["SoLuongGheHang1"];
            SoLuongGheHang1DaDat = (int)row["SoLuongGheHang1DaDat"];
            SoLuongGheHang2 = (int)row["SoLuongGheHang2"];
            SoLuongGheHang2DaDat = (int)row["SoLuongGheHang2DaDat"];
            GiaVe = (int)row["GiaVe"];
        }
        
    }
}
