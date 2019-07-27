using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fLogin.DTO
{
    public class DoanhThuThang
    {
        public string MaDoanhThuThang { get; set; }
        public string Nam { get; set; }
        public long DoanhThu { get; set; }
        public double TiLe { get; set; }
        public int SoChuyenBay { get; set; }
        public DoanhThuThang() { }
        public DoanhThuThang(string madoanhthu,long doanhthu,string nam,double tile,int sochuyenbay)
        {
            MaDoanhThuThang = madoanhthu;
            Nam = nam;
            DoanhThu = doanhthu;
            TiLe = tile;
            SoChuyenBay = sochuyenbay;
        }
        public DoanhThuThang(DataRow row)
        {
            MaDoanhThuThang = row["MaDoanhThuThang"].ToString();
            Nam = row["Nam"].ToString();
            DoanhThu = Convert.ToInt64(row["DoanhThu"]);
            TiLe = Convert.ToDouble(row["TiLe"]);
            SoChuyenBay = (int)row["SoChuyenBay"];
        }

    }
}
