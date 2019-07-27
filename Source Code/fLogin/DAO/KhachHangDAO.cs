using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using fLogin.DTO;
using System.Data;

namespace fLogin.DAO
{
    public class KhachHangDAO
    {
        private static KhachHangDAO instance;

        public static KhachHangDAO Instance
        {
            get
            {
                if (instance == null) instance = new KhachHangDAO();
                return instance;
            }

            set
            {
                instance = value;
            }
        }
        public KhachHang GetKhachHangByCMND(string cmnd)
        {
            KhachHang khachhang = new KhachHang();
            string query = "select * from dbo.KhachHang where CMND='" + cmnd + "'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            try
            {
                khachhang = new KhachHang(data.Rows[0]);
            }
            catch
            {
                khachhang = null;
            }
            return khachhang;
        }
        public void InsertKhachHang(string cmnd,string ten,string sodienthoai)
        {
            string query = "insert into dbo.KhachHang values ('" + cmnd + "','" + ten + "','" + sodienthoai + "')";
            DataProvider.Instance.ExecuteNonQuery(query);
        }
        public void UpdateKhachHang(string sodienthoai,string cmnd)
        {
            string query = "update dbo.KhachHang set SoDienThoai='" + sodienthoai + "' where CMND='" + cmnd + "'";
            DataProvider.Instance.ExecuteNonQuery(query);
        }
    }
}
