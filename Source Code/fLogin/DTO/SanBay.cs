using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fLogin.DTO
{
    public class SanBay
    {
        public string TenSanBay { get; set; }
        public SanBay() { }
        public SanBay(string sanbay)
        {
            TenSanBay = sanbay;
        }
        public SanBay(DataRow row)
        {
            TenSanBay = row["TenSanBay"].ToString();
        }

    }
}
