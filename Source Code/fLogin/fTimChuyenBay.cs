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
    public partial class fTimChuyenBay : Form
    {
        public fTimChuyenBay()
        {
            InitializeComponent();
        }
        public EventHandler wait;
        void LoadSanBay()
        {
            List<SanBay> sanbay = SanBayDAO.Instance.GetListSanBay();
            foreach(SanBay sb in sanbay)
            {
                sanbaydi.Items.Add(sb.TenSanBay);
                sanbayden.Items.Add(sb.TenSanBay);
            }
            sanbaydi.SelectedIndex = 0;
            sanbayden.SelectedIndex = 0;
            date.CustomFormat = "dd/MM/yyyy";
        }
        public string SBDEN { get; set; }
        public string SBDI { get; set; }
        public string DATE { get; set; }

        private void btnfind_Click(object sender, EventArgs e)
        {
            SBDEN = sanbayden.Text.Trim();
            SBDI = sanbaydi.Text.Trim();
            DATE = date.Value.ToString("dd/MM/yyyy");
            if (wait != null)
                wait(this, new EventArgs());
        }

        private void fTimChuyenBay_Load(object sender, EventArgs e)
        {
            LoadSanBay();
        }

        private void fTimChuyenBay_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
    }
}
