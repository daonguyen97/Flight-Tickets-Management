using fLogin.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fLogin.DAO
{
    public class SanBayTrungGianDAO
    {
        private static SanBayTrungGianDAO instance;

        public static SanBayTrungGianDAO Instance
        {
            get
            {
                if (instance == null) instance = new SanBayTrungGianDAO(); 
                return instance;
            }

            set
            {
                instance = value;
            }
        }
        public List<SanBayTrungGian> GetListSanBayTrungGianByMaChuyenBay(string mcb)
        {
            List<SanBayTrungGian> listSBTG = new List<SanBayTrungGian>();
            string query = "SELECT * FROM dbo.SanBayTrungGian WHERE MaChuyenBay='" + mcb + "'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach(DataRow item in data.Rows)
            {
                SanBayTrungGian sanbaytg = new SanBayTrungGian(item);
                listSBTG.Add(sanbaytg);
            }
            return listSBTG;
        }
        public string para (string x)
        {
            return "'"+x+"'";
        }
        public void InsertSanBayTrungGian(string mcb,string tsb,string tgd,string chuthich)
        {
            string query = "INSERT INTO dbo.SanBayTrungGian VALUES (" + para(mcb) + "," + para(tsb) + "," + para(tgd) + "," + para(chuthich) + ")";
            DataProvider.Instance.ExecuteNonQuery(query);
        }
        
    }
}
