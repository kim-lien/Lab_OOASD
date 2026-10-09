
using System;
using System.Drawing;
using System.Windows.Forms;

namespace QuanLyCongTyDuLich.Forms
{
    public static class UiStyle
    {
        private static readonly Color SkyBlue = Color.FromArgb(135, 206, 250);
        private static readonly Color PrimaryBlue = Color.FromArgb(91, 174, 230);
        private static readonly Color LightBlue = Color.FromArgb(230, 245, 255);
        private static readonly Color Background = Color.White;
        private static readonly Color Border = Color.FromArgb(220, 235, 245);
        private static readonly Color TextColor = Color.FromArgb(45, 65, 80);

        public static void Apply(Form form)
        {
            form.BackColor = Background;
            form.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
            form.ForeColor = TextColor;
            StyleControls(form.Controls);
        }

        private static void StyleControls(Control.ControlCollection controls)
        {
            foreach (Control control in controls)
            {
                if (control is DataGridView grid)
                {
                    grid.BackgroundColor = Color.White;
                    grid.BorderStyle = BorderStyle.None;
                    grid.GridColor = Border;
                    grid.EnableHeadersVisualStyles = false;
                    grid.ColumnHeadersDefaultCellStyle.BackColor = SkyBlue;
                    grid.ColumnHeadersDefaultCellStyle.ForeColor = TextColor;
                    grid.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
                    grid.ColumnHeadersHeight = 40;
                    grid.RowTemplate.Height = 34;
                    grid.DefaultCellStyle.BackColor = Color.White;
                    grid.DefaultCellStyle.ForeColor = TextColor;
                    grid.DefaultCellStyle.SelectionBackColor = LightBlue;
                    grid.DefaultCellStyle.SelectionForeColor = TextColor;
                    grid.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(248, 252, 255);
                    grid.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
                    grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    grid.MultiSelect = false;
                }
                else if (control is Button button)
                {
                    button.FlatStyle = FlatStyle.Flat;
                    button.FlatAppearance.BorderSize = 0;
                    button.BackColor = PrimaryBlue;
                    button.ForeColor = Color.White;
                    button.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
                    button.Cursor = Cursors.Hand;
                    button.Height = Math.Max(button.Height, 34);
                    button.Padding = new Padding(8, 3, 8, 3);
                }
                else if (control is TextBox || control is ComboBox || control is DateTimePicker)
                {
                    control.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
                    control.BackColor = Color.White;
                    control.ForeColor = TextColor;
                    control.Height = 28;
                }
                else if (control is Label label)
                {
                    label.ForeColor = TextColor;
                    label.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
                }
                else if (control is FlowLayoutPanel || control is Panel)
                {
                    control.BackColor = Background;
                }

                StyleControls(control.Controls);
            }
        }
    }
}