
namespace QuanLyChoThueVanPhong.Forms
{
    partial class FrmMain
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.Label lblPhuDe;
        private System.Windows.Forms.GroupBox grpDanhMuc;
        private System.Windows.Forms.GroupBox grpHopDong;
        private System.Windows.Forms.GroupBox grpDichVu;
        private System.Windows.Forms.GroupBox grpVanHanh;
        private System.Windows.Forms.Button btnTang;
        private System.Windows.Forms.Button btnVanPhong;
        private System.Windows.Forms.Button btnKhachHang;
        private System.Windows.Forms.Button btnHopDong;
        private System.Windows.Forms.Button btnGiaHan;
        private System.Windows.Forms.Button btnTienThue;
        private System.Windows.Forms.Button btnDichVu;
        private System.Windows.Forms.Button btnHoaDonDV;
        private System.Windows.Forms.Button btnThanhToanDV;
        private System.Windows.Forms.Button btnNhanVien;
        private System.Windows.Forms.Button btnTheXe;
        private System.Windows.Forms.Button btnKiemTra;
        private System.Windows.Forms.Button btnXuPhat;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.Button btnThoat;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.lblPhuDe = new System.Windows.Forms.Label();
            this.grpDanhMuc = new System.Windows.Forms.GroupBox();
            this.btnTang = new System.Windows.Forms.Button();
            this.btnVanPhong = new System.Windows.Forms.Button();
            this.btnKhachHang = new System.Windows.Forms.Button();
            this.grpHopDong = new System.Windows.Forms.GroupBox();
            this.btnHopDong = new System.Windows.Forms.Button();
            this.btnGiaHan = new System.Windows.Forms.Button();
            this.btnTienThue = new System.Windows.Forms.Button();
            this.grpDichVu = new System.Windows.Forms.GroupBox();
            this.btnDichVu = new System.Windows.Forms.Button();
            this.btnHoaDonDV = new System.Windows.Forms.Button();
            this.btnThanhToanDV = new System.Windows.Forms.Button();
            this.grpVanHanh = new System.Windows.Forms.GroupBox();
            this.btnNhanVien = new System.Windows.Forms.Button();
            this.btnTheXe = new System.Windows.Forms.Button();
            this.btnKiemTra = new System.Windows.Forms.Button();
            this.btnXuPhat = new System.Windows.Forms.Button();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.pnlHeader.SuspendLayout();
            this.grpDanhMuc.SuspendLayout();
            this.grpHopDong.SuspendLayout();
            this.grpDichVu.SuspendLayout();
            this.grpVanHanh.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(72)))), ((int)(((byte)(105)))));
            this.pnlHeader.Controls.Add(this.lblTieuDe);
            this.pnlHeader.Controls.Add(this.lblPhuDe);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1077, 119);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.AutoSize = true;
            this.lblTieuDe.Font = new System.Drawing.Font("Segoe UI", 19F, System.Drawing.FontStyle.Bold);
            this.lblTieuDe.ForeColor = System.Drawing.Color.White;
            this.lblTieuDe.Location = new System.Drawing.Point(260, 14);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(743, 61);
            this.lblTieuDe.TabIndex = 0;
            this.lblTieuDe.Text = "QUẢN LÝ CHO THUÊ VĂN PHÒNG";
            // 
            // lblPhuDe
            // 
            this.lblPhuDe.AutoSize = true;
            this.lblPhuDe.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblPhuDe.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblPhuDe.Location = new System.Drawing.Point(400, 75);
            this.lblPhuDe.Name = "lblPhuDe";
            this.lblPhuDe.Size = new System.Drawing.Size(356, 36);
            this.lblPhuDe.TabIndex = 1;
            this.lblPhuDe.Text = "HỆ THỐNG QUẢN LÝ CAO ỐC";
            this.lblPhuDe.Click += new System.EventHandler(this.lblPhuDe_Click);
            // 
            // grpDanhMuc
            // 
            this.grpDanhMuc.Controls.Add(this.btnTang);
            this.grpDanhMuc.Controls.Add(this.btnVanPhong);
            this.grpDanhMuc.Controls.Add(this.btnKhachHang);
            this.grpDanhMuc.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.grpDanhMuc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(72)))), ((int)(((byte)(105)))));
            this.grpDanhMuc.Location = new System.Drawing.Point(55, 125);
            this.grpDanhMuc.Name = "grpDanhMuc";
            this.grpDanhMuc.Size = new System.Drawing.Size(940, 110);
            this.grpDanhMuc.TabIndex = 1;
            this.grpDanhMuc.TabStop = false;
            this.grpDanhMuc.Text = "QUẢN LÝ DANH MỤC";
            // 
            // btnTang
            // 
            this.btnTang.BackColor = System.Drawing.Color.White;
            this.btnTang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTang.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnTang.ForeColor = System.Drawing.Color.Black;
            this.btnTang.Location = new System.Drawing.Point(40, 40);
            this.btnTang.Name = "btnTang";
            this.btnTang.Size = new System.Drawing.Size(260, 45);
            this.btnTang.TabIndex = 0;
            this.btnTang.Text = "Quản lý tầng";
            this.btnTang.UseVisualStyleBackColor = false;
            this.btnTang.Click += new System.EventHandler(this.btnTang_Click);
            // 
            // btnVanPhong
            // 
            this.btnVanPhong.BackColor = System.Drawing.Color.White;
            this.btnVanPhong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVanPhong.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnVanPhong.ForeColor = System.Drawing.Color.Black;
            this.btnVanPhong.Location = new System.Drawing.Point(340, 40);
            this.btnVanPhong.Name = "btnVanPhong";
            this.btnVanPhong.Size = new System.Drawing.Size(260, 45);
            this.btnVanPhong.TabIndex = 1;
            this.btnVanPhong.Text = "Quản lý văn phòng";
            this.btnVanPhong.UseVisualStyleBackColor = false;
            this.btnVanPhong.Click += new System.EventHandler(this.btnVanPhong_Click);
            // 
            // btnKhachHang
            // 
            this.btnKhachHang.BackColor = System.Drawing.Color.White;
            this.btnKhachHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKhachHang.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnKhachHang.ForeColor = System.Drawing.Color.Black;
            this.btnKhachHang.Location = new System.Drawing.Point(640, 40);
            this.btnKhachHang.Name = "btnKhachHang";
            this.btnKhachHang.Size = new System.Drawing.Size(260, 45);
            this.btnKhachHang.TabIndex = 2;
            this.btnKhachHang.Text = "Quản lý khách hàng";
            this.btnKhachHang.UseVisualStyleBackColor = false;
            this.btnKhachHang.Click += new System.EventHandler(this.btnKhachHang_Click);
            // 
            // grpHopDong
            // 
            this.grpHopDong.Controls.Add(this.btnHopDong);
            this.grpHopDong.Controls.Add(this.btnGiaHan);
            this.grpHopDong.Controls.Add(this.btnTienThue);
            this.grpHopDong.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.grpHopDong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(72)))), ((int)(((byte)(105)))));
            this.grpHopDong.Location = new System.Drawing.Point(55, 250);
            this.grpHopDong.Name = "grpHopDong";
            this.grpHopDong.Size = new System.Drawing.Size(940, 110);
            this.grpHopDong.TabIndex = 2;
            this.grpHopDong.TabStop = false;
            this.grpHopDong.Text = "HỢP ĐỒNG VÀ THANH TOÁN";
            // 
            // btnHopDong
            // 
            this.btnHopDong.BackColor = System.Drawing.Color.White;
            this.btnHopDong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHopDong.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnHopDong.ForeColor = System.Drawing.Color.Black;
            this.btnHopDong.Location = new System.Drawing.Point(40, 40);
            this.btnHopDong.Name = "btnHopDong";
            this.btnHopDong.Size = new System.Drawing.Size(260, 45);
            this.btnHopDong.TabIndex = 0;
            this.btnHopDong.Text = "Hợp đồng thuê";
            this.btnHopDong.UseVisualStyleBackColor = false;
            this.btnHopDong.Click += new System.EventHandler(this.btnHopDong_Click);
            // 
            // btnGiaHan
            // 
            this.btnGiaHan.BackColor = System.Drawing.Color.White;
            this.btnGiaHan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGiaHan.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnGiaHan.ForeColor = System.Drawing.Color.Black;
            this.btnGiaHan.Location = new System.Drawing.Point(340, 40);
            this.btnGiaHan.Name = "btnGiaHan";
            this.btnGiaHan.Size = new System.Drawing.Size(260, 45);
            this.btnGiaHan.TabIndex = 1;
            this.btnGiaHan.Text = "Gia hạn hợp đồng";
            this.btnGiaHan.UseVisualStyleBackColor = false;
            this.btnGiaHan.Click += new System.EventHandler(this.btnGiaHan_Click);
            // 
            // btnTienThue
            // 
            this.btnTienThue.BackColor = System.Drawing.Color.White;
            this.btnTienThue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTienThue.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnTienThue.ForeColor = System.Drawing.Color.Black;
            this.btnTienThue.Location = new System.Drawing.Point(640, 40);
            this.btnTienThue.Name = "btnTienThue";
            this.btnTienThue.Size = new System.Drawing.Size(260, 45);
            this.btnTienThue.TabIndex = 2;
            this.btnTienThue.Text = "Thanh toán tiền thuê";
            this.btnTienThue.UseVisualStyleBackColor = false;
            this.btnTienThue.Click += new System.EventHandler(this.btnTienThue_Click);
            // 
            // grpDichVu
            // 
            this.grpDichVu.Controls.Add(this.btnDichVu);
            this.grpDichVu.Controls.Add(this.btnHoaDonDV);
            this.grpDichVu.Controls.Add(this.btnThanhToanDV);
            this.grpDichVu.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.grpDichVu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(72)))), ((int)(((byte)(105)))));
            this.grpDichVu.Location = new System.Drawing.Point(55, 375);
            this.grpDichVu.Name = "grpDichVu";
            this.grpDichVu.Size = new System.Drawing.Size(940, 110);
            this.grpDichVu.TabIndex = 3;
            this.grpDichVu.TabStop = false;
            this.grpDichVu.Text = "QUẢN LÝ DỊCH VỤ";
            // 
            // btnDichVu
            // 
            this.btnDichVu.BackColor = System.Drawing.Color.White;
            this.btnDichVu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDichVu.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnDichVu.ForeColor = System.Drawing.Color.Black;
            this.btnDichVu.Location = new System.Drawing.Point(40, 40);
            this.btnDichVu.Name = "btnDichVu";
            this.btnDichVu.Size = new System.Drawing.Size(260, 45);
            this.btnDichVu.TabIndex = 0;
            this.btnDichVu.Text = "Danh mục dịch vụ";
            this.btnDichVu.UseVisualStyleBackColor = false;
            this.btnDichVu.Click += new System.EventHandler(this.btnDichVu_Click);
            // 
            // btnHoaDonDV
            // 
            this.btnHoaDonDV.BackColor = System.Drawing.Color.White;
            this.btnHoaDonDV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHoaDonDV.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnHoaDonDV.ForeColor = System.Drawing.Color.Black;
            this.btnHoaDonDV.Location = new System.Drawing.Point(340, 40);
            this.btnHoaDonDV.Name = "btnHoaDonDV";
            this.btnHoaDonDV.Size = new System.Drawing.Size(260, 45);
            this.btnHoaDonDV.TabIndex = 1;
            this.btnHoaDonDV.Text = "Hóa đơn dịch vụ";
            this.btnHoaDonDV.UseVisualStyleBackColor = false;
            this.btnHoaDonDV.Click += new System.EventHandler(this.btnHoaDonDV_Click);
            // 
            // btnThanhToanDV
            // 
            this.btnThanhToanDV.BackColor = System.Drawing.Color.White;
            this.btnThanhToanDV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThanhToanDV.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnThanhToanDV.ForeColor = System.Drawing.Color.Black;
            this.btnThanhToanDV.Location = new System.Drawing.Point(640, 40);
            this.btnThanhToanDV.Name = "btnThanhToanDV";
            this.btnThanhToanDV.Size = new System.Drawing.Size(260, 45);
            this.btnThanhToanDV.TabIndex = 2;
            this.btnThanhToanDV.Text = "Thanh toán dịch vụ";
            this.btnThanhToanDV.UseVisualStyleBackColor = false;
            this.btnThanhToanDV.Click += new System.EventHandler(this.btnThanhToanDV_Click);
            // 
            // grpVanHanh
            // 
            this.grpVanHanh.Controls.Add(this.btnNhanVien);
            this.grpVanHanh.Controls.Add(this.btnTheXe);
            this.grpVanHanh.Controls.Add(this.btnKiemTra);
            this.grpVanHanh.Controls.Add(this.btnXuPhat);
            this.grpVanHanh.Controls.Add(this.btnThongKe);
            this.grpVanHanh.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.grpVanHanh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(72)))), ((int)(((byte)(105)))));
            this.grpVanHanh.Location = new System.Drawing.Point(55, 500);
            this.grpVanHanh.Name = "grpVanHanh";
            this.grpVanHanh.Size = new System.Drawing.Size(940, 165);
            this.grpVanHanh.TabIndex = 4;
            this.grpVanHanh.TabStop = false;
            this.grpVanHanh.Text = "QUẢN LÝ VẬN HÀNH";
            // 
            // btnNhanVien
            // 
            this.btnNhanVien.BackColor = System.Drawing.Color.White;
            this.btnNhanVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNhanVien.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnNhanVien.ForeColor = System.Drawing.Color.Black;
            this.btnNhanVien.Location = new System.Drawing.Point(40, 35);
            this.btnNhanVien.Name = "btnNhanVien";
            this.btnNhanVien.Size = new System.Drawing.Size(260, 45);
            this.btnNhanVien.TabIndex = 0;
            this.btnNhanVien.Text = "Nhân viên văn phòng";
            this.btnNhanVien.UseVisualStyleBackColor = false;
            this.btnNhanVien.Click += new System.EventHandler(this.btnNhanVien_Click);
            // 
            // btnTheXe
            // 
            this.btnTheXe.BackColor = System.Drawing.Color.White;
            this.btnTheXe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTheXe.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnTheXe.ForeColor = System.Drawing.Color.Black;
            this.btnTheXe.Location = new System.Drawing.Point(340, 35);
            this.btnTheXe.Name = "btnTheXe";
            this.btnTheXe.Size = new System.Drawing.Size(260, 45);
            this.btnTheXe.TabIndex = 1;
            this.btnTheXe.Text = "Thẻ giữ xe";
            this.btnTheXe.UseVisualStyleBackColor = false;
            this.btnTheXe.Click += new System.EventHandler(this.btnTheXe_Click);
            // 
            // btnKiemTra
            // 
            this.btnKiemTra.BackColor = System.Drawing.Color.White;
            this.btnKiemTra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKiemTra.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnKiemTra.ForeColor = System.Drawing.Color.Black;
            this.btnKiemTra.Location = new System.Drawing.Point(640, 35);
            this.btnKiemTra.Name = "btnKiemTra";
            this.btnKiemTra.Size = new System.Drawing.Size(260, 45);
            this.btnKiemTra.TabIndex = 2;
            this.btnKiemTra.Text = "Kiểm tra văn phòng";
            this.btnKiemTra.UseVisualStyleBackColor = false;
            this.btnKiemTra.Click += new System.EventHandler(this.btnKiemTra_Click);
            // 
            // btnXuPhat
            // 
            this.btnXuPhat.BackColor = System.Drawing.Color.White;
            this.btnXuPhat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXuPhat.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnXuPhat.ForeColor = System.Drawing.Color.Black;
            this.btnXuPhat.Location = new System.Drawing.Point(40, 95);
            this.btnXuPhat.Name = "btnXuPhat";
            this.btnXuPhat.Size = new System.Drawing.Size(260, 45);
            this.btnXuPhat.TabIndex = 3;
            this.btnXuPhat.Text = "Xử phạt vi phạm";
            this.btnXuPhat.UseVisualStyleBackColor = false;
            this.btnXuPhat.Click += new System.EventHandler(this.btnXuPhat_Click);
            // 
            // btnThongKe
            // 
            this.btnThongKe.BackColor = System.Drawing.Color.White;
            this.btnThongKe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThongKe.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnThongKe.ForeColor = System.Drawing.Color.Black;
            this.btnThongKe.Location = new System.Drawing.Point(340, 95);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(260, 45);
            this.btnThongKe.TabIndex = 4;
            this.btnThongKe.Text = "Thống kê và báo cáo";
            this.btnThongKe.UseVisualStyleBackColor = false;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnThoat.ForeColor = System.Drawing.Color.White;
            this.btnThoat.Location = new System.Drawing.Point(395, 691);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(210, 45);
            this.btnThoat.TabIndex = 6;
            this.btnThoat.Text = "THOÁT";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(249)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(1077, 770);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.grpVanHanh);
            this.Controls.Add(this.grpDichVu);
            this.Controls.Add(this.grpHopDong);
            this.Controls.Add(this.grpDanhMuc);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý cho thuê văn phòng";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.grpDanhMuc.ResumeLayout(false);
            this.grpHopDong.ResumeLayout(false);
            this.grpDichVu.ResumeLayout(false);
            this.grpVanHanh.ResumeLayout(false);
            this.ResumeLayout(false);

        }
    }
}
