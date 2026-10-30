
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace QuanLyBenhAn;

public sealed class GenericTableForm : UserControl
{
    private static readonly Dictionary<string, string> Keys = new()
    {
        ["Khoa"] = "MaKhoa",
        ["BacSi"] = "MaBS",
        ["DangKyKhamBenh"] = "MaDK",
        ["LePhiNam"] = "MaLePhi",
        ["HoSoBenhAn"] = "MaHoSo",
        ["XetNghiem"] = "MaXN",
        ["Thuoc"] = "MaThuoc",
        ["LichKhamDinhKy"] = "MaLich",
        ["ThanhToanVienPhi"] = "MaThanhToan"
    };

    private readonly string table, key;

    private readonly DataGridView grid = new()
    {
        Dock = DockStyle.Fill,
        ReadOnly = true,
        AllowUserToAddRows = false,
        SelectionMode = DataGridViewSelectionMode.FullRowSelect,
        MultiSelect = false,
        AutoSizeColumnsMode =
            DataGridViewAutoSizeColumnsMode.DisplayedCells
    };

    private readonly FlowLayoutPanel fields = new()
    {
        Dock = DockStyle.Top,
        AutoScroll = true,
        Height = 135,
        Padding = new Padding(8)
    };

    private readonly Label notice = new()
    {
        Dock = DockStyle.Bottom,
        Height = 25,
        ForeColor = Color.DarkSlateBlue
    };

    private readonly Dictionary<string, TextBox> boxes = new();

    private readonly Dictionary<string, string> sqlTypes = new();

    private int? id;

    public GenericTableForm(string tableName)
    {
        if (!Keys.TryGetValue(tableName, out var primaryKey))
            throw new ArgumentException("Bảng không được hỗ trợ.");

        table = tableName;
        key = primaryKey;

        Dock = DockStyle.Fill;

        var bar = new FlowLayoutPanel
        {
            Dock = DockStyle.Top,
            Height = 44,
            Padding = new Padding(8)
        };

        foreach (var item in new (string, Action)[]
        {
            ("Thêm", Insert),
            ("Cập nhật", Update),
            ("Xóa", Delete),
            ("Nhập mới", Clear),
            ("Tải lại", LoadRows)
        })
        {
            var button = new Button
            {
                Text = item.Item1,
                AutoSize = true,
                Height = 29
            };

            var action = item.Item2;

            button.Click += (_, _) => Safe(action);

            bar.Controls.Add(button);
        }

        Controls.Add(grid);
        Controls.Add(fields);
        Controls.Add(bar);
        Controls.Add(notice);

        grid.SelectionChanged += (_, _) => FillFromSelection();

        Load += (_, _) => Safe(() =>
        {
            BuildFields();
            LoadRows();
        });
    }

    // Xử lý thông báo thành công hoặc lỗi
    private void Safe(Action action)
    {
        try
        {
            action();

            notice.Text = "Hoàn tất: " +
                          DateTime.Now.ToString("HH:mm:ss");
        }
        catch (Exception ex)
        {
            notice.Text = ex.Message;

            MessageBox.Show(
                ex.Message,
                "Lỗi",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            );
        }
    }

    // Tạo các trường nhập liệu
    private void BuildFields()
    {
        if (boxes.Count > 0) return;

        var info = Db.Query(
            @"SELECT COLUMN_NAME, DATA_TYPE
              FROM INFORMATION_SCHEMA.COLUMNS
              WHERE TABLE_NAME = @table
              ORDER BY ORDINAL_POSITION",
            Db.P("@table", table)
        );

        foreach (DataRow row in info.Rows)
        {
            string name =
                Convert.ToString(row["COLUMN_NAME"])!;

            if (name == key)
                continue;

            var ty =
                Convert.ToString(row["DATA_TYPE"])!;

            // Vẫn lưu kiểu dữ liệu để xử lý SQL
            sqlTypes[name] = ty;

            var container = new Panel
            {
                Width = 230,
                Height = 57,
                Margin = new Padding(5)
            };

            // CHỈ HIỂN THỊ TÊN TRƯỜNG
            // Không hiển thị varchar, nvarchar, int...
            var label = new Label
            {
                Text = name,
                AutoSize = true,
                Dock = DockStyle.Top
            };

            var box = new TextBox
            {
                Dock = DockStyle.Bottom,
                Width = 215,
                PlaceholderText = "Trống = NULL"
            };

            container.Controls.Add(label);
            container.Controls.Add(box);

            fields.Controls.Add(container);

            boxes[name] = box;
        }
    }

    // Hiển thị dữ liệu lên DataGridView
    private void LoadRows()
    {
        grid.DataSource = Db.Query(
            $"SELECT * FROM [{table}] ORDER BY [{key}] DESC"
        );
    }

    // Hiển thị dữ liệu dòng được chọn lên TextBox
    private void FillFromSelection()
    {
        if (grid.CurrentRow?.DataBoundItem
            is not DataRowView row)
            return;

        id = Convert.ToInt32(row[key]);

        foreach (var (column, box) in boxes)
        {
            if (row[column] == DBNull.Value)
            {
                box.Text = "";
                continue;
            }

            box.Text = row[column] is DateTime d
                ? (sqlTypes[column] == "date"
                    ? d.ToString("yyyy-MM-dd")
                    : d.ToString("yyyy-MM-dd HH:mm:ss"))
                : Convert.ToString(row[column]) ?? "";
        }
    }

    // Xóa nội dung nhập liệu
    private void Clear()
    {
        grid.ClearSelection();
        grid.CurrentCell = null;

        id = null;

        foreach (var box in boxes.Values)
        {
            box.Clear();
        }
    }

    // Chuyển dữ liệu TextBox thành tham số SQL
    private Microsoft.Data.SqlClient.SqlParameter[] Parameters()
    {
        return boxes.Select(kv =>
        {
            object? value =
                string.IsNullOrWhiteSpace(kv.Value.Text)
                    ? DBNull.Value
                    : kv.Value.Text.Trim();

            var type = sqlTypes[kv.Key];

            if (value != DBNull.Value)
            {
                if (type == "int")
                {
                    value = int.Parse((string)value!);
                }
                else if (type == "decimal" ||
                         type == "numeric")
                {
                    value = decimal.Parse(
                        (string)value!,
                        System.Globalization.CultureInfo.InvariantCulture
                    );
                }
                else if (type == "date" ||
                         type == "datetime" ||
                         type == "datetime2")
                {
                    value = DateTime.Parse(
                        (string)value!,
                        System.Globalization.CultureInfo.InvariantCulture
                    );
                }
            }

            return Db.P("@" + kv.Key, value);

        }).ToArray();
    }

    // THÊM DỮ LIỆU
    private void Insert()
    {
        var columns = boxes.Keys.ToArray();

        Db.Execute(
            $"INSERT INTO [{table}] " +
            $"({string.Join(",", columns.Select(c => "[" + c + "]"))}) " +
            $"VALUES ({string.Join(",", columns.Select(c => "@" + c))})",
            Parameters()
        );

        LoadRows();
    }

    // CẬP NHẬT DỮ LIỆU
    private void Update()
    {
        if (!id.HasValue)
            throw new Exception("Hãy chọn một dòng cần sửa.");

        var pars = Parameters()
            .Concat(new[]
            {
                Db.P("@rowId", id.Value)
            })
            .ToArray();

        Db.Execute(
            $"UPDATE [{table}] SET " +
            $"{string.Join(",", boxes.Keys.Select(c => "[" + c + "]=@" + c))} " +
            $"WHERE [{key}]=@rowId",
            pars
        );

        LoadRows();
    }

    // XÓA DỮ LIỆU
    private void Delete()
    {
        if (!id.HasValue)
            throw new Exception("Hãy chọn một dòng cần xóa.");

        if (MessageBox.Show(
            "Xóa dòng đã chọn? Dữ liệu đang được liên kết sẽ bị SQL Server chặn.",
            "Xác nhận",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
        ) != DialogResult.Yes)
            return;

        Db.Execute(
            $"DELETE FROM [{table}] WHERE [{key}]=@rowId",
            Db.P("@rowId", id.Value)
        );

        id = null;

        LoadRows();
    }
}
