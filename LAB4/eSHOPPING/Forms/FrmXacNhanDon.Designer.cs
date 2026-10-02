namespace eSHOPPING.UI
{
    partial class FrmXacNhanDon
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Panel pnlBottom;

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubTitle;
        private System.Windows.Forms.Label lblIcon;
        private System.Windows.Forms.Label lblInfoTitle;

        private System.Windows.Forms.TextBox info;
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

            this.pnlHeader = new System.Windows.Forms.Panel();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.pnlBottom = new System.Windows.Forms.Panel();

            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubTitle = new System.Windows.Forms.Label();
            this.lblIcon = new System.Windows.Forms.Label();
            this.lblInfoTitle = new System.Windows.Forms.Label();

            this.info = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();

            this.pnlHeader.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlBottom.SuspendLayout();

            this.SuspendLayout();

            this.pnlHeader.BackColor =
                System.Drawing.Color.FromArgb(22, 101, 52);
            this.pnlHeader.Controls.Add(this.lblIcon);
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Controls.Add(this.lblSubTitle);
            this.pnlHeader.Dock =
                System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location =
                new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size =
                new System.Drawing.Size(620, 125);
            this.pnlHeader.TabIndex = 0;

            this.lblIcon.AutoSize = true;
            this.lblIcon.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    28F,
                    System.Drawing.FontStyle.Bold
                );
            this.lblIcon.ForeColor =
                System.Drawing.Color.White;
            this.lblIcon.Location =
                new System.Drawing.Point(35, 35);
            this.lblIcon.Name = "lblIcon";
            this.lblIcon.Text = "✓";

            this.lblTitle.AutoSize = true;
            this.lblTitle.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    18F,
                    System.Drawing.FontStyle.Bold
                );
            this.lblTitle.ForeColor =
                System.Drawing.Color.White;
            this.lblTitle.Location =
                new System.Drawing.Point(90, 25);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Text = "ĐẶT HÀNG THÀNH CÔNG";

            this.lblSubTitle.AutoSize = true;
            this.lblSubTitle.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    9.5F
                );
            this.lblSubTitle.ForeColor =
                System.Drawing.Color.FromArgb(220, 252, 231);
            this.lblSubTitle.Location =
                new System.Drawing.Point(93, 69);
            this.lblSubTitle.Name = "lblSubTitle";
            this.lblSubTitle.Text =
                "Đơn hàng của bạn đã được ghi nhận và thanh toán";

            this.pnlContent.BackColor =
                System.Drawing.Color.White;
            this.pnlContent.Controls.Add(this.lblInfoTitle);
            this.pnlContent.Controls.Add(this.info);
            this.pnlContent.Dock =
                System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location =
                new System.Drawing.Point(0, 125);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Padding =
                new System.Windows.Forms.Padding(35, 20, 35, 10);
            this.pnlContent.Size =
                new System.Drawing.Size(620, 300);
            this.pnlContent.TabIndex = 1;

            this.lblInfoTitle.AutoSize = true;
            this.lblInfoTitle.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    10.5F,
                    System.Drawing.FontStyle.Bold
                );
            this.lblInfoTitle.ForeColor =
                System.Drawing.Color.FromArgb(30, 41, 59);
            this.lblInfoTitle.Location =
                new System.Drawing.Point(35, 20);
            this.lblInfoTitle.Name = "lblInfoTitle";
            this.lblInfoTitle.Text = "THÔNG TIN ĐƠN HÀNG";

            this.info.BackColor =
                System.Drawing.Color.FromArgb(248, 250, 252);
            this.info.BorderStyle =
                System.Windows.Forms.BorderStyle.FixedSingle;
            this.info.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    10F
                );
            this.info.ForeColor =
                System.Drawing.Color.FromArgb(51, 65, 85);
            this.info.Location =
                new System.Drawing.Point(35, 55);
            this.info.Multiline = true;
            this.info.Name = "info";
            this.info.ReadOnly = true;
            this.info.ScrollBars =
                System.Windows.Forms.ScrollBars.Vertical;
            this.info.Size =
                new System.Drawing.Size(550, 215);
            this.info.TabIndex = 0;

            this.pnlBottom.BackColor =
                System.Drawing.Color.White;
            this.pnlBottom.Controls.Add(this.btnClose);
            this.pnlBottom.Dock =
                System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location =
                new System.Drawing.Point(0, 425);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size =
                new System.Drawing.Size(620, 70);
            this.pnlBottom.TabIndex = 2;

            this.btnClose.BackColor =
                System.Drawing.Color.FromArgb(37, 99, 235);
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    10F,
                    System.Drawing.FontStyle.Bold
                );
            this.btnClose.ForeColor =
                System.Drawing.Color.White;
            this.btnClose.Location =
                new System.Drawing.Point(240, 15);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size =
                new System.Drawing.Size(140, 40);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "ĐÓNG";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click +=
                new System.EventHandler(this.Close_Click);

            this.AutoScaleDimensions =
                new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode =
                System.Windows.Forms.AutoScaleMode.Font;

            this.BackColor =
                System.Drawing.Color.White;

            this.ClientSize =
                new System.Drawing.Size(620, 495);

            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.pnlHeader);

            this.FormBorderStyle =
                System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            this.Name = "FrmXacNhanDon";
            this.StartPosition =
                System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text =
                "e-SHOPPING - Xác nhận đơn hàng";

            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();

            this.pnlContent.ResumeLayout(false);
            this.pnlContent.PerformLayout();

            this.pnlBottom.ResumeLayout(false);

            this.ResumeLayout(false);
        }
    }
}