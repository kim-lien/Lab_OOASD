using System.Data;
namespace QuanLyBenhAn.Services;

/// <summary>Các truy vấn dùng lại để tra cứu bệnh nhân và hồ sơ.</summary>
public static class BenhAnService
{
    public static DataTable TimBenhNhan(string tuKhoa) => Db.Query(
        "SELECT * FROM BenhNhan WHERE HoTen LIKE @q OR SoDienThoai LIKE @q ORDER BY MaBN DESC",
        Db.P("@q", "%" + tuKhoa.Trim() + "%"));

    public static DataTable LichSuKham(int maHoSo) => Db.Query(
        "SELECT * FROM PhieuKham WHERE MaHoSo=@id ORDER BY NgayGioKham DESC",
        Db.P("@id", maHoSo));
}
