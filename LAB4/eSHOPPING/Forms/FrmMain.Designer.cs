namespace eSHOPPING.UI
{
    partial class FrmMain
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubTitle;
        private System.Windows.Forms.Button btnDangNhap;
        private System.Windows.Forms.Button btnSanPham;
        private System.Windows.Forms.Button btnChiTietSanPham;
        private System.Windows.Forms.Button btnThoat;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubTitle = new System.Windows.Forms.Label();

            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.btnSanPham = new System.Windows.Forms.Button();
            this.btnChiTietSanPham = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();

            this.pnlHeader.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            this.SuspendLayout();

            this.pnlHeader.BackColor =
                System.Drawing.Color.FromArgb(30, 41, 59);
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Controls.Add(this.lblSubTitle);
            this.pnlHeader.Dock =
                System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location =
                new System.Drawing.Point(0, 0);
            this.pnlHeader.Size =
                new System.Drawing.Size(900, 150);

            this.lblTitle.AutoSize = true;
            this.lblTitle.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    28F,
                    System.Drawing.FontStyle.Bold
                );
            this.lblTitle.ForeColor =
                System.Drawing.Color.White;
            this.lblTitle.Location =
                new System.Drawing.Point(40, 35);
            this.lblTitle.Text = "e-SHOPPING";

            this.lblSubTitle.AutoSize = true;
            this.lblSubTitle.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    11F
                );
            this.lblSubTitle.ForeColor =
                System.Drawing.Color.FromArgb(
                    203, 213, 225
                );
            this.lblSubTitle.Location =
                new System.Drawing.Point(45, 92);
            this.lblSubTitle.Text =
                "Hệ thống bán hàng trực tuyến";

            this.pnlMenu.BackColor =
                System.Drawing.Color.FromArgb(
                    248, 250, 252
                );
            this.pnlMenu.Controls.Add(this.btnDangNhap);
            this.pnlMenu.Controls.Add(this.btnSanPham);
            this.pnlMenu.Controls.Add(this.btnChiTietSanPham);
            this.pnlMenu.Controls.Add(this.btnThoat);
            this.pnlMenu.Dock =
                System.Windows.Forms.DockStyle.Fill;
            this.pnlMenu.Padding =
                new System.Windows.Forms.Padding(45);

            this.btnDangNhap.BackColor =
                System.Drawing.Color.FromArgb(
                    37, 99, 235
                );
            this.btnDangNhap.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;
            this.btnDangNhap.FlatAppearance.BorderSize = 0;
            this.btnDangNhap.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    11F,
                    System.Drawing.FontStyle.Bold
                );
            this.btnDangNhap.ForeColor =
                System.Drawing.Color.White;
            this.btnDangNhap.Location =
                new System.Drawing.Point(50, 45);
            this.btnDangNhap.Size =
                new System.Drawing.Size(350, 60);
            this.btnDangNhap.Text =
                "ĐĂNG NHẬP";
            this.btnDangNhap.Click +=
                new System.EventHandler(
                    this.btnDangNhap_Click
                );

            this.btnSanPham.BackColor =
                System.Drawing.Color.White;
            this.btnSanPham.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;
            this.btnSanPham.FlatAppearance.BorderColor =
                System.Drawing.Color.FromArgb(
                    203, 213, 225
                );
            this.btnSanPham.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    11F,
                    System.Drawing.FontStyle.Bold
                );
            this.btnSanPham.ForeColor =
                System.Drawing.Color.FromArgb(
                    30, 41, 59
                );
            this.btnSanPham.Location =
                new System.Drawing.Point(470, 45);
            this.btnSanPham.Size =
                new System.Drawing.Size(350, 60);
            this.btnSanPham.Text =
                "QUẢN LÝ SẢN PHẨM";
            this.btnSanPham.Click +=
                new System.EventHandler(
                    this.btnSanPham_Click
                );

            this.btnChiTietSanPham.BackColor =
                System.Drawing.Color.White;
            this.btnChiTietSanPham.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;
            this.btnChiTietSanPham.FlatAppearance.BorderColor =
                System.Drawing.Color.FromArgb(
                    203, 213, 225
                );
            this.btnChiTietSanPham.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    11F,
                    System.Drawing.FontStyle.Bold
                );
            this.btnChiTietSanPham.ForeColor =
                System.Drawing.Color.FromArgb(
                    30, 41, 59
                );
            this.btnChiTietSanPham.Location =
                new System.Drawing.Point(50, 135);
            this.btnChiTietSanPham.Size =
                new System.Drawing.Size(350, 60);
            this.btnChiTietSanPham.Text =
                "CHI TIẾT SẢN PHẨM";
            this.btnChiTietSanPham.Click +=
                new System.EventHandler(
                    this.btnChiTietSanPham_Click
                );

            this.btnThoat.BackColor =
                System.Drawing.Color.FromArgb(
                    220, 38, 38
                );
            this.btnThoat.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.FlatAppearance.BorderSize = 0;
            this.btnThoat.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    11F,
                    System.Drawing.FontStyle.Bold
                );
            this.btnThoat.ForeColor =
                System.Drawing.Color.White;
            this.btnThoat.Location =
                new System.Drawing.Point(470, 135);
            this.btnThoat.Size =
                new System.Drawing.Size(350, 60);
            this.btnThoat.Text =
                "THOÁT";
            this.btnThoat.Click +=
                new System.EventHandler(
                    this.btnThoat_Click
                );

            this.ClientSize =
                new System.Drawing.Size(900, 420);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.pnlHeader);

            this.FormBorderStyle =
                System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.StartPosition =
                System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text =
                "e-SHOPPING - Trang chính";

            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlMenu.ResumeLayout(false);
            this.ResumeLayout(false);
        }
    }
}