
namespace QuanLyChoThueVanPhong.Forms
{
    partial class FrmXuPhat
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.GroupBox grpThongTin;
        private System.Windows.Forms.GroupBox grpDanhSach;
        private System.Windows.Forms.Label lblMaPhat;
        private System.Windows.Forms.Label lblPhieuKiemTra;
        private System.Windows.Forms.Label lblNgayLap;
        private System.Windows.Forms.Label lblSoTienPhat;
        private System.Windows.Forms.Label lblLyDo;
        private System.Windows.Forms.Label lblTrangThai;
        private System.Windows.Forms.Label lblTimKiem;
        private System.Windows.Forms.TextBox txtMaPhat;
        private System.Windows.Forms.TextBox txtLyDo;
        private System.Windows.Forms.TextBox txtTrangThai;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.ComboBox cboPhieuKiemTra;
        private System.Windows.Forms.DateTimePicker dtNgayLap;
        private System.Windows.Forms.NumericUpDown nudSoTienPhat;
        private System.Windows.Forms.DataGridView dgvXuPhat;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnTimKiem;
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
            this.grpDanhSach = new System.Windows.Forms.GroupBox();
            this.lblMaPhat = new System.Windows.Forms.Label();
            this.lblPhieuKiemTra = new System.Windows.Forms.Label();
            this.lblNgayLap = new System.Windows.Forms.Label();
            this.lblSoTienPhat = new System.Windows.Forms.Label();
            this.lblLyDo = new System.Windows.Forms.Label();
            this.lblTrangThai = new System.Windows.Forms.Label();
            this.lblTimKiem = new System.Windows.Forms.Label();
            this.txtMaPhat = new System.Windows.Forms.TextBox();
            this.txtLyDo = new System.Windows.Forms.TextBox();
            this.txtTrangThai = new System.Windows.Forms.TextBox();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.cboPhieuKiemTra = new System.Windows.Forms.ComboBox();
            this.dtNgayLap = new System.Windows.Forms.DateTimePicker();
            this.nudSoTienPhat = new System.Windows.Forms.NumericUpDown();
            this.dgvXuPhat = new System.Windows.Forms.DataGridView();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();

            this.grpThongTin.SuspendLayout();
            this.grpDanhSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoTienPhat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvXuPhat)).BeginInit();
            this.SuspendLayout();

            this.lblTieuDe.AutoSize = true;
            this.lblTieuDe.Font = new System.Drawing.Font(
                "Segoe UI", 19F, System.Drawing.FontStyle.Bold);
            this.lblTieuDe.ForeColor =
                System.Drawing.Color.FromArgb(34, 72, 105);
            this.lblTieuDe.Location = new System.Drawing.Point(365, 20);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.TabIndex = 0;
            this.lblTieuDe.Text = "QUẢN LÝ XỬ PHẠT";

            this.grpThongTin.Controls.Add(this.lblMaPhat);
            this.grpThongTin.Controls.Add(this.lblPhieuKiemTra);
            this.grpThongTin.Controls.Add(this.lblNgayLap);
            this.grpThongTin.Controls.Add(this.lblSoTienPhat);
            this.grpThongTin.Controls.Add(this.lblLyDo);
            this.grpThongTin.Controls.Add(this.lblTrangThai);
            this.grpThongTin.Controls.Add(this.txtMaPhat);
            this.grpThongTin.Controls.Add(this.cboPhieuKiemTra);
            this.grpThongTin.Controls.Add(this.dtNgayLap);
            this.grpThongTin.Controls.Add(this.nudSoTienPhat);
            this.grpThongTin.Controls.Add(this.txtLyDo);
            this.grpThongTin.Controls.Add(this.txtTrangThai);
            this.grpThongTin.Font = new System.Drawing.Font(
                "Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpThongTin.ForeColor =
                System.Drawing.Color.FromArgb(34, 72, 105);
            this.grpThongTin.Location = new System.Drawing.Point(30, 80);
            this.grpThongTin.Name = "grpThongTin";
            this.grpThongTin.Size = new System.Drawing.Size(1040, 260);
            this.grpThongTin.TabIndex = 1;
            this.grpThongTin.TabStop = false;
            this.grpThongTin.Text = "THÔNG TIN PHIẾU XỬ PHẠT";

            this.lblMaPhat.AutoSize = true;
            this.lblMaPhat.Location = new System.Drawing.Point(25, 42);
            this.lblMaPhat.Name = "lblMaPhat";
            this.lblMaPhat.Text = "Mã phiếu phạt:";

            this.txtMaPhat.Location = new System.Drawing.Point(180, 39);
            this.txtMaPhat.MaxLength = 20;
            this.txtMaPhat.Name = "txtMaPhat";
            this.txtMaPhat.Size = new System.Drawing.Size(280, 25);
            this.txtMaPhat.TabIndex = 0;

            this.lblPhieuKiemTra.AutoSize = true;
            this.lblPhieuKiemTra.Location =
                new System.Drawing.Point(535, 42);
            this.lblPhieuKiemTra.Name = "lblPhieuKiemTra";
            this.lblPhieuKiemTra.Text = "Phiếu kiểm tra:";

            this.cboPhieuKiemTra.DropDownStyle =
                System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPhieuKiemTra.FormattingEnabled = true;
            this.cboPhieuKiemTra.Location =
                new System.Drawing.Point(700, 39);
            this.cboPhieuKiemTra.Name = "cboPhieuKiemTra";
            this.cboPhieuKiemTra.Size =
                new System.Drawing.Size(285, 25);
            this.cboPhieuKiemTra.TabIndex = 1;

            this.lblNgayLap.AutoSize = true;
            this.lblNgayLap.Location = new System.Drawing.Point(25, 97);
            this.lblNgayLap.Name = "lblNgayLap";
            this.lblNgayLap.Text = "Ngày lập:";

            this.dtNgayLap.CustomFormat = "dd/MM/yyyy";
            this.dtNgayLap.Format =
                System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtNgayLap.Location = new System.Drawing.Point(180, 94);
            this.dtNgayLap.Name = "dtNgayLap";
            this.dtNgayLap.Size = new System.Drawing.Size(280, 25);
            this.dtNgayLap.TabIndex = 2;

            this.lblSoTienPhat.AutoSize = true;
            this.lblSoTienPhat.Location =
                new System.Drawing.Point(535, 97);
            this.lblSoTienPhat.Name = "lblSoTienPhat";
            this.lblSoTienPhat.Text = "Số tiền phạt:";

            this.nudSoTienPhat.Location =
                new System.Drawing.Point(700, 94);
            this.nudSoTienPhat.Maximum = new decimal(
                new int[] { 2000000000, 0, 0, 0 });
            this.nudSoTienPhat.Name = "nudSoTienPhat";
            this.nudSoTienPhat.Size =
                new System.Drawing.Size(285, 25);
            this.nudSoTienPhat.TabIndex = 3;
            this.nudSoTienPhat.ThousandsSeparator = true;

            this.lblLyDo.AutoSize = true;
            this.lblLyDo.Location = new System.Drawing.Point(25, 152);
            this.lblLyDo.Name = "lblLyDo";
            this.lblLyDo.Text = "Lý do xử phạt:";

            this.txtLyDo.Location = new System.Drawing.Point(180, 149);
            this.txtLyDo.MaxLength = 500;
            this.txtLyDo.Multiline = true;
            this.txtLyDo.Name = "txtLyDo";
            this.txtLyDo.ScrollBars =
                System.Windows.Forms.ScrollBars.Vertical;
            this.txtLyDo.Size = new System.Drawing.Size(805, 55);
            this.txtLyDo.TabIndex = 4;

            this.lblTrangThai.AutoSize = true;
            this.lblTrangThai.Location =
                new System.Drawing.Point(25, 222);
            this.lblTrangThai.Name = "lblTrangThai";
            this.lblTrangThai.Text = "Trạng thái:";

            this.txtTrangThai.Location = new System.Drawing.Point(180, 219);
            this.txtTrangThai.MaxLength = 100;
            this.txtTrangThai.Name = "txtTrangThai";
            this.txtTrangThai.Size = new System.Drawing.Size(280, 25);
            this.txtTrangThai.TabIndex = 5;

            this.btnThem.BackColor =
                System.Drawing.Color.FromArgb(41, 128, 85);
            this.btnThem.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(60, 360);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(140, 42);
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = "THÊM";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click +=
                new System.EventHandler(this.btnThem_Click);

            this.btnSua.BackColor =
                System.Drawing.Color.FromArgb(39, 106, 166);
            this.btnSua.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(220, 360);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(140, 42);
            this.btnSua.TabIndex = 3;
            this.btnSua.Text = "SỬA";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click +=
                new System.EventHandler(this.btnSua_Click);

            this.btnXoa.BackColor =
                System.Drawing.Color.FromArgb(180, 65, 65);
            this.btnXoa.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(380, 360);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(140, 42);
            this.btnXoa.TabIndex = 4;
            this.btnXoa.Text = "XÓA";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click +=
                new System.EventHandler(this.btnXoa_Click);

            this.btnLamMoi.BackColor =
                System.Drawing.Color.FromArgb(100, 110, 120);
            this.btnLamMoi.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;
            this.btnLamMoi.ForeColor = System.Drawing.Color.White;
            this.btnLamMoi.Location = new System.Drawing.Point(540, 360);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(140, 42);
            this.btnLamMoi.TabIndex = 5;
            this.btnLamMoi.Text = "LÀM MỚI";
            this.btnLamMoi.UseVisualStyleBackColor = false;
            this.btnLamMoi.Click +=
                new System.EventHandler(this.btnLamMoi_Click);

            this.btnDong.BackColor =
                System.Drawing.Color.FromArgb(180, 65, 65);
            this.btnDong.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;
            this.btnDong.ForeColor = System.Drawing.Color.White;
            this.btnDong.Location = new System.Drawing.Point(870, 360);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(140, 42);
            this.btnDong.TabIndex = 6;
            this.btnDong.Text = "ĐÓNG";
            this.btnDong.UseVisualStyleBackColor = false;
            this.btnDong.Click +=
                new System.EventHandler(this.btnDong_Click);

            this.grpDanhSach.Controls.Add(this.lblTimKiem);
            this.grpDanhSach.Controls.Add(this.txtTimKiem);
            this.grpDanhSach.Controls.Add(this.btnTimKiem);
            this.grpDanhSach.Controls.Add(this.dgvXuPhat);
            this.grpDanhSach.Font = new System.Drawing.Font(
                "Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpDanhSach.ForeColor =
                System.Drawing.Color.FromArgb(34, 72, 105);
            this.grpDanhSach.Location = new System.Drawing.Point(30, 425);
            this.grpDanhSach.Name = "grpDanhSach";
            this.grpDanhSach.Size = new System.Drawing.Size(1040, 325);
            this.grpDanhSach.TabIndex = 7;
            this.grpDanhSach.TabStop = false;
            this.grpDanhSach.Text = "DANH SÁCH PHIẾU XỬ PHẠT";

            this.lblTimKiem.AutoSize = true;
            this.lblTimKiem.Location = new System.Drawing.Point(25, 37);
            this.lblTimKiem.Name = "lblTimKiem";
            this.lblTimKiem.Text = "Tìm kiếm:";

            this.txtTimKiem.Location = new System.Drawing.Point(130, 34);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(520, 25);
            this.txtTimKiem.TabIndex = 0;

            this.btnTimKiem.BackColor =
                System.Drawing.Color.FromArgb(39, 106, 166);
            this.btnTimKiem.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiem.ForeColor = System.Drawing.Color.White;
            this.btnTimKiem.Location =
                new System.Drawing.Point(690, 29);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size =
                new System.Drawing.Size(165, 37);
            this.btnTimKiem.TabIndex = 1;
            this.btnTimKiem.Text = "TÌM KIẾM";
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click +=
                new System.EventHandler(this.btnTimKiem_Click);

            this.dgvXuPhat.AllowUserToAddRows = false;
            this.dgvXuPhat.AllowUserToDeleteRows = false;
            this.dgvXuPhat.AutoSizeColumnsMode =
                System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvXuPhat.BackgroundColor = System.Drawing.Color.White;
            this.dgvXuPhat.Location = new System.Drawing.Point(20, 83);
            this.dgvXuPhat.MultiSelect = false;
            this.dgvXuPhat.Name = "dgvXuPhat";
            this.dgvXuPhat.ReadOnly = true;
            this.dgvXuPhat.RowHeadersVisible = false;
            this.dgvXuPhat.SelectionMode =
                System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvXuPhat.Size = new System.Drawing.Size(1000, 220);
            this.dgvXuPhat.TabIndex = 2;
            this.dgvXuPhat.CellClick +=
                new System.Windows.Forms.DataGridViewCellEventHandler(
                    this.dgvXuPhat_CellClick);

            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode =
                System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor =
                System.Drawing.Color.FromArgb(247, 249, 252);
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
            this.Name = "FrmXuPhat";
            this.StartPosition =
                System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Quản lý xử phạt";
            this.Load +=
                new System.EventHandler(this.FrmXuPhat_Load);

            this.grpThongTin.ResumeLayout(false);
            this.grpThongTin.PerformLayout();
            this.grpDanhSach.ResumeLayout(false);
            this.grpDanhSach.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoTienPhat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvXuPhat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
