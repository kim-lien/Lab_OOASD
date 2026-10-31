
namespace QuanLyChoThueVanPhong.Forms
{
    partial class FrmGiaHan
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.GroupBox grpThongTin;
        private System.Windows.Forms.GroupBox grpDanhSach;
        private System.Windows.Forms.Label lblMaGiaHan;
        private System.Windows.Forms.Label lblHopDong;
        private System.Windows.Forms.Label lblVanPhong;
        private System.Windows.Forms.Label lblNgayKetThuc;
        private System.Windows.Forms.Label lblThoiHanGoc;
        private System.Windows.Forms.Label lblDaGiaHan;
        private System.Windows.Forms.Label lblConDuocGiaHan;
        private System.Windows.Forms.Label lblSoThang;
        private System.Windows.Forms.Label lblNgayBatDauMoi;
        private System.Windows.Forms.Label lblNgayKetThucMoi;
        private System.Windows.Forms.Label lblNoTienThue;
        private System.Windows.Forms.Label lblNoDichVu;
        private System.Windows.Forms.Label lblTimKiem;

        private System.Windows.Forms.TextBox txtMaGiaHan;
        private System.Windows.Forms.TextBox txtNgayKetThuc;
        private System.Windows.Forms.TextBox txtThoiHanGoc;
        private System.Windows.Forms.TextBox txtDaGiaHan;
        private System.Windows.Forms.TextBox txtConDuocGiaHan;
        private System.Windows.Forms.TextBox txtNgayBatDauMoi;
        private System.Windows.Forms.TextBox txtNgayKetThucMoi;
        private System.Windows.Forms.TextBox txtNoTienThue;
        private System.Windows.Forms.TextBox txtNoDichVu;
        private System.Windows.Forms.TextBox txtTimKiem;

        private System.Windows.Forms.ComboBox cboHopDong;
        private System.Windows.Forms.ComboBox cboVanPhong;
        private System.Windows.Forms.NumericUpDown nudSoThang;
        private System.Windows.Forms.DataGridView dgvGiaHan;

        private System.Windows.Forms.Button btnGiaHan;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnDong;

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
            this.lblMaGiaHan = new System.Windows.Forms.Label();
            this.lblHopDong = new System.Windows.Forms.Label();
            this.lblVanPhong = new System.Windows.Forms.Label();
            this.lblNgayKetThuc = new System.Windows.Forms.Label();
            this.lblThoiHanGoc = new System.Windows.Forms.Label();
            this.lblDaGiaHan = new System.Windows.Forms.Label();
            this.lblConDuocGiaHan = new System.Windows.Forms.Label();
            this.lblSoThang = new System.Windows.Forms.Label();
            this.lblNgayBatDauMoi = new System.Windows.Forms.Label();
            this.lblNgayKetThucMoi = new System.Windows.Forms.Label();
            this.lblNoTienThue = new System.Windows.Forms.Label();
            this.lblNoDichVu = new System.Windows.Forms.Label();
            this.txtMaGiaHan = new System.Windows.Forms.TextBox();
            this.txtNgayKetThuc = new System.Windows.Forms.TextBox();
            this.txtThoiHanGoc = new System.Windows.Forms.TextBox();
            this.txtDaGiaHan = new System.Windows.Forms.TextBox();
            this.txtConDuocGiaHan = new System.Windows.Forms.TextBox();
            this.txtNgayBatDauMoi = new System.Windows.Forms.TextBox();
            this.txtNgayKetThucMoi = new System.Windows.Forms.TextBox();
            this.txtNoTienThue = new System.Windows.Forms.TextBox();
            this.txtNoDichVu = new System.Windows.Forms.TextBox();
            this.cboHopDong = new System.Windows.Forms.ComboBox();
            this.cboVanPhong = new System.Windows.Forms.ComboBox();
            this.nudSoThang = new System.Windows.Forms.NumericUpDown();
            this.grpDanhSach = new System.Windows.Forms.GroupBox();
            this.lblTimKiem = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.dgvGiaHan = new System.Windows.Forms.DataGridView();
            this.btnGiaHan = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.grpThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoThang)).BeginInit();
            this.grpDanhSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGiaHan)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.AutoSize = true;
            this.lblTieuDe.Font = new System.Drawing.Font("Segoe UI", 19F, System.Drawing.FontStyle.Bold);
            this.lblTieuDe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(72)))), ((int)(((byte)(105)))));
            this.lblTieuDe.Location = new System.Drawing.Point(335, 20);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(604, 61);
            this.lblTieuDe.TabIndex = 0;
            this.lblTieuDe.Text = "GIA HẠN HỢP ĐỒNG THUÊ";
            // 
            // grpThongTin
            // 
            this.grpThongTin.Controls.Add(this.lblMaGiaHan);
            this.grpThongTin.Controls.Add(this.lblHopDong);
            this.grpThongTin.Controls.Add(this.lblVanPhong);
            this.grpThongTin.Controls.Add(this.lblNgayKetThuc);
            this.grpThongTin.Controls.Add(this.lblThoiHanGoc);
            this.grpThongTin.Controls.Add(this.lblDaGiaHan);
            this.grpThongTin.Controls.Add(this.lblConDuocGiaHan);
            this.grpThongTin.Controls.Add(this.lblSoThang);
            this.grpThongTin.Controls.Add(this.lblNgayBatDauMoi);
            this.grpThongTin.Controls.Add(this.lblNgayKetThucMoi);
            this.grpThongTin.Controls.Add(this.lblNoTienThue);
            this.grpThongTin.Controls.Add(this.lblNoDichVu);
            this.grpThongTin.Controls.Add(this.txtMaGiaHan);
            this.grpThongTin.Controls.Add(this.txtNgayKetThuc);
            this.grpThongTin.Controls.Add(this.txtThoiHanGoc);
            this.grpThongTin.Controls.Add(this.txtDaGiaHan);
            this.grpThongTin.Controls.Add(this.txtConDuocGiaHan);
            this.grpThongTin.Controls.Add(this.txtNgayBatDauMoi);
            this.grpThongTin.Controls.Add(this.txtNgayKetThucMoi);
            this.grpThongTin.Controls.Add(this.txtNoTienThue);
            this.grpThongTin.Controls.Add(this.txtNoDichVu);
            this.grpThongTin.Controls.Add(this.cboHopDong);
            this.grpThongTin.Controls.Add(this.cboVanPhong);
            this.grpThongTin.Controls.Add(this.nudSoThang);
            this.grpThongTin.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpThongTin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(72)))), ((int)(((byte)(105)))));
            this.grpThongTin.Location = new System.Drawing.Point(30, 80);
            this.grpThongTin.Name = "grpThongTin";
            this.grpThongTin.Size = new System.Drawing.Size(1040, 350);
            this.grpThongTin.TabIndex = 1;
            this.grpThongTin.TabStop = false;
            this.grpThongTin.Text = "THÔNG TIN GIA HẠN";
            // 
            // lblMaGiaHan
            // 
            this.lblMaGiaHan.AutoSize = true;
            this.lblMaGiaHan.Location = new System.Drawing.Point(25, 40);
            this.lblMaGiaHan.Name = "lblMaGiaHan";
            this.lblMaGiaHan.Size = new System.Drawing.Size(219, 32);
            this.lblMaGiaHan.TabIndex = 0;
            this.lblMaGiaHan.Text = "Mã phiếu gia hạn:";
            // 
            // lblHopDong
            // 
            this.lblHopDong.AutoSize = true;
            this.lblHopDong.Location = new System.Drawing.Point(540, 40);
            this.lblHopDong.Name = "lblHopDong";
            this.lblHopDong.Size = new System.Drawing.Size(136, 32);
            this.lblHopDong.TabIndex = 1;
            this.lblHopDong.Text = "Hợp đồng:";
            // 
            // lblVanPhong
            // 
            this.lblVanPhong.AutoSize = true;
            this.lblVanPhong.Location = new System.Drawing.Point(25, 90);
            this.lblVanPhong.Name = "lblVanPhong";
            this.lblVanPhong.Size = new System.Drawing.Size(145, 32);
            this.lblVanPhong.TabIndex = 2;
            this.lblVanPhong.Text = "Văn phòng:";
            // 
            // lblNgayKetThuc
            // 
            this.lblNgayKetThuc.AutoSize = true;
            this.lblNgayKetThuc.Location = new System.Drawing.Point(540, 90);
            this.lblNgayKetThuc.Name = "lblNgayKetThuc";
            this.lblNgayKetThuc.Size = new System.Drawing.Size(272, 32);
            this.lblNgayKetThuc.TabIndex = 3;
            this.lblNgayKetThuc.Text = "Ngày kết thúc hiện tại:";
            // 
            // lblThoiHanGoc
            // 
            this.lblThoiHanGoc.AutoSize = true;
            this.lblThoiHanGoc.Location = new System.Drawing.Point(25, 140);
            this.lblThoiHanGoc.Name = "lblThoiHanGoc";
            this.lblThoiHanGoc.Size = new System.Drawing.Size(260, 32);
            this.lblThoiHanGoc.TabIndex = 4;
            this.lblThoiHanGoc.Text = "Thời hạn gốc (tháng):";
            // 
            // lblDaGiaHan
            // 
            this.lblDaGiaHan.AutoSize = true;
            this.lblDaGiaHan.Location = new System.Drawing.Point(540, 140);
            this.lblDaGiaHan.Name = "lblDaGiaHan";
            this.lblDaGiaHan.Size = new System.Drawing.Size(234, 32);
            this.lblDaGiaHan.TabIndex = 5;
            this.lblDaGiaHan.Text = "Đã gia hạn (tháng):";
            // 
            // lblConDuocGiaHan
            // 
            this.lblConDuocGiaHan.AutoSize = true;
            this.lblConDuocGiaHan.Location = new System.Drawing.Point(25, 190);
            this.lblConDuocGiaHan.Name = "lblConDuocGiaHan";
            this.lblConDuocGiaHan.Size = new System.Drawing.Size(222, 32);
            this.lblConDuocGiaHan.TabIndex = 6;
            this.lblConDuocGiaHan.Text = "Còn được gia hạn:";
            // 
            // lblSoThang
            // 
            this.lblSoThang.AutoSize = true;
            this.lblSoThang.Location = new System.Drawing.Point(540, 190);
            this.lblSoThang.Name = "lblSoThang";
            this.lblSoThang.Size = new System.Drawing.Size(213, 32);
            this.lblSoThang.TabIndex = 7;
            this.lblSoThang.Text = "Số tháng gia hạn:";
            // 
            // lblNgayBatDauMoi
            // 
            this.lblNgayBatDauMoi.AutoSize = true;
            this.lblNgayBatDauMoi.Location = new System.Drawing.Point(25, 240);
            this.lblNgayBatDauMoi.Name = "lblNgayBatDauMoi";
            this.lblNgayBatDauMoi.Size = new System.Drawing.Size(226, 32);
            this.lblNgayBatDauMoi.TabIndex = 8;
            this.lblNgayBatDauMoi.Text = "Ngày bắt đầu mới:";
            // 
            // lblNgayKetThucMoi
            // 
            this.lblNgayKetThucMoi.AutoSize = true;
            this.lblNgayKetThucMoi.Location = new System.Drawing.Point(540, 240);
            this.lblNgayKetThucMoi.Name = "lblNgayKetThucMoi";
            this.lblNgayKetThucMoi.Size = new System.Drawing.Size(231, 32);
            this.lblNgayKetThucMoi.TabIndex = 9;
            this.lblNgayKetThucMoi.Text = "Ngày kết thúc mới:";
            // 
            // lblNoTienThue
            // 
            this.lblNoTienThue.AutoSize = true;
            this.lblNoTienThue.Location = new System.Drawing.Point(25, 290);
            this.lblNoTienThue.Name = "lblNoTienThue";
            this.lblNoTienThue.Size = new System.Drawing.Size(242, 32);
            this.lblNoTienThue.TabIndex = 10;
            this.lblNoTienThue.Text = "Nợ tiền thuê (VNĐ):";
            // 
            // lblNoDichVu
            // 
            this.lblNoDichVu.AutoSize = true;
            this.lblNoDichVu.Location = new System.Drawing.Point(540, 290);
            this.lblNoDichVu.Name = "lblNoDichVu";
            this.lblNoDichVu.Size = new System.Drawing.Size(223, 32);
            this.lblNoDichVu.TabIndex = 11;
            this.lblNoDichVu.Text = "Nợ dịch vụ (VNĐ):";
            // 
            // txtMaGiaHan
            // 
            this.txtMaGiaHan.Location = new System.Drawing.Point(195, 37);
            this.txtMaGiaHan.MaxLength = 20;
            this.txtMaGiaHan.Name = "txtMaGiaHan";
            this.txtMaGiaHan.Size = new System.Drawing.Size(250, 39);
            this.txtMaGiaHan.TabIndex = 12;
            // 
            // txtNgayKetThuc
            // 
            this.txtNgayKetThuc.Location = new System.Drawing.Point(818, 90);
            this.txtNgayKetThuc.Name = "txtNgayKetThuc";
            this.txtNgayKetThuc.ReadOnly = true;
            this.txtNgayKetThuc.Size = new System.Drawing.Size(182, 39);
            this.txtNgayKetThuc.TabIndex = 13;
            // 
            // txtThoiHanGoc
            // 
            this.txtThoiHanGoc.Location = new System.Drawing.Point(284, 142);
            this.txtThoiHanGoc.Name = "txtThoiHanGoc";
            this.txtThoiHanGoc.ReadOnly = true;
            this.txtThoiHanGoc.Size = new System.Drawing.Size(216, 39);
            this.txtThoiHanGoc.TabIndex = 14;
            // 
            // txtDaGiaHan
            // 
            this.txtDaGiaHan.Location = new System.Drawing.Point(790, 140);
            this.txtDaGiaHan.Name = "txtDaGiaHan";
            this.txtDaGiaHan.ReadOnly = true;
            this.txtDaGiaHan.Size = new System.Drawing.Size(210, 39);
            this.txtDaGiaHan.TabIndex = 15;
            // 
            // txtConDuocGiaHan
            // 
            this.txtConDuocGiaHan.Location = new System.Drawing.Point(250, 190);
            this.txtConDuocGiaHan.Name = "txtConDuocGiaHan";
            this.txtConDuocGiaHan.ReadOnly = true;
            this.txtConDuocGiaHan.Size = new System.Drawing.Size(227, 39);
            this.txtConDuocGiaHan.TabIndex = 16;
            // 
            // txtNgayBatDauMoi
            // 
            this.txtNgayBatDauMoi.Location = new System.Drawing.Point(257, 240);
            this.txtNgayBatDauMoi.Name = "txtNgayBatDauMoi";
            this.txtNgayBatDauMoi.ReadOnly = true;
            this.txtNgayBatDauMoi.Size = new System.Drawing.Size(220, 39);
            this.txtNgayBatDauMoi.TabIndex = 17;
            // 
            // txtNgayKetThucMoi
            // 
            this.txtNgayKetThucMoi.Location = new System.Drawing.Point(777, 240);
            this.txtNgayKetThucMoi.Name = "txtNgayKetThucMoi";
            this.txtNgayKetThucMoi.ReadOnly = true;
            this.txtNgayKetThucMoi.Size = new System.Drawing.Size(223, 39);
            this.txtNgayKetThucMoi.TabIndex = 18;
            // 
            // txtNoTienThue
            // 
            this.txtNoTienThue.Location = new System.Drawing.Point(273, 290);
            this.txtNoTienThue.Name = "txtNoTienThue";
            this.txtNoTienThue.ReadOnly = true;
            this.txtNoTienThue.Size = new System.Drawing.Size(227, 39);
            this.txtNoTienThue.TabIndex = 19;
            // 
            // txtNoDichVu
            // 
            this.txtNoDichVu.Location = new System.Drawing.Point(759, 285);
            this.txtNoDichVu.Name = "txtNoDichVu";
            this.txtNoDichVu.ReadOnly = true;
            this.txtNoDichVu.Size = new System.Drawing.Size(252, 39);
            this.txtNoDichVu.TabIndex = 20;
            // 
            // cboHopDong
            // 
            this.cboHopDong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboHopDong.Location = new System.Drawing.Point(720, 37);
            this.cboHopDong.Name = "cboHopDong";
            this.cboHopDong.Size = new System.Drawing.Size(255, 39);
            this.cboHopDong.TabIndex = 21;
            this.cboHopDong.SelectedIndexChanged += new System.EventHandler(this.cboHopDong_SelectedIndexChanged);
            // 
            // cboVanPhong
            // 
            this.cboVanPhong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboVanPhong.Location = new System.Drawing.Point(195, 87);
            this.cboVanPhong.Name = "cboVanPhong";
            this.cboVanPhong.Size = new System.Drawing.Size(250, 39);
            this.cboVanPhong.TabIndex = 22;
            this.cboVanPhong.SelectedIndexChanged += new System.EventHandler(this.cboVanPhong_SelectedIndexChanged);
            // 
            // nudSoThang
            // 
            this.nudSoThang.Location = new System.Drawing.Point(759, 188);
            this.nudSoThang.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.nudSoThang.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSoThang.Name = "nudSoThang";
            this.nudSoThang.Size = new System.Drawing.Size(241, 39);
            this.nudSoThang.TabIndex = 23;
            this.nudSoThang.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSoThang.ValueChanged += new System.EventHandler(this.nudSoThang_ValueChanged);
            // 
            // grpDanhSach
            // 
            this.grpDanhSach.Controls.Add(this.lblTimKiem);
            this.grpDanhSach.Controls.Add(this.txtTimKiem);
            this.grpDanhSach.Controls.Add(this.btnTimKiem);
            this.grpDanhSach.Controls.Add(this.dgvGiaHan);
            this.grpDanhSach.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpDanhSach.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(72)))), ((int)(((byte)(105)))));
            this.grpDanhSach.Location = new System.Drawing.Point(30, 515);
            this.grpDanhSach.Name = "grpDanhSach";
            this.grpDanhSach.Size = new System.Drawing.Size(1040, 320);
            this.grpDanhSach.TabIndex = 5;
            this.grpDanhSach.TabStop = false;
            this.grpDanhSach.Text = "LỊCH SỬ GIA HẠN";
            // 
            // lblTimKiem
            // 
            this.lblTimKiem.AutoSize = true;
            this.lblTimKiem.Location = new System.Drawing.Point(25, 37);
            this.lblTimKiem.Name = "lblTimKiem";
            this.lblTimKiem.Size = new System.Drawing.Size(126, 32);
            this.lblTimKiem.TabIndex = 0;
            this.lblTimKiem.Text = "Tìm kiếm:";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(125, 34);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(500, 39);
            this.txtTimKiem.TabIndex = 1;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(106)))), ((int)(((byte)(166)))));
            this.btnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiem.ForeColor = System.Drawing.Color.White;
            this.btnTimKiem.Location = new System.Drawing.Point(660, 28);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(165, 37);
            this.btnTimKiem.TabIndex = 2;
            this.btnTimKiem.Text = "TÌM KIẾM";
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // dgvGiaHan
            // 
            this.dgvGiaHan.AllowUserToAddRows = false;
            this.dgvGiaHan.AllowUserToDeleteRows = false;
            this.dgvGiaHan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGiaHan.BackgroundColor = System.Drawing.Color.White;
            this.dgvGiaHan.ColumnHeadersHeight = 40;
            this.dgvGiaHan.Location = new System.Drawing.Point(20, 83);
            this.dgvGiaHan.MultiSelect = false;
            this.dgvGiaHan.Name = "dgvGiaHan";
            this.dgvGiaHan.ReadOnly = true;
            this.dgvGiaHan.RowHeadersVisible = false;
            this.dgvGiaHan.RowHeadersWidth = 72;
            this.dgvGiaHan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGiaHan.Size = new System.Drawing.Size(1000, 215);
            this.dgvGiaHan.TabIndex = 3;
            // 
            // btnGiaHan
            // 
            this.btnGiaHan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(85)))));
            this.btnGiaHan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGiaHan.ForeColor = System.Drawing.Color.White;
            this.btnGiaHan.Location = new System.Drawing.Point(65, 450);
            this.btnGiaHan.Name = "btnGiaHan";
            this.btnGiaHan.Size = new System.Drawing.Size(200, 43);
            this.btnGiaHan.TabIndex = 2;
            this.btnGiaHan.Text = "XÁC NHẬN GIA HẠN";
            this.btnGiaHan.UseVisualStyleBackColor = false;
            this.btnGiaHan.Click += new System.EventHandler(this.btnGiaHan_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(106)))), ((int)(((byte)(166)))));
            this.btnLamMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLamMoi.ForeColor = System.Drawing.Color.White;
            this.btnLamMoi.Location = new System.Drawing.Point(295, 450);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(160, 43);
            this.btnLamMoi.TabIndex = 3;
            this.btnLamMoi.Text = "LÀM MỚI";
            this.btnLamMoi.UseVisualStyleBackColor = false;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnDong
            // 
            this.btnDong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.btnDong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDong.ForeColor = System.Drawing.Color.White;
            this.btnDong.Location = new System.Drawing.Point(870, 450);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(160, 43);
            this.btnDong.TabIndex = 4;
            this.btnDong.Text = "ĐÓNG";
            this.btnDong.UseVisualStyleBackColor = false;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // FrmGiaHan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(249)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(1100, 860);
            this.Controls.Add(this.lblTieuDe);
            this.Controls.Add(this.grpThongTin);
            this.Controls.Add(this.btnGiaHan);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.grpDanhSach);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Name = "FrmGiaHan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Gia hạn hợp đồng thuê";
            this.Load += new System.EventHandler(this.FrmGiaHan_Load);
            this.grpThongTin.ResumeLayout(false);
            this.grpThongTin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoThang)).EndInit();
            this.grpDanhSach.ResumeLayout(false);
            this.grpDanhSach.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGiaHan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
