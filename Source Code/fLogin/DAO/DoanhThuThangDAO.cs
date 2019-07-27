using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using fLogin.DTO;
using System.Data;
using System.Windows.Forms;

namespace fLogin.DAO
{
    public class DoanhThuThangDAO
    {
        private static DoanhThuThangDAO instance;

        public static DoanhThuThangDAO Instance
        {
            get
            {
                if (instance == null) instance = new DoanhThuThangDAO();
                return instance;
            }

            set
            {
                instance = value;
            }
        }
        public long DoanhThuChuyenBay(string machuyenbay)
        {
            long x;
            string query = "select sum(GiaVe)as DoanhThu from dbo.QuanLyVe where MaChuyenBay='" + machuyenbay + "'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            DataRow row = data.Rows[0];
            try
            {
                x = Convert.ToInt64(row[0]);
            }
            catch
            {
                x = 0;
            }
            return x;
        }
        public void UpdateDoanhThuThang(string thang,string nam,long tongdoanhthu,double tile,int sochuyenbay)
        {

            string query = "update dbo.DoanhThuThang set DoanhThu=" + tongdoanhthu.ToString() + ",TiLe=" + tile.ToString("0.00") + ",SoChuyenBay=" + sochuyenbay.ToString() + " where MaDoanhThuThang='" + thang + nam + "'";
            try
            {
                DataProvider.Instance.ExecuteNonQuery(query);
            }
            catch(Exception ex)
            {
                //MessageBox.Show(ex.ToString());
            }
        }
        public List<DoanhThuThang> LoadListDoanhThuThang(string nam)
        {
            List<DoanhThuThang> listdoanhthu = new List<DoanhThuThang>();
            string query = "select * from dbo.DoanhThuThang where Nam='" + nam + "'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach(DataRow item in data.Rows)
            {
                DoanhThuThang dt = new DoanhThuThang(item);
                listdoanhthu.Add(dt);
            }
            return listdoanhthu;

        }
    }
}
