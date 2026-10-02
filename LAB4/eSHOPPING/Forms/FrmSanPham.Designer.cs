namespace eSHOPPING.UI
{
    partial class FrmSanPham
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label lblGroup;
        private System.Windows.Forms.ComboBox cboGroup;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnDetail;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCart;
        private System.Windows.Forms.Label lblCart;
        private System.Windows.Forms.DataGridView grid;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();

            lblTitle = new System.Windows.Forms.Label();
            lblUser = new System.Windows.Forms.Label();

            btnLogin = new System.Windows.Forms.Button();
            btnRegister = new System.Windows.Forms.Button();

            lblGroup = new System.Windows.Forms.Label();
            cboGroup = new System.Windows.Forms.ComboBox();

            lblSearch = new System.Windows.Forms.Label();
            txtSearch = new System.Windows.Forms.TextBox();

            btnDetail = new System.Windows.Forms.Button();
            btnAdd = new System.Windows.Forms.Button();
            btnCart = new System.Windows.Forms.Button();

            lblCart = new System.Windows.Forms.Label();
            grid = new System.Windows.Forms.DataGridView();

            ((System.ComponentModel.ISupportInitialize)(grid)).BeginInit();
            SuspendLayout();

            lblTitle.AutoSize = true;
            lblTitle.Font = new System.Drawing.Font(
                "Segoe UI",
                22F,
                System.Drawing.FontStyle.Bold
            );
            lblTitle.ForeColor = System.Drawing.Color.Black;
            lblTitle.Location = new System.Drawing.Point(25, 18);
            lblTitle.Name = "lblTitle";
            lblTitle.Text = "e-SHOPPING";

            lblUser.AutoSize = true;
            lblUser.Font = new System.Drawing.Font(
                "Segoe UI",
                9F
            );
            lblUser.ForeColor = System.Drawing.Color.Black;
            lblUser.Location = new System.Drawing.Point(780, 28);
            lblUser.Name = "lblUser";
            lblUser.Text = "Khách chưa đăng nhập";

            btnLogin.BackColor = System.Drawing.Color.White;
            btnLogin.FlatAppearance.BorderColor =
                System.Drawing.Color.FromArgb(37, 99, 235);
            btnLogin.FlatAppearance.BorderSize = 1;
            btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnLogin.Font = new System.Drawing.Font(
                "Segoe UI",
                9F,
                System.Drawing.FontStyle.Bold
            );
            btnLogin.ForeColor =
                System.Drawing.Color.FromArgb(37, 99, 235);
            btnLogin.Location = new System.Drawing.Point(930, 20);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new System.Drawing.Size(95, 32);
            btnLogin.Text = "Đăng nhập";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += new System.EventHandler(Login_Click);

            btnRegister.BackColor = System.Drawing.Color.White;
            btnRegister.FlatAppearance.BorderColor =
                System.Drawing.Color.FromArgb(37, 99, 235);
            btnRegister.FlatAppearance.BorderSize = 1;
            btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnRegister.Font = new System.Drawing.Font(
                "Segoe UI",
                9F,
                System.Drawing.FontStyle.Bold
            );
            btnRegister.ForeColor =
                System.Drawing.Color.FromArgb(37, 99, 235);
            btnRegister.Location = new System.Drawing.Point(1030, 20);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new System.Drawing.Size(95, 32);
            btnRegister.Text = "Đăng ký";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += new System.EventHandler(Register_Click);

            lblGroup.AutoSize = true;
            lblGroup.Font = new System.Drawing.Font(
                "Segoe UI",
                9F,
                System.Drawing.FontStyle.Bold
            );
            lblGroup.ForeColor = System.Drawing.Color.Black;
            lblGroup.Location = new System.Drawing.Point(25, 80);
            lblGroup.Name = "lblGroup";
            lblGroup.Text = "Nhóm sản phẩm";

            cboGroup.BackColor = System.Drawing.Color.White;
            cboGroup.ForeColor = System.Drawing.Color.Black;
            cboGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cboGroup.Location = new System.Drawing.Point(125, 76);
            cboGroup.Name = "cboGroup";
            cboGroup.Size = new System.Drawing.Size(220, 23);
            cboGroup.DropDownStyle =
                System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboGroup.SelectedIndexChanged +=
                new System.EventHandler(GroupOrSearchChanged);

            lblSearch.AutoSize = true;
            lblSearch.Font = new System.Drawing.Font(
                "Segoe UI",
                9F,
                System.Drawing.FontStyle.Bold
            );
            lblSearch.ForeColor = System.Drawing.Color.Black;
            lblSearch.Location = new System.Drawing.Point(370, 80);
            lblSearch.Name = "lblSearch";
            lblSearch.Text = "Tìm kiếm";

            txtSearch.BackColor = System.Drawing.Color.White;
            txtSearch.ForeColor = System.Drawing.Color.Black;
            txtSearch.BorderStyle =
                System.Windows.Forms.BorderStyle.FixedSingle;
            txtSearch.Location = new System.Drawing.Point(430, 76);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new System.Drawing.Size(260, 23);
            txtSearch.TextChanged +=
                new System.EventHandler(GroupOrSearchChanged);

            btnDetail.BackColor = System.Drawing.Color.White;
            btnDetail.FlatAppearance.BorderColor =
                System.Drawing.Color.FromArgb(37, 99, 235);
            btnDetail.FlatAppearance.BorderSize = 1;
            btnDetail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnDetail.Font = new System.Drawing.Font(
                "Segoe UI",
                9F,
                System.Drawing.FontStyle.Bold
            );
            btnDetail.ForeColor =
                System.Drawing.Color.FromArgb(37, 99, 235);
            btnDetail.Location = new System.Drawing.Point(705, 74);
            btnDetail.Name = "btnDetail";
            btnDetail.Size = new System.Drawing.Size(110, 32);
            btnDetail.Text = "Xem chi tiết";
            btnDetail.UseVisualStyleBackColor = false;
            btnDetail.Click += new System.EventHandler(Detail_Click);

            btnAdd.BackColor = System.Drawing.Color.White;
            btnAdd.FlatAppearance.BorderColor =
                System.Drawing.Color.FromArgb(37, 99, 235);
            btnAdd.FlatAppearance.BorderSize = 1;
            btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnAdd.Font = new System.Drawing.Font(
                "Segoe UI",
                9F,
                System.Drawing.FontStyle.Bold
            );
            btnAdd.ForeColor =
                System.Drawing.Color.FromArgb(37, 99, 235);
            btnAdd.Location = new System.Drawing.Point(820, 74);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new System.Drawing.Size(120, 32);
            btnAdd.Text = "Thêm vào giỏ";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += new System.EventHandler(Add_Click);

            btnCart.BackColor = System.Drawing.Color.White;
            btnCart.FlatAppearance.BorderColor =
                System.Drawing.Color.FromArgb(37, 99, 235);
            btnCart.FlatAppearance.BorderSize = 1;
            btnCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCart.Font = new System.Drawing.Font(
                "Segoe UI",
                9F,
                System.Drawing.FontStyle.Bold
            );
            btnCart.ForeColor =
                System.Drawing.Color.FromArgb(37, 99, 235);
            btnCart.Location = new System.Drawing.Point(945, 74);
            btnCart.Name = "btnCart";
            btnCart.Size = new System.Drawing.Size(100, 32);
            btnCart.Text = "Giỏ hàng";
            btnCart.UseVisualStyleBackColor = false;
            btnCart.Click += new System.EventHandler(Cart_Click);

            lblCart.AutoSize = true;
            lblCart.Font = new System.Drawing.Font(
                "Segoe UI",
                9F,
                System.Drawing.FontStyle.Bold
            );
            lblCart.ForeColor = System.Drawing.Color.Black;
            lblCart.Location = new System.Drawing.Point(1055, 82);
            lblCart.Name = "lblCart";
            lblCart.Text = "0 sản phẩm";

            grid.BackgroundColor = System.Drawing.Color.White;
            grid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            grid.GridColor =
                System.Drawing.Color.FromArgb(37, 99, 235);
            grid.EnableHeadersVisualStyles = false;

            grid.ColumnHeadersDefaultCellStyle.BackColor =
                System.Drawing.Color.FromArgb(37, 99, 235);
            grid.ColumnHeadersDefaultCellStyle.ForeColor =
                System.Drawing.Color.White;
            grid.ColumnHeadersDefaultCellStyle.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    9F,
                    System.Drawing.FontStyle.Bold
                );

            grid.DefaultCellStyle.BackColor =
                System.Drawing.Color.White;
            grid.DefaultCellStyle.ForeColor =
                System.Drawing.Color.Black;
            grid.DefaultCellStyle.SelectionBackColor =
                System.Drawing.Color.FromArgb(37, 99, 235);
            grid.DefaultCellStyle.SelectionForeColor =
                System.Drawing.Color.White;

            grid.Location = new System.Drawing.Point(25, 125);
            grid.Name = "grid";
            grid.Size = new System.Drawing.Size(1110, 520);
            grid.ReadOnly = true;
            grid.AutoGenerateColumns = false;
            grid.SelectionMode =
                System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            grid.MultiSelect = false;
            grid.AllowUserToAddRows = false;
            grid.RowHeadersVisible = false;
            grid.DoubleClick +=
                new System.EventHandler(Grid_DoubleClick);

            grid.Columns.Add(
                new System.Windows.Forms.DataGridViewTextBoxColumn
                {
                    HeaderText = "Mã SP",
                    DataPropertyName = "MaSP",
                    Width = 70
                }
            );

            grid.Columns.Add(
                new System.Windows.Forms.DataGridViewTextBoxColumn
                {
                    HeaderText = "Tên sản phẩm",
                    DataPropertyName = "TenSP",
                    Width = 260
                }
            );

            grid.Columns.Add(
                new System.Windows.Forms.DataGridViewTextBoxColumn
                {
                    HeaderText = "Nhà sản xuất",
                    DataPropertyName = "NhaSanXuat",
                    Width = 160
                }
            );

            grid.Columns.Add(
                new System.Windows.Forms.DataGridViewTextBoxColumn
                {
                    HeaderText = "Nhóm",
                    DataPropertyName = "TenNhom",
                    Width = 180
                }
            );

            grid.Columns.Add(
                new System.Windows.Forms.DataGridViewTextBoxColumn
                {
                    HeaderText = "Giá bán",
                    DataPropertyName = "GiaBan",
                    Width = 130,
                    DefaultCellStyle =
                        new System.Windows.Forms.DataGridViewCellStyle
                        {
                            Format = "N0"
                        }
                }
            );

            grid.Columns.Add(
                new System.Windows.Forms.DataGridViewTextBoxColumn
                {
                    HeaderText = "Tồn kho",
                    DataPropertyName = "TonKho",
                    Width = 90
                }
            );

            AutoScaleDimensions =
                new System.Drawing.SizeF(7F, 15F);

            AutoScaleMode =
                System.Windows.Forms.AutoScaleMode.Font;

            BackColor = System.Drawing.Color.White;

            ClientSize =
                new System.Drawing.Size(1180, 680);

            Controls.AddRange(
                new System.Windows.Forms.Control[]
                {
                    lblTitle,
                    lblUser,
                    btnLogin,
                    btnRegister,
                    lblGroup,
                    cboGroup,
                    lblSearch,
                    txtSearch,
                    btnDetail,
                    btnAdd,
                    btnCart,
                    lblCart,
                    grid
                }
            );

            Name = "FrmSanPham";
            StartPosition =
                System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "e-SHOPPING - Sản phẩm";
            MinimumSize =
                new System.Drawing.Size(1000, 650);

            ((System.ComponentModel.ISupportInitialize)(grid)).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}