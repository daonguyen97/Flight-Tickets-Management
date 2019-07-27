using fLogin.DAO;
using fLogin.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fLogin
{
    public partial class fEditSoGhe : Form
    {
        public fEditSoGhe()
        {
            InitializeComponent();
        }
        public ChuyenBay chuyenbay;

        private void fEditSoGhe_Load(object sender, EventArgs e)
        {
            hang1.Text = chuyenbay.SoLuongGheHang1.ToString();
            hang2.Text = chuyenbay.SoLuongGheHang2.ToString();
            dadat1.Text = "Đã đặt " + chuyenbay.SoLuongGheHang1DaDat.ToString() + " ghế.";
            dadat2.Text = "Đã đặt " + chuyenbay.SoLuongGheHang2DaDat.ToString() + " ghế.";
        }
        bool kiemtradieukien()
        {
            try
            {
                if (int.Parse(hang1.Text) < chuyenbay.SoLuongGheHang1DaDat || int.Parse(hang2.Text) < chuyenbay.SoLuongGheHang2DaDat) return false;
            }
            catch
            {
                return false;
            }
            return true;
        }

        private void accept_Click(object sender, EventArgs e)
        {
            if (kiemtradieukien())
            {
                ChuyenBayDAO.Instance.EditGheChuyenBay(chuyenbay.MaChuyenBay.Trim(), int.Parse(hang1.Text), int.Parse(hang2.Text)); 
                this.Close();
            }
            else MessageBox.Show("Không thế lưu !");
                
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    
}
