
using System;
using System.Data;
using System.Data.SqlClient;
using QuanLyChoThueVanPhong.Data;

namespace QuanLyChoThueVanPhong.Services
{
    public class ThanhToanDichVuService
    {
        public DataTable LayHoaDon()
        {
            return Db.Query(
                @"SELECT h.MaHoaDon, h.MaHD, h.MaPhong,
                         h.Thang, h.Nam, h.NgayLap,
                         h.HanThanhToan, h.TongTien,
                         ISNULL(t.DaThanhToan, 0) AS DaThanhToan,
                         h.TongTien - ISNULL(t.DaThanhToan, 0) AS ConNo,
                         h.TrangThai
                  FROM HoaDonDichVu h
                  LEFT JOIN
                  (
                      SELECT MaHoaDon, SUM(SoTien) AS DaThanhToan
                      FROM ThanhToanDichVu
                      GROUP BY MaHoaDon
                  ) t ON h.MaHoaDon = t.MaHoaDon
                  ORDER BY h.Nam DESC, h.Thang DESC, h.MaHoaDon"
            );
        }

        public DataTable TimKiem(string tuKhoa)
        {
            return Db.Query(
                @"SELECT h.MaHoaDon, h.MaHD, h.MaPhong,
                         h.Thang, h.Nam, h.NgayLap,
                         h.HanThanhToan, h.TongTien,
                         ISNULL(t.DaThanhToan, 0) AS DaThanhToan,
                         h.TongTien - ISNULL(t.DaThanhToan, 0) AS ConNo,
                         h.TrangThai
                  FROM HoaDonDichVu h
                  LEFT JOIN
                  (
                      SELECT MaHoaDon, SUM(SoTien) AS DaThanhToan
                      FROM ThanhToanDichVu
                      GROUP BY MaHoaDon
                  ) t ON h.MaHoaDon = t.MaHoaDon
                  WHERE h.MaHoaDon LIKE @TuKhoa
                     OR h.MaHD LIKE @TuKhoa
                     OR h.MaPhong LIKE @TuKhoa
                  ORDER BY h.Nam DESC, h.Thang DESC",
                Db.P("@TuKhoa", "%" + tuKhoa.Trim() + "%")
            );
        }

        public DataTable LayLichSu(string maHoaDon)
        {
            return Db.Query(
                @"SELECT MaTTDV, MaHoaDon, NgayThanhToan,
                         SoTien, HinhThucThanhToan
                  FROM ThanhToanDichVu
                  WHERE MaHoaDon = @MaHoaDon
                  ORDER BY NgayThanhToan DESC, MaTTDV",
                Db.P("@MaHoaDon", maHoaDon)
            );
        }

        public void ThanhToan(
            string maTTDV,
            string maHoaDon,
            decimal soTien,
            string hinhThuc)
        {
            if (string.IsNullOrWhiteSpace(maTTDV))
                throw new Exception("Mã thanh toán không được để trống.");

            if (string.IsNullOrWhiteSpace(maHoaDon))
                throw new Exception("Vui lòng chọn hóa đơn.");

            if (soTien <= 0)
                throw new Exception("Số tiền thanh toán phải lớn hơn 0.");

            if (string.IsNullOrWhiteSpace(hinhThuc))
                throw new Exception("Vui lòng chọn hình thức thanh toán.");

            using (SqlConnection connection = Db.OpenConnection())
            {
                if (connection.State != ConnectionState.Open)
                    connection.Open();

                using (SqlTransaction transaction = connection.BeginTransaction())
                {
                    try
                    {
                        decimal tongTien;
                        decimal daThanhToan;

                        using (SqlCommand command = new SqlCommand(
                            @"SELECT TongTien
                              FROM HoaDonDichVu WITH (UPDLOCK, HOLDLOCK)
                              WHERE MaHoaDon = @MaHoaDon",
                            connection, transaction))
                        {
                            command.Parameters.Add("@MaHoaDon", SqlDbType.VarChar, 20)
                                .Value = maHoaDon.Trim();

                            object ketQua = command.ExecuteScalar();

                            if (ketQua == null || ketQua == DBNull.Value)
                                throw new Exception("Không tìm thấy hóa đơn.");

                            tongTien = Convert.ToDecimal(ketQua);
                        }

                        using (SqlCommand command = new SqlCommand(
                            @"SELECT ISNULL(SUM(SoTien), 0)
                              FROM ThanhToanDichVu
                              WHERE MaHoaDon = @MaHoaDon",
                            connection, transaction))
                        {
                            command.Parameters.Add("@MaHoaDon", SqlDbType.VarChar, 20)
                                .Value = maHoaDon.Trim();

                            daThanhToan = Convert.ToDecimal(command.ExecuteScalar());
                        }

                        decimal conNo = tongTien - daThanhToan;

                        if (conNo <= 0)
                            throw new Exception("Hóa đơn đã được thanh toán đủ.");

                        if (soTien > conNo)
                            throw new Exception("Số tiền thanh toán vượt quá công nợ.");

                        using (SqlCommand command = new SqlCommand(
                            @"INSERT INTO ThanhToanDichVu
                              (MaTTDV, MaHoaDon, NgayThanhToan,
                               SoTien, HinhThucThanhToan)
                              VALUES
                              (@MaTTDV, @MaHoaDon, GETDATE(),
                               @SoTien, @HinhThuc)",
                            connection, transaction))
                        {
                            command.Parameters.Add("@MaTTDV", SqlDbType.VarChar, 20)
                                .Value = maTTDV.Trim();

                            command.Parameters.Add("@MaHoaDon", SqlDbType.VarChar, 20)
                                .Value = maHoaDon.Trim();

                            SqlParameter p = command.Parameters.Add(
                                "@SoTien", SqlDbType.Decimal);

                            p.Precision = 18;
                            p.Scale = 2;
                            p.Value = soTien;

                            command.Parameters.Add("@HinhThuc", SqlDbType.NVarChar, 100)
                                .Value = hinhThuc;

                            command.ExecuteNonQuery();
                        }

                        decimal tongDaTra = daThanhToan + soTien;

                        string trangThai = tongDaTra >= tongTien
                            ? "Đã thanh toán"
                            : "Thanh toán một phần";

                        using (SqlCommand command = new SqlCommand(
                            @"UPDATE HoaDonDichVu
                              SET TrangThai = @TrangThai
                              WHERE MaHoaDon = @MaHoaDon",
                            connection, transaction))
                        {
                            command.Parameters.Add("@TrangThai", SqlDbType.NVarChar, 100)
                                .Value = trangThai;

                            command.Parameters.Add("@MaHoaDon", SqlDbType.VarChar, 20)
                                .Value = maHoaDon.Trim();

                            command.ExecuteNonQuery();
                        }

                        transaction.Commit();
                    }
                    catch
                    {
                        transaction.Rollback();
                        throw;
                    }
                }
            }
        }
    }
}
