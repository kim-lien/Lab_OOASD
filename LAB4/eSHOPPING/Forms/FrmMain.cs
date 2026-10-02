using System;
using System.Windows.Forms;

namespace eSHOPPING.UI
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            using (var form = new FrmDangNhap())
            {
                form.ShowDialog(this);
            }
        }

        private void btnSanPham_Click(object sender, EventArgs e)
        {
            var form = new FrmSanPham();
            form.ShowDialog(this);
        }

        private void btnChiTietSanPham_Click(object sender, EventArgs e)
        {
            var form = new FrmChiTietSanPham();
            form.ShowDialog(this);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}