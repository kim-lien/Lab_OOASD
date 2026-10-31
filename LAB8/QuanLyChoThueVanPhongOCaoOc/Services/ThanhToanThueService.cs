
using System;
using System.Data;
using System.Data.SqlClient;
using QuanLyChoThueVanPhong.Data;

namespace QuanLyChoThueVanPhong.Services
{
    public class ThanhToanThueService
    {
        public DataTable LayHopDong()
        {
            return Db.Query(
                @"SELECT hd.MaHD, kh.TenCongTy
                  FROM HopDongThue hd
                  JOIN KhachHang kh ON hd.MaKH = kh.MaKH
                  WHERE hd.TrangThai <> N'Đã hủy'
                  ORDER BY hd.MaHD"
            );
        }

        public DataTable LayKyThanhToan(string maHD)
        {
            return Db.Query(
                @"SELECT k.MaKy, k.MaPhong, k.ThangThu,
                         k.LoaiKy, k.NgayDenHan,
                         k.SoTienPhaiThu,
                         COALESCE(SUM(t.SoTien), 0) AS DaThanhToan,
                         k.SoTienPhaiThu - COALESCE(SUM(t.SoTien), 0) AS ConNo,
                         k.TrangThai
                  FROM KyThanhToan k
                  LEFT JOIN ThanhToanTienThue t ON k.MaKy = t.MaKy
                  WHERE k.MaHD = @MaHD
                  GROUP BY k.MaKy, k.MaPhong, k.ThangThu,
                           k.LoaiKy, k.NgayDenHan,
                           k.SoTienPhaiThu, k.TrangThai
                  ORDER BY k.MaPhong, k.ThangThu",
                Db.P("@MaHD", maHD)
            );
        }

        public DataTable LayLichSuThanhToan(string maKy)
        {
            return Db.Query(
                @"SELECT MaThanhToan, NgayThanhToan,
                         SoTien, HinhThucThanhToan, GhiChu
                  FROM ThanhToanTienThue
                  WHERE MaKy = @MaKy
                  ORDER BY NgayThanhToan DESC",
                Db.P("@MaKy", maKy)
            );
        }

        public void ThanhToan(
            string maThanhToan,
            string maKy,
            decimal soTien,
            string hinhThuc)
        {
            if (string.IsNullOrWhiteSpace(maThanhToan))
                throw new Exception("Mã thanh toán không được để trống.");

            if (string.IsNullOrWhiteSpace(maKy))
                throw new Exception("Vui lòng chọn kỳ thanh toán.");

            if (soTien <= 0)
                throw new Exception("Số tiền thanh toán phải lớn hơn 0.");

            if (string.IsNullOrWhiteSpace(hinhThuc))
                throw new Exception("Vui lòng chọn hình thức thanh toán.");

            using (SqlConnection connection = Db.OpenConnection())
            using (SqlCommand command = new SqlCommand("sp_ThanhToanTienThue", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.CommandTimeout = 60;

                command.Parameters.Add("@MaThanhToan", SqlDbType.VarChar, 20).Value = maThanhToan.Trim();
                command.Parameters.Add("@MaKy", SqlDbType.VarChar, 20).Value = maKy;
                command.Parameters.Add("@SoTien", SqlDbType.Decimal).Value = soTien;
                command.Parameters["@SoTien"].Precision = 18;
                command.Parameters["@SoTien"].Scale = 2;
                command.Parameters.Add("@HinhThuc", SqlDbType.NVarChar, 100).Value = hinhThuc;

                command.ExecuteNonQuery();
            }
        }
    }
}
