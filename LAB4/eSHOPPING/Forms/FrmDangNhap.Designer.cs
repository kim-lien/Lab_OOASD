namespace eSHOPPING.UI
{
    partial class FrmDangNhap
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Panel pnlForm;
        private System.Windows.Forms.Panel pnlBottom;

        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Label lblLogoSub;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.Label lblRegister;
        private System.Windows.Forms.Label lblFooter;

        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnClose;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();

            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblLogo = new System.Windows.Forms.Label();
            this.lblLogoSub = new System.Windows.Forms.Label();

            this.pnlForm = new System.Windows.Forms.Panel();

            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();

            this.lblUser = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();

            this.lblPass = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();

            this.btnLogin = new System.Windows.Forms.Button();

            this.pnlBottom = new System.Windows.Forms.Panel();

            this.lblRegister = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblFooter = new System.Windows.Forms.Label();

            this.pnlTop.SuspendLayout();
            this.pnlForm.SuspendLayout();
            this.pnlBottom.SuspendLayout();

            this.SuspendLayout();

            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(37, 99, 235);
            this.pnlTop.Controls.Add(this.lblLogo);
            this.pnlTop.Controls.Add(this.lblLogoSub);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(620, 155);
            this.pnlTop.TabIndex = 0;

            this.lblLogo.AutoSize = true;
            this.lblLogo.Font = new System.Drawing.Font(
                "Segoe UI",
                27F,
                System.Drawing.FontStyle.Bold
            );
            this.lblLogo.ForeColor = System.Drawing.Color.White;
            this.lblLogo.Location = new System.Drawing.Point(190, 35);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(240, 48);
            this.lblLogo.TabIndex = 0;
            this.lblLogo.Text = "e-SHOPPING";

            this.lblLogoSub.AutoSize = true;
            this.lblLogoSub.Font = new System.Drawing.Font(
                "Segoe UI",
                10F
            );
            this.lblLogoSub.ForeColor = System.Drawing.Color.FromArgb(225, 235, 255);
            this.lblLogoSub.Location = new System.Drawing.Point(206, 88);
            this.lblLogoSub.Name = "lblLogoSub";
            this.lblLogoSub.Size = new System.Drawing.Size(208, 19);
            this.lblLogoSub.TabIndex = 1;
            this.lblLogoSub.Text = "Hệ thống mua sắm trực tuyến";

            this.pnlForm.BackColor = System.Drawing.Color.White;
            this.pnlForm.Controls.Add(this.lblWelcome);
            this.pnlForm.Controls.Add(this.lblSubtitle);
            this.pnlForm.Controls.Add(this.lblUser);
            this.pnlForm.Controls.Add(this.txtUsername);
            this.pnlForm.Controls.Add(this.lblPass);
            this.pnlForm.Controls.Add(this.txtPassword);
            this.pnlForm.Controls.Add(this.btnLogin);
            this.pnlForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlForm.Location = new System.Drawing.Point(0, 155);
            this.pnlForm.Name = "pnlForm";
            this.pnlForm.Size = new System.Drawing.Size(620, 290);
            this.pnlForm.TabIndex = 1;

            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font(
                "Segoe UI",
                21F,
                System.Drawing.FontStyle.Bold
            );
            this.lblWelcome.ForeColor = System.Drawing.Color.FromArgb(31, 41, 55);
            this.lblWelcome.Location = new System.Drawing.Point(105, 22);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(158, 38);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Đăng nhập";

            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Font = new System.Drawing.Font(
                "Segoe UI",
                9F
            );
            this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128);
            this.lblSubtitle.Location = new System.Drawing.Point(108, 62);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(306, 15);
            this.lblSubtitle.TabIndex = 1;
            this.lblSubtitle.Text = "Nhập thông tin tài khoản để tiếp tục";

            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font(
                "Segoe UI",
                9.5F,
                System.Drawing.FontStyle.Bold
            );
            this.lblUser.ForeColor = System.Drawing.Color.FromArgb(55, 65, 81);
            this.lblUser.Location = new System.Drawing.Point(108, 92);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(98, 17);
            this.lblUser.TabIndex = 2;
            this.lblUser.Text = "Tên đăng nhập";

            this.txtUsername.BackColor = System.Drawing.Color.FromArgb(249, 250, 251);
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsername.Font = new System.Drawing.Font(
                "Segoe UI",
                10.5F
            );
            this.txtUsername.ForeColor = System.Drawing.Color.FromArgb(31, 41, 55);
            this.txtUsername.Location = new System.Drawing.Point(105, 114);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(410, 26);
            this.txtUsername.TabIndex = 3;

            this.lblPass.AutoSize = true;
            this.lblPass.Font = new System.Drawing.Font(
                "Segoe UI",
                9.5F,
                System.Drawing.FontStyle.Bold
            );
            this.lblPass.ForeColor = System.Drawing.Color.FromArgb(55, 65, 81);
            this.lblPass.Location = new System.Drawing.Point(108, 148);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(67, 17);
            this.lblPass.TabIndex = 4;
            this.lblPass.Text = "Mật khẩu";

            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(249, 250, 251);
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.Font = new System.Drawing.Font(
                "Segoe UI",
                10.5F
            );
            this.txtPassword.ForeColor = System.Drawing.Color.FromArgb(31, 41, 55);
            this.txtPassword.Location = new System.Drawing.Point(105, 170);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(410, 26);
            this.txtPassword.TabIndex = 5;
            this.txtPassword.UseSystemPasswordChar = true;

            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(37, 99, 235);
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font(
                "Segoe UI",
                10F,
                System.Drawing.FontStyle.Bold
            );
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(105, 215);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(410, 40);
            this.btnLogin.TabIndex = 6;
            this.btnLogin.Text = "ĐĂNG NHẬP";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.Login_Click);

            this.pnlBottom.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            this.pnlBottom.Controls.Add(this.lblRegister);
            this.pnlBottom.Controls.Add(this.btnRegister);
            this.pnlBottom.Controls.Add(this.btnClose);
            this.pnlBottom.Controls.Add(this.lblFooter);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 445);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(620, 155);
            this.pnlBottom.TabIndex = 2;

            this.lblRegister.AutoSize = true;
            this.lblRegister.Font = new System.Drawing.Font(
                "Segoe UI",
                9F
            );
            this.lblRegister.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128);
            this.lblRegister.Location = new System.Drawing.Point(105, 18);
            this.lblRegister.Name = "lblRegister";
            this.lblRegister.Size = new System.Drawing.Size(177, 15);
            this.lblRegister.TabIndex = 0;
            this.lblRegister.Text = "Chưa có tài khoản? Đăng ký:";

            this.btnRegister.BackColor = System.Drawing.Color.White;
            this.btnRegister.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(37, 99, 235);
            this.btnRegister.FlatAppearance.BorderSize = 1;
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Font = new System.Drawing.Font(
                "Segoe UI",
                9F,
                System.Drawing.FontStyle.Bold
            );
            this.btnRegister.ForeColor = System.Drawing.Color.FromArgb(37, 99, 235);
            this.btnRegister.Location = new System.Drawing.Point(105, 43);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(195, 36);
            this.btnRegister.TabIndex = 1;
            this.btnRegister.Text = "TẠO TÀI KHOẢN";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.Register_Click);

            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(209, 213, 219);
            this.btnClose.FlatAppearance.BorderSize = 1;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font(
                "Segoe UI",
                9F,
                System.Drawing.FontStyle.Bold
            );
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(75, 85, 99);
            this.btnClose.Location = new System.Drawing.Point(320, 43);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(195, 36);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "ĐÓNG";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.Close_Click);

            this.lblFooter.AutoSize = true;
            this.lblFooter.Font = new System.Drawing.Font(
                "Segoe UI",
                8F
            );
            this.lblFooter.ForeColor = System.Drawing.Color.FromArgb(156, 163, 175);
            this.lblFooter.Location = new System.Drawing.Point(158, 105);
            this.lblFooter.Name = "lblFooter";
            this.lblFooter.Size = new System.Drawing.Size(305, 13);
            this.lblFooter.TabIndex = 3;
            this.lblFooter.Text = "© 2026 e-SHOPPING - Hệ thống bán hàng trực tuyến";

            this.AcceptButton = this.btnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(620, 600);
            this.Controls.Add(this.pnlForm);
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.pnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmDangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "e-SHOPPING - Đăng nhập";

            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();

            this.pnlForm.ResumeLayout(false);
            this.pnlForm.PerformLayout();

            this.pnlBottom.ResumeLayout(false);
            this.pnlBottom.PerformLayout();

            this.ResumeLayout(false);
        }
    }
}