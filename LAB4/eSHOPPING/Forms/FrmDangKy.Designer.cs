namespace eSHOPPING.UI
{
    partial class FrmDangKy
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Panel pnlRight;

        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.Label lblSlogan;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubTitle;

        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.Label lblCMND;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.Label lblDienThoai;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblEmail;

        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtNgaySinh;
        private System.Windows.Forms.TextBox txtCMND;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtDienThoai;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtEmail;

        private System.Windows.Forms.Button btnRegister;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();

            this.pnlLeft = new System.Windows.Forms.Panel();
            this.lblBrand = new System.Windows.Forms.Label();
            this.lblSlogan = new System.Windows.Forms.Label();

            this.pnlRight = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubTitle = new System.Windows.Forms.Label();

            this.lblHoTen = new System.Windows.Forms.Label();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.lblCMND = new System.Windows.Forms.Label();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.lblDienThoai = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();

            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtNgaySinh = new System.Windows.Forms.TextBox();
            this.txtCMND = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtDienThoai = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();

            this.btnRegister = new System.Windows.Forms.Button();

            this.pnlLeft.SuspendLayout();
            this.pnlRight.SuspendLayout();

            this.SuspendLayout();

            this.pnlLeft.BackColor = System.Drawing.Color.FromArgb(25, 42, 65);
            this.pnlLeft.Controls.Add(this.lblBrand);
            this.pnlLeft.Controls.Add(this.lblSlogan);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(300, 620);
            this.pnlLeft.TabIndex = 0;

            this.lblBrand.AutoSize = true;
            this.lblBrand.Font = new System.Drawing.Font(
                "Segoe UI",
                27F,
                System.Drawing.FontStyle.Bold
            );
            this.lblBrand.ForeColor = System.Drawing.Color.White;
            this.lblBrand.Location = new System.Drawing.Point(38, 245);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Text = "e-SHOPPING";

            this.lblSlogan.Font = new System.Drawing.Font(
                "Segoe UI",
                11F
            );
            this.lblSlogan.ForeColor = System.Drawing.Color.FromArgb(210, 220, 235);
            this.lblSlogan.Location = new System.Drawing.Point(42, 305);
            this.lblSlogan.Name = "lblSlogan";
            this.lblSlogan.Size = new System.Drawing.Size(215, 80);
            this.lblSlogan.Text = "Tạo tài khoản để bắt đầu\r\nmua sắm trực tuyến\r\nnhanh chóng và tiện lợi.";
            this.lblSlogan.TextAlign = System.Drawing.ContentAlignment.TopCenter;

            this.pnlRight.BackColor = System.Drawing.Color.White;
            this.pnlRight.Controls.Add(this.lblTitle);
            this.pnlRight.Controls.Add(this.lblSubTitle);
            this.pnlRight.Controls.Add(this.lblHoTen);
            this.pnlRight.Controls.Add(this.txtHoTen);
            this.pnlRight.Controls.Add(this.lblNgaySinh);
            this.pnlRight.Controls.Add(this.txtNgaySinh);
            this.pnlRight.Controls.Add(this.lblCMND);
            this.pnlRight.Controls.Add(this.txtCMND);
            this.pnlRight.Controls.Add(this.lblDiaChi);
            this.pnlRight.Controls.Add(this.txtDiaChi);
            this.pnlRight.Controls.Add(this.lblDienThoai);
            this.pnlRight.Controls.Add(this.txtDienThoai);
            this.pnlRight.Controls.Add(this.lblUsername);
            this.pnlRight.Controls.Add(this.txtUsername);
            this.pnlRight.Controls.Add(this.lblPassword);
            this.pnlRight.Controls.Add(this.txtPassword);
            this.pnlRight.Controls.Add(this.lblEmail);
            this.pnlRight.Controls.Add(this.txtEmail);
            this.pnlRight.Controls.Add(this.btnRegister);
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRight.Location = new System.Drawing.Point(300, 0);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Size = new System.Drawing.Size(600, 620);
            this.pnlRight.TabIndex = 1;

            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font(
                "Segoe UI",
                22F,
                System.Drawing.FontStyle.Bold
            );
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(25, 42, 65);
            this.lblTitle.Location = new System.Drawing.Point(45, 30);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Text = "Tạo tài khoản";

            this.lblSubTitle.AutoSize = true;
            this.lblSubTitle.Font = new System.Drawing.Font(
                "Segoe UI",
                9.5F
            );
            this.lblSubTitle.ForeColor = System.Drawing.Color.Gray;
            this.lblSubTitle.Location = new System.Drawing.Point(48, 70);
            this.lblSubTitle.Name = "lblSubTitle";
            this.lblSubTitle.Text = "Nhập thông tin để đăng ký tài khoản e-SHOPPING";

            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Font = new System.Drawing.Font(
                "Segoe UI",
                9F,
                System.Drawing.FontStyle.Bold
            );
            this.lblHoTen.ForeColor = System.Drawing.Color.FromArgb(55, 65, 81);
            this.lblHoTen.Location = new System.Drawing.Point(48, 110);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Text = "Họ tên";

            this.txtHoTen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHoTen.Font = new System.Drawing.Font(
                "Segoe UI",
                10F
            );
            this.txtHoTen.Location = new System.Drawing.Point(48, 130);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(235, 25);

            this.lblNgaySinh.AutoSize = true;
            this.lblNgaySinh.Font = new System.Drawing.Font(
                "Segoe UI",
                9F,
                System.Drawing.FontStyle.Bold
            );
            this.lblNgaySinh.ForeColor = System.Drawing.Color.FromArgb(55, 65, 81);
            this.lblNgaySinh.Location = new System.Drawing.Point(305, 110);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Text = "Ngày sinh";

            this.txtNgaySinh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNgaySinh.Font = new System.Drawing.Font(
                "Segoe UI",
                10F
            );
            this.txtNgaySinh.Location = new System.Drawing.Point(305, 130);
            this.txtNgaySinh.Name = "txtNgaySinh";
            this.txtNgaySinh.Size = new System.Drawing.Size(235, 25);

            this.lblCMND.AutoSize = true;
            this.lblCMND.Font = new System.Drawing.Font(
                "Segoe UI",
                9F,
                System.Drawing.FontStyle.Bold
            );
            this.lblCMND.ForeColor = System.Drawing.Color.FromArgb(55, 65, 81);
            this.lblCMND.Location = new System.Drawing.Point(48, 175);
            this.lblCMND.Name = "lblCMND";
            this.lblCMND.Text = "CMND / Passport";

            this.txtCMND.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCMND.Font = new System.Drawing.Font(
                "Segoe UI",
                10F
            );
            this.txtCMND.Location = new System.Drawing.Point(48, 195);
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Size = new System.Drawing.Size(235, 25);

            this.lblDienThoai.AutoSize = true;
            this.lblDienThoai.Font = new System.Drawing.Font(
                "Segoe UI",
                9F,
                System.Drawing.FontStyle.Bold
            );
            this.lblDienThoai.ForeColor = System.Drawing.Color.FromArgb(55, 65, 81);
            this.lblDienThoai.Location = new System.Drawing.Point(305, 175);
            this.lblDienThoai.Name = "lblDienThoai";
            this.lblDienThoai.Text = "Điện thoại";

            this.txtDienThoai.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDienThoai.Font = new System.Drawing.Font(
                "Segoe UI",
                10F
            );
            this.txtDienThoai.Location = new System.Drawing.Point(305, 195);
            this.txtDienThoai.Name = "txtDienThoai";
            this.txtDienThoai.Size = new System.Drawing.Size(235, 25);

            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Font = new System.Drawing.Font(
                "Segoe UI",
                9F,
                System.Drawing.FontStyle.Bold
            );
            this.lblDiaChi.ForeColor = System.Drawing.Color.FromArgb(55, 65, 81);
            this.lblDiaChi.Location = new System.Drawing.Point(48, 240);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Text = "Địa chỉ";

            this.txtDiaChi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDiaChi.Font = new System.Drawing.Font(
                "Segoe UI",
                10F
            );
            this.txtDiaChi.Location = new System.Drawing.Point(48, 260);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(492, 25);

            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font(
                "Segoe UI",
                9F,
                System.Drawing.FontStyle.Bold
            );
            this.lblEmail.ForeColor = System.Drawing.Color.FromArgb(55, 65, 81);
            this.lblEmail.Location = new System.Drawing.Point(48, 305);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Text = "Email";

            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Font = new System.Drawing.Font(
                "Segoe UI",
                10F
            );
            this.txtEmail.Location = new System.Drawing.Point(48, 325);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(492, 25);

            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font(
                "Segoe UI",
                9F,
                System.Drawing.FontStyle.Bold
            );
            this.lblUsername.ForeColor = System.Drawing.Color.FromArgb(55, 65, 81);
            this.lblUsername.Location = new System.Drawing.Point(48, 370);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Text = "Tên đăng nhập";

            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsername.Font = new System.Drawing.Font(
                "Segoe UI",
                10F
            );
            this.txtUsername.Location = new System.Drawing.Point(48, 390);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(235, 25);

            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font(
                "Segoe UI",
                9F,
                System.Drawing.FontStyle.Bold
            );
            this.lblPassword.ForeColor = System.Drawing.Color.FromArgb(55, 65, 81);
            this.lblPassword.Location = new System.Drawing.Point(305, 370);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Text = "Mật khẩu";

            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.Font = new System.Drawing.Font(
                "Segoe UI",
                10F
            );
            this.txtPassword.Location = new System.Drawing.Point(305, 390);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(235, 25);
            this.txtPassword.UseSystemPasswordChar = true;

            this.btnRegister.BackColor = System.Drawing.Color.FromArgb(37, 99, 235);
            this.btnRegister.FlatAppearance.BorderSize = 0;
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Font = new System.Drawing.Font(
                "Segoe UI",
                11F,
                System.Drawing.FontStyle.Bold
            );
            this.btnRegister.ForeColor = System.Drawing.Color.White;
            this.btnRegister.Location = new System.Drawing.Point(48, 455);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(492, 45);
            this.btnRegister.TabIndex = 0;
            this.btnRegister.Text = "TẠO TÀI KHOẢN";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.Register_Click);

            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(900, 620);
            this.Controls.Add(this.pnlRight);
            this.Controls.Add(this.pnlLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmDangKy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "e-SHOPPING - Đăng ký khách hàng";

            this.pnlLeft.ResumeLayout(false);
            this.pnlLeft.PerformLayout();

            this.pnlRight.ResumeLayout(false);
            this.pnlRight.PerformLayout();

            this.ResumeLayout(false);
        }
    }
}