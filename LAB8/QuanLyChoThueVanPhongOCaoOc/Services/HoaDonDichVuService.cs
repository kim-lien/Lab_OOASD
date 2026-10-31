
using System;
using System.Data;
using System.Data.SqlClient;
using QuanLyChoThueVanPhong.Data;

namespace QuanLyChoThueVanPhong.Services
{
    public class HoaDonDichVuService
    {
        public DataTable LayHopDong()
        {
            return Db.Query(
                @"SELECT MaHD FROM HopDongThue
                  WHERE TrangThai <> N'Đã hủy'
                  ORDER BY MaHD"
            );
        }

        public DataTable LayPhong(string maHD)
        {
            return Db.Query(
                @"SELECT MaPhong FROM ChiTietHopDong
                  WHERE MaHD = @MaHD
                  ORDER BY MaPhong",
                Db.P("@MaHD", maHD)
            );
        }

        public DataTable LayDichVu()
        {
            return Db.Query(
                @"SELECT MaDV, TenDV, DonViTinh, DonGia
                  FROM DichVu
                  WHERE TrangThai = N'Đang sử dụng'
                  ORDER BY MaDV"
            );
        }

        public DataTable LayHoaDon()
        {
            return Db.Query(
                @"SELECT MaHoaDon, MaHD, MaPhong, Thang, Nam,
                         NgayLap, HanThanhToan, TongTien, TrangThai
                  FROM HoaDonDichVu
                  ORDER BY Nam DESC, Thang DESC, MaHoaDon"
            );
        }

        public DataTable TimKiem(string tuKhoa)
        {
            return Db.Query(
                @"SELECT MaHoaDon, MaHD, MaPhong, Thang, Nam,
                         NgayLap, HanThanhToan, TongTien, TrangThai
                  FROM HoaDonDichVu
                  WHERE MaHoaDon LIKE @TuKhoa
                     OR MaHD LIKE @TuKhoa
                     OR MaPhong LIKE @TuKhoa
                  ORDER BY Nam DESC, Thang DESC",
                Db.P("@TuKhoa", "%" + tuKhoa.Trim() + "%")
            );
        }

        public DataTable LayChiTiet(string maHoaDon)
        {
            return Db.Query(
                @"SELECT ct.MaDV, dv.TenDV, dv.DonViTinh,
                         ct.SoLuong, ct.DonGia, ct.ThanhTien
                  FROM ChiTietHoaDon ct
                  JOIN DichVu dv ON ct.MaDV = dv.MaDV
                  WHERE ct.MaHoaDon = @MaHoaDon
                  ORDER BY ct.MaDV",
                Db.P("@MaHoaDon", maHoaDon)
            );
        }

        public void LapHoaDon(
            string maHoaDon,
            string maHD,
            string maPhong,
            int thang,
            int nam,
            DataTable danhSachDichVu)
        {
            if (string.IsNullOrWhiteSpace(maHoaDon))
                throw new Exception("Mã hóa đơn không được để trống.");

            if (string.IsNullOrWhiteSpace(maHD) ||
                string.IsNullOrWhiteSpace(maPhong))
                throw new Exception("Phải chọn hợp đồng và văn phòng.");

            if (thang < 1 || thang > 12 || nam < 2000 || nam > 9999)
                throw new Exception("Tháng hoặc năm không hợp lệ.");

            if (new DateTime(nam, thang, 1).AddMonths(1).AddDays(-1)
                > DateTime.Today)
                throw new Exception("Chưa đến cuối tháng để lập hóa đơn.");

            if (danhSachDichVu == null || danhSachDichVu.Rows.Count == 0)
                throw new Exception("Vui lòng chọn ít nhất một dịch vụ.");

            using (SqlConnection connection = Db.OpenConnection())
            using (SqlCommand command =
                new SqlCommand("sp_LapHoaDonDichVu", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.CommandTimeout = 60;

                command.Parameters.Add("@MaHoaDon", SqlDbType.VarChar, 20)
                    .Value = maHoaDon.Trim();

                command.Parameters.Add("@MaHD", SqlDbType.VarChar, 20)
                    .Value = maHD;

                command.Parameters.Add("@MaPhong", SqlDbType.VarChar, 20)
                    .Value = maPhong;

                command.Parameters.Add("@Thang", SqlDbType.Int).Value = thang;
                command.Parameters.Add("@Nam", SqlDbType.Int).Value = nam;

                SqlParameter ds = command.Parameters.Add(
                    "@DanhSachDichVu", SqlDbType.Structured
                );

                ds.TypeName = "dbo.DanhSachDichVu";
                ds.Value = danhSachDichVu;

                command.ExecuteNonQuery();
            }
        }
    }
}
