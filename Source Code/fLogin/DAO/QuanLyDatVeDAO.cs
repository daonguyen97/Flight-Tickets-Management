using fLogin.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fLogin.DAO
{
    public class QuanLyDatVeDAO
    {
        private static QuanLyDatVeDAO instance;

        public static QuanLyDatVeDAO Instance
        {
            get
            {
                if (instance == null) instance = new QuanLyDatVeDAO();
                return instance;
            }

            set
            {
                instance = value;
            }
        }
        public List<QuanLyDatVe> GetListDatVe()
        {
            List<QuanLyDatVe> listdatve = new List<QuanLyDatVe>();
            string query = "select * from dbo.QuanLyDatVe";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach(DataRow item in data.Rows)
            {
                QuanLyDatVe datve = new QuanLyDatVe(item);
                listdatve.Add(datve);
            }
            return listdatve;
        } 
        public void InsertListDatVe(string machuyenbay,string cmnd,string hangve,int giave)
        {
            string query = "insert into dbo.QuanLyDatVe values ('"+randomstring()+"','" + machuyenbay + "','" + cmnd + "','" + hangve + "'," + giave.ToString() + ",'0')";
            DataProvider.Instance.ExecuteNonQuery(query);
        }
        public void DeleteDatVe(string madatve)
        {
            string query = "delete from dbo.QuanLyDatVe where MaDatVe='" + madatve + "'";
            DataProvider.Instance.ExecuteNonQuery(query);
        }
        public void HUYVE(int ngayhuyve)
        {
            DataTable data = new DataTable();
            DateTime date = DateTime.Now - TimeSpan.FromDays(ngayhuyve);
            List<ChuyenBay> listcb = ChuyenBayDAO.Instance.LoadListChuyenBayByDate(ngayhuyve);
            string query = string.Empty;
            foreach(ChuyenBay cb in listcb)
            {
                query = "delete from dbo.QuanLyDatVe where MaChuyenBay='" + cb.MaChuyenBay.Trim() + "'";
                DataProvider.Instance.ExecuteNonQuery(query);
            }
        }
        public QuanLyDatVe GetDatVeByMaDatVe(string madatve)
        {
            QuanLyDatVe datve = new QuanLyDatVe();
            string query = "select * from dbo.QuanLyDatVe where MaDatVe='" + madatve + "'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            try
            {
                datve = new QuanLyDatVe(data.Rows[0]);
            }
            catch { }
            return datve;
        }
        
        public List<QuanLyDatVe> GetDatVeByCMND(string cmnd)
        {
            List<QuanLyDatVe> listdatve = new List<QuanLyDatVe>();
            string query = "select * from dbo.QuanLyDatVe where CMND='" + cmnd + "'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach(DataRow item in data.Rows)
            {
                QuanLyDatVe datve = new QuanLyDatVe(item);
                listdatve.Add(datve);
            }
            return listdatve;
        }
        public string randomstring()
        {
            var ABC = "QWERTYUIOPASDFGJKLZXCVBNM0123456789";
            string X = string.Empty;
            Random random = new Random();
            for(int i=0;i<6;i++)
            {
                X += ABC[random.Next(ABC.Length)];
            }
            return X;
        }
    }
}
