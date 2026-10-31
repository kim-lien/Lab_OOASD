
namespace QuanLyChoThueVanPhong.Forms
{
    partial class FrmThanhToanThue
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.Label lblHopDong;
        private System.Windows.Forms.Label lblMaThanhToan;
        private System.Windows.Forms.Label lblMaKy;
        private System.Windows.Forms.Label lblMaPhong;
        private System.Windows.Forms.Label lblThangThu;
        private System.Windows.Forms.Label lblPhaiThu;
        private System.Windows.Forms.Label lblDaThanhToan;
        private System.Windows.Forms.Label lblConNo;
        private System.Windows.Forms.Label lblSoTien;
        private System.Windows.Forms.Label lblHinhThuc;
        private System.Windows.Forms.GroupBox grpKyThanhToan;
        private System.Windows.Forms.GroupBox grpThongTin;
        private System.Windows.Forms.GroupBox grpLichSu;
        private System.Windows.Forms.ComboBox cboHopDong;
        private System.Windows.Forms.ComboBox cboHinhThuc;
        private System.Windows.Forms.TextBox txtMaThanhToan;
        private System.Windows.Forms.TextBox txtMaKy;
        private System.Windows.Forms.TextBox txtMaPhong;
        private System.Windows.Forms.TextBox txtThangThu;
        private System.Windows.Forms.TextBox txtPhaiThu;
        private System.Windows.Forms.TextBox txtDaThanhToan;
        private System.Windows.Forms.TextBox txtConNo;
        private System.Windows.Forms.NumericUpDown nudSoTien;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.DataGridView dgvKyThanhToan;
        private System.Windows.Forms.DataGridView dgvLichSu;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.lblHopDong = new System.Windows.Forms.Label();
            this.lblMaThanhToan = new System.Windows.Forms.Label();
            this.lblMaKy = new System.Windows.Forms.Label();
            this.lblMaPhong = new System.Windows.Forms.Label();
            this.lblThangThu = new System.Windows.Forms.Label();
            this.lblPhaiThu = new System.Windows.Forms.Label();
            this.lblDaThanhToan = new System.Windows.Forms.Label();
            this.lblConNo = new System.Windows.Forms.Label();
            this.lblSoTien = new System.Windows.Forms.Label();
            this.lblHinhThuc = new System.Windows.Forms.Label();
            this.grpKyThanhToan = new System.Windows.Forms.GroupBox();
            this.dgvKyThanhToan = new System.Windows.Forms.DataGridView();
            this.grpThongTin = new System.Windows.Forms.GroupBox();
            this.txtMaThanhToan = new System.Windows.Forms.TextBox();
            this.txtMaKy = new System.Windows.Forms.TextBox();
            this.txtMaPhong = new System.Windows.Forms.TextBox();
            this.txtThangThu = new System.Windows.Forms.TextBox();
            this.txtPhaiThu = new System.Windows.Forms.TextBox();
            this.txtDaThanhToan = new System.Windows.Forms.TextBox();
            this.txtConNo = new System.Windows.Forms.TextBox();
            this.nudSoTien = new System.Windows.Forms.NumericUpDown();
            this.cboHinhThuc = new System.Windows.Forms.ComboBox();
            this.grpLichSu = new System.Windows.Forms.GroupBox();
            this.dgvLichSu = new System.Windows.Forms.DataGridView();
            this.cboHopDong = new System.Windows.Forms.ComboBox();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.grpKyThanhToan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKyThanhToan)).BeginInit();
            this.grpThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoTien)).BeginInit();
            this.grpLichSu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichSu)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.AutoSize = true;
            this.lblTieuDe.Font = new System.Drawing.Font("Segoe UI", 19F, System.Drawing.FontStyle.Bold);
            this.lblTieuDe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(72)))), ((int)(((byte)(105)))));
            this.lblTieuDe.Location = new System.Drawing.Point(325, 20);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(567, 61);
            this.lblTieuDe.TabIndex = 0;
            this.lblTieuDe.Text = "THANH TOÁN TIỀN THUÊ";
            // 
            // lblHopDong
            // 
            this.lblHopDong.AutoSize = true;
            this.lblHopDong.Location = new System.Drawing.Point(35, 83);
            this.lblHopDong.Name = "lblHopDong";
            this.lblHopDong.Size = new System.Drawing.Size(164, 30);
            this.lblHopDong.TabIndex = 1;
            this.lblHopDong.Text = "Chọn hợp đồng:";
            // 
            // lblMaThanhToan
            // 
            this.lblMaThanhToan.AutoSize = true;
            this.lblMaThanhToan.Location = new System.Drawing.Point(20, 35);
            this.lblMaThanhToan.Name = "lblMaThanhToan";
            this.lblMaThanhToan.Size = new System.Drawing.Size(188, 32);
            this.lblMaThanhToan.TabIndex = 0;
            this.lblMaThanhToan.Text = "Mã thanh toán:";
            // 
            // lblMaKy
            // 
            this.lblMaKy.AutoSize = true;
            this.lblMaKy.Location = new System.Drawing.Point(555, 35);
            this.lblMaKy.Name = "lblMaKy";
            this.lblMaKy.Size = new System.Drawing.Size(90, 32);
            this.lblMaKy.TabIndex = 1;
            this.lblMaKy.Text = "Mã kỳ:";
            // 
            // lblMaPhong
            // 
            this.lblMaPhong.AutoSize = true;
            this.lblMaPhong.Location = new System.Drawing.Point(20, 75);
            this.lblMaPhong.Name = "lblMaPhong";
            this.lblMaPhong.Size = new System.Drawing.Size(138, 32);
            this.lblMaPhong.TabIndex = 2;
            this.lblMaPhong.Text = "Mã phòng:";
            // 
            // lblThangThu
            // 
            this.lblThangThu.AutoSize = true;
            this.lblThangThu.Location = new System.Drawing.Point(555, 75);
            this.lblThangThu.Name = "lblThangThu";
            this.lblThangThu.Size = new System.Drawing.Size(138, 32);
            this.lblThangThu.TabIndex = 3;
            this.lblThangThu.Text = "Tháng thứ:";
            // 
            // lblPhaiThu
            // 
            this.lblPhaiThu.AutoSize = true;
            this.lblPhaiThu.Location = new System.Drawing.Point(20, 115);
            this.lblPhaiThu.Name = "lblPhaiThu";
            this.lblPhaiThu.Size = new System.Drawing.Size(201, 32);
            this.lblPhaiThu.TabIndex = 4;
            this.lblPhaiThu.Text = "Số tiền phải thu:";
            // 
            // lblDaThanhToan
            // 
            this.lblDaThanhToan.AutoSize = true;
            this.lblDaThanhToan.Location = new System.Drawing.Point(555, 115);
            this.lblDaThanhToan.Name = "lblDaThanhToan";
            this.lblDaThanhToan.Size = new System.Drawing.Size(183, 32);
            this.lblDaThanhToan.TabIndex = 5;
            this.lblDaThanhToan.Text = "Đã thanh toán:";
            // 
            // lblConNo
            // 
            this.lblConNo.AutoSize = true;
            this.lblConNo.Location = new System.Drawing.Point(20, 155);
            this.lblConNo.Name = "lblConNo";
            this.lblConNo.Size = new System.Drawing.Size(186, 32);
            this.lblConNo.TabIndex = 6;
            this.lblConNo.Text = "Số tiền còn nợ:";
            // 
            // lblSoTien
            // 
            this.lblSoTien.AutoSize = true;
            this.lblSoTien.Location = new System.Drawing.Point(555, 155);
            this.lblSoTien.Name = "lblSoTien";
            this.lblSoTien.Size = new System.Drawing.Size(231, 32);
            this.lblSoTien.TabIndex = 7;
            this.lblSoTien.Text = "Số tiền thanh toán:";
            // 
            // lblHinhThuc
            // 
            this.lblHinhThuc.AutoSize = true;
            this.lblHinhThuc.Location = new System.Drawing.Point(20, 185);
            this.lblHinhThuc.Name = "lblHinhThuc";
            this.lblHinhThuc.Size = new System.Drawing.Size(264, 32);
            this.lblHinhThuc.TabIndex = 8;
            this.lblHinhThuc.Text = "Hình thức thanh toán:";
            // 
            // grpKyThanhToan
            // 
            this.grpKyThanhToan.Controls.Add(this.dgvKyThanhToan);
            this.grpKyThanhToan.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpKyThanhToan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(72)))), ((int)(((byte)(105)))));
            this.grpKyThanhToan.Location = new System.Drawing.Point(30, 125);
            this.grpKyThanhToan.Name = "grpKyThanhToan";
            this.grpKyThanhToan.Size = new System.Drawing.Size(1050, 245);
            this.grpKyThanhToan.TabIndex = 3;
            this.grpKyThanhToan.TabStop = false;
            this.grpKyThanhToan.Text = "DANH SÁCH KỲ THANH TOÁN";
            // 
            // dgvKyThanhToan
            // 
            this.dgvKyThanhToan.AllowUserToAddRows = false;
            this.dgvKyThanhToan.AllowUserToDeleteRows = false;
            this.dgvKyThanhToan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKyThanhToan.BackgroundColor = System.Drawing.Color.White;
            this.dgvKyThanhToan.ColumnHeadersHeight = 40;
            this.dgvKyThanhToan.Location = new System.Drawing.Point(20, 30);
            this.dgvKyThanhToan.MultiSelect = false;
            this.dgvKyThanhToan.Name = "dgvKyThanhToan";
            this.dgvKyThanhToan.ReadOnly = true;
            this.dgvKyThanhToan.RowHeadersVisible = false;
            this.dgvKyThanhToan.RowHeadersWidth = 72;
            this.dgvKyThanhToan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKyThanhToan.Size = new System.Drawing.Size(1010, 195);
            this.dgvKyThanhToan.TabIndex = 0;
            this.dgvKyThanhToan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKyThanhToan_CellClick);
            // 
            // grpThongTin
            // 
            this.grpThongTin.Controls.Add(this.lblMaThanhToan);
            this.grpThongTin.Controls.Add(this.lblMaKy);
            this.grpThongTin.Controls.Add(this.lblMaPhong);
            this.grpThongTin.Controls.Add(this.lblThangThu);
            this.grpThongTin.Controls.Add(this.lblPhaiThu);
            this.grpThongTin.Controls.Add(this.lblDaThanhToan);
            this.grpThongTin.Controls.Add(this.lblConNo);
            this.grpThongTin.Controls.Add(this.lblSoTien);
            this.grpThongTin.Controls.Add(this.lblHinhThuc);
            this.grpThongTin.Controls.Add(this.txtMaThanhToan);
            this.grpThongTin.Controls.Add(this.txtMaKy);
            this.grpThongTin.Controls.Add(this.txtMaPhong);
            this.grpThongTin.Controls.Add(this.txtThangThu);
            this.grpThongTin.Controls.Add(this.txtPhaiThu);
            this.grpThongTin.Controls.Add(this.txtDaThanhToan);
            this.grpThongTin.Controls.Add(this.txtConNo);
            this.grpThongTin.Controls.Add(this.nudSoTien);
            this.grpThongTin.Controls.Add(this.cboHinhThuc);
            this.grpThongTin.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpThongTin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(72)))), ((int)(((byte)(105)))));
            this.grpThongTin.Location = new System.Drawing.Point(30, 385);
            this.grpThongTin.Name = "grpThongTin";
            this.grpThongTin.Size = new System.Drawing.Size(1050, 225);
            this.grpThongTin.TabIndex = 4;
            this.grpThongTin.TabStop = false;
            this.grpThongTin.Text = "THÔNG TIN THANH TOÁN";
            // 
            // txtMaThanhToan
            // 
            this.txtMaThanhToan.Location = new System.Drawing.Point(214, 32);
            this.txtMaThanhToan.MaxLength = 20;
            this.txtMaThanhToan.Name = "txtMaThanhToan";
            this.txtMaThanhToan.Size = new System.Drawing.Size(255, 39);
            this.txtMaThanhToan.TabIndex = 9;
            // 
            // txtMaKy
            // 
            this.txtMaKy.Location = new System.Drawing.Point(720, 32);
            this.txtMaKy.Name = "txtMaKy";
            this.txtMaKy.ReadOnly = true;
            this.txtMaKy.Size = new System.Drawing.Size(255, 39);
            this.txtMaKy.TabIndex = 10;
            // 
            // txtMaPhong
            // 
            this.txtMaPhong.Location = new System.Drawing.Point(175, 72);
            this.txtMaPhong.Name = "txtMaPhong";
            this.txtMaPhong.ReadOnly = true;
            this.txtMaPhong.Size = new System.Drawing.Size(255, 39);
            this.txtMaPhong.TabIndex = 11;
            // 
            // txtThangThu
            // 
            this.txtThangThu.Location = new System.Drawing.Point(720, 72);
            this.txtThangThu.Name = "txtThangThu";
            this.txtThangThu.ReadOnly = true;
            this.txtThangThu.Size = new System.Drawing.Size(255, 39);
            this.txtThangThu.TabIndex = 12;
            // 
            // txtPhaiThu
            // 
            this.txtPhaiThu.Location = new System.Drawing.Point(220, 112);
            this.txtPhaiThu.Name = "txtPhaiThu";
            this.txtPhaiThu.ReadOnly = true;
            this.txtPhaiThu.Size = new System.Drawing.Size(233, 39);
            this.txtPhaiThu.TabIndex = 13;
            // 
            // txtDaThanhToan
            // 
            this.txtDaThanhToan.Location = new System.Drawing.Point(720, 112);
            this.txtDaThanhToan.Name = "txtDaThanhToan";
            this.txtDaThanhToan.ReadOnly = true;
            this.txtDaThanhToan.Size = new System.Drawing.Size(255, 39);
            this.txtDaThanhToan.TabIndex = 14;
            // 
            // txtConNo
            // 
            this.txtConNo.Location = new System.Drawing.Point(175, 152);
            this.txtConNo.Name = "txtConNo";
            this.txtConNo.ReadOnly = true;
            this.txtConNo.Size = new System.Drawing.Size(255, 39);
            this.txtConNo.TabIndex = 15;
            // 
            // nudSoTien
            // 
            this.nudSoTien.Location = new System.Drawing.Point(789, 152);
            this.nudSoTien.Maximum = new decimal(new int[] {
            -1,
            -1,
            542101086,
            0});
            this.nudSoTien.Name = "nudSoTien";
            this.nudSoTien.Size = new System.Drawing.Size(214, 39);
            this.nudSoTien.TabIndex = 16;
            this.nudSoTien.ThousandsSeparator = true;
            // 
            // cboHinhThuc
            // 
            this.cboHinhThuc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboHinhThuc.Location = new System.Drawing.Point(290, 182);
            this.cboHinhThuc.Name = "cboHinhThuc";
            this.cboHinhThuc.Size = new System.Drawing.Size(209, 39);
            this.cboHinhThuc.TabIndex = 17;
            // 
            // grpLichSu
            // 
            this.grpLichSu.Controls.Add(this.dgvLichSu);
            this.grpLichSu.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpLichSu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(72)))), ((int)(((byte)(105)))));
            this.grpLichSu.Location = new System.Drawing.Point(30, 665);
            this.grpLichSu.Name = "grpLichSu";
            this.grpLichSu.Size = new System.Drawing.Size(1050, 195);
            this.grpLichSu.TabIndex = 8;
            this.grpLichSu.TabStop = false;
            this.grpLichSu.Text = "LỊCH SỬ THANH TOÁN";
            // 
            // dgvLichSu
            // 
            this.dgvLichSu.AllowUserToAddRows = false;
            this.dgvLichSu.AllowUserToDeleteRows = false;
            this.dgvLichSu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLichSu.BackgroundColor = System.Drawing.Color.White;
            this.dgvLichSu.ColumnHeadersHeight = 40;
            this.dgvLichSu.Location = new System.Drawing.Point(20, 30);
            this.dgvLichSu.Name = "dgvLichSu";
            this.dgvLichSu.ReadOnly = true;
            this.dgvLichSu.RowHeadersVisible = false;
            this.dgvLichSu.RowHeadersWidth = 72;
            this.dgvLichSu.Size = new System.Drawing.Size(1010, 145);
            this.dgvLichSu.TabIndex = 0;
            // 
            // cboHopDong
            // 
            this.cboHopDong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboHopDong.FormattingEnabled = true;
            this.cboHopDong.Location = new System.Drawing.Point(205, 81);
            this.cboHopDong.Name = "cboHopDong";
            this.cboHopDong.Size = new System.Drawing.Size(300, 38);
            this.cboHopDong.TabIndex = 2;
            this.cboHopDong.SelectedIndexChanged += new System.EventHandler(this.cboHopDong_SelectedIndexChanged);
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(85)))));
            this.btnThanhToan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThanhToan.ForeColor = System.Drawing.Color.White;
            this.btnThanhToan.Location = new System.Drawing.Point(56, 616);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(205, 43);
            this.btnThanhToan.TabIndex = 5;
            this.btnThanhToan.Text = "XÁC NHẬN THANH TOÁN";
            this.btnThanhToan.UseVisualStyleBackColor = false;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(106)))), ((int)(((byte)(166)))));
            this.btnLamMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLamMoi.ForeColor = System.Drawing.Color.White;
            this.btnLamMoi.Location = new System.Drawing.Point(300, 616);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(160, 43);
            this.btnLamMoi.TabIndex = 6;
            this.btnLamMoi.Text = "LÀM MỚI";
            this.btnLamMoi.UseVisualStyleBackColor = false;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnDong
            // 
            this.btnDong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.btnDong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDong.ForeColor = System.Drawing.Color.White;
            this.btnDong.Location = new System.Drawing.Point(865, 605);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(160, 43);
            this.btnDong.TabIndex = 7;
            this.btnDong.Text = "ĐÓNG";
            this.btnDong.UseVisualStyleBackColor = false;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // FrmThanhToanThue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(249)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(1110, 885);
            this.Controls.Add(this.lblTieuDe);
            this.Controls.Add(this.lblHopDong);
            this.Controls.Add(this.cboHopDong);
            this.Controls.Add(this.grpKyThanhToan);
            this.Controls.Add(this.grpThongTin);
            this.Controls.Add(this.btnThanhToan);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.grpLichSu);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Name = "FrmThanhToanThue";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Thanh toán tiền thuê văn phòng";
            this.Load += new System.EventHandler(this.FrmThanhToanThue_Load);
            this.grpKyThanhToan.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKyThanhToan)).EndInit();
            this.grpThongTin.ResumeLayout(false);
            this.grpThongTin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoTien)).EndInit();
            this.grpLichSu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichSu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
