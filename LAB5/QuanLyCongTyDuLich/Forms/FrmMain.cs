using System;
using System.Drawing;
using System.Windows.Forms;

namespace QuanLyCongTyDuLich.Forms
{
    public class FrmMain : Form
    {
        private readonly Color primaryBlue = Color.FromArgb(91, 174, 230);
        private readonly Color lightBlue = Color.FromArgb(230, 245, 255);
        private readonly Color textColor = Color.FromArgb(45, 65, 80);

        public FrmMain()
        {
            Text = "Quản lý công ty du lịch";
            StartPosition = FormStartPosition.CenterScreen;
            Size = new Size(1100, 720);
            MinimumSize = new Size(850, 600);
            BackColor = Color.White;
            Font = new Font("Segoe UI", 10F);

            var layout = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                ColumnCount = 1,
                RowCount = 3,
                BackColor = Color.White,
                Margin = Padding.Empty,
                Padding = Padding.Empty
            };

            layout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            layout.RowStyles.Add(new RowStyle(SizeType.Absolute, 125F));
            layout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            layout.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));

            var header = new Panel
            {
                Dock = DockStyle.Fill,
                BackColor = lightBlue,
                Padding = new Padding(32, 15, 25, 10),
                Margin = Padding.Empty
            };

            var title = new Label
            {
                Text = "HỆ THỐNG QUẢN LÝ CÔNG TY DU LỊCH",
                Dock = DockStyle.Top,
                Height = 52,
                Font = new Font("Segoe UI", 19F, FontStyle.Bold),
                ForeColor = Color.FromArgb(40, 105, 155),
                TextAlign = ContentAlignment.MiddleLeft
            };

            var subtitle = new Label
            {
                Text = "Quản lý tour, đăng ký khách, hướng dẫn viên và thống kê",
                Dock = DockStyle.Top,
                Height = 32,
                Font = new Font("Segoe UI", 10F),
                ForeColor = textColor,
                TextAlign = ContentAlignment.MiddleLeft
            };

            header.Controls.Add(subtitle);
            header.Controls.Add(title);

            var content = new Panel
            {
                Dock = DockStyle.Fill,
                BackColor = Color.White,
                Padding = new Padding(28, 15, 28, 12),
                Margin = Padding.Empty
            };

            var sectionTitle = new Label
            {
                Text = "CHỨC NĂNG HỆ THỐNG",
                Dock = DockStyle.Top,
                Height = 42,
                Font = new Font("Segoe UI", 12F, FontStyle.Bold),
                ForeColor = Color.FromArgb(55, 125, 175),
                TextAlign = ContentAlignment.MiddleLeft
            };

            var scrollPanel = new Panel
            {
                Dock = DockStyle.Fill,
                AutoScroll = true,
                BackColor = Color.White,
                Padding = new Padding(0, 5, 0, 5)
            };

            var menu = new TableLayoutPanel
            {
                Dock = DockStyle.Top,
                AutoSize = true,
                ColumnCount = 2,
                RowCount = 5,
                BackColor = Color.White,
                Margin = Padding.Empty,
                Padding = Padding.Empty
            };

            menu.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            menu.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));

            for (int i = 0; i < 5; i++)
                menu.RowStyles.Add(new RowStyle(SizeType.Absolute, 105F));

            AddMenuButton(menu, "01   Quản lý danh mục",
                () => new FrmDanhMuc().ShowDialog(), 0, 0);

            AddMenuButton(menu, "02   Quản lý tour",
                () => new FrmTour().ShowDialog(), 1, 0);

            AddMenuButton(menu, "03   Quản lý chuyến khách lẻ",
                () => new FrmChuyenLe().ShowDialog(), 0, 1);

            AddMenuButton(menu, "04   Đăng ký khách lẻ",
                () => new FrmDangKyLe().ShowDialog(), 1, 1);

            AddMenuButton(menu, "05   Đăng ký đoàn khách",
                () => new FrmDangKyDoan().ShowDialog(), 0, 2);

            AddMenuButton(menu, "06   Phân công hướng dẫn viên",
                () => new FrmPhanCongHDV().ShowDialog(), 1, 2);

            AddMenuButton(menu, "07   Kết thúc tour / khảo sát",
                () => new FrmKetThucKhaoSat().ShowDialog(), 0, 3);

            AddMenuButton(menu, "08   Lương và thống kê",
                () => new FrmLuongThongKe().ShowDialog(), 1, 3);

            scrollPanel.Controls.Add(menu);
            content.Controls.Add(scrollPanel);
            content.Controls.Add(sectionTitle);

            var footer = new Label
            {
                Text = "HỆ THỐNG QUẢN LÝ DU LỊCH",
                Dock = DockStyle.Fill,
                Height = 35,
                ForeColor = Color.FromArgb(125, 145, 160),
                Font = new Font("Segoe UI", 8.5F),
                TextAlign = ContentAlignment.MiddleCenter,
                BackColor = Color.White,
                Margin = Padding.Empty
            };

            layout.Controls.Add(header, 0, 0);
            layout.Controls.Add(content, 0, 1);
            layout.Controls.Add(footer, 0, 2);

            Controls.Add(layout);
        }

        private void AddMenuButton(
            TableLayoutPanel panel,
            string text,
            Action action,
            int column,
            int row)
        {
            var button = new Button
            {
                Text = text,
                Dock = DockStyle.Fill,
                Margin = new Padding(7),
                BackColor = lightBlue,
                ForeColor = Color.FromArgb(45, 105, 150),
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Segoe UI", 10F, FontStyle.Bold),
                Cursor = Cursors.Hand,
                TextAlign = ContentAlignment.MiddleLeft,
                Padding = new Padding(18, 0, 8, 0)
            };

            button.FlatAppearance.BorderColor = Color.FromArgb(205, 230, 247);
            button.FlatAppearance.BorderSize = 1;
            button.FlatAppearance.MouseOverBackColor = Color.FromArgb(210, 237, 255);
            button.FlatAppearance.MouseDownBackColor = primaryBlue;
            button.Click += (sender, e) => action();

            panel.Controls.Add(button, column, row);
        }

        private void CheckConnection()
        {
            try
            {
                var result = Data.Db.Scalar("SELECT DB_NAME()");
                MessageBox.Show(
                    "Kết nối SQL Server thành công.\nCơ sở dữ liệu: " + result,
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Lỗi kết nối",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}