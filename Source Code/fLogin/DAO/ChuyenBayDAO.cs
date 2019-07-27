using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using fLogin.DTO;
namespace fLogin.DAO
{
    public class ChuyenBayDAO
    {
        private static ChuyenBayDAO instance;

        public static ChuyenBayDAO Instance
        {
            get
            {
                if (instance == null) instance = new ChuyenBayDAO();
                return instance;
            }

            set
            {
                instance = value;
            }
        }
        public List<ChuyenBay> LoadListChuyenBay()
        {
            List<ChuyenBay> listchuyenbay = new List<ChuyenBay>();
            string query = "select * from dbo.ChuyenBay";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                ChuyenBay chuyenbay = new ChuyenBay(item);
                listchuyenbay.Add(chuyenbay);
            }

            return listchuyenbay;
        }
        public List<ChuyenBay> FindChuyenBay(string date,string sbdi,string sbden)
        {
            List<ChuyenBay> listchuyenbay = new List<ChuyenBay>();
            string query = "select * from dbo.ChuyenBay where SanBayDi='"+sbdi+"' and SanBayDen='"+sbden+"' and NgayBay='"+date+"'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                ChuyenBay chuyenbay = new ChuyenBay(item);
                //if (chuyenbay.NgayBay.Trim()==date && chuyenbay.SanBayDi.Trim()==sbdi &&chuyenbay.SanBayDen.Trim()==sbden)
                listchuyenbay.Add(chuyenbay);
            }

            return listchuyenbay;
        }
        public List<ChuyenBay> LoadListChuyenBayByThangNam(string thang, string nam)
        {
            List<ChuyenBay> listchuyenbay = new List<ChuyenBay>();
            string query = "select * from dbo.ChuyenBay";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                ChuyenBay chuyenbay = new ChuyenBay(item);
                string[] day = chuyenbay.NgayBay.Trim().Split('/');
                if (day[1] == thang && day[2] == nam) listchuyenbay.Add(chuyenbay);
            }

            return listchuyenbay;
        }
        public ChuyenBay LoadChuyenBayByMaChuyenBay(string mcb)
        {
            ChuyenBay cb = new ChuyenBay();
            string query = "select * from dbo.ChuyenBay where MaChuyenBay='" + mcb + "'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            if (data.Rows[0] != null)
            {
                cb = new ChuyenBay(data.Rows[0]);
            }
            return cb;
        }

        public void InsertChuyenBay(string msb, string sbdi, string sbden, string day, string time, string tgb, int sl1, int sl2, int gia)
        {
            msb = "'" + msb + "',";
            sbdi = "'" + sbdi + "',";
            sbden = "'" + sbden + "',";
            day = "'" + day + "',";
            time = "'" + time + "',";
            tgb = "'" + tgb + "',";
            string query = "INSERT INTO dbo.ChuyenBay VALUES (" + msb + sbdi + sbden + day + time + tgb + sl1.ToString() + ",0," + sl2.ToString() + ",0," + gia.ToString() + ")";
            DataProvider.Instance.ExecuteNonQuery(query);
            //string query = "EXEC USP_ThemChuyenBay @MaChuyenBay @SanBayDi @SanBayDen @NgayBay @GioBay @ThoiGianBay @SoLuongGheHang1 @SoLuongGheHang2 @GiaVe";
            //DataProvider.Instance.ExecuteNonQuery(query, new object[] { msb, sbdi, sbden, day, time, tgb, sl1, sl2, gia });
        }
        public void UpdateSoLuongGheDaDatChuyenBay()
        {
            int hang1 = 0, hang2 = 0;
            string query = "select * from dbo.ChuyenBay";
            DataTable lichbay = DataProvider.Instance.ExecuteQuery(query);
            string machuyenbay;
            DataRow row;
            DataTable data;
            foreach (DataRow item in lichbay.Rows)
            {
                machuyenbay = item[0].ToString().Trim();
                query = "select sum(C) as TongGheHang1 from(select count(MaDatVe) as C from dbo.QuanLyDatVe where MaChuyenBay ='" + machuyenbay + "' and HangVe='1' UNION ALL select count(MaDatVe) as C from dbo.QuanLyVe where MaChuyenBay ='" + machuyenbay + "' and HangVe='1') AS B";
                data = DataProvider.Instance.ExecuteQuery(query);
                row = data.Rows[0];
                try
                {
                    hang1 = (int)row[0];
                }
                catch { hang1 = 0; }
                query = "select sum(C) as TongGheHang2 from(select count(MaDatVe) as C from dbo.QuanLyDatVe where MaChuyenBay ='" + machuyenbay + "' and HangVe='2' UNION ALL select count(MaDatVe) as C from dbo.QuanLyVe where MaChuyenBay ='" + machuyenbay + "' and HangVe='2') AS B";
                data = DataProvider.Instance.ExecuteQuery(query);
                row = data.Rows[0];
                try
                {
                    hang2 = (int)row[0];
                }
                catch { hang2 = 0; }
                query = "update dbo.ChuyenBay set SoLuongGheHang1DaDat=" + hang1.ToString() + ",SoLuongGheHang2DaDat=" + hang2.ToString() + " where MaChuyenBay='" + machuyenbay + "'";
                DataProvider.Instance.ExecuteNonQuery(query);
            }
        }
        public void EditGheChuyenBay(string machuyenbay,int hang1,int hang2)
        {
            string query = "update dbo.Chuyenbay set SoLuongGheHang1=" + hang1.ToString() + ",SoLuongGheHang2=" + hang2.ToString() + " where MaChuyenBay='" + machuyenbay + "'";
            DataProvider.Instance.ExecuteNonQuery(query);
        }
        public List<ChuyenBay> LoadListChuyenBayByDate(int ngayhuyve)
        {
            List<ChuyenBay> listchuyenbay = new List<ChuyenBay>();
            string query = "select * from dbo.ChuyenBay";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                ChuyenBay chuyenbay = new ChuyenBay(item);
                if (DateTime.ParseExact(chuyenbay.NgayBay.Trim(), "dd/MM/yyyy", System.Globalization.CultureInfo.CurrentCulture) - TimeSpan.FromDays(ngayhuyve) <= DateTime.Now) listchuyenbay.Add(chuyenbay);
            }

            return listchuyenbay;
        }
        public List<ChuyenBay> LoadListValidChuyenBay()
        {
            List<ChuyenBay> listchuyenbay = new List<ChuyenBay>();
            string query = "select * from dbo.ChuyenBay";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                ChuyenBay chuyenbay = new ChuyenBay(item);
                if (DateTime.ParseExact(chuyenbay.NgayBay.Trim(), "dd/MM/yyyy", System.Globalization.CultureInfo.CurrentCulture) > DateTime.Now) listchuyenbay.Add(chuyenbay);
            }

            return listchuyenbay;
        }

    }
}
