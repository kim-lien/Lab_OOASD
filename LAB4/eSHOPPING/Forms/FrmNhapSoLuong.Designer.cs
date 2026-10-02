namespace eSHOPPING.UI
{
    partial class FrmNhapSoLuong
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.NumericUpDown num;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;

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

            this.lblTitle = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();

            this.num = new System.Windows.Forms.NumericUpDown();

            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();

            this.pnlHeader.SuspendLayout();
            this.pnlContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num)).BeginInit();

            this.SuspendLayout();

            this.pnlHeader.BackColor =
                System.Drawing.Color.FromArgb(31, 45, 61);
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Dock =
                System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location =
                new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size =
                new System.Drawing.Size(430, 85);
            this.pnlHeader.TabIndex = 0;

            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font(
                "Segoe UI",
                17F,
                System.Drawing.FontStyle.Bold
            );
            this.lblTitle.ForeColor =
                System.Drawing.Color.White;
            this.lblTitle.Location =
                new System.Drawing.Point(28, 24);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Text = "Cập nhật số lượng";

            this.pnlContent.BackColor =
                System.Drawing.Color.White;
            this.pnlContent.Controls.Add(this.lblQuantity);
            this.pnlContent.Controls.Add(this.num);
            this.pnlContent.Controls.Add(this.btnOk);
            this.pnlContent.Controls.Add(this.btnCancel);
            this.pnlContent.Dock =
                System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location =
                new System.Drawing.Point(0, 85);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size =
                new System.Drawing.Size(430, 195);
            this.pnlContent.TabIndex = 1;

            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font(
                "Segoe UI",
                10F,
                System.Drawing.FontStyle.Bold
            );
            this.lblQuantity.ForeColor =
                System.Drawing.Color.FromArgb(55, 65, 81);
            this.lblQuantity.Location =
                new System.Drawing.Point(55, 32);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Text = "Số lượng sản phẩm:";

            this.num.Font = new System.Drawing.Font(
                "Segoe UI",
                11F
            );
            this.num.Location =
                new System.Drawing.Point(225, 27);
            this.num.Name = "num";
            this.num.Size =
                new System.Drawing.Size(120, 27);
            this.num.Minimum = 1;
            this.num.Maximum = 1;
            this.num.TextAlign =
                System.Windows.Forms.HorizontalAlignment.Center;
            this.num.TabIndex = 0;

            this.btnOk.BackColor =
                System.Drawing.Color.FromArgb(37, 99, 235);
            this.btnOk.FlatAppearance.BorderSize = 0;
            this.btnOk.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;
            this.btnOk.Font = new System.Drawing.Font(
                "Segoe UI",
                9.5F,
                System.Drawing.FontStyle.Bold
            );
            this.btnOk.ForeColor =
                System.Drawing.Color.White;
            this.btnOk.Location =
                new System.Drawing.Point(55, 92);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size =
                new System.Drawing.Size(150, 40);
            this.btnOk.TabIndex = 1;
            this.btnOk.Text = "XÁC NHẬN";
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click +=
                new System.EventHandler(this.Ok_Click);

            this.btnCancel.BackColor =
                System.Drawing.Color.White;
            this.btnCancel.FlatAppearance.BorderColor =
                System.Drawing.Color.FromArgb(156, 163, 175);
            this.btnCancel.FlatAppearance.BorderSize = 1;
            this.btnCancel.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font(
                "Segoe UI",
                9.5F,
                System.Drawing.FontStyle.Bold
            );
            this.btnCancel.ForeColor =
                System.Drawing.Color.FromArgb(75, 85, 99);
            this.btnCancel.Location =
                new System.Drawing.Point(225, 92);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size =
                new System.Drawing.Size(120, 40);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "HỦY";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click +=
                new System.EventHandler(this.Cancel_Click);

            this.AcceptButton = this.btnOk;
            this.CancelButton = this.btnCancel;

            this.AutoScaleDimensions =
                new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode =
                System.Windows.Forms.AutoScaleMode.Font;

            this.BackColor =
                System.Drawing.Color.White;
            this.ClientSize =
                new System.Drawing.Size(430, 280);

            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlHeader);

            this.FormBorderStyle =
                System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            this.Name = "FrmNhapSoLuong";
            this.StartPosition =
                System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "e-SHOPPING - Cập nhật số lượng";

            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();

            this.pnlContent.ResumeLayout(false);
            this.pnlContent.PerformLayout();

            ((System.ComponentModel.ISupportInitialize)(this.num)).EndInit();

            this.ResumeLayout(false);
        }
    }
}