using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using fLogin.DAO;
using fLogin.DTO;
namespace fLogin
{
    public partial class fThemChuyenBay : Form
    {
        public fThemChuyenBay()
        {
            InitializeComponent();
        }
        QuiDinh quidinh = new QuiDinh();

        private void fThemChuyenBay_Load(object sender, EventArgs e)
        {
            quidinh = QuiDinhDAO.Instance.Loadquidinh();
            ttngay.CustomFormat = "dd/MM/yyyy";
            LoadSanBay();
            LoadLichBay();
            try
            {
                ttsanbaydi.SelectedIndex = 0;
                ttsanbayden.SelectedIndex = 1;
            }
            catch
            {

            }

        }
        public void LoadSanBay()
        {
            List<SanBay> listsanbay = SanBayDAO.Instance.GetListSanBay();
            DataGridViewComboBoxColumn listsanbaytg = new DataGridViewComboBoxColumn();
            listsanbaytg.HeaderText = "Sân Bay Trung Gian";
            listsanbaytg.Name = "sanbay";
            foreach (SanBay sb in listsanbay)
            {
                ttsanbaydi.Items.Add(sb.TenSanBay);
                ttsanbayden.Items.Add(sb.TenSanBay);
                listsanbaytg.Items.Add(sb.TenSanBay);
                
            }
            dgvsanbaytrunggian.Columns.Insert(0, listsanbaytg);

            
        }
        public void LoadLichBay()
        {
            dgvlichbay.Rows.Clear();
            List<ChuyenBay> listchuyenbay = ChuyenBayDAO.Instance.LoadListValidChuyenBay();
            foreach (ChuyenBay cb in listchuyenbay)
            {
                this.dgvlichbay.Rows.Add(cb.MaChuyenBay, cb.SanBayDi, cb.SanBayDen, cb.NgayBay, cb.GioBay, cb.ThoiGianBay, cb.SoLuongGheHang1,cb.SoLuongGheHang2,String.Format("{0:N2}", cb.GiaVe));
            }
        }
        public bool checktime(string A)
        {
            if (A.Length != 5) return false;
            try
            {
                if (TimeSpan.Parse(A) > TimeSpan.Zero && TimeSpan.Parse(A) <= TimeSpan.Parse("23:59")) return true;
            }
            catch
            {
                return false;
            }
            return true;
        }
        private void btnadd_Click(object sender, EventArgs e)
        {
            try
            {

                if (ttmachuyenbay.Text!=string.Empty && checktime(ttgio.Text) && kiemtraquidinh()) 
                {
                    ChuyenBayDAO.Instance.InsertChuyenBay(ttmachuyenbay.Text, ttsanbaydi.Text.Trim(), ttsanbayden.Text.Trim(), ttngay.Value.ToString("dd/MM/yyyy"), ttgio.Text, ttgiobay.Text, int.Parse(ttsoghehang1.Text), int.Parse(ttsoghehang2.Text), int.Parse(ttgiave.Text));
                    foreach (DataGridViewRow row in dgvsanbaytrunggian.Rows)
                    {
                        SanBayTrungGianDAO.Instance.InsertSanBayTrungGian(ttmachuyenbay.Text, row.Cells[0].Value.ToString(), row.Cells[1].Value == null ? String.Empty : row.Cells[1].Value.ToString(), row.Cells[2].Value == null ? String.Empty : row.Cells[2].Value.ToString());
                    }
                    MessageBox.Show("Thêm chuyến bay thành công !");
                    LoadLichBay();
                }
                else
                {
                    MessageBox.Show(string.Format("Vui lòng kiếm tra lại thông tin theo đúng qui định \n Qui định: \n Thời gian bay tối thiêu: {0} \n Thời gian dừng tại sân bay trung gian tối thiểu: {1} \n Thời gian dừng lại sân bay trung gian tối đa: {2}",quidinh.ThoiGianBayMin,quidinh.ThoiGianDungMin ,quidinh.ThoiGianDungMax));
                }
            }
            catch { MessageBox.Show("Lỗi dữ liệu ! Vui lòng kiểm tra lại thông tin !"); }
        }
        bool checksbtg(string a)
        {
            try
            {
                TimeSpan A = TimeSpan.Parse(a);
                TimeSpan min = TimeSpan.Parse(quidinh.ThoiGianDungMin);
                TimeSpan max = TimeSpan.Parse(quidinh.ThoiGianDungMax);
                if (A >= min && A <= max) return true;
            }
            catch
            {
                return false;
            }
            return false;
        }
        bool kiemtraquidinh()
        {
            if (ttngay.Value <= DateTime.Now) return false;
            try
            {
                if (TimeSpan.Parse(ttgiobay.Text) < TimeSpan.Parse(quidinh.ThoiGianBayMin)) return false;
            }
            catch
            {
                return false;
            }
            foreach (DataGridViewRow row in dgvsanbaytrunggian.Rows)
            {
                if (row.Cells[0].ToString() == null || !checksbtg(Convert.ToString(row.Cells["ThoiGianDung"].Value)))
                {
                    MessageBox.Show("Kiểm tra lại thông tin sân bay trung gian!");
                    return false;
                }
    
            }
            return true;
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            ttmachuyenbay.Text = "";
            ttgiave.Text = "";
            ttgiobay.Text = "";
            ttngay.Value = DateTime.Now;
            ttgio.Text = "";
            ttsoghehang1.Text = "";
            ttsoghehang2.Text = "";
            

        }

        private void themsbtgbtn_Click(object sender, EventArgs e)
        {
            if (dgvsanbaytrunggian.Rows.Count < quidinh.SoSanBayTrungGianMax)
                dgvsanbaytrunggian.Rows.Add();
            else MessageBox.Show(string.Format("Theo qui định : Có tối đa {0} sân bay trung gian.", quidinh.SoSanBayTrungGianMax));
        }

        private void xoasbtgbtn_Click(object sender, EventArgs e)
        {
            if (dgvsanbaytrunggian.Rows.Count>0)
            dgvsanbaytrunggian.Rows.RemoveAt(dgvsanbaytrunggian.Rows.Count-1);
        }

        private void ttgio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
            if(!char.IsControl(e.KeyChar) && ttgio.Text.Length==2)
            {
                ttgio.Text += ":";
                ttgio.SelectionStart = ttgio.Text.Length;
            }
            if (ttgio.Text.Length >= 5 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void ttgiobay_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
            if (!char.IsControl(e.KeyChar) && ttgiobay.Text.Length == 2)
            {
                ttgiobay.Text += ":";
                ttgiobay.SelectionStart = ttgiobay.Text.Length;
            }
            if (ttgiobay.Text.Length >= 5 && !char.IsControl(e.KeyChar))
            {
               
                e.Handled = true;
                
            }
           
        }

        private void ttsoghehang1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void ttsanbaydi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ttsanbaydi.SelectedIndex == ttsanbayden.SelectedIndex)
            {

                if (ttsanbayden.SelectedIndex == ttsanbayden.Items.Count - 1)
                    ttsanbayden.SelectedIndex = 0;
                else ttsanbayden.SelectedIndex++;
            }
        }

        private void ttgio_TextChanged(object sender, EventArgs e)
        {
            if(ttgio.Text.Length==5 && !checktime(ttgio.Text))
            {
                ttgio.Text = "23:59";
                ttgio.SelectionStart = 5;
            }
        }

        private void ttsanbayden_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ttsanbaydi.SelectedIndex == ttsanbayden.SelectedIndex)
            {

                if (ttsanbaydi.SelectedIndex == ttsanbaydi.Items.Count - 1)
                    ttsanbaydi.SelectedIndex = 0;
                else ttsanbaydi.SelectedIndex++;
            }
        }

        private void btnedit_Click(object sender, EventArgs e)
        { 
            ChuyenBay chuyenbay = ChuyenBayDAO.Instance.LoadChuyenBayByMaChuyenBay(dgvlichbay.CurrentRow.Cells[0].Value.ToString().Trim());
            fEditSoGhe editform = new fEditSoGhe();
            editform.Text += chuyenbay.MaChuyenBay;
            editform.chuyenbay = chuyenbay;
            editform.ShowDialog();
            LoadLichBay();
        }

        private void dgvlichbay_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvlichbay.CurrentRow == null) btnedit.Enabled = false;
            else btnedit.Enabled = true;
        }
    }
}
