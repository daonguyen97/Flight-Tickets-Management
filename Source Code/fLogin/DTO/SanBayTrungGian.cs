using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fLogin.DTO
{
    public class SanBayTrungGian
    {
        public string MaChuyenBay { get; set; }
        public string TenSanBay { get; set; }
        public string ThoiGianDung { get; set; }
        public string GhiChu { get; set; }
        public SanBayTrungGian() { }
        public SanBayTrungGian(string mcb,string tsb,string tgd,string ghichu)
        {
            MaChuyenBay = mcb;
            TenSanBay = tsb;
            ThoiGianDung = tgd;
            GhiChu = ghichu;
        }
        public SanBayTrungGian(DataRow row)
        {
            MaChuyenBay = row["MaChuyenBay"].ToString();
            TenSanBay = row["TenSanBay"].ToString();
            ThoiGianDung = row["ThoiGianDung"].ToString();
            GhiChu = row["ChuThich"].ToString();
        }
    }
}
