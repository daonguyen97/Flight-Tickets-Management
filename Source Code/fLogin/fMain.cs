using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using fLogin.DTO;
using fLogin.DAO;
using System.Globalization;

namespace fLogin
{
    public partial class fMain : Form
    {

        public fMain()
        {
            
            InitializeComponent();
        }
        
        #region XuLy
        QuiDinh quidinh = new QuiDinh();
        CultureInfo culture = new CultureInfo("vn-VN"); 
        string departuretime(string A,string B)
        {
            string x = string.Empty;
            DateTime date = DateTime.ParseExact(A, "dd/MM/yyyy", System.Globalization.CultureInfo.CurrentCulture);
            date = date.Add(TimeSpan.Parse(B));
            x = date.ToString("dd/MM/yyyy HH:mm tt");
            return x;
        }
        string arrivaltime(string A,string B,string C)
        {
            string x=string.Empty;
            DateTime date = DateTime.ParseExact(A, "dd/MM/yyyy", System.Globalization.CultureInfo.CurrentCulture);
            date = date.Add(TimeSpan.Parse(B)+TimeSpan.Parse(C));
            x = date.ToString("dd/MM/yyyy HH:mm tt");
            return x;
        }
        public bool checktime(string A)
        {
            if (A.Length != 5) return false;
            try
            {
                string[] B = A.Split(':');
                if (Convert.ToInt16(B[0]) < 24 && Convert.ToInt16(B[1]) < 60) return true;
            }
            catch
            {
                return false;
            }
            return false;
        }
        public bool checkcmnd(string A)
        {
            try
            {
                Convert.ToInt64(A);
                return true;
            }
            catch
            {
                return false;
            }
        }
        #endregion
        #region FORM_EVENT
        private void fMain_Load(object sender, EventArgs e)
        {
            try
            {
                defaultform();
                LoadLichBay();
                LoadListDatVe();
                LoadListVe();
                LoadListDoanhThuThang();
                LoadListDoanhThuNam();
                LoadQuiDinh();
            }
            catch
            {
                MessageBox.Show("Lỗi kết nối đến Database.");
            }
        }
        public void LoadQuiDinh()
        {
            quidinh = QuiDinhDAO.Instance.Loadquidinh();
        }
        public void defaultform()
        {
            doanhthunamnam.SelectedIndex = 0;
            datvehangve.SelectedIndex = 1;
            comboBox1.SelectedIndex = 0;
            doanhthucomboboxthang.SelectedIndex = 4;
            doanhthucomboboxnam.SelectedIndex = 0;
        }
        private void fMain_Activated(object sender, EventArgs e)
        {
            //LoadLichBay();
        }
        private void fChangebtn_Click(object sender, EventArgs e)
        {
            
        }
        private void fMain_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
                fMain_Load(sender, new EventArgs());
        }

        private void QuanLyLichBay_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (QuanLyLichBay.SelectedIndex != 0 ) ;
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            datetime.Text = DateTime.Now.ToLongDateString();
            time.Text = DateTime.Now.ToString("HH:MM:ss tt");
        }
        #endregion
        #region MENU
        private void thayĐổiQuiĐịnhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fChange fchange = new fChange();
            fchange.ShowDialog();
            LoadQuiDinh();
        }

        private void thayĐổiLịchBayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fThemChuyenBay fthemchuyenbay = new fThemChuyenBay();
            fthemchuyenbay.ShowDialog();
        }

        private void lịchBayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLyLichBay.SelectedIndex = 0;
        }

        private void đặtVéToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLyLichBay.SelectedIndex = 1;
        }

        private void quảnLýVéToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLyLichBay.SelectedIndex = 2;
        }

        private void thángToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLyLichBay.SelectedIndex = 3;
            bangdoanhthu.SelectedIndex = 0;
        }

        private void nămToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLyLichBay.SelectedIndex = 3;
            bangdoanhthu.SelectedIndex = 1;
        }

        private void reloadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fMain_Load(sender, new EventArgs());
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void thoátToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void aboutUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aboutus AU = new aboutus();
            AU.ShowDialog();
        }
        #endregion
        #region TAB_lichbay

        public void LoadLichBay()
        {
            dgvlichbay.Rows.Clear();
            ChuyenBayDAO.Instance.UpdateSoLuongGheDaDatChuyenBay();
            List<ChuyenBay> listchuyenbay = ChuyenBayDAO.Instance.LoadListValidChuyenBay();
            foreach(ChuyenBay cb in listchuyenbay)
            {
                this.dgvlichbay.Rows.Add(cb.MaChuyenBay, cb.SanBayDi, cb.SanBayDen, cb.NgayBay.ToString(), cb.GioBay, cb.ThoiGianBay, cb.SoLuongGheHang1 + cb.SoLuongGheHang2, cb.SoLuongGheHang1DaDat + cb.SoLuongGheHang2DaDat,cb.SoLuongGheHang1, cb.SoLuongGheHang1DaDat, cb.SoLuongGheHang2, cb.SoLuongGheHang2DaDat, cb.GiaVe.ToString("###,### VND"));
                if (cb.SoLuongGheHang1DaDat == cb.SoLuongGheHang1 && cb.SoLuongGheHang2DaDat == cb.SoLuongGheHang2) dgvlichbay.Rows[dgvlichbay.RowCount - 1].DefaultCellStyle.BackColor = Color.Red;
            }
        }

       

        private void fThemChuyenBaybtn_Click(object sender, EventArgs e)
        {
            fThemChuyenBay fthemchuyenbay = new fThemChuyenBay();
            fthemchuyenbay.ShowDialog();
            LoadLichBay();
        }
        
        private void dgvlichbay_SelectionChanged(object sender, EventArgs e)
        {
            labelmachuyenbay.Text = "Số Hiệu: " + dgvlichbay.CurrentRow.Cells[0].Value.ToString();
            labelsanbaydi.Text = dgvlichbay.CurrentRow.Cells[1].Value.ToString();
            labelsanbayden.Text = dgvlichbay.CurrentRow.Cells[2].Value.ToString();
            int ghe1, ghe2;
            ghe1 = (int)dgvlichbay.CurrentRow.Cells[8].Value - (int)dgvlichbay.CurrentRow.Cells[9].Value;
            ghe2 = (int)dgvlichbay.CurrentRow.Cells[10].Value - (int)dgvlichbay.CurrentRow.Cells[11].Value;
            labelsoghehang1conlai.Text = "Hạng 1: " + ghe1.ToString();
            labelsoghehang2conlai.Text = "Hạng 2: " + ghe2.ToString();
            labelsoghehang1dadat.Text = "Hạng 1: " + dgvlichbay.CurrentRow.Cells[9].Value.ToString();
            labelsoghehang2dadat.Text = "Hạng 2: " + dgvlichbay.CurrentRow.Cells[11].Value.ToString();
            labelgiave.Text = "Giá Vé: " + dgvlichbay.CurrentRow.Cells[12].Value.ToString();
            labelgiobaydi.Text = departuretime(dgvlichbay.CurrentRow.Cells[3].Value.ToString(), dgvlichbay.CurrentRow.Cells[4].Value.ToString());
            labelgiobayden.Text = arrivaltime(dgvlichbay.CurrentRow.Cells[3].Value.ToString(),dgvlichbay.CurrentRow.Cells[4].Value.ToString(), dgvlichbay.CurrentRow.Cells[5].Value.ToString());
            dgvlichbaysanbaytrunggian.DataSource = SanBayTrungGianDAO.Instance.GetListSanBayTrungGianByMaChuyenBay(dgvlichbay.CurrentRow.Cells[0].Value.ToString());
            dgvlichbaysanbaytrunggian.Columns.RemoveAt(0);
            dgvlichbaysanbaytrunggian.Columns[0].HeaderText = "Tên Sân Bay";
            dgvlichbaysanbaytrunggian.Columns[1].HeaderText = "Thời Gian Chờ";
            dgvlichbaysanbaytrunggian.Columns[2].HeaderText = "Chú Thích";
        }

        private void lichbaydatvebtn_Click(object sender, EventArgs e)
        {
            datvemachuyenbay.Text = dgvlichbay.CurrentRow.Cells[0].Value.ToString();
            QuanLyLichBay.SelectedIndex = 1;
            datvebtncheck.PerformClick();
        }
       
        private void btntimchuyenbay_Click(object sender, EventArgs e)
        {
            fTimChuyenBay find = new fTimChuyenBay();
            find.Owner = this;
            find.wait += new EventHandler(timchuyenbay);
            find.Show();
            
        }
        void timchuyenbay(object sender,EventArgs e)
        {
            fTimChuyenBay find = (fTimChuyenBay)sender;
            dgvlichbay.Rows.Clear();
            List<ChuyenBay> listchuyenbay = ChuyenBayDAO.Instance.FindChuyenBay(find.DATE,find.SBDI,find.SBDEN);
            foreach (ChuyenBay cb in listchuyenbay)
            {
                this.dgvlichbay.Rows.Add(cb.MaChuyenBay, cb.SanBayDi, cb.SanBayDen, cb.NgayBay.ToString(), cb.GioBay, cb.ThoiGianBay, cb.SoLuongGheHang1 + cb.SoLuongGheHang2, cb.SoLuongGheHang1DaDat + cb.SoLuongGheHang2DaDat, cb.SoLuongGheHang1, cb.SoLuongGheHang1DaDat, cb.SoLuongGheHang2, cb.SoLuongGheHang2DaDat, cb.GiaVe.ToString("###,### VND"));
                if (cb.SoLuongGheHang1DaDat == cb.SoLuongGheHang1 && cb.SoLuongGheHang2DaDat == cb.SoLuongGheHang2) dgvlichbay.Rows[dgvlichbay.RowCount - 1].DefaultCellStyle.BackColor = Color.Red;
            }

        }
        #endregion
        #region TAB_datve
        ChuyenBay selectChuyenBay = new ChuyenBay();
        private void datvebtncheck_Click(object sender, EventArgs e)
        {
            try
            {
                ChuyenBay chuyenbay = ChuyenBayDAO.Instance.LoadChuyenBayByMaChuyenBay(datvemachuyenbay.Text);
                selectChuyenBay = chuyenbay;
                if (!KiemTraNgayDat())
                {
                    MessageBox.Show("Quá thời hạn đặt vé cho chuyến bay này !");
                    datvemachuyenbay.Text = string.Empty;
                    QuanLyLichBay.SelectedIndex = 0;
                    return;
                }
                labeldatvesanbaydi.Text = chuyenbay.SanBayDi;
                labeldatvesanbayden.Text = chuyenbay.SanBayDen;
                labeldatvegiobaydi.Text = departuretime(chuyenbay.NgayBay,chuyenbay.GioBay);
                labeldatvegiobayden.Text = arrivaltime(chuyenbay.NgayBay, chuyenbay.GioBay, chuyenbay.ThoiGianBay);
                datvegiave.Text = chuyenbay.GiaVe.ToString("###,### VND");
                datvebtndatve.Enabled = true;
                datvebtnmuave.Enabled = true;
            }
            catch
            {
                datvebtnmuave.Enabled = false;
                datvebtndatve.Enabled = false;
                MessageBox.Show("Chuyến bay không tồn tại !");
            }
        }


        bool KiemTraGheTrong()
        {
            int ghe, dadat;
            if (datvehangve.SelectedIndex == 0)
            {
                ghe = selectChuyenBay.SoLuongGheHang1;
                dadat = selectChuyenBay.SoLuongGheHang1DaDat;
            }
            else
            {
                ghe = selectChuyenBay.SoLuongGheHang2;
                dadat = selectChuyenBay.SoLuongGheHang2DaDat;
            }
            if (dadat < ghe) return true;
            return false;
        }
        bool KiemTraNgayDat()
        {
            TimeSpan ngaydatchamnhat = TimeSpan.FromDays(quidinh.ThoiGianDatVeChamNhat);
            DateTime date = DateTime.ParseExact(selectChuyenBay.NgayBay.Trim()+" "+selectChuyenBay.GioBay.Trim(), "dd/MM/yyyy HH:mm", System.Globalization.CultureInfo.CurrentCulture);
            if (date - ngaydatchamnhat > DateTime.Now) return true;
            return false;
        }

        private void datvebtndatve_Click(object sender, EventArgs e)
        {
            if (KiemTraGheTrong())
            {
                if (datvehovaten.Text != null && datvecmnd.Text != null && datvehovaten.Text!=string.Empty && datvecmnd.Text.Length==9)
                {
                    try
                    {
                        kiemtrakhachhang();
                        QuanLyDatVeDAO.Instance.InsertListDatVe(selectChuyenBay.MaChuyenBay.Trim(), datvecmnd.Text, datvehangve.SelectedItem.ToString(),(datvehangve.SelectedIndex==1)?selectChuyenBay.GiaVe:(selectChuyenBay.GiaVe*105/100));
                        LoadListDatVe();
                        LoadLichBay();
                        datvebtnhuy.PerformClick();
                        datvebtncheck.PerformClick();
                        MessageBox.Show("Đặt vé thành công!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
            }
            else
            {
                MessageBox.Show("Số lượng vé đã hết !\n Vui lòng chọn hạng vé khác hoặc Chuyến bay khác !\n Mong quý khách thông cảm!");
            }

        }
        private void datvebtnmuave_Click(object sender, EventArgs e)
        {
            if (KiemTraGheTrong())
            {
                if (datvehovaten.Text != null && datvecmnd.Text != null && datvehovaten.Text!=string.Empty && datvecmnd.Text.Length==9)
                {
                    try
                    {
                        kiemtrakhachhang();
                        QuanLyVeDAO.Instance.InsertQuanLyVe(string.Empty, selectChuyenBay.MaChuyenBay.Trim(), datvecmnd.Text, datvehangve.SelectedItem.ToString(), (datvehangve.SelectedIndex==1)?selectChuyenBay.GiaVe:(selectChuyenBay.GiaVe*105/100), DateTime.Now.ToString("dd/MM/yyyy"));
                        LoadListVe();
                        LoadLichBay();
                        datvebtnhuy.PerformClick();
                        datvebtncheck.PerformClick();
                        MessageBox.Show("Mua vé thành công!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
            }
            else
            {
                MessageBox.Show("Số lượng vé đã hết !\n Vui lòng chọn hạng vé khác hoặc Chuyến bay khác !\n Mong quý khách thông cảm!");
            }
        }
        private void datvehangve_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(datvehangve.SelectedIndex==0)
            {
                datvegiave.Text = ((int)(selectChuyenBay.GiaVe * 105 / 100)).ToString("###,### VND");
            }
            if(datvehangve.SelectedIndex==1)
            {
                datvegiave.Text = selectChuyenBay.GiaVe.ToString("###,### VND");
            }
        }
        public void LoadListDatVe()
        {
            QuanLyDatVeDAO.Instance.HUYVE(quidinh.ThoiGianHuyVe);
            datvedata.Rows.Clear();
            List<QuanLyDatVe> listdatve = QuanLyDatVeDAO.Instance.GetListDatVe();
            foreach(QuanLyDatVe item in listdatve)
            {
                KhachHang khachhang = KhachHangDAO.Instance.GetKhachHangByCMND(item.CMND);
                datvedata.Rows.Add(item.MaDatVe, item.MaChuyenBay,khachhang.Ten, item.CMND,khachhang.SoDienThoai, item.HangVe,item.GiaVe.ToString("###,### VND"));
            }
            
        }
        private void timkiemdatvebtn_Click(object sender, EventArgs e)
        {
            datvedata.Rows.Clear();
            List<QuanLyDatVe> listdatve = QuanLyDatVeDAO.Instance.GetDatVeByCMND(timkiemcmnd.Text);
            foreach (QuanLyDatVe item in listdatve)
            {
                KhachHang khachhang = KhachHangDAO.Instance.GetKhachHangByCMND(item.CMND);
                datvedata.Rows.Add(item.MaDatVe, item.MaChuyenBay, khachhang.Ten, item.CMND, khachhang.SoDienThoai, item.HangVe, item.GiaVe.ToString("###,### VND"));
            }
        }
        private void datvedata_SelectionChanged(object sender, EventArgs e)
        {
            if (datvedata.CurrentRow == null) datvebtnthanhtoan.Enabled = false;
            datvebtnthanhtoan.Enabled = true;
        }
        private void datvemachuyenbay_TextChanged(object sender, EventArgs e)
        {
            datvebtndatve.Enabled = false;
            datvebtnmuave.Enabled = false;
        }
        private void datvebtnhuy_Click(object sender, EventArgs e)
        {

            datvecmnd.Text = string.Empty;
            datvehovaten.Text = string.Empty;
            datveSoDienThoai.Text = string.Empty;
        }
        private void datvebtnthanhtoan_Click(object sender, EventArgs e)
        {
            QuanLyDatVe selectdatve = QuanLyDatVeDAO.Instance.GetDatVeByMaDatVe(datvedata.CurrentRow.Cells[0].Value.ToString().Trim());
            QuanLyDatVeDAO.Instance.DeleteDatVe(selectdatve.MaDatVe.Trim());
            QuanLyVeDAO.Instance.InsertQuanLyVe(selectdatve.MaDatVe.Trim(),selectdatve.MaChuyenBay.Trim(), selectdatve.CMND.Trim(), selectdatve.HangVe.Trim(), selectdatve.GiaVe, DateTime.Now.ToString("dd/MM/yyyy"));
            LoadListDatVe();
            LoadListVe();
            MessageBox.Show("Thanh toán thành công!");
        }
        private void datvehovaten_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
                e.KeyChar = char.ToUpper(e.KeyChar);
        }

        private void datvecmnd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
            if (datvecmnd.Text.Length == 9 && !char.IsControl(e.KeyChar))
                e.Handled = true ;
        }
        public void kiemtrakhachhang()
        {
            if(khachhang==null) KhachHangDAO.Instance.InsertKhachHang(datvecmnd.Text, datvehovaten.Text, datveSoDienThoai.Text == null ? string.Empty : datveSoDienThoai.Text);
            else
            {
                KhachHangDAO.Instance.UpdateKhachHang(datveSoDienThoai.Text, khachhang.CMND);
            }
        }
        KhachHang khachhang = new KhachHang();
        private void datvecmnd_TextChanged(object sender, EventArgs e)
        {
            if(datvecmnd.Text.Length==9)
            {
                khachhang = KhachHangDAO.Instance.GetKhachHangByCMND(datvecmnd.Text);
                if(khachhang!=null)
                {
                    datvehovaten.Text = khachhang.Ten.Trim();
                    datvehovaten.Enabled = false;
                    datveSoDienThoai.Text = khachhang.SoDienThoai.Trim();
                }
            }
            else
            {
                datvehovaten.Enabled = true;
            }
        }
        private void datveSoDienThoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar!='+')
                e.Handled = true;

        }
        private void timkiemcmnd_TextChanged(object sender, EventArgs e)
        {
            if (timkiemcmnd.Text.Length < 9) timkiemdatvebtn.Enabled = false;
            else timkiemdatvebtn.Enabled = true;
        }
        private void timkiemcmnd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
            if (timkiemcmnd.Text.Length == 9 && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }
        #endregion
        #region TAB_quanlyve

        public void LoadListVe()
        {
            dgvquanlyve.Rows.Clear();   
            List<QuanLyVe> listve = QuanLyVeDAO.Instance.GetListVe();
            foreach(QuanLyVe item in listve)
            {
                KhachHang khachhang = KhachHangDAO.Instance.GetKhachHangByCMND(item.CMND);
                dgvquanlyve.Rows.Add(item.NgayBan, item.MaChuyenBay, khachhang.Ten, khachhang.CMND,khachhang.SoDienThoai, item.HangVe, item.GiaVe.ToString("###,### VND"));
            }
        }
        public void LoadListVeFilter()
        {
            dgvquanlyve.Rows.Clear();
            List<QuanLyVe> listve=new List<QuanLyVe>();
            switch (comboBox1.SelectedIndex)
            {
                case 1: listve = QuanLyVeDAO.Instance.GetListByNgayBanVe(quanlyvetimkiembox.Text);
                    break;
                case 2: listve = QuanLyVeDAO.Instance.GetListVeByThang(int.Parse(quanlyvetimkiembox.Text).ToString("00")+DateTime.Now.Year.ToString());
                    break;
                case 3: listve = QuanLyVeDAO.Instance.GetListVeByMaChuyenBay(quanlyvetimkiembox.Text);
                    break;
                case 4: listve = QuanLyVeDAO.Instance.GetListVeByCMND(quanlyvetimkiembox.Text);
                    break;
                default: listve = QuanLyVeDAO.Instance.GetListVe();
                    break;

            }
            foreach (QuanLyVe item in listve)
            {
                KhachHang khachhang = KhachHangDAO.Instance.GetKhachHangByCMND(item.CMND);
                dgvquanlyve.Rows.Add(item.NgayBan, item.MaChuyenBay, khachhang.Ten, khachhang.CMND,khachhang.SoDienThoai, item.HangVe, item.GiaVe.ToString("###,### VND"));
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                quanlyvetimkiembox.Enabled = false;
                quanlyvetimkiembox.Text = string.Empty;
            }
            else quanlyvetimkiembox.Enabled = true;
        }
        private void quanlyvebtntimkiem_Click(object sender, EventArgs e)
        {
            try
            {
                if (quanlyvetimkiembox.Enabled == false) LoadListVe();
                else if (quanlyvetimkiembox.Text != string.Empty) LoadListVeFilter();
            }
            catch
            {
                MessageBox.Show("Lỗi kết nối Database");
            }
        }
        private void quanlyvetimkiembox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                quanlyvebtntimkiem.PerformClick();
        }

        #endregion
        #region TAB_doanhthu
        public void LoadListDoanhThuThang()
        {
            dgvdoanhthuthang.Rows.Clear();
            long tongdoanhthu = 0;
            double tile = 0;
            List<ChuyenBay> listcb = new List<ChuyenBay>();
            listcb = ChuyenBayDAO.Instance.LoadListChuyenBayByThangNam(doanhthucomboboxthang.SelectedItem.ToString(),doanhthucomboboxnam.SelectedItem.ToString());
            foreach(ChuyenBay cb in listcb)
            {
                tongdoanhthu += DoanhThuThangDAO.Instance.DoanhThuChuyenBay(cb.MaChuyenBay.Trim());
                tile+= (double)(cb.SoLuongGheHang1DaDat + cb.SoLuongGheHang2DaDat) / (cb.SoLuongGheHang1 + cb.SoLuongGheHang2);
                dgvdoanhthuthang.Rows.Add(cb.MaChuyenBay, cb.SoLuongGheHang1DaDat + cb.SoLuongGheHang2DaDat, DoanhThuThangDAO.Instance.DoanhThuChuyenBay(cb.MaChuyenBay.Trim()).ToString("###,### VND"),((double) (cb.SoLuongGheHang1DaDat+cb.SoLuongGheHang2DaDat)/(cb.SoLuongGheHang1+cb.SoLuongGheHang2)).ToString("0.00"));
            }
            doanhthutongdoanhthu.Text = tongdoanhthu.ToString("###,### VND");
            try
            {
                tile = tile / dgvdoanhthuthang.RowCount;
            }
            catch
            {
                tile = 0;
            }
            
            DoanhThuThangDAO.Instance.UpdateDoanhThuThang(doanhthucomboboxthang.SelectedItem.ToString(), doanhthucomboboxnam.SelectedItem.ToString(),tongdoanhthu,tile,dgvdoanhthuthang.Rows.Count);
            //MessageBox.Show(doanhthucomboboxthang.SelectedItem.ToString() + doanhthucomboboxnam.SelectedItem.ToString() + "/");
        }

        private void doanhthuthangbtnkiemtra_Click(object sender, EventArgs e)
        {
            try
            {
                LoadListDoanhThuThang();
            }
            catch
            {
                MessageBox.Show("Lỗi kết nối Database");
            }
        }
        public void LoadListDoanhThuNam()
        {
            dgvdoanhthunam.Rows.Clear();
            int sochuyenbay = 0;
            double tile = 0;
            long tongdoanhthu = 0;
            List<DoanhThuThang> listdoanhthu = DoanhThuThangDAO.Instance.LoadListDoanhThuThang(doanhthunamnam.SelectedItem.ToString());
            foreach(DoanhThuThang doanhthu in listdoanhthu)
            {
                sochuyenbay += doanhthu.SoChuyenBay;
                tile += doanhthu.TiLe;
                tongdoanhthu += doanhthu.DoanhThu;
                dgvdoanhthunam.Rows.Add(doanhthu.MaDoanhThuThang.Replace(doanhthu.Nam, string.Empty), doanhthu.SoChuyenBay, doanhthu.DoanhThu.ToString("###,### VND"), doanhthu.TiLe);

            }
            dgvdoanhthunam.Rows.Add("Tông cộng", sochuyenbay, tongdoanhthu.ToString("###,### VND"), (double)tile / 12);

        }
        private void doanhthunambtnkiemtra_Click(object sender, EventArgs e)
        {
            try
            {
                LoadListDoanhThuNam();
            }
            catch
            {
                MessageBox.Show("Lỗi kết nối Database");
            }
        }
        #endregion

        
    }
}
