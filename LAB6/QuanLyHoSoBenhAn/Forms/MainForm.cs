using System.Data;
using System.Drawing;
using System.Windows.Forms;
namespace QuanLyBenhAn;
public partial class MainForm : Form
{
    private readonly TabControl tabs = new() { Dock = DockStyle.Fill };
    private readonly DataGridView gBN = Grid(), gPK = Grid(), gToa = Grid(), gCT = Grid();
    private readonly TextBox bnTen = new(), bnDiaChi = new(), bnSdt = new(), bnAnh = new();
    private readonly DateTimePicker bnNgaySinh = new() { Format = DateTimePickerFormat.Short };
    private readonly ComboBox pkHS = Combo(), pkBS = Combo(), pkKhoa = Combo(), pkDK = Combo(), toaPK = Combo(), ctThuoc = Combo();
    private readonly DateTimePicker pkNgay = new() { Format = DateTimePickerFormat.Custom, CustomFormat = "dd/MM/yyyy HH:mm", Width = 180 };
    private readonly TextBox pkTrieuChung = new(), pkChanDoan = new(), toaLoiDan = new(), ctLieu = new(), ctCach = new();
    private readonly NumericUpDown ctSL = new() { Minimum = 1, Maximum = 100000, Value = 1 };
    private readonly Label status = new() { Dock = DockStyle.Bottom, Height = 25, Text = "Sẵn sàng", ForeColor = Color.DarkSlateBlue };
    private int? selectedBN, selectedPK, selectedToa;
    public MainForm()
    {
        InitializeComponent();
        Text = "QUẢN LÝ HỒ SƠ BỆNH ÁN";
        MinimumSize = new Size(1150, 720);
        StartPosition = FormStartPosition.CenterScreen;
        Controls.Add(tabs); Controls.Add(status);
        BuildBN(); BuildPK(); BuildToa(); BuildOtherTables();
        Shown += (_, _) => Safe(RefreshAll);
    }
    private static DataGridView Grid() => new()
    {
        Dock = DockStyle.Fill, ReadOnly = true, AllowUserToAddRows = false,
        MultiSelect = false, SelectionMode = DataGridViewSelectionMode.FullRowSelect,
        AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
    };
    private static ComboBox Combo() => new() { DropDownStyle = ComboBoxStyle.DropDownList, Width = 230 };
    private static TableLayoutPanel Editor() => new()
    {
        Dock = DockStyle.Top, AutoSize = true, Padding = new Padding(10), ColumnCount = 4,
        AutoSizeMode = AutoSizeMode.GrowAndShrink
    };
    private static void Field(TableLayoutPanel p, string label, Control c)
    {
        int index = p.Controls.Count / 2;
        int row = index / 2, col = (index % 2) * 2;
        while (p.RowCount <= row) { p.RowStyles.Add(new RowStyle(SizeType.AutoSize)); p.RowCount++; }
        p.Controls.Add(new Label { Text = label, AutoSize = true, Margin = new Padding(4, 10, 4, 3) }, col, row);
        c.Width = Math.Max(c.Width, 230); c.Margin = new Padding(4);
        p.Controls.Add(c, col + 1, row);
    }
    private static FlowLayoutPanel Buttons(params Control[] controls)
    {
        var p = new FlowLayoutPanel { Dock = DockStyle.Top, Height = 45, Padding = new Padding(10, 5, 0, 0) };
        p.Controls.AddRange(controls); return p;
    }
    private static Button B(string caption, Action action)
    {
        var b = new Button { Text = caption, AutoSize = true, Height = 30 };
        b.Click += (_, _) => action(); return b;
    }
    private TabPage Tab(string name, DataGridView grid, TableLayoutPanel editor, FlowLayoutPanel bar)
    {
        var tab = new TabPage(name);
        tab.Controls.Add(grid); tab.Controls.Add(bar); tab.Controls.Add(editor);
        tabs.TabPages.Add(tab); return tab;
    }
    private void BuildBN()
    {
        var e = Editor();
        Field(e, "Họ tên (*)", bnTen); Field(e, "Ngày sinh", bnNgaySinh);
        Field(e, "Địa chỉ", bnDiaChi); Field(e, "Điện thoại", bnSdt);
        Field(e, "Đường dẫn ảnh 3x4", bnAnh);
        var b = Buttons(B("Thêm bệnh nhân + hồ sơ", () => Safe(AddBN)),
            B("Cập nhật", () => Safe(UpdateBN)), B("Xóa", () => Safe(DeleteBN)),
            B("Làm mới", () => Safe(RefreshAll)));
        Tab("1. Bệnh nhân", gBN, e, b);
        gBN.SelectionChanged += (_, _) =>
        {
            if (gBN.CurrentRow?.DataBoundItem is not DataRowView r) return;
            selectedBN = Convert.ToInt32(r["MaBN"]);
            bnTen.Text = Convert.ToString(r["HoTen"]); bnDiaChi.Text = Convert.ToString(r["DiaChi"]);
            bnSdt.Text = Convert.ToString(r["SoDienThoai"]); bnAnh.Text = Convert.ToString(r["Anh3x4"]);
            if (r["NgaySinh"] != DBNull.Value) bnNgaySinh.Value = Convert.ToDateTime(r["NgaySinh"]);
        };
    }
    private void BuildPK()
    {
        var e = Editor();
        Field(e, "Hồ sơ bệnh án (*)", pkHS); Field(e, "Bác sĩ (*)", pkBS);
        Field(e, "Khoa (*)", pkKhoa); Field(e, "Đăng ký (không bắt buộc)", pkDK);
        Field(e, "Ngày giờ khám", pkNgay); Field(e, "Triệu chứng", pkTrieuChung);
        Field(e, "Chẩn đoán", pkChanDoan);
        var b = Buttons(B("Thêm phiếu khám", () => Safe(AddPK)),
            B("Cập nhật", () => Safe(UpdatePK)), B("Làm mới", () => Safe(RefreshAll)));
        Tab("2. Phiếu khám", gPK, e, b);
        gPK.SelectionChanged += (_, _) =>
        {
            if (gPK.CurrentRow?.DataBoundItem is not DataRowView r) return;
            selectedPK = Convert.ToInt32(r["MaPhieuKham"]);
            SelectCombo(pkHS, r["MaHoSo"]); SelectCombo(pkBS, r["MaBS"]);
            SelectCombo(pkKhoa, r["MaKhoa"]); SelectCombo(pkDK, r["MaDK"]);
            pkNgay.Value = Convert.ToDateTime(r["NgayGioKham"]);
            pkTrieuChung.Text = Convert.ToString(r["TrieuChung"]);
            pkChanDoan.Text = Convert.ToString(r["ChanDoan"]);
        };
    }
    private void BuildToa()
    {
        var page = new TabPage("3. Lập toa thuốc"); tabs.TabPages.Add(page);
        var split = new SplitContainer { Dock = DockStyle.Fill, Orientation = Orientation.Horizontal, SplitterDistance = 260 };
        page.Controls.Add(split);
        var e = Editor(); Field(e, "Phiếu khám (*)", toaPK); Field(e, "Lời dặn", toaLoiDan);
        split.Panel1.Controls.Add(gToa);
        split.Panel1.Controls.Add(Buttons(B("Lập toa thuốc", () => Safe(AddToa)), B("Làm mới", () => Safe(RefreshAll))));
        split.Panel1.Controls.Add(e);
        var top = Editor(); Field(top, "Thuốc (*)", ctThuoc); Field(top, "Số lượng (*)", ctSL);
        Field(top, "Liều dùng (*)", ctLieu); Field(top, "Cách dùng", ctCach);
        split.Panel2.Controls.Add(gCT);
        split.Panel2.Controls.Add(Buttons(B("Thêm thuốc vào toa đang chọn", () => Safe(AddCT)),
            B("Xóa thuốc đang chọn", () => Safe(DeleteCT))));
        split.Panel2.Controls.Add(top);
        gToa.SelectionChanged += (_, _) =>
        {
            if (gToa.CurrentRow?.DataBoundItem is not DataRowView r) return;
            selectedToa = Convert.ToInt32(r["MaToa"]);
            SelectCombo(toaPK, r["MaPhieuKham"]); toaLoiDan.Text = Convert.ToString(r["LoiDan"]);
            Safe(RefreshCT);
        };
    }
    private void BuildOtherTables()
    {
        foreach (var (table, title) in new (string, string)[]
        {
            ("Khoa","Khoa"),("BacSi","Bác sĩ"),("DangKyKhamBenh","Đăng ký khám"),
            ("LePhiNam","Lệ phí năm"),("HoSoBenhAn","Hồ sơ bệnh án"),
            ("XetNghiem","Xét nghiệm"),("Thuoc","Danh mục thuốc"),
            ("LichKhamDinhKy","Lịch khám định kỳ"),("ThanhToanVienPhi","Thanh toán viện phí")
        })
        {
            var page = new TabPage(title);
            page.Controls.Add(new GenericTableForm(table));
            tabs.TabPages.Add(page);
        }
    }
    private void Safe(Action action)
    {
        try { action(); status.Text = "Thao tác thành công - " + DateTime.Now.ToString("HH:mm:ss"); }
        catch (Exception ex) { status.Text = "Có lỗi: " + ex.Message; MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); }
    }
    private static void BindCombo(ComboBox c, string sql, bool allowEmpty = false)
    {
        var dt = Db.Query(sql);
        if (allowEmpty)
        {
            var r = dt.NewRow(); r["Id"] = DBNull.Value; r["Ten"] = "-- Không chọn --";
            dt.Rows.InsertAt(r, 0);
        }
        c.DisplayMember = "Ten"; c.ValueMember = "Id"; c.DataSource = dt;
    }
    private static void SelectCombo(ComboBox c, object id)
    {
        if (c.DataSource == null) return;
        c.SelectedValue = id == DBNull.Value ? DBNull.Value : id;
    }
    private static int SelectedId(ComboBox c)
    {
        if (c.SelectedValue == null || c.SelectedValue == DBNull.Value) throw new Exception("Vui lòng chọn đầy đủ thông tin bắt buộc.");
        return Convert.ToInt32(c.SelectedValue);
    }
    private void RefreshAll()
    {
        gBN.DataSource = Db.Query("SELECT * FROM BenhNhan ORDER BY MaBN DESC");
        gPK.DataSource = Db.Query("SELECT * FROM PhieuKham ORDER BY MaPhieuKham DESC");
        BindCombo(pkHS, "SELECT MaHoSo AS Id, CONCAT(N'Hồ sơ #',MaHoSo,N' - ',bn.HoTen) AS Ten FROM HoSoBenhAn h JOIN BenhNhan bn ON bn.MaBN=h.MaBN ORDER BY MaHoSo");
        BindCombo(pkBS, "SELECT MaBS AS Id, HoTen AS Ten FROM BacSi ORDER BY MaBS");
        BindCombo(pkKhoa, "SELECT MaKhoa AS Id, TenKhoa AS Ten FROM Khoa ORDER BY MaKhoa");
        BindCombo(pkDK, "SELECT MaDK AS Id, CONCAT(N'Đăng ký #',MaDK) AS Ten FROM DangKyKhamBenh ORDER BY MaDK", true);
        BindCombo(toaPK, "SELECT MaPhieuKham AS Id, CONCAT(N'Phiếu khám #',MaPhieuKham) AS Ten FROM PhieuKham ORDER BY MaPhieuKham");
        BindCombo(ctThuoc, "SELECT MaThuoc AS Id, TenThuoc AS Ten FROM Thuoc ORDER BY MaThuoc");
        gToa.DataSource = Db.Query("SELECT * FROM ToaThuoc ORDER BY MaToa DESC");
        RefreshCT();
    }
    private void RefreshCT()
    {
        gCT.DataSource = selectedToa.HasValue
            ? Db.Query("SELECT ct.MaCTToa, ct.MaToa, t.TenThuoc, ct.SoLuong, ct.LieuDung, ct.CachDung FROM ChiTietToaThuoc ct JOIN Thuoc t ON t.MaThuoc=ct.MaThuoc WHERE ct.MaToa=@id ORDER BY ct.MaCTToa", Db.P("@id", selectedToa.Value))
            : new DataTable();
    }
    private void AddBN()
    {
        if (string.IsNullOrWhiteSpace(bnTen.Text)) throw new Exception("Họ tên không được trống.");
        // Tạo bệnh nhân và hồ sơ trong cùng một transaction SQL.
        Db.Execute(@"SET XACT_ABORT ON; BEGIN TRAN;
          DECLARE @id INT;
          INSERT INTO BenhNhan(HoTen,NgaySinh,DiaChi,SoDienThoai,Anh3x4) VALUES(@ten,@ngay,@dc,@sdt,@anh);
          SET @id=SCOPE_IDENTITY();
          INSERT INTO HoSoBenhAn(MaBN) VALUES(@id);
          COMMIT;", Db.P("@ten",bnTen.Text.Trim()),Db.P("@ngay",bnNgaySinh.Value.Date),
          Db.P("@dc",bnDiaChi.Text),Db.P("@sdt",bnSdt.Text),Db.P("@anh",bnAnh.Text));
        RefreshAll();
    }
    private void UpdateBN()
    {
        if (!selectedBN.HasValue) throw new Exception("Chọn bệnh nhân cần sửa.");
        Db.Execute("UPDATE BenhNhan SET HoTen=@ten,NgaySinh=@ngay,DiaChi=@dc,SoDienThoai=@sdt,Anh3x4=@anh WHERE MaBN=@id",
          Db.P("@ten",bnTen.Text),Db.P("@ngay",bnNgaySinh.Value.Date),Db.P("@dc",bnDiaChi.Text),
          Db.P("@sdt",bnSdt.Text),Db.P("@anh",bnAnh.Text),Db.P("@id",selectedBN.Value));
        RefreshAll();
    }
    private void DeleteBN()
    {
        if (!selectedBN.HasValue) throw new Exception("Chọn bệnh nhân cần xóa.");
        if (MessageBox.Show("Xóa bệnh nhân và hồ sơ trống? Không thể xóa nếu đã có dữ liệu liên quan.", "Xác nhận", MessageBoxButtons.YesNo) != DialogResult.Yes) return;
        Db.Execute(@"SET XACT_ABORT ON; BEGIN TRAN;
          DELETE FROM HoSoBenhAn WHERE MaBN=@id;
          DELETE FROM BenhNhan WHERE MaBN=@id;
          COMMIT;",Db.P("@id",selectedBN.Value));
        selectedBN=null;RefreshAll();
    }
    private void AddPK()
    {
        Db.Execute(@"INSERT INTO PhieuKham(MaHoSo,MaBS,MaKhoa,MaDK,NgayGioKham,TrieuChung,ChanDoan)
          VALUES(@hs,@bs,@khoa,@dk,@ngay,@tc,@cd)", Db.P("@hs",SelectedId(pkHS)),Db.P("@bs",SelectedId(pkBS)),
          Db.P("@khoa",SelectedId(pkKhoa)),Db.P("@dk",pkDK.SelectedValue),Db.P("@ngay",pkNgay.Value),
          Db.P("@tc",pkTrieuChung.Text),Db.P("@cd",pkChanDoan.Text));
        RefreshAll();
    }
    private void UpdatePK()
    {
        if (!selectedPK.HasValue) throw new Exception("Chọn phiếu khám cần sửa.");
        Db.Execute(@"UPDATE PhieuKham SET MaHoSo=@hs,MaBS=@bs,MaKhoa=@khoa,MaDK=@dk,
          NgayGioKham=@ngay,TrieuChung=@tc,ChanDoan=@cd WHERE MaPhieuKham=@id",
          Db.P("@hs",SelectedId(pkHS)),Db.P("@bs",SelectedId(pkBS)),Db.P("@khoa",SelectedId(pkKhoa)),
          Db.P("@dk",pkDK.SelectedValue),Db.P("@ngay",pkNgay.Value),Db.P("@tc",pkTrieuChung.Text),
          Db.P("@cd",pkChanDoan.Text),Db.P("@id",selectedPK.Value));
        RefreshAll();
    }
    private void AddToa()
    {
        int pk = SelectedId(toaPK);
        Db.Execute("INSERT INTO ToaThuoc(MaPhieuKham,LoiDan) VALUES(@pk,@ld)",Db.P("@pk",pk),Db.P("@ld",toaLoiDan.Text));
        RefreshAll();
    }
    private void AddCT()
    {
        if (!selectedToa.HasValue) throw new Exception("Chọn toa thuốc ở bảng phía trên trước.");
        if (string.IsNullOrWhiteSpace(ctLieu.Text)) throw new Exception("Nhập liều dùng.");
        Db.Execute(@"INSERT INTO ChiTietToaThuoc(MaToa,MaThuoc,SoLuong,LieuDung,CachDung)
          VALUES(@toa,@thuoc,@sl,@lieu,@cach)",Db.P("@toa",selectedToa.Value),Db.P("@thuoc",SelectedId(ctThuoc)),
          Db.P("@sl",(int)ctSL.Value),Db.P("@lieu",ctLieu.Text),Db.P("@cach",ctCach.Text));
        RefreshCT();
    }
    private void DeleteCT()
    {
        if (gCT.CurrentRow?.DataBoundItem is not DataRowView r) throw new Exception("Chọn dòng thuốc cần xóa.");
        Db.Execute("DELETE FROM ChiTietToaThuoc WHERE MaCTToa=@id", Db.P("@id",r["MaCTToa"]));
        RefreshCT();
    }
}
