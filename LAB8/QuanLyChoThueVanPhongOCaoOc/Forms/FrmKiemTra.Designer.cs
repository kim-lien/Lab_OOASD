
namespace QuanLyChoThueVanPhong.Forms
{
    partial class FrmKiemTra
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.GroupBox grpThongTin;
        private System.Windows.Forms.GroupBox grpDanhSach;
        private System.Windows.Forms.Label lblMaKiemTra;
        private System.Windows.Forms.Label lblVanPhong;
        private System.Windows.Forms.Label lblNgayKiemTra;
        private System.Windows.Forms.Label lblTinhTrang;
        private System.Windows.Forms.Label lblKetLuan;
        private System.Windows.Forms.Label lblNguoiKiemTra;
        private System.Windows.Forms.Label lblTimKiem;
        private System.Windows.Forms.TextBox txtMaKiemTra;
        private System.Windows.Forms.TextBox txtTinhTrang;
        private System.Windows.Forms.TextBox txtKetLuan;
        private System.Windows.Forms.TextBox txtNguoiKiemTra;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.ComboBox cboVanPhong;
        private System.Windows.Forms.DateTimePicker dtNgayKiemTra;
        private System.Windows.Forms.DataGridView dgvKiemTra;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnDong;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.grpThongTin = new System.Windows.Forms.GroupBox();
            this.lblMaKiemTra = new System.Windows.Forms.Label();
            this.lblVanPhong = new System.Windows.Forms.Label();
            this.lblNgayKiemTra = new System.Windows.Forms.Label();
            this.lblTinhTrang = new System.Windows.Forms.Label();
            this.lblKetLuan = new System.Windows.Forms.Label();
            this.lblNguoiKiemTra = new System.Windows.Forms.Label();
            this.txtMaKiemTra = new System.Windows.Forms.TextBox();
            this.cboVanPhong = new System.Windows.Forms.ComboBox();
            this.dtNgayKiemTra = new System.Windows.Forms.DateTimePicker();
            this.txtTinhTrang = new System.Windows.Forms.TextBox();
            this.txtKetLuan = new System.Windows.Forms.TextBox();
            this.txtNguoiKiemTra = new System.Windows.Forms.TextBox();
            this.grpDanhSach = new System.Windows.Forms.GroupBox();
            this.lblTimKiem = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.dgvKiemTra = new System.Windows.Forms.DataGridView();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.grpThongTin.SuspendLayout();
            this.grpDanhSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKiemTra)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.AutoSize = true;
            this.lblTieuDe.Font = new System.Drawing.Font("Segoe UI", 19F, System.Drawing.FontStyle.Bold);
            this.lblTieuDe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(72)))), ((int)(((byte)(105)))));
            this.lblTieuDe.Location = new System.Drawing.Point(340, 18);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(727, 61);
            this.lblTieuDe.TabIndex = 0;
            this.lblTieuDe.Text = "QUẢN LÝ KIỂM TRA VĂN PHÒNG";
            // 
            // grpThongTin
            // 
            this.grpThongTin.Controls.Add(this.lblMaKiemTra);
            this.grpThongTin.Controls.Add(this.lblVanPhong);
            this.grpThongTin.Controls.Add(this.lblNgayKiemTra);
            this.grpThongTin.Controls.Add(this.lblTinhTrang);
            this.grpThongTin.Controls.Add(this.lblKetLuan);
            this.grpThongTin.Controls.Add(this.lblNguoiKiemTra);
            this.grpThongTin.Controls.Add(this.txtMaKiemTra);
            this.grpThongTin.Controls.Add(this.cboVanPhong);
            this.grpThongTin.Controls.Add(this.dtNgayKiemTra);
            this.grpThongTin.Controls.Add(this.txtTinhTrang);
            this.grpThongTin.Controls.Add(this.txtKetLuan);
            this.grpThongTin.Controls.Add(this.txtNguoiKiemTra);
            this.grpThongTin.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpThongTin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(72)))), ((int)(((byte)(105)))));
            this.grpThongTin.Location = new System.Drawing.Point(30, 80);
            this.grpThongTin.Name = "grpThongTin";
            this.grpThongTin.Size = new System.Drawing.Size(1040, 255);
            this.grpThongTin.TabIndex = 1;
            this.grpThongTin.TabStop = false;
            this.grpThongTin.Text = "THÔNG TIN KIỂM TRA";
            // 
            // lblMaKiemTra
            // 
            this.lblMaKiemTra.AutoSize = true;
            this.lblMaKiemTra.Location = new System.Drawing.Point(25, 40);
            this.lblMaKiemTra.Name = "lblMaKiemTra";
            this.lblMaKiemTra.Size = new System.Drawing.Size(158, 32);
            this.lblMaKiemTra.TabIndex = 0;
            this.lblMaKiemTra.Text = "Mã kiểm tra:";
            // 
            // lblVanPhong
            // 
            this.lblVanPhong.AutoSize = true;
            this.lblVanPhong.Location = new System.Drawing.Point(540, 40);
            this.lblVanPhong.Name = "lblVanPhong";
            this.lblVanPhong.Size = new System.Drawing.Size(145, 32);
            this.lblVanPhong.TabIndex = 1;
            this.lblVanPhong.Text = "Văn phòng:";
            // 
            // lblNgayKiemTra
            // 
            this.lblNgayKiemTra.AutoSize = true;
            this.lblNgayKiemTra.Location = new System.Drawing.Point(25, 95);
            this.lblNgayKiemTra.Name = "lblNgayKiemTra";
            this.lblNgayKiemTra.Size = new System.Drawing.Size(182, 32);
            this.lblNgayKiemTra.TabIndex = 2;
            this.lblNgayKiemTra.Text = "Ngày kiểm tra:";
            // 
            // lblTinhTrang
            // 
            this.lblTinhTrang.AutoSize = true;
            this.lblTinhTrang.Location = new System.Drawing.Point(25, 150);
            this.lblTinhTrang.Name = "lblTinhTrang";
            this.lblTinhTrang.Size = new System.Drawing.Size(140, 32);
            this.lblTinhTrang.TabIndex = 3;
            this.lblTinhTrang.Text = "Tình trạng:";
            // 
            // lblKetLuan
            // 
            this.lblKetLuan.AutoSize = true;
            this.lblKetLuan.Location = new System.Drawing.Point(25, 205);
            this.lblKetLuan.Name = "lblKetLuan";
            this.lblKetLuan.Size = new System.Drawing.Size(116, 32);
            this.lblKetLuan.TabIndex = 4;
            this.lblKetLuan.Text = "Kết luận:";
            // 
            // lblNguoiKiemTra
            // 
            this.lblNguoiKiemTra.AutoSize = true;
            this.lblNguoiKiemTra.Location = new System.Drawing.Point(540, 95);
            this.lblNguoiKiemTra.Name = "lblNguoiKiemTra";
            this.lblNguoiKiemTra.Size = new System.Drawing.Size(194, 32);
            this.lblNguoiKiemTra.TabIndex = 5;
            this.lblNguoiKiemTra.Text = "Người kiểm tra:";
            // 
            // txtMaKiemTra
            // 
            this.txtMaKiemTra.Location = new System.Drawing.Point(180, 37);
            this.txtMaKiemTra.MaxLength = 20;
            this.txtMaKiemTra.Name = "txtMaKiemTra";
            this.txtMaKiemTra.Size = new System.Drawing.Size(285, 39);
            this.txtMaKiemTra.TabIndex = 0;
            // 
            // cboVanPhong
            // 
            this.cboVanPhong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboVanPhong.FormattingEnabled = true;
            this.cboVanPhong.Location = new System.Drawing.Point(700, 37);
            this.cboVanPhong.Name = "cboVanPhong";
            this.cboVanPhong.Size = new System.Drawing.Size(285, 39);
            this.cboVanPhong.TabIndex = 1;
            // 
            // dtNgayKiemTra
            // 
            this.dtNgayKiemTra.CustomFormat = "dd/MM/yyyy";
            this.dtNgayKiemTra.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtNgayKiemTra.Location = new System.Drawing.Point(205, 92);
            this.dtNgayKiemTra.Name = "dtNgayKiemTra";
            this.dtNgayKiemTra.Size = new System.Drawing.Size(285, 39);
            this.dtNgayKiemTra.TabIndex = 2;
            // 
            // txtTinhTrang
            // 
            this.txtTinhTrang.Location = new System.Drawing.Point(180, 147);
            this.txtTinhTrang.MaxLength = 300;
            this.txtTinhTrang.Name = "txtTinhTrang";
            this.txtTinhTrang.Size = new System.Drawing.Size(805, 39);
            this.txtTinhTrang.TabIndex = 4;
            // 
            // txtKetLuan
            // 
            this.txtKetLuan.Location = new System.Drawing.Point(180, 202);
            this.txtKetLuan.MaxLength = 500;
            this.txtKetLuan.Name = "txtKetLuan";
            this.txtKetLuan.Size = new System.Drawing.Size(805, 39);
            this.txtKetLuan.TabIndex = 5;
            // 
            // txtNguoiKiemTra
            // 
            this.txtNguoiKiemTra.Location = new System.Drawing.Point(700, 92);
            this.txtNguoiKiemTra.MaxLength = 150;
            this.txtNguoiKiemTra.Name = "txtNguoiKiemTra";
            this.txtNguoiKiemTra.Size = new System.Drawing.Size(285, 39);
            this.txtNguoiKiemTra.TabIndex = 3;
            // 
            // grpDanhSach
            // 
            this.grpDanhSach.Controls.Add(this.lblTimKiem);
            this.grpDanhSach.Controls.Add(this.txtTimKiem);
            this.grpDanhSach.Controls.Add(this.btnTimKiem);
            this.grpDanhSach.Controls.Add(this.dgvKiemTra);
            this.grpDanhSach.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpDanhSach.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(72)))), ((int)(((byte)(105)))));
            this.grpDanhSach.Location = new System.Drawing.Point(30, 420);
            this.grpDanhSach.Name = "grpDanhSach";
            this.grpDanhSach.Size = new System.Drawing.Size(1040, 330);
            this.grpDanhSach.TabIndex = 7;
            this.grpDanhSach.TabStop = false;
            this.grpDanhSach.Text = "DANH SÁCH PHIẾU KIỂM TRA";
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
            this.txtTimKiem.Location = new System.Drawing.Point(130, 34);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(520, 39);
            this.txtTimKiem.TabIndex = 0;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(106)))), ((int)(((byte)(166)))));
            this.btnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiem.ForeColor = System.Drawing.Color.White;
            this.btnTimKiem.Location = new System.Drawing.Point(690, 29);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(165, 37);
            this.btnTimKiem.TabIndex = 1;
            this.btnTimKiem.Text = "TÌM KIẾM";
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // dgvKiemTra
            // 
            this.dgvKiemTra.AllowUserToAddRows = false;
            this.dgvKiemTra.AllowUserToDeleteRows = false;
            this.dgvKiemTra.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKiemTra.BackgroundColor = System.Drawing.Color.White;
            this.dgvKiemTra.ColumnHeadersHeight = 40;
            this.dgvKiemTra.Location = new System.Drawing.Point(20, 83);
            this.dgvKiemTra.MultiSelect = false;
            this.dgvKiemTra.Name = "dgvKiemTra";
            this.dgvKiemTra.ReadOnly = true;
            this.dgvKiemTra.RowHeadersVisible = false;
            this.dgvKiemTra.RowHeadersWidth = 72;
            this.dgvKiemTra.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKiemTra.Size = new System.Drawing.Size(1000, 225);
            this.dgvKiemTra.TabIndex = 2;
            this.dgvKiemTra.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKiemTra_CellClick);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(85)))));
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(60, 355);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(140, 42);
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = "THÊM";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(106)))), ((int)(((byte)(166)))));
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(220, 355);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(140, 42);
            this.btnSua.TabIndex = 3;
            this.btnSua.Text = "SỬA";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(380, 355);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(140, 42);
            this.btnXoa.TabIndex = 4;
            this.btnXoa.Text = "XÓA";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(110)))), ((int)(((byte)(120)))));
            this.btnLamMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLamMoi.ForeColor = System.Drawing.Color.White;
            this.btnLamMoi.Location = new System.Drawing.Point(540, 355);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(140, 42);
            this.btnLamMoi.TabIndex = 5;
            this.btnLamMoi.Text = "LÀM MỚI";
            this.btnLamMoi.UseVisualStyleBackColor = false;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnDong
            // 
            this.btnDong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.btnDong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDong.ForeColor = System.Drawing.Color.White;
            this.btnDong.Location = new System.Drawing.Point(870, 355);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(140, 42);
            this.btnDong.TabIndex = 6;
            this.btnDong.Text = "ĐÓNG";
            this.btnDong.UseVisualStyleBackColor = false;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // FrmKiemTra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(249)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(1100, 780);
            this.Controls.Add(this.lblTieuDe);
            this.Controls.Add(this.grpThongTin);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.grpDanhSach);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Name = "FrmKiemTra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Quản lý kiểm tra văn phòng";
            this.Load += new System.EventHandler(this.FrmKiemTra_Load);
            this.grpThongTin.ResumeLayout(false);
            this.grpThongTin.PerformLayout();
            this.grpDanhSach.ResumeLayout(false);
            this.grpDanhSach.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKiemTra)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
