
namespace QuanLyChoThueVanPhong.Forms
{
    partial class FrmHopDong
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.GroupBox grpThongTin;
        private System.Windows.Forms.GroupBox grpVanPhong;
        private System.Windows.Forms.GroupBox grpHopDong;
        private System.Windows.Forms.Label lblMaHD;
        private System.Windows.Forms.Label lblKhachHang;
        private System.Windows.Forms.Label lblNgayKy;
        private System.Windows.Forms.Label lblNgayBatDau;
        private System.Windows.Forms.Label lblThoiHan;
        private System.Windows.Forms.Label lblTongTienTieuDe;
        private System.Windows.Forms.Label lblTraTruocTieuDe;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.Label lblTraTruoc;
        private System.Windows.Forms.Label lblTimKiem;
        private System.Windows.Forms.TextBox txtMaHD;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.ComboBox cboKhachHang;
        private System.Windows.Forms.DateTimePicker dtNgayKy;
        private System.Windows.Forms.DateTimePicker dtNgayBatDau;
        private System.Windows.Forms.NumericUpDown nudThoiHan;
        private System.Windows.Forms.Button btnLapHopDong;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.DataGridView dgvVanPhong;
        private System.Windows.Forms.DataGridView dgvHopDong;
        private System.Windows.Forms.DataGridView dgvChiTiet;
        private System.Windows.Forms.DataGridView dgvKyThanhToan;
        private System.Windows.Forms.TabControl tabChiTiet;
        private System.Windows.Forms.TabPage tabPhong;
        private System.Windows.Forms.TabPage tabKy;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.grpThongTin = new System.Windows.Forms.GroupBox();
            this.lblMaHD = new System.Windows.Forms.Label();
            this.lblKhachHang = new System.Windows.Forms.Label();
            this.lblNgayKy = new System.Windows.Forms.Label();
            this.lblNgayBatDau = new System.Windows.Forms.Label();
            this.lblThoiHan = new System.Windows.Forms.Label();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.cboKhachHang = new System.Windows.Forms.ComboBox();
            this.dtNgayKy = new System.Windows.Forms.DateTimePicker();
            this.dtNgayBatDau = new System.Windows.Forms.DateTimePicker();
            this.nudThoiHan = new System.Windows.Forms.NumericUpDown();
            this.grpVanPhong = new System.Windows.Forms.GroupBox();
            this.dgvVanPhong = new System.Windows.Forms.DataGridView();
            this.lblTongTienTieuDe = new System.Windows.Forms.Label();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.lblTraTruocTieuDe = new System.Windows.Forms.Label();
            this.lblTraTruoc = new System.Windows.Forms.Label();
            this.grpHopDong = new System.Windows.Forms.GroupBox();
            this.lblTimKiem = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.dgvHopDong = new System.Windows.Forms.DataGridView();
            this.tabChiTiet = new System.Windows.Forms.TabControl();
            this.tabPhong = new System.Windows.Forms.TabPage();
            this.dgvChiTiet = new System.Windows.Forms.DataGridView();
            this.tabKy = new System.Windows.Forms.TabPage();
            this.dgvKyThanhToan = new System.Windows.Forms.DataGridView();
            this.btnLapHopDong = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.grpThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudThoiHan)).BeginInit();
            this.grpVanPhong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVanPhong)).BeginInit();
            this.grpHopDong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHopDong)).BeginInit();
            this.tabChiTiet.SuspendLayout();
            this.tabPhong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTiet)).BeginInit();
            this.tabKy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKyThanhToan)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.AutoSize = true;
            this.lblTieuDe.Font = new System.Drawing.Font("Segoe UI", 19F, System.Drawing.FontStyle.Bold);
            this.lblTieuDe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(72)))), ((int)(((byte)(105)))));
            this.lblTieuDe.Location = new System.Drawing.Point(400, 12);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(607, 61);
            this.lblTieuDe.TabIndex = 0;
            this.lblTieuDe.Text = "QUẢN LÝ HỢP ĐỒNG THUÊ";
            // 
            // grpThongTin
            // 
            this.grpThongTin.Controls.Add(this.lblMaHD);
            this.grpThongTin.Controls.Add(this.lblKhachHang);
            this.grpThongTin.Controls.Add(this.lblNgayKy);
            this.grpThongTin.Controls.Add(this.lblNgayBatDau);
            this.grpThongTin.Controls.Add(this.lblThoiHan);
            this.grpThongTin.Controls.Add(this.txtMaHD);
            this.grpThongTin.Controls.Add(this.cboKhachHang);
            this.grpThongTin.Controls.Add(this.dtNgayKy);
            this.grpThongTin.Controls.Add(this.dtNgayBatDau);
            this.grpThongTin.Controls.Add(this.nudThoiHan);
            this.grpThongTin.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpThongTin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(72)))), ((int)(((byte)(105)))));
            this.grpThongTin.Location = new System.Drawing.Point(20, 65);
            this.grpThongTin.Name = "grpThongTin";
            this.grpThongTin.Size = new System.Drawing.Size(1160, 135);
            this.grpThongTin.TabIndex = 1;
            this.grpThongTin.TabStop = false;
            this.grpThongTin.Text = "THÔNG TIN HỢP ĐỒNG";
            // 
            // lblMaHD
            // 
            this.lblMaHD.AutoSize = true;
            this.lblMaHD.Location = new System.Drawing.Point(20, 35);
            this.lblMaHD.Name = "lblMaHD";
            this.lblMaHD.Size = new System.Drawing.Size(175, 32);
            this.lblMaHD.TabIndex = 0;
            this.lblMaHD.Text = "Mã hợp đồng:";
            // 
            // lblKhachHang
            // 
            this.lblKhachHang.AutoSize = true;
            this.lblKhachHang.Location = new System.Drawing.Point(500, 35);
            this.lblKhachHang.Name = "lblKhachHang";
            this.lblKhachHang.Size = new System.Drawing.Size(154, 32);
            this.lblKhachHang.TabIndex = 1;
            this.lblKhachHang.Text = "Khách hàng:";
            // 
            // lblNgayKy
            // 
            this.lblNgayKy.AutoSize = true;
            this.lblNgayKy.Location = new System.Drawing.Point(20, 85);
            this.lblNgayKy.Name = "lblNgayKy";
            this.lblNgayKy.Size = new System.Drawing.Size(114, 32);
            this.lblNgayKy.TabIndex = 2;
            this.lblNgayKy.Text = "Ngày ký:";
            // 
            // lblNgayBatDau
            // 
            this.lblNgayBatDau.AutoSize = true;
            this.lblNgayBatDau.Location = new System.Drawing.Point(310, 85);
            this.lblNgayBatDau.Name = "lblNgayBatDau";
            this.lblNgayBatDau.Size = new System.Drawing.Size(175, 32);
            this.lblNgayBatDau.TabIndex = 3;
            this.lblNgayBatDau.Text = "Ngày bắt đầu:";
            // 
            // lblThoiHan
            // 
            this.lblThoiHan.AutoSize = true;
            this.lblThoiHan.Location = new System.Drawing.Point(660, 85);
            this.lblThoiHan.Name = "lblThoiHan";
            this.lblThoiHan.Size = new System.Drawing.Size(211, 32);
            this.lblThoiHan.TabIndex = 4;
            this.lblThoiHan.Text = "Thời hạn (tháng):";
            // 
            // txtMaHD
            // 
            this.txtMaHD.Location = new System.Drawing.Point(196, 32);
            this.txtMaHD.MaxLength = 20;
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.Size = new System.Drawing.Size(209, 39);
            this.txtMaHD.TabIndex = 5;
            // 
            // cboKhachHang
            // 
            this.cboKhachHang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboKhachHang.FormattingEnabled = true;
            this.cboKhachHang.Location = new System.Drawing.Point(635, 32);
            this.cboKhachHang.Name = "cboKhachHang";
            this.cboKhachHang.Size = new System.Drawing.Size(480, 39);
            this.cboKhachHang.TabIndex = 6;
            // 
            // dtNgayKy
            // 
            this.dtNgayKy.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgayKy.Location = new System.Drawing.Point(140, 82);
            this.dtNgayKy.Name = "dtNgayKy";
            this.dtNgayKy.Size = new System.Drawing.Size(164, 39);
            this.dtNgayKy.TabIndex = 7;
            // 
            // dtNgayBatDau
            // 
            this.dtNgayBatDau.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgayBatDau.Location = new System.Drawing.Point(491, 82);
            this.dtNgayBatDau.Name = "dtNgayBatDau";
            this.dtNgayBatDau.Size = new System.Drawing.Size(163, 39);
            this.dtNgayBatDau.TabIndex = 8;
            // 
            // nudThoiHan
            // 
            this.nudThoiHan.Location = new System.Drawing.Point(877, 82);
            this.nudThoiHan.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.nudThoiHan.Minimum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.nudThoiHan.Name = "nudThoiHan";
            this.nudThoiHan.Size = new System.Drawing.Size(110, 39);
            this.nudThoiHan.TabIndex = 9;
            this.nudThoiHan.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            // 
            // grpVanPhong
            // 
            this.grpVanPhong.Controls.Add(this.dgvVanPhong);
            this.grpVanPhong.Controls.Add(this.lblTongTienTieuDe);
            this.grpVanPhong.Controls.Add(this.lblTongTien);
            this.grpVanPhong.Controls.Add(this.lblTraTruocTieuDe);
            this.grpVanPhong.Controls.Add(this.lblTraTruoc);
            this.grpVanPhong.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpVanPhong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(72)))), ((int)(((byte)(105)))));
            this.grpVanPhong.Location = new System.Drawing.Point(20, 210);
            this.grpVanPhong.Name = "grpVanPhong";
            this.grpVanPhong.Size = new System.Drawing.Size(1160, 235);
            this.grpVanPhong.TabIndex = 2;
            this.grpVanPhong.TabStop = false;
            this.grpVanPhong.Text = "CHỌN VĂN PHÒNG THUÊ";
            // 
            // dgvVanPhong
            // 
            this.dgvVanPhong.AllowUserToAddRows = false;
            this.dgvVanPhong.AllowUserToDeleteRows = false;
            this.dgvVanPhong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVanPhong.BackgroundColor = System.Drawing.Color.White;
            this.dgvVanPhong.ColumnHeadersHeight = 40;
            this.dgvVanPhong.Location = new System.Drawing.Point(20, 30);
            this.dgvVanPhong.MultiSelect = false;
            this.dgvVanPhong.Name = "dgvVanPhong";
            this.dgvVanPhong.RowHeadersVisible = false;
            this.dgvVanPhong.RowHeadersWidth = 72;
            this.dgvVanPhong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVanPhong.Size = new System.Drawing.Size(1120, 145);
            this.dgvVanPhong.TabIndex = 0;
            this.dgvVanPhong.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVanPhong_CellValueChanged);
            this.dgvVanPhong.CurrentCellDirtyStateChanged += new System.EventHandler(this.dgvVanPhong_CurrentCellDirtyStateChanged);
            // 
            // lblTongTienTieuDe
            // 
            this.lblTongTienTieuDe.AutoSize = true;
            this.lblTongTienTieuDe.Location = new System.Drawing.Point(25, 192);
            this.lblTongTienTieuDe.Name = "lblTongTienTieuDe";
            this.lblTongTienTieuDe.Size = new System.Drawing.Size(205, 32);
            this.lblTongTienTieuDe.TabIndex = 1;
            this.lblTongTienTieuDe.Text = "Tiền thuê/tháng:";
            // 
            // lblTongTien
            // 
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(115)))), ((int)(((byte)(70)))));
            this.lblTongTien.Location = new System.Drawing.Point(236, 192);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(88, 32);
            this.lblTongTien.TabIndex = 2;
            this.lblTongTien.Text = "0 VNĐ";
            // 
            // lblTraTruocTieuDe
            // 
            this.lblTraTruocTieuDe.AutoSize = true;
            this.lblTraTruocTieuDe.Location = new System.Drawing.Point(610, 192);
            this.lblTraTruocTieuDe.Name = "lblTraTruocTieuDe";
            this.lblTraTruocTieuDe.Size = new System.Drawing.Size(219, 32);
            this.lblTraTruocTieuDe.TabIndex = 3;
            this.lblTraTruocTieuDe.Text = "Trả trước 6 tháng:";
            // 
            // lblTraTruoc
            // 
            this.lblTraTruoc.AutoSize = true;
            this.lblTraTruoc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.lblTraTruoc.Location = new System.Drawing.Point(835, 192);
            this.lblTraTruoc.Name = "lblTraTruoc";
            this.lblTraTruoc.Size = new System.Drawing.Size(88, 32);
            this.lblTraTruoc.TabIndex = 4;
            this.lblTraTruoc.Text = "0 VNĐ";
            // 
            // grpHopDong
            // 
            this.grpHopDong.Controls.Add(this.lblTimKiem);
            this.grpHopDong.Controls.Add(this.txtTimKiem);
            this.grpHopDong.Controls.Add(this.btnTimKiem);
            this.grpHopDong.Controls.Add(this.dgvHopDong);
            this.grpHopDong.Controls.Add(this.tabChiTiet);
            this.grpHopDong.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpHopDong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(72)))), ((int)(((byte)(105)))));
            this.grpHopDong.Location = new System.Drawing.Point(20, 510);
            this.grpHopDong.Name = "grpHopDong";
            this.grpHopDong.Size = new System.Drawing.Size(1160, 410);
            this.grpHopDong.TabIndex = 6;
            this.grpHopDong.TabStop = false;
            this.grpHopDong.Text = "DANH SÁCH HỢP ĐỒNG VÀ CHI TIẾT";
            // 
            // lblTimKiem
            // 
            this.lblTimKiem.AutoSize = true;
            this.lblTimKiem.Location = new System.Drawing.Point(20, 33);
            this.lblTimKiem.Name = "lblTimKiem";
            this.lblTimKiem.Size = new System.Drawing.Size(126, 32);
            this.lblTimKiem.TabIndex = 0;
            this.lblTimKiem.Text = "Tìm kiếm:";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(125, 30);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(460, 39);
            this.txtTimKiem.TabIndex = 1;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(106)))), ((int)(((byte)(166)))));
            this.btnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiem.ForeColor = System.Drawing.Color.White;
            this.btnTimKiem.Location = new System.Drawing.Point(615, 25);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(145, 36);
            this.btnTimKiem.TabIndex = 2;
            this.btnTimKiem.Text = "TÌM KIẾM";
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // dgvHopDong
            // 
            this.dgvHopDong.AllowUserToAddRows = false;
            this.dgvHopDong.AllowUserToDeleteRows = false;
            this.dgvHopDong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHopDong.BackgroundColor = System.Drawing.Color.White;
            this.dgvHopDong.ColumnHeadersHeight = 40;
            this.dgvHopDong.Location = new System.Drawing.Point(20, 75);
            this.dgvHopDong.MultiSelect = false;
            this.dgvHopDong.Name = "dgvHopDong";
            this.dgvHopDong.ReadOnly = true;
            this.dgvHopDong.RowHeadersVisible = false;
            this.dgvHopDong.RowHeadersWidth = 72;
            this.dgvHopDong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHopDong.Size = new System.Drawing.Size(1120, 145);
            this.dgvHopDong.TabIndex = 3;
            this.dgvHopDong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHopDong_CellClick);
            // 
            // tabChiTiet
            // 
            this.tabChiTiet.Controls.Add(this.tabPhong);
            this.tabChiTiet.Controls.Add(this.tabKy);
            this.tabChiTiet.Location = new System.Drawing.Point(20, 235);
            this.tabChiTiet.Name = "tabChiTiet";
            this.tabChiTiet.SelectedIndex = 0;
            this.tabChiTiet.Size = new System.Drawing.Size(1120, 155);
            this.tabChiTiet.TabIndex = 4;
            // 
            // tabPhong
            // 
            this.tabPhong.Controls.Add(this.dgvChiTiet);
            this.tabPhong.Location = new System.Drawing.Point(4, 40);
            this.tabPhong.Name = "tabPhong";
            this.tabPhong.Padding = new System.Windows.Forms.Padding(3);
            this.tabPhong.Size = new System.Drawing.Size(1112, 111);
            this.tabPhong.TabIndex = 0;
            this.tabPhong.Text = "Văn phòng trong hợp đồng";
            this.tabPhong.UseVisualStyleBackColor = true;
            // 
            // dgvChiTiet
            // 
            this.dgvChiTiet.AllowUserToAddRows = false;
            this.dgvChiTiet.AllowUserToDeleteRows = false;
            this.dgvChiTiet.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvChiTiet.BackgroundColor = System.Drawing.Color.White;
            this.dgvChiTiet.ColumnHeadersHeight = 40;
            this.dgvChiTiet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvChiTiet.Location = new System.Drawing.Point(3, 3);
            this.dgvChiTiet.Name = "dgvChiTiet";
            this.dgvChiTiet.ReadOnly = true;
            this.dgvChiTiet.RowHeadersVisible = false;
            this.dgvChiTiet.RowHeadersWidth = 72;
            this.dgvChiTiet.Size = new System.Drawing.Size(1106, 105);
            this.dgvChiTiet.TabIndex = 0;
            // 
            // tabKy
            // 
            this.tabKy.Controls.Add(this.dgvKyThanhToan);
            this.tabKy.Location = new System.Drawing.Point(4, 40);
            this.tabKy.Name = "tabKy";
            this.tabKy.Padding = new System.Windows.Forms.Padding(3);
            this.tabKy.Size = new System.Drawing.Size(1112, 111);
            this.tabKy.TabIndex = 1;
            this.tabKy.Text = "Các kỳ thanh toán";
            this.tabKy.UseVisualStyleBackColor = true;
            // 
            // dgvKyThanhToan
            // 
            this.dgvKyThanhToan.AllowUserToAddRows = false;
            this.dgvKyThanhToan.AllowUserToDeleteRows = false;
            this.dgvKyThanhToan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKyThanhToan.BackgroundColor = System.Drawing.Color.White;
            this.dgvKyThanhToan.ColumnHeadersHeight = 40;
            this.dgvKyThanhToan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvKyThanhToan.Location = new System.Drawing.Point(3, 3);
            this.dgvKyThanhToan.Name = "dgvKyThanhToan";
            this.dgvKyThanhToan.ReadOnly = true;
            this.dgvKyThanhToan.RowHeadersVisible = false;
            this.dgvKyThanhToan.RowHeadersWidth = 72;
            this.dgvKyThanhToan.Size = new System.Drawing.Size(1106, 105);
            this.dgvKyThanhToan.TabIndex = 0;
            // 
            // btnLapHopDong
            // 
            this.btnLapHopDong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(125)))), ((int)(((byte)(86)))));
            this.btnLapHopDong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLapHopDong.ForeColor = System.Drawing.Color.White;
            this.btnLapHopDong.Location = new System.Drawing.Point(45, 455);
            this.btnLapHopDong.Name = "btnLapHopDong";
            this.btnLapHopDong.Size = new System.Drawing.Size(205, 40);
            this.btnLapHopDong.TabIndex = 3;
            this.btnLapHopDong.Text = "LẬP HỢP ĐỒNG";
            this.btnLapHopDong.UseVisualStyleBackColor = false;
            this.btnLapHopDong.Click += new System.EventHandler(this.btnLapHopDong_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(105)))), ((int)(((byte)(115)))));
            this.btnLamMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLamMoi.ForeColor = System.Drawing.Color.White;
            this.btnLamMoi.Location = new System.Drawing.Point(275, 455);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(150, 40);
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
            this.btnDong.Location = new System.Drawing.Point(1005, 455);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(150, 40);
            this.btnDong.TabIndex = 5;
            this.btnDong.Text = "ĐÓNG";
            this.btnDong.UseVisualStyleBackColor = false;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // FrmHopDong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(249)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(1200, 940);
            this.Controls.Add(this.lblTieuDe);
            this.Controls.Add(this.grpThongTin);
            this.Controls.Add(this.grpVanPhong);
            this.Controls.Add(this.btnLapHopDong);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.grpHopDong);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Name = "FrmHopDong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Quản lý hợp đồng thuê văn phòng";
            this.Load += new System.EventHandler(this.FrmHopDong_Load);
            this.grpThongTin.ResumeLayout(false);
            this.grpThongTin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudThoiHan)).EndInit();
            this.grpVanPhong.ResumeLayout(false);
            this.grpVanPhong.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVanPhong)).EndInit();
            this.grpHopDong.ResumeLayout(false);
            this.grpHopDong.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHopDong)).EndInit();
            this.tabChiTiet.ResumeLayout(false);
            this.tabPhong.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTiet)).EndInit();
            this.tabKy.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKyThanhToan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
