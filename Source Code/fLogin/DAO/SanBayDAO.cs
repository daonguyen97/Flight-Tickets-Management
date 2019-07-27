using fLogin.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fLogin.DAO
{
    public class SanBayDAO
    {
        private static SanBayDAO instance;

        public static SanBayDAO Instance
        {
            get
            {
                if (instance == null) instance = new SanBayDAO();
                return instance;
            }

            set
            {
                instance = value;
            }
        }
        public List<SanBay> GetListSanBay()
        {
            List<SanBay> listsanbay = new List<SanBay>();
            string query = "SELECT * FROM dbo.SanBay";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach(DataRow item in data.Rows)
            {
                SanBay sb = new SanBay(item);
                listsanbay.Add(sb);
            }
            return listsanbay;
        }
        public void InsertSanBay(string tensanbay)
        {
            string query = "INSERT INTO dbo.SanBay VALUES ('" + tensanbay + "')";
            DataProvider.Instance.ExecuteNonQuery(query);
        }
        public void DeleteSanBay(string tensanbay)
        {
            string query = "DELETE FROM dbo.SanBay WHERE TenSanBay='" + tensanbay + "'";
            DataProvider.Instance.ExecuteNonQuery(query);
        }
    }
}
