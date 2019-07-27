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
    public partial class fChange : Form
    {
        public fChange()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void LoadSanBay()
        {
            dataGridViewSanBay.Rows.Clear();
            List<SanBay> listsanbay = SanBayDAO.Instance.GetListSanBay();
            foreach(SanBay sb in listsanbay)
            {
                dataGridViewSanBay.Rows.Add(sb.TenSanBay);
            }
            
        }
        public void LoadQuiDinh()
        {
            QuiDinh quidinh = QuiDinhDAO.Instance.Loadquidinh();
            thoigianbaymin.Text = quidinh.ThoiGianBayMin.Trim();
            sanbaytrunggianmax.Text = quidinh.SoSanBayTrungGianMax.ToString();
            thoigiandungmax.Text = quidinh.ThoiGianDungMax.Trim();
            thoigiandungmin.Text = quidinh.ThoiGianDungMin.Trim();
            day1.Text = quidinh.ThoiGianDatVeChamNhat.ToString();
            day2.Text = quidinh.ThoiGianHuyVe.ToString();
        }
        private void fChange_Load(object sender, EventArgs e)
        {
            LoadSanBay();
            LoadQuiDinh();
        }

        private void sanbaybtnadd_Click(object sender, EventArgs e)
        {
            if (textBoxtensanbay.Text != "")
            {
                SanBayDAO.Instance.InsertSanBay(textBoxtensanbay.Text);
                LoadSanBay();
            }
        }
        int index;
        private void dataGridViewSanBay_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
        }

        private void sanbaybtnremove_Click(object sender, EventArgs e)
        {
            try
            {
                string sanbay = dataGridViewSanBay.CurrentRow.Cells[0].Value.ToString().Trim();
                SanBayDAO.Instance.DeleteSanBay(sanbay);
            }
            catch
            {
                MessageBox.Show("Không thể xóa Sân bay này !");
            }
            
            LoadSanBay();
        }

        private void dataGridViewSanBay_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                index = dataGridViewSanBay.CurrentRow.Index;
            }
            catch { }
            
        }
        bool kiemtra()
        {
            try
            {
                if (!checktime(thoigianbaymin.Text) || int.Parse(sanbaytrunggianmax.Text) > 10) return false;
                if (TimeSpan.Parse(thoigiandungmax.Text) < TimeSpan.Parse(thoigiandungmin.Text)) return false;
                Convert.ToInt16(day1.Text);
                Convert.ToInt16(day2.Text);
                
            }
            catch
            {
                return false;
            }
            return true;
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
        private void thoigianbaymin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
            if (!char.IsControl(e.KeyChar) && thoigianbaymin.Text.Length == 2)
            {
                thoigianbaymin.Text += ":";
                thoigianbaymin.SelectionStart = thoigianbaymin.Text.Length;
            }
            if (thoigianbaymin.Text.Length >= 5 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void thoigianbaymin_TextChanged(object sender, EventArgs e)
        {
            if (thoigianbaymin.Text.Length == 5 && !checktime(thoigianbaymin.Text))
            {
                thoigianbaymin.Text = "23:59";
                thoigianbaymin.SelectionStart = 5;
            }
        }

        private void savebutton_Click(object sender, EventArgs e)
        {
            if (kiemtra())
            {
                QuiDinhDAO.Instance.UpdateQuiDinh(thoigianbaymin.Text, int.Parse(sanbaytrunggianmax.Text), thoigiandungmin.Text, thoigiandungmax.Text, int.Parse(day1.Text), int.Parse(day2.Text));
                MessageBox.Show("Đã lưu!");
            }
            else MessageBox.Show("Kiểm tra lại thông tin và dữ liệu !");
            LoadQuiDinh();
        }

        private void setdefaultbutton_Click(object sender, EventArgs e)
        {
            QuiDinhDAO.Instance.SetDefault();
            LoadQuiDinh();
        }
    }
}
