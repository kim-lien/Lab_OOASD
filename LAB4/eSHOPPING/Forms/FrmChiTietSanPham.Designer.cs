namespace eSHOPPING.UI
{
    partial class FrmChiTietSanPham
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;

        private System.Windows.Forms.Panel pnlInfo;

        private System.Windows.Forms.Label lblMaSP;
        private System.Windows.Forms.Label lblNhaSanXuat;
        private System.Windows.Forms.Label lblNhom;
        private System.Windows.Forms.Label lblGiaBan;
        private System.Windows.Forms.Label lblTonKho;
        private System.Windows.Forms.Label lblMoTa;
        private System.Windows.Forms.Label lblThongSo;
        private System.Windows.Forms.Label lblQty;

        private System.Windows.Forms.TextBox txtMaSP;
        private System.Windows.Forms.TextBox txtNhaSanXuat;
        private System.Windows.Forms.TextBox txtNhom;
        private System.Windows.Forms.TextBox txtGiaBan;
        private System.Windows.Forms.TextBox txtTonKho;
        private System.Windows.Forms.TextBox txtMoTa;
        private System.Windows.Forms.TextBox txtThongSo;

        private System.Windows.Forms.NumericUpDown numQuantity;

        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCart;
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
            this.lblTitle = new System.Windows.Forms.Label();

            this.pnlInfo = new System.Windows.Forms.Panel();

            this.lblMaSP = new System.Windows.Forms.Label();
            this.lblNhaSanXuat = new System.Windows.Forms.Label();
            this.lblNhom = new System.Windows.Forms.Label();
            this.lblGiaBan = new System.Windows.Forms.Label();
            this.lblTonKho = new System.Windows.Forms.Label();
            this.lblMoTa = new System.Windows.Forms.Label();
            this.lblThongSo = new System.Windows.Forms.Label();
            this.lblQty = new System.Windows.Forms.Label();

            this.txtMaSP = new System.Windows.Forms.TextBox();
            this.txtNhaSanXuat = new System.Windows.Forms.TextBox();
            this.txtNhom = new System.Windows.Forms.TextBox();
            this.txtGiaBan = new System.Windows.Forms.TextBox();
            this.txtTonKho = new System.Windows.Forms.TextBox();
            this.txtMoTa = new System.Windows.Forms.TextBox();
            this.txtThongSo = new System.Windows.Forms.TextBox();

            this.numQuantity = new System.Windows.Forms.NumericUpDown();

            this.pnlBottom = new System.Windows.Forms.Panel();

            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCart = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();

            this.pnlHeader.SuspendLayout();
            this.pnlInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).BeginInit();
            this.pnlBottom.SuspendLayout();

            this.SuspendLayout();

            this.pnlHeader.BackColor =
                System.Drawing.Color.FromArgb(37, 99, 235);

            this.pnlHeader.Controls.Add(this.lblTitle);

            this.pnlHeader.Dock =
                System.Windows.Forms.DockStyle.Top;

            this.pnlHeader.Location =
                new System.Drawing.Point(0, 0);

            this.pnlHeader.Name = "pnlHeader";

            this.pnlHeader.Size =
                new System.Drawing.Size(820, 75);

            this.pnlHeader.TabIndex = 0;

            this.lblTitle.AutoSize = true;

            this.lblTitle.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    21F,
                    System.Drawing.FontStyle.Bold
                );

            this.lblTitle.ForeColor =
                System.Drawing.Color.White;

            this.lblTitle.Location =
                new System.Drawing.Point(28, 20);

            this.lblTitle.Name = "lblTitle";

            this.lblTitle.Size =
                new System.Drawing.Size(220, 38);

            this.lblTitle.TabIndex = 0;

            this.lblTitle.Text =
                "Chi tiết sản phẩm";

            this.pnlInfo.BackColor =
                System.Drawing.Color.White;

            this.pnlInfo.Controls.Add(this.lblMaSP);
            this.pnlInfo.Controls.Add(this.txtMaSP);
            this.pnlInfo.Controls.Add(this.lblNhaSanXuat);
            this.pnlInfo.Controls.Add(this.txtNhaSanXuat);
            this.pnlInfo.Controls.Add(this.lblNhom);
            this.pnlInfo.Controls.Add(this.txtNhom);
            this.pnlInfo.Controls.Add(this.lblGiaBan);
            this.pnlInfo.Controls.Add(this.txtGiaBan);
            this.pnlInfo.Controls.Add(this.lblTonKho);
            this.pnlInfo.Controls.Add(this.txtTonKho);
            this.pnlInfo.Controls.Add(this.lblMoTa);
            this.pnlInfo.Controls.Add(this.txtMoTa);
            this.pnlInfo.Controls.Add(this.lblThongSo);
            this.pnlInfo.Controls.Add(this.txtThongSo);
            this.pnlInfo.Controls.Add(this.lblQty);
            this.pnlInfo.Controls.Add(this.numQuantity);

            this.pnlInfo.Dock =
                System.Windows.Forms.DockStyle.Fill;

            this.pnlInfo.Location =
                new System.Drawing.Point(0, 75);

            this.pnlInfo.Name = "pnlInfo";

            this.pnlInfo.Padding =
                new System.Windows.Forms.Padding(30);

            this.pnlInfo.Size =
                new System.Drawing.Size(820, 465);

            this.pnlInfo.TabIndex = 1;

            this.lblMaSP.AutoSize = true;

            this.lblMaSP.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    10F,
                    System.Drawing.FontStyle.Bold
                );

            this.lblMaSP.ForeColor =
                System.Drawing.Color.Black;

            this.lblMaSP.Location =
                new System.Drawing.Point(35, 35);

            this.lblMaSP.Name = "lblMaSP";

            this.lblMaSP.Text =
                "Mã sản phẩm";

            this.txtMaSP.BackColor =
                System.Drawing.Color.White;

            this.txtMaSP.ForeColor =
                System.Drawing.Color.Black;

            this.txtMaSP.BorderStyle =
                System.Windows.Forms.BorderStyle.FixedSingle;

            this.txtMaSP.Location =
                new System.Drawing.Point(160, 31);

            this.txtMaSP.Name =
                "txtMaSP";

            this.txtMaSP.ReadOnly = true;

            this.txtMaSP.Size =
                new System.Drawing.Size(230, 25);

            this.lblNhaSanXuat.AutoSize = true;

            this.lblNhaSanXuat.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    10F,
                    System.Drawing.FontStyle.Bold
                );

            this.lblNhaSanXuat.ForeColor =
                System.Drawing.Color.Black;

            this.lblNhaSanXuat.Location =
                new System.Drawing.Point(425, 35);

            this.lblNhaSanXuat.Name =
                "lblNhaSanXuat";

            this.lblNhaSanXuat.Text =
                "Nhà sản xuất";

            this.txtNhaSanXuat.BackColor =
                System.Drawing.Color.White;

            this.txtNhaSanXuat.ForeColor =
                System.Drawing.Color.Black;

            this.txtNhaSanXuat.BorderStyle =
                System.Windows.Forms.BorderStyle.FixedSingle;

            this.txtNhaSanXuat.Location =
                new System.Drawing.Point(545, 31);

            this.txtNhaSanXuat.Name =
                "txtNhaSanXuat";

            this.txtNhaSanXuat.ReadOnly = true;

            this.txtNhaSanXuat.Size =
                new System.Drawing.Size(230, 25);

            this.lblNhom.AutoSize = true;

            this.lblNhom.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    10F,
                    System.Drawing.FontStyle.Bold
                );

            this.lblNhom.ForeColor =
                System.Drawing.Color.Black;

            this.lblNhom.Location =
                new System.Drawing.Point(35, 85);

            this.lblNhom.Name =
                "lblNhom";

            this.lblNhom.Text =
                "Nhóm sản phẩm";

            this.txtNhom.BackColor =
                System.Drawing.Color.White;

            this.txtNhom.ForeColor =
                System.Drawing.Color.Black;

            this.txtNhom.BorderStyle =
                System.Windows.Forms.BorderStyle.FixedSingle;

            this.txtNhom.Location =
                new System.Drawing.Point(160, 81);

            this.txtNhom.Name =
                "txtNhom";

            this.txtNhom.ReadOnly = true;

            this.txtNhom.Size =
                new System.Drawing.Size(230, 25);

            this.lblGiaBan.AutoSize = true;

            this.lblGiaBan.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    10F,
                    System.Drawing.FontStyle.Bold
                );

            this.lblGiaBan.ForeColor =
                System.Drawing.Color.Black;

            this.lblGiaBan.Location =
                new System.Drawing.Point(425, 85);

            this.lblGiaBan.Name =
                "lblGiaBan";

            this.lblGiaBan.Text =
                "Giá bán";

            this.txtGiaBan.BackColor =
                System.Drawing.Color.White;

            this.txtGiaBan.ForeColor =
                System.Drawing.Color.Black;

            this.txtGiaBan.BorderStyle =
                System.Windows.Forms.BorderStyle.FixedSingle;

            this.txtGiaBan.Location =
                new System.Drawing.Point(545, 81);

            this.txtGiaBan.Name =
                "txtGiaBan";

            this.txtGiaBan.ReadOnly = true;

            this.txtGiaBan.Size =
                new System.Drawing.Size(230, 25);

            this.lblTonKho.AutoSize = true;

            this.lblTonKho.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    10F,
                    System.Drawing.FontStyle.Bold
                );

            this.lblTonKho.ForeColor =
                System.Drawing.Color.Black;

            this.lblTonKho.Location =
                new System.Drawing.Point(35, 135);

            this.lblTonKho.Name =
                "lblTonKho";

            this.lblTonKho.Text =
                "Tồn kho";

            this.txtTonKho.BackColor =
                System.Drawing.Color.White;

            this.txtTonKho.ForeColor =
                System.Drawing.Color.Black;

            this.txtTonKho.BorderStyle =
                System.Windows.Forms.BorderStyle.FixedSingle;

            this.txtTonKho.Location =
                new System.Drawing.Point(160, 131);

            this.txtTonKho.Name =
                "txtTonKho";

            this.txtTonKho.ReadOnly = true;

            this.txtTonKho.Size =
                new System.Drawing.Size(230, 25);

            this.lblMoTa.AutoSize = true;

            this.lblMoTa.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    10F,
                    System.Drawing.FontStyle.Bold
                );

            this.lblMoTa.ForeColor =
                System.Drawing.Color.Black;

            this.lblMoTa.Location =
                new System.Drawing.Point(35, 180);

            this.lblMoTa.Name =
                "lblMoTa";

            this.lblMoTa.Text =
                "Mô tả";

            this.txtMoTa.BackColor =
                System.Drawing.Color.White;

            this.txtMoTa.ForeColor =
                System.Drawing.Color.Black;

            this.txtMoTa.BorderStyle =
                System.Windows.Forms.BorderStyle.FixedSingle;

            this.txtMoTa.Location =
                new System.Drawing.Point(160, 176);

            this.txtMoTa.Multiline = true;

            this.txtMoTa.Name =
                "txtMoTa";

            this.txtMoTa.ReadOnly = true;

            this.txtMoTa.ScrollBars =
                System.Windows.Forms.ScrollBars.Vertical;

            this.txtMoTa.Size =
                new System.Drawing.Size(615, 75);

            this.lblThongSo.AutoSize = true;

            this.lblThongSo.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    10F,
                    System.Drawing.FontStyle.Bold
                );

            this.lblThongSo.ForeColor =
                System.Drawing.Color.Black;

            this.lblThongSo.Location =
                new System.Drawing.Point(35, 270);

            this.lblThongSo.Name =
                "lblThongSo";

            this.lblThongSo.Text =
                "Thông số kỹ thuật";

            this.txtThongSo.BackColor =
                System.Drawing.Color.White;

            this.txtThongSo.ForeColor =
                System.Drawing.Color.Black;

            this.txtThongSo.BorderStyle =
                System.Windows.Forms.BorderStyle.FixedSingle;

            this.txtThongSo.Location =
                new System.Drawing.Point(160, 266);

            this.txtThongSo.Multiline = true;

            this.txtThongSo.Name =
                "txtThongSo";

            this.txtThongSo.ReadOnly = true;

            this.txtThongSo.ScrollBars =
                System.Windows.Forms.ScrollBars.Vertical;

            this.txtThongSo.Size =
                new System.Drawing.Size(615, 75);

            this.lblQty.AutoSize = true;

            this.lblQty.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    10F,
                    System.Drawing.FontStyle.Bold
                );

            this.lblQty.ForeColor =
                System.Drawing.Color.Black;

            this.lblQty.Location =
                new System.Drawing.Point(35, 370);

            this.lblQty.Name =
                "lblQty";

            this.lblQty.Text =
                "Số lượng";

            this.numQuantity.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    10F
                );

            this.numQuantity.Location =
                new System.Drawing.Point(160, 367);

            this.numQuantity.Maximum =
                new decimal(new int[] {
                    1, 0, 0, 0
                });

            this.numQuantity.Minimum =
                new decimal(new int[] {
                    1, 0, 0, 0
                });

            this.numQuantity.Name =
                "numQuantity";

            this.numQuantity.Size =
                new System.Drawing.Size(100, 25);

            this.numQuantity.Value =
                new decimal(new int[] {
                    1, 0, 0, 0
                });

            this.pnlBottom.BackColor =
                System.Drawing.Color.White;

            this.pnlBottom.Controls.Add(this.btnAdd);
            this.pnlBottom.Controls.Add(this.btnCart);
            this.pnlBottom.Controls.Add(this.btnClose);

            this.pnlBottom.Dock =
                System.Windows.Forms.DockStyle.Bottom;

            this.pnlBottom.Location =
                new System.Drawing.Point(0, 540);

            this.pnlBottom.Name =
                "pnlBottom";

            this.pnlBottom.Size =
                new System.Drawing.Size(820, 70);

            this.pnlBottom.TabIndex = 2;

            this.btnAdd.BackColor =
                System.Drawing.Color.White;

            this.btnAdd.FlatAppearance.BorderColor =
                System.Drawing.Color.FromArgb(37, 99, 235);

            this.btnAdd.FlatAppearance.BorderSize = 1;

            this.btnAdd.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;

            this.btnAdd.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    10F,
                    System.Drawing.FontStyle.Bold
                );

            this.btnAdd.ForeColor =
                System.Drawing.Color.FromArgb(37, 99, 235);

            this.btnAdd.Location =
                new System.Drawing.Point(275, 18);

            this.btnAdd.Name =
                "btnAdd";

            this.btnAdd.Size =
                new System.Drawing.Size(150, 38);

            this.btnAdd.TabIndex = 0;

            this.btnAdd.Text =
                "Thêm vào giỏ";

            this.btnAdd.UseVisualStyleBackColor = false;

            this.btnAdd.Click +=
                new System.EventHandler(this.Add_Click);

            this.btnCart.BackColor =
                System.Drawing.Color.White;

            this.btnCart.FlatAppearance.BorderColor =
                System.Drawing.Color.FromArgb(37, 99, 235);

            this.btnCart.FlatAppearance.BorderSize = 1;

            this.btnCart.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;

            this.btnCart.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    10F,
                    System.Drawing.FontStyle.Bold
                );

            this.btnCart.ForeColor =
                System.Drawing.Color.FromArgb(37, 99, 235);

            this.btnCart.Location =
                new System.Drawing.Point(435, 18);

            this.btnCart.Name =
                "btnCart";

            this.btnCart.Size =
                new System.Drawing.Size(130, 38);

            this.btnCart.TabIndex = 1;

            this.btnCart.Text =
                "Giỏ hàng";

            this.btnCart.UseVisualStyleBackColor = false;

            this.btnCart.Click +=
                new System.EventHandler(this.Cart_Click);

            this.btnClose.BackColor =
                System.Drawing.Color.White;

            this.btnClose.FlatAppearance.BorderColor =
                System.Drawing.Color.FromArgb(37, 99, 235);

            this.btnClose.FlatAppearance.BorderSize = 1;

            this.btnClose.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;

            this.btnClose.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    10F,
                    System.Drawing.FontStyle.Bold
                );

            this.btnClose.ForeColor =
                System.Drawing.Color.FromArgb(37, 99, 235);

            this.btnClose.Location =
                new System.Drawing.Point(575, 18);

            this.btnClose.Name =
                "btnClose";

            this.btnClose.Size =
                new System.Drawing.Size(100, 38);

            this.btnClose.TabIndex = 2;

            this.btnClose.Text =
                "Đóng";

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
                new System.Drawing.Size(820, 610);

            this.Controls.Add(this.pnlInfo);
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.pnlHeader);

            this.FormBorderStyle =
                System.Windows.Forms.FormBorderStyle.FixedSingle;

            this.MaximizeBox = false;
            this.MinimizeBox = false;

            this.Name =
                "FrmChiTietSanPham";

            this.StartPosition =
                System.Windows.Forms.FormStartPosition.CenterParent;

            this.Text =
                "e-SHOPPING - Chi tiết sản phẩm";

            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();

            this.pnlInfo.ResumeLayout(false);
            this.pnlInfo.PerformLayout();

            ((System.ComponentModel.ISupportInitialize)
                (this.numQuantity)).EndInit();

            this.pnlBottom.ResumeLayout(false);

            this.ResumeLayout(false);
        }
    }
}