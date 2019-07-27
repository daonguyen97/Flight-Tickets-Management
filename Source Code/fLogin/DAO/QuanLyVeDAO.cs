using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using fLogin.DTO;
using System.Data;

namespace fLogin.DAO
{
    public class QuanLyVeDAO
    {
        private static QuanLyVeDAO instance;

        public static QuanLyVeDAO Instance
        {
            get
            {
                if (instance == null) instance = new QuanLyVeDAO();
                return instance;
            }

            set
            {
                instance = value;
            }
        }
        public List<QuanLyVe> GetListVe()
        {
            List<QuanLyVe> listve = new List<QuanLyVe>();
            string query = "select * from dbo.QuanLyVe";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                QuanLyVe ve = new QuanLyVe(item);
                listve.Add(ve);
            }
            return listve;
        }
        public List<QuanLyVe> GetListVeByMaChuyenBay(string machuyenbay)
        {
            List<QuanLyVe> listve = new List<QuanLyVe>();
            string query = "select * from dbo.QuanLyVe where MaChuyenBay='"+machuyenbay+"'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                QuanLyVe ve = new QuanLyVe(item);
                listve.Add(ve);
            }
            return listve;
        }
        public List<QuanLyVe> GetListVeByCMND(string cmnd)
        {
            List<QuanLyVe> listve = new List<QuanLyVe>();
            string query = "select * from dbo.QuanLyVe where CMND='"+cmnd+"'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                QuanLyVe ve = new QuanLyVe(item);
                listve.Add(ve);
            }
            return listve;
        }
        public List<QuanLyVe> GetListByNgayBanVe(string ngayban)
        {
            List<QuanLyVe> listve = new List<QuanLyVe>();
            string query = "select * from dbo.QuanLyVe where NgayBan='"+ngayban+"'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                QuanLyVe ve = new QuanLyVe(item);
                listve.Add(ve);
            }
            return listve;
        }
        public List<QuanLyVe> GetListVeByThang(string thang)
        {
            List<QuanLyVe> listve = new List<QuanLyVe>();
            
            string query = "select * from dbo.QuanLyVe where Thang='"+thang+"'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                QuanLyVe ve = new QuanLyVe(item);
                listve.Add(ve);
            }
            return listve;
        }
        string para(string x)
        {
            return "'" + x + "',";
        }
        public void InsertQuanLyVe(string madatve,string machuyenbay,string cmnd,string hangve,int giave,string ngayban)
        {
            string[] thang = ngayban.Split('/');
            if (madatve == string.Empty) madatve = QuanLyDatVeDAO.Instance.randomstring();
            string query = "insert into dbo.QuanLyVe values('" + madatve + "','" + machuyenbay + "','" + cmnd + "','" + hangve + "'," + giave.ToString() + ",'" + ngayban + "','" + thang[1] + thang[2] + "')";
            DataProvider.Instance.ExecuteNonQuery(query);
        }
    }
}
