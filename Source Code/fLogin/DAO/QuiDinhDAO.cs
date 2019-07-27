using fLogin.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fLogin.DAO
{
    public class QuiDinhDAO
    {
        private static QuiDinhDAO instance;

        public static QuiDinhDAO Instance
        {
            get
            {
                if (instance == null) instance = new QuiDinhDAO();
                return instance;
            }

            set
            {
                instance = value;
            }
        }
        public QuiDinh Loadquidinh()
        {
            string query = "select * from dbo.QuiDinh";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            QuiDinh qd = new QuiDinh(data.Rows[0]);
            return qd;
        }
        public void UpdateQuiDinh(string thoigianbaymin,int sosanbaytrunggianmax,string thoigiandungmin,string thoigiandungmax,int thoigiandatvechamnhat,int thoigianhuyve)
        {
            string query = "update dbo.QuiDinh set ThoiGianBayMin='" + thoigianbaymin + "',SoSanBayTrungGianMax=" + sosanbaytrunggianmax.ToString() + ",ThoiGianDungMin='" + thoigiandungmin + "',ThoiGianDungMax='" + thoigiandungmax + "',ThoiGianHuyVe=" + thoigianhuyve.ToString() + ",ThoiGianDatVeChamNhat=" + thoigiandatvechamnhat.ToString();
            DataProvider.Instance.ExecuteNonQuery(query);
        }
        public void SetDefault()
        {
            string query = "update dbo.QuiDinh set ThoiGianBayMin='00:30',SoSanBayTrungGianMax=2,ThoiGianDungMin='00:10',ThoiGianDungMax='00:20',ThoiGianHuyVe=0,ThoiGianDatVeChamNhat=1";
            DataProvider.Instance.ExecuteNonQuery(query);
        }
    }
}
