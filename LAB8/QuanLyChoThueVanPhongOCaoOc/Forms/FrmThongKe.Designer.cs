
namespace QuanLyChoThueVanPhong.Forms
{
    partial class FrmThongKe
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.Label lblChonNam;
        private System.Windows.Forms.Label lblTieuDeSoTang;
        private System.Windows.Forms.Label lblTieuDeSoVanPhong;
        private System.Windows.Forms.Label lblTieuDeSoKhachHang;
        private System.Windows.Forms.Label lblTieuDeSoHopDong;
        private System.Windows.Forms.Label lblTieuDeSoNhanVien;
        private System.Windows.Forms.Label lblTieuDeSoTheXe;
        private System.Windows.Forms.Label lblTieuDeDoanhThuThue;
        private System.Windows.Forms.Label lblTieuDeDoanhThuDichVu;
        private System.Windows.Forms.Label lblTieuDeTongDoanhThu;
        private System.Windows.Forms.Label lblTieuDeNoTienThue;
        private System.Windows.Forms.Label lblTieuDeNoDichVu;
        private System.Windows.Forms.Label lblTieuDeTongCongNo;
        private System.Windows.Forms.Label lblTieuDeTienXuPhat;

        private System.Windows.Forms.Label lblSoTang;
        private System.Windows.Forms.Label lblSoVanPhong;
        private System.Windows.Forms.Label lblSoKhachHang;
        private System.Windows.Forms.Label lblSoHopDong;
        private System.Windows.Forms.Label lblSoNhanVien;
        private System.Windows.Forms.Label lblSoTheXe;
        private System.Windows.Forms.Label lblDoanhThuThue;
        private System.Windows.Forms.Label lblDoanhThuDichVu;
        private System.Windows.Forms.Label lblTongDoanhThu;
        private System.Windows.Forms.Label lblNoTienThue;
        private System.Windows.Forms.Label lblNoDichVu;
        private System.Windows.Forms.Label lblTongCongNo;
        private System.Windows.Forms.Label lblTienXuPhat;

        private System.Windows.Forms.GroupBox grpTongQuan;
        private System.Windows.Forms.GroupBox grpTaiChinh;
        private System.Windows.Forms.TabControl tabThongKe;
        private System.Windows.Forms.TabPage tabDoanhThu;
        private System.Windows.Forms.TabPage tabVanPhong;
        private System.Windows.Forms.TabPage tabCongNo;

        private System.Windows.Forms.NumericUpDown nudNam;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.DataGridView dgvDoanhThu;
        private System.Windows.Forms.DataGridView dgvVanPhong;
        private System.Windows.Forms.DataGridView dgvCongNo;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.lblChonNam = new System.Windows.Forms.Label();
            this.lblTieuDeSoTang = new System.Windows.Forms.Label();
            this.lblTieuDeSoVanPhong = new System.Windows.Forms.Label();
            this.lblTieuDeSoKhachHang = new System.Windows.Forms.Label();
            this.lblTieuDeSoHopDong = new System.Windows.Forms.Label();
            this.lblTieuDeSoNhanVien = new System.Windows.Forms.Label();
            this.lblTieuDeSoTheXe = new System.Windows.Forms.Label();
            this.lblTieuDeDoanhThuThue = new System.Windows.Forms.Label();
            this.lblTieuDeDoanhThuDichVu = new System.Windows.Forms.Label();
            this.lblTieuDeTongDoanhThu = new System.Windows.Forms.Label();
            this.lblTieuDeNoTienThue = new System.Windows.Forms.Label();
            this.lblTieuDeNoDichVu = new System.Windows.Forms.Label();
            this.lblTieuDeTongCongNo = new System.Windows.Forms.Label();
            this.lblTieuDeTienXuPhat = new System.Windows.Forms.Label();
            this.lblSoTang = new System.Windows.Forms.Label();
            this.lblSoVanPhong = new System.Windows.Forms.Label();
            this.lblSoKhachHang = new System.Windows.Forms.Label();
            this.lblSoHopDong = new System.Windows.Forms.Label();
            this.lblSoNhanVien = new System.Windows.Forms.Label();
            this.lblSoTheXe = new System.Windows.Forms.Label();
            this.lblDoanhThuThue = new System.Windows.Forms.Label();
            this.lblDoanhThuDichVu = new System.Windows.Forms.Label();
            this.lblTongDoanhThu = new System.Windows.Forms.Label();
            this.lblNoTienThue = new System.Windows.Forms.Label();
            this.lblNoDichVu = new System.Windows.Forms.Label();
            this.lblTongCongNo = new System.Windows.Forms.Label();
            this.lblTienXuPhat = new System.Windows.Forms.Label();
            this.grpTongQuan = new System.Windows.Forms.GroupBox();
            this.grpTaiChinh = new System.Windows.Forms.GroupBox();
            this.tabThongKe = new System.Windows.Forms.TabControl();
            this.tabDoanhThu = new System.Windows.Forms.TabPage();
            this.dgvDoanhThu = new System.Windows.Forms.DataGridView();
            this.tabVanPhong = new System.Windows.Forms.TabPage();
            this.dgvVanPhong = new System.Windows.Forms.DataGridView();
            this.tabCongNo = new System.Windows.Forms.TabPage();
            this.dgvCongNo = new System.Windows.Forms.DataGridView();
            this.nudNam = new System.Windows.Forms.NumericUpDown();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.grpTongQuan.SuspendLayout();
            this.grpTaiChinh.SuspendLayout();
            this.tabThongKe.SuspendLayout();
            this.tabDoanhThu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoanhThu)).BeginInit();
            this.tabVanPhong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVanPhong)).BeginInit();
            this.tabCongNo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCongNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNam)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.AutoSize = true;
            this.lblTieuDe.Font = new System.Drawing.Font("Segoe UI", 19F, System.Drawing.FontStyle.Bold);
            this.lblTieuDe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(72)))), ((int)(((byte)(105)))));
            this.lblTieuDe.Location = new System.Drawing.Point(420, 15);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(498, 61);
            this.lblTieuDe.TabIndex = 0;
            this.lblTieuDe.Text = "THỐNG KÊ HỆ THỐNG";
            // 
            // lblChonNam
            // 
            this.lblChonNam.AutoSize = true;
            this.lblChonNam.Location = new System.Drawing.Point(35, 83);
            this.lblChonNam.Name = "lblChonNam";
            this.lblChonNam.Size = new System.Drawing.Size(151, 30);
            this.lblChonNam.TabIndex = 1;
            this.lblChonNam.Text = "Năm thống kê:";
            // 
            // lblTieuDeSoTang
            // 
            this.lblTieuDeSoTang.AutoSize = true;
            this.lblTieuDeSoTang.Location = new System.Drawing.Point(30, 40);
            this.lblTieuDeSoTang.Name = "lblTieuDeSoTang";
            this.lblTieuDeSoTang.Size = new System.Drawing.Size(108, 32);
            this.lblTieuDeSoTang.TabIndex = 0;
            this.lblTieuDeSoTang.Text = "Số tầng:";
            // 
            // lblTieuDeSoVanPhong
            // 
            this.lblTieuDeSoVanPhong.AutoSize = true;
            this.lblTieuDeSoVanPhong.Location = new System.Drawing.Point(400, 40);
            this.lblTieuDeSoVanPhong.Name = "lblTieuDeSoVanPhong";
            this.lblTieuDeSoVanPhong.Size = new System.Drawing.Size(178, 32);
            this.lblTieuDeSoVanPhong.TabIndex = 1;
            this.lblTieuDeSoVanPhong.Text = "Số văn phòng:";
            // 
            // lblTieuDeSoKhachHang
            // 
            this.lblTieuDeSoKhachHang.AutoSize = true;
            this.lblTieuDeSoKhachHang.Location = new System.Drawing.Point(780, 40);
            this.lblTieuDeSoKhachHang.Name = "lblTieuDeSoKhachHang";
            this.lblTieuDeSoKhachHang.Size = new System.Drawing.Size(154, 32);
            this.lblTieuDeSoKhachHang.TabIndex = 2;
            this.lblTieuDeSoKhachHang.Text = "Khách hàng:";
            // 
            // lblTieuDeSoHopDong
            // 
            this.lblTieuDeSoHopDong.AutoSize = true;
            this.lblTieuDeSoHopDong.Location = new System.Drawing.Point(30, 95);
            this.lblTieuDeSoHopDong.Name = "lblTieuDeSoHopDong";
            this.lblTieuDeSoHopDong.Size = new System.Drawing.Size(136, 32);
            this.lblTieuDeSoHopDong.TabIndex = 3;
            this.lblTieuDeSoHopDong.Text = "Hợp đồng:";
            // 
            // lblTieuDeSoNhanVien
            // 
            this.lblTieuDeSoNhanVien.AutoSize = true;
            this.lblTieuDeSoNhanVien.Location = new System.Drawing.Point(400, 95);
            this.lblTieuDeSoNhanVien.Name = "lblTieuDeSoNhanVien";
            this.lblTieuDeSoNhanVien.Size = new System.Drawing.Size(137, 32);
            this.lblTieuDeSoNhanVien.TabIndex = 4;
            this.lblTieuDeSoNhanVien.Text = "Nhân viên:";
            // 
            // lblTieuDeSoTheXe
            // 
            this.lblTieuDeSoTheXe.AutoSize = true;
            this.lblTieuDeSoTheXe.Location = new System.Drawing.Point(780, 95);
            this.lblTieuDeSoTheXe.Name = "lblTieuDeSoTheXe";
            this.lblTieuDeSoTheXe.Size = new System.Drawing.Size(140, 32);
            this.lblTieuDeSoTheXe.TabIndex = 5;
            this.lblTieuDeSoTheXe.Text = "Thẻ giữ xe:";
            // 
            // lblTieuDeDoanhThuThue
            // 
            this.lblTieuDeDoanhThuThue.AutoSize = true;
            this.lblTieuDeDoanhThuThue.Location = new System.Drawing.Point(30, 40);
            this.lblTieuDeDoanhThuThue.Name = "lblTieuDeDoanhThuThue";
            this.lblTieuDeDoanhThuThue.Size = new System.Drawing.Size(199, 32);
            this.lblTieuDeDoanhThuThue.TabIndex = 0;
            this.lblTieuDeDoanhThuThue.Text = "Doanh thu thuê:";
            // 
            // lblTieuDeDoanhThuDichVu
            // 
            this.lblTieuDeDoanhThuDichVu.AutoSize = true;
            this.lblTieuDeDoanhThuDichVu.Location = new System.Drawing.Point(580, 40);
            this.lblTieuDeDoanhThuDichVu.Name = "lblTieuDeDoanhThuDichVu";
            this.lblTieuDeDoanhThuDichVu.Size = new System.Drawing.Size(231, 32);
            this.lblTieuDeDoanhThuDichVu.TabIndex = 1;
            this.lblTieuDeDoanhThuDichVu.Text = "Doanh thu dịch vụ:";
            // 
            // lblTieuDeTongDoanhThu
            // 
            this.lblTieuDeTongDoanhThu.AutoSize = true;
            this.lblTieuDeTongDoanhThu.Location = new System.Drawing.Point(30, 85);
            this.lblTieuDeTongDoanhThu.Name = "lblTieuDeTongDoanhThu";
            this.lblTieuDeTongDoanhThu.Size = new System.Drawing.Size(204, 32);
            this.lblTieuDeTongDoanhThu.TabIndex = 2;
            this.lblTieuDeTongDoanhThu.Text = "Tổng doanh thu:";
            // 
            // lblTieuDeNoTienThue
            // 
            this.lblTieuDeNoTienThue.AutoSize = true;
            this.lblTieuDeNoTienThue.Location = new System.Drawing.Point(580, 85);
            this.lblTieuDeNoTienThue.Name = "lblTieuDeNoTienThue";
            this.lblTieuDeNoTienThue.Size = new System.Drawing.Size(256, 32);
            this.lblTieuDeNoTienThue.TabIndex = 3;
            this.lblTieuDeNoTienThue.Text = "Nợ tiền thuê hiện tại:";
            // 
            // lblTieuDeNoDichVu
            // 
            this.lblTieuDeNoDichVu.AutoSize = true;
            this.lblTieuDeNoDichVu.Location = new System.Drawing.Point(30, 130);
            this.lblTieuDeNoDichVu.Name = "lblTieuDeNoDichVu";
            this.lblTieuDeNoDichVu.Size = new System.Drawing.Size(237, 32);
            this.lblTieuDeNoDichVu.TabIndex = 4;
            this.lblTieuDeNoDichVu.Text = "Nợ dịch vụ hiện tại:";
            // 
            // lblTieuDeTongCongNo
            // 
            this.lblTieuDeTongCongNo.AutoSize = true;
            this.lblTieuDeTongCongNo.Location = new System.Drawing.Point(566, 130);
            this.lblTieuDeTongCongNo.Name = "lblTieuDeTongCongNo";
            this.lblTieuDeTongCongNo.Size = new System.Drawing.Size(273, 32);
            this.lblTieuDeTongCongNo.TabIndex = 5;
            this.lblTieuDeTongCongNo.Text = "Tổng công nợ hiện tại:";
            // 
            // lblTieuDeTienXuPhat
            // 
            this.lblTieuDeTienXuPhat.AutoSize = true;
            this.lblTieuDeTienXuPhat.Location = new System.Drawing.Point(30, 175);
            this.lblTieuDeTienXuPhat.Name = "lblTieuDeTienXuPhat";
            this.lblTieuDeTienXuPhat.Size = new System.Drawing.Size(205, 32);
            this.lblTieuDeTienXuPhat.TabIndex = 6;
            this.lblTieuDeTienXuPhat.Text = "Tiền phạt đã lập:";
            // 
            // lblSoTang
            // 
            this.lblSoTang.AutoSize = true;
            this.lblSoTang.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblSoTang.Location = new System.Drawing.Point(175, 37);
            this.lblSoTang.Name = "lblSoTang";
            this.lblSoTang.Size = new System.Drawing.Size(33, 38);
            this.lblSoTang.TabIndex = 6;
            this.lblSoTang.Text = "0";
            // 
            // lblSoVanPhong
            // 
            this.lblSoVanPhong.AutoSize = true;
            this.lblSoVanPhong.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblSoVanPhong.Location = new System.Drawing.Point(584, 37);
            this.lblSoVanPhong.Name = "lblSoVanPhong";
            this.lblSoVanPhong.Size = new System.Drawing.Size(33, 38);
            this.lblSoVanPhong.TabIndex = 7;
            this.lblSoVanPhong.Text = "0";
            // 
            // lblSoKhachHang
            // 
            this.lblSoKhachHang.AutoSize = true;
            this.lblSoKhachHang.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblSoKhachHang.Location = new System.Drawing.Point(960, 37);
            this.lblSoKhachHang.Name = "lblSoKhachHang";
            this.lblSoKhachHang.Size = new System.Drawing.Size(33, 38);
            this.lblSoKhachHang.TabIndex = 8;
            this.lblSoKhachHang.Text = "0";
            // 
            // lblSoHopDong
            // 
            this.lblSoHopDong.AutoSize = true;
            this.lblSoHopDong.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblSoHopDong.Location = new System.Drawing.Point(175, 92);
            this.lblSoHopDong.Name = "lblSoHopDong";
            this.lblSoHopDong.Size = new System.Drawing.Size(33, 38);
            this.lblSoHopDong.TabIndex = 9;
            this.lblSoHopDong.Text = "0";
            // 
            // lblSoNhanVien
            // 
            this.lblSoNhanVien.AutoSize = true;
            this.lblSoNhanVien.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblSoNhanVien.Location = new System.Drawing.Point(565, 92);
            this.lblSoNhanVien.Name = "lblSoNhanVien";
            this.lblSoNhanVien.Size = new System.Drawing.Size(33, 38);
            this.lblSoNhanVien.TabIndex = 10;
            this.lblSoNhanVien.Text = "0";
            // 
            // lblSoTheXe
            // 
            this.lblSoTheXe.AutoSize = true;
            this.lblSoTheXe.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblSoTheXe.Location = new System.Drawing.Point(960, 92);
            this.lblSoTheXe.Name = "lblSoTheXe";
            this.lblSoTheXe.Size = new System.Drawing.Size(33, 38);
            this.lblSoTheXe.TabIndex = 11;
            this.lblSoTheXe.Text = "0";
            // 
            // lblDoanhThuThue
            // 
            this.lblDoanhThuThue.AutoSize = true;
            this.lblDoanhThuThue.Location = new System.Drawing.Point(240, 40);
            this.lblDoanhThuThue.Name = "lblDoanhThuThue";
            this.lblDoanhThuThue.Size = new System.Drawing.Size(88, 32);
            this.lblDoanhThuThue.TabIndex = 7;
            this.lblDoanhThuThue.Text = "0 VNĐ";
            // 
            // lblDoanhThuDichVu
            // 
            this.lblDoanhThuDichVu.AutoSize = true;
            this.lblDoanhThuDichVu.Location = new System.Drawing.Point(817, 40);
            this.lblDoanhThuDichVu.Name = "lblDoanhThuDichVu";
            this.lblDoanhThuDichVu.Size = new System.Drawing.Size(88, 32);
            this.lblDoanhThuDichVu.TabIndex = 8;
            this.lblDoanhThuDichVu.Text = "0 VNĐ";
            this.lblDoanhThuDichVu.Click += new System.EventHandler(this.lblDoanhThuDichVu_Click);
            // 
            // lblTongDoanhThu
            // 
            this.lblTongDoanhThu.AutoSize = true;
            this.lblTongDoanhThu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(125)))), ((int)(((byte)(78)))));
            this.lblTongDoanhThu.Location = new System.Drawing.Point(240, 85);
            this.lblTongDoanhThu.Name = "lblTongDoanhThu";
            this.lblTongDoanhThu.Size = new System.Drawing.Size(88, 32);
            this.lblTongDoanhThu.TabIndex = 9;
            this.lblTongDoanhThu.Text = "0 VNĐ";
            // 
            // lblNoTienThue
            // 
            this.lblNoTienThue.AutoSize = true;
            this.lblNoTienThue.Location = new System.Drawing.Point(832, 85);
            this.lblNoTienThue.Name = "lblNoTienThue";
            this.lblNoTienThue.Size = new System.Drawing.Size(88, 32);
            this.lblNoTienThue.TabIndex = 10;
            this.lblNoTienThue.Text = "0 VNĐ";
            // 
            // lblNoDichVu
            // 
            this.lblNoDichVu.AutoSize = true;
            this.lblNoDichVu.Location = new System.Drawing.Point(273, 130);
            this.lblNoDichVu.Name = "lblNoDichVu";
            this.lblNoDichVu.Size = new System.Drawing.Size(88, 32);
            this.lblNoDichVu.TabIndex = 11;
            this.lblNoDichVu.Text = "0 VNĐ";
            this.lblNoDichVu.Click += new System.EventHandler(this.lblNoDichVu_Click);
            // 
            // lblTongCongNo
            // 
            this.lblTongCongNo.AutoSize = true;
            this.lblTongCongNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.lblTongCongNo.Location = new System.Drawing.Point(845, 130);
            this.lblTongCongNo.Name = "lblTongCongNo";
            this.lblTongCongNo.Size = new System.Drawing.Size(88, 32);
            this.lblTongCongNo.TabIndex = 12;
            this.lblTongCongNo.Text = "0 VNĐ";
            this.lblTongCongNo.Click += new System.EventHandler(this.lblTongCongNo_Click);
            // 
            // lblTienXuPhat
            // 
            this.lblTienXuPhat.AutoSize = true;
            this.lblTienXuPhat.Location = new System.Drawing.Point(252, 175);
            this.lblTienXuPhat.Name = "lblTienXuPhat";
            this.lblTienXuPhat.Size = new System.Drawing.Size(88, 32);
            this.lblTienXuPhat.TabIndex = 13;
            this.lblTienXuPhat.Text = "0 VNĐ";
            // 
            // grpTongQuan
            // 
            this.grpTongQuan.Controls.Add(this.lblTieuDeSoTang);
            this.grpTongQuan.Controls.Add(this.lblTieuDeSoVanPhong);
            this.grpTongQuan.Controls.Add(this.lblTieuDeSoKhachHang);
            this.grpTongQuan.Controls.Add(this.lblTieuDeSoHopDong);
            this.grpTongQuan.Controls.Add(this.lblTieuDeSoNhanVien);
            this.grpTongQuan.Controls.Add(this.lblTieuDeSoTheXe);
            this.grpTongQuan.Controls.Add(this.lblSoTang);
            this.grpTongQuan.Controls.Add(this.lblSoVanPhong);
            this.grpTongQuan.Controls.Add(this.lblSoKhachHang);
            this.grpTongQuan.Controls.Add(this.lblSoHopDong);
            this.grpTongQuan.Controls.Add(this.lblSoNhanVien);
            this.grpTongQuan.Controls.Add(this.lblSoTheXe);
            this.grpTongQuan.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpTongQuan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(72)))), ((int)(((byte)(105)))));
            this.grpTongQuan.Location = new System.Drawing.Point(25, 130);
            this.grpTongQuan.Name = "grpTongQuan";
            this.grpTongQuan.Size = new System.Drawing.Size(1150, 155);
            this.grpTongQuan.TabIndex = 6;
            this.grpTongQuan.TabStop = false;
            this.grpTongQuan.Text = "THỐNG KÊ TỔNG QUAN";
            // 
            // grpTaiChinh
            // 
            this.grpTaiChinh.Controls.Add(this.lblTieuDeDoanhThuThue);
            this.grpTaiChinh.Controls.Add(this.lblTieuDeDoanhThuDichVu);
            this.grpTaiChinh.Controls.Add(this.lblTieuDeTongDoanhThu);
            this.grpTaiChinh.Controls.Add(this.lblTieuDeNoTienThue);
            this.grpTaiChinh.Controls.Add(this.lblTieuDeNoDichVu);
            this.grpTaiChinh.Controls.Add(this.lblTieuDeTongCongNo);
            this.grpTaiChinh.Controls.Add(this.lblTieuDeTienXuPhat);
            this.grpTaiChinh.Controls.Add(this.lblDoanhThuThue);
            this.grpTaiChinh.Controls.Add(this.lblDoanhThuDichVu);
            this.grpTaiChinh.Controls.Add(this.lblTongDoanhThu);
            this.grpTaiChinh.Controls.Add(this.lblNoTienThue);
            this.grpTaiChinh.Controls.Add(this.lblNoDichVu);
            this.grpTaiChinh.Controls.Add(this.lblTongCongNo);
            this.grpTaiChinh.Controls.Add(this.lblTienXuPhat);
            this.grpTaiChinh.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpTaiChinh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(72)))), ((int)(((byte)(105)))));
            this.grpTaiChinh.Location = new System.Drawing.Point(25, 300);
            this.grpTaiChinh.Name = "grpTaiChinh";
            this.grpTaiChinh.Size = new System.Drawing.Size(1150, 235);
            this.grpTaiChinh.TabIndex = 7;
            this.grpTaiChinh.TabStop = false;
            this.grpTaiChinh.Text = "THỐNG KÊ TÀI CHÍNH";
            // 
            // tabThongKe
            // 
            this.tabThongKe.Controls.Add(this.tabDoanhThu);
            this.tabThongKe.Controls.Add(this.tabVanPhong);
            this.tabThongKe.Controls.Add(this.tabCongNo);
            this.tabThongKe.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tabThongKe.Location = new System.Drawing.Point(25, 555);
            this.tabThongKe.Name = "tabThongKe";
            this.tabThongKe.SelectedIndex = 0;
            this.tabThongKe.Size = new System.Drawing.Size(1150, 310);
            this.tabThongKe.TabIndex = 8;
            // 
            // tabDoanhThu
            // 
            this.tabDoanhThu.Controls.Add(this.dgvDoanhThu);
            this.tabDoanhThu.Location = new System.Drawing.Point(4, 40);
            this.tabDoanhThu.Name = "tabDoanhThu";
            this.tabDoanhThu.Padding = new System.Windows.Forms.Padding(3);
            this.tabDoanhThu.Size = new System.Drawing.Size(1142, 266);
            this.tabDoanhThu.TabIndex = 0;
            this.tabDoanhThu.Text = "Doanh thu theo tháng";
            this.tabDoanhThu.UseVisualStyleBackColor = true;
            // 
            // dgvDoanhThu
            // 
            this.dgvDoanhThu.AllowUserToAddRows = false;
            this.dgvDoanhThu.AllowUserToDeleteRows = false;
            this.dgvDoanhThu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDoanhThu.BackgroundColor = System.Drawing.Color.White;
            this.dgvDoanhThu.ColumnHeadersHeight = 40;
            this.dgvDoanhThu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDoanhThu.Location = new System.Drawing.Point(3, 3);
            this.dgvDoanhThu.Name = "dgvDoanhThu";
            this.dgvDoanhThu.ReadOnly = true;
            this.dgvDoanhThu.RowHeadersVisible = false;
            this.dgvDoanhThu.RowHeadersWidth = 72;
            this.dgvDoanhThu.Size = new System.Drawing.Size(1136, 260);
            this.dgvDoanhThu.TabIndex = 0;
            // 
            // tabVanPhong
            // 
            this.tabVanPhong.Controls.Add(this.dgvVanPhong);
            this.tabVanPhong.Location = new System.Drawing.Point(4, 40);
            this.tabVanPhong.Name = "tabVanPhong";
            this.tabVanPhong.Padding = new System.Windows.Forms.Padding(3);
            this.tabVanPhong.Size = new System.Drawing.Size(1142, 266);
            this.tabVanPhong.TabIndex = 1;
            this.tabVanPhong.Text = "Tình trạng văn phòng";
            this.tabVanPhong.UseVisualStyleBackColor = true;
            // 
            // dgvVanPhong
            // 
            this.dgvVanPhong.AllowUserToAddRows = false;
            this.dgvVanPhong.AllowUserToDeleteRows = false;
            this.dgvVanPhong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVanPhong.BackgroundColor = System.Drawing.Color.White;
            this.dgvVanPhong.ColumnHeadersHeight = 40;
            this.dgvVanPhong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvVanPhong.Location = new System.Drawing.Point(3, 3);
            this.dgvVanPhong.Name = "dgvVanPhong";
            this.dgvVanPhong.ReadOnly = true;
            this.dgvVanPhong.RowHeadersVisible = false;
            this.dgvVanPhong.RowHeadersWidth = 72;
            this.dgvVanPhong.Size = new System.Drawing.Size(1136, 260);
            this.dgvVanPhong.TabIndex = 0;
            // 
            // tabCongNo
            // 
            this.tabCongNo.Controls.Add(this.dgvCongNo);
            this.tabCongNo.Location = new System.Drawing.Point(4, 40);
            this.tabCongNo.Name = "tabCongNo";
            this.tabCongNo.Padding = new System.Windows.Forms.Padding(3);
            this.tabCongNo.Size = new System.Drawing.Size(1142, 266);
            this.tabCongNo.TabIndex = 2;
            this.tabCongNo.Text = "Công nợ theo hợp đồng";
            this.tabCongNo.UseVisualStyleBackColor = true;
            // 
            // dgvCongNo
            // 
            this.dgvCongNo.AllowUserToAddRows = false;
            this.dgvCongNo.AllowUserToDeleteRows = false;
            this.dgvCongNo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCongNo.BackgroundColor = System.Drawing.Color.White;
            this.dgvCongNo.ColumnHeadersHeight = 40;
            this.dgvCongNo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCongNo.Location = new System.Drawing.Point(3, 3);
            this.dgvCongNo.Name = "dgvCongNo";
            this.dgvCongNo.ReadOnly = true;
            this.dgvCongNo.RowHeadersVisible = false;
            this.dgvCongNo.RowHeadersWidth = 72;
            this.dgvCongNo.Size = new System.Drawing.Size(1136, 260);
            this.dgvCongNo.TabIndex = 0;
            // 
            // nudNam
            // 
            this.nudNam.Location = new System.Drawing.Point(192, 81);
            this.nudNam.Maximum = new decimal(new int[] {
            9998,
            0,
            0,
            0});
            this.nudNam.Minimum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.nudNam.Name = "nudNam";
            this.nudNam.Size = new System.Drawing.Size(127, 35);
            this.nudNam.TabIndex = 2;
            this.nudNam.Value = new decimal(new int[] {
            2026,
            0,
            0,
            0});
            // 
            // btnThongKe
            // 
            this.btnThongKe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(106)))), ((int)(((byte)(166)))));
            this.btnThongKe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThongKe.ForeColor = System.Drawing.Color.White;
            this.btnThongKe.Location = new System.Drawing.Point(350, 73);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(160, 38);
            this.btnThongKe.TabIndex = 3;
            this.btnThongKe.Text = "XEM THỐNG KÊ";
            this.btnThongKe.UseVisualStyleBackColor = false;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(110)))), ((int)(((byte)(120)))));
            this.btnLamMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLamMoi.ForeColor = System.Drawing.Color.White;
            this.btnLamMoi.Location = new System.Drawing.Point(530, 73);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(145, 38);
            this.btnLamMoi.TabIndex = 4;
            this.btnLamMoi.Text = "LÀM MỚI";
            this.btnLamMoi.UseVisualStyleBackColor = false;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnDong
            // 
            this.btnDong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.btnDong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDong.ForeColor = System.Drawing.Color.White;
            this.btnDong.Location = new System.Drawing.Point(1010, 73);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(145, 38);
            this.btnDong.TabIndex = 5;
            this.btnDong.Text = "ĐÓNG";
            this.btnDong.UseVisualStyleBackColor = false;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // FrmThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(249)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(1200, 890);
            this.Controls.Add(this.lblTieuDe);
            this.Controls.Add(this.lblChonNam);
            this.Controls.Add(this.nudNam);
            this.Controls.Add(this.btnThongKe);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.grpTongQuan);
            this.Controls.Add(this.grpTaiChinh);
            this.Controls.Add(this.tabThongKe);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Name = "FrmThongKe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Thống kê quản lý cho thuê văn phòng";
            this.Load += new System.EventHandler(this.FrmThongKe_Load);
            this.grpTongQuan.ResumeLayout(false);
            this.grpTongQuan.PerformLayout();
            this.grpTaiChinh.ResumeLayout(false);
            this.grpTaiChinh.PerformLayout();
            this.tabThongKe.ResumeLayout(false);
            this.tabDoanhThu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoanhThu)).EndInit();
            this.tabVanPhong.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVanPhong)).EndInit();
            this.tabCongNo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCongNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNam)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
