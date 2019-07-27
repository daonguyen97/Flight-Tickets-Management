using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fLogin.DTO
{
    public class QuiDinh
    {
        public string ThoiGianBayMin { get; set; }
        public int SoSanBayTrungGianMax { get; set; }
        public string ThoiGianDungMin { get; set; }
        public string ThoiGianDungMax { get; set; }
        public int ThoiGianHuyVe { get; set; }
        public int ThoiGianDatVeChamNhat { get; set; }
        public QuiDinh() { }
        public QuiDinh(string thoigianbaymin,int sosanbaytrunggianmax,string thoigiandungmin,string thoigiandungmax,int thoigianhuyve,int thoigiandatvechamnhat)
        {
            ThoiGianBayMin = thoigianbaymin;
            SoSanBayTrungGianMax = sosanbaytrunggianmax;
            ThoiGianDungMin = thoigiandungmin;
            ThoiGianDungMax = thoigiandungmax;
            ThoiGianHuyVe = thoigianhuyve;
            ThoiGianDatVeChamNhat = thoigiandatvechamnhat;
        }
        public QuiDinh(DataRow row)
        {
            ThoiGianBayMin = row["ThoiGianBayMin"].ToString();
            SoSanBayTrungGianMax = (int)row["SoSanBayTrungGianMax"];
            ThoiGianDungMin = row["ThoiGianDungMin"].ToString();
            ThoiGianDungMax = row["ThoiGianDungMax"].ToString();
            ThoiGianHuyVe = (int)row["ThoiGianHuyVe"];
            ThoiGianDatVeChamNhat = (int)row["ThoiGianDatVeChamNhat"];
        }
    }
}
