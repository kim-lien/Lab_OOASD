
using System;
using System.Data;
using System.Data.SqlClient;
using QuanLyChoThueVanPhong.Data;

namespace QuanLyChoThueVanPhong.Services
{
    public class GiaHanService
    {
        public DataTable LayHopDong()
        {
            return Db.Query(
                @"SELECT MaHD, MaKH, NgayBatDau, NgayKetThuc,
                         ThoiHanThue, TrangThai
                  FROM HopDongThue
                  ORDER BY MaHD"
            );
        }

        public DataTable LayVanPhong(string maHD)
        {
            return Db.Query(
                @"SELECT ct.MaPhong, ct.DonGiaThue,
                         ct.NgayBatDau, ct.NgayKetThuc,
                         ct.ThoiHanThue
                  FROM ChiTietHopDong ct
                  WHERE ct.MaHD = @MaHD
                  ORDER BY ct.MaPhong",
                Db.P("@MaHD", maHD)
            );
        }

        public DataTable LayLichSu()
        {
            return Db.Query(
                @"SELECT MaGiaHan, MaHD, MaPhong, NgayLap,
                         SoThangGiaHan, NgayBatDauMoi,
                         NgayKetThucMoi, TrangThai
                  FROM PhieuGiaHan
                  ORDER BY NgayLap DESC, MaGiaHan"
            );
        }

        public DataTable TimKiem(string tuKhoa)
        {
            return Db.Query(
                @"SELECT MaGiaHan, MaHD, MaPhong, NgayLap,
                         SoThangGiaHan, NgayBatDauMoi,
                         NgayKetThucMoi, TrangThai
                  FROM PhieuGiaHan
                  WHERE MaGiaHan LIKE @TuKhoa
                     OR MaHD LIKE @TuKhoa
                     OR MaPhong LIKE @TuKhoa
                  ORDER BY NgayLap DESC, MaGiaHan",
                Db.P("@TuKhoa", "%" + tuKhoa.Trim() + "%")
            );
        }

        public DataTable LayThongTin(string maHD, string maPhong)
        {
            return Db.Query(
                @"SELECT ct.MaHD, ct.MaPhong,
                         ct.NgayBatDau, ct.NgayKetThuc,
                         ct.ThoiHanThue,
                         hd.ThoiHanThue AS ThoiHanGoc,
                         ISNULL(g.SoThangDaGiaHan, 0) AS DaGiaHan,
                         CAST(
                             ISNULL(hd.ThoiHanThue, 0) / 2
                             - ISNULL(g.SoThangDaGiaHan, 0)
                             AS INT
                         ) AS ConDuocGiaHan
                  FROM ChiTietHopDong ct
                  INNER JOIN HopDongThue hd
                      ON hd.MaHD = ct.MaHD
                  OUTER APPLY
                  (
                      SELECT SUM(p.SoThangGiaHan) AS SoThangDaGiaHan
                      FROM PhieuGiaHan p
                      WHERE p.MaHD = ct.MaHD
                        AND p.MaPhong = ct.MaPhong
                        AND p.TrangThai <> N'Đã hủy'
                  ) g
                  WHERE ct.MaHD = @MaHD
                    AND ct.MaPhong = @MaPhong",
                Db.P("@MaHD", maHD),
                Db.P("@MaPhong", maPhong)
            );
        }

        public DataTable LayCongNo(string maHD, string maPhong)
        {
            return Db.Query(
                @"SELECT
                    (
                        SELECT ISNULL(SUM(
                            CASE WHEN k.SoTienPhaiThu > ISNULL(t.DaTra, 0)
                                 THEN k.SoTienPhaiThu - ISNULL(t.DaTra, 0)
                                 ELSE 0 END
                        ), 0)
                        FROM KyThanhToan k
                        OUTER APPLY
                        (
                            SELECT SUM(x.SoTien) AS DaTra
                            FROM ThanhToanTienThue x
                            WHERE x.MaKy = k.MaKy
                        ) t
                        WHERE k.MaHD = @MaHD
                          AND k.MaPhong = @MaPhong
                    ) AS NoTienThue,
                    (
                        SELECT ISNULL(SUM(
                            CASE WHEN h.TongTien > ISNULL(t.DaTra, 0)
                                 THEN h.TongTien - ISNULL(t.DaTra, 0)
                                 ELSE 0 END
                        ), 0)
                        FROM HoaDonDichVu h
                        OUTER APPLY
                        (
                            SELECT SUM(x.SoTien) AS DaTra
                            FROM ThanhToanDichVu x
                            WHERE x.MaHoaDon = h.MaHoaDon
                        ) t
                        WHERE h.MaHD = @MaHD
                          AND h.MaPhong = @MaPhong
                    ) AS NoDichVu",
                Db.P("@MaHD", maHD),
                Db.P("@MaPhong", maPhong)
            );
        }

        public void GiaHan(
            string maGiaHan,
            string maHD,
            string maPhong,
            int soThang)
        {
            if (string.IsNullOrWhiteSpace(maGiaHan))
                throw new Exception("Vui lòng nhập mã phiếu gia hạn.");

            if (string.IsNullOrWhiteSpace(maHD) ||
                string.IsNullOrWhiteSpace(maPhong))
                throw new Exception("Vui lòng chọn hợp đồng và văn phòng.");

            if (soThang <= 0)
                throw new Exception("Số tháng gia hạn phải lớn hơn 0.");

            using (SqlConnection connection = Db.OpenConnection())
            {
                if (connection.State != ConnectionState.Open)
                    connection.Open();

                using (SqlTransaction transaction = connection.BeginTransaction(
                    IsolationLevel.Serializable))
                {
                    try
                    {
                        DateTime ngayKetThuc;
                        int thoiHanGoc;
                        int daGiaHan;

                        using (SqlCommand command = new SqlCommand(
                            @"SELECT ct.NgayKetThuc,
                                     hd.ThoiHanThue,
                                     ISNULL((
                                         SELECT SUM(p.SoThangGiaHan)
                                         FROM PhieuGiaHan p
                                         WHERE p.MaHD = ct.MaHD
                                           AND p.MaPhong = ct.MaPhong
                                           AND p.TrangThai <> N'Đã hủy'
                                     ), 0) AS DaGiaHan
                              FROM ChiTietHopDong ct WITH (UPDLOCK, HOLDLOCK)
                              JOIN HopDongThue hd ON hd.MaHD = ct.MaHD
                              WHERE ct.MaHD = @MaHD
                                AND ct.MaPhong = @MaPhong",
                            connection, transaction))
                        {
                            command.Parameters.AddWithValue("@MaHD", maHD);
                            command.Parameters.AddWithValue("@MaPhong", maPhong);

                            using (SqlDataReader reader = command.ExecuteReader())
                            {
                                if (!reader.Read())
                                    throw new Exception(
                                        "Không tìm thấy văn phòng trong hợp đồng."
                                    );

                                ngayKetThuc = Convert.ToDateTime(reader["NgayKetThuc"]);
                                thoiHanGoc = Convert.ToInt32(reader["ThoiHanThue"]);
                                daGiaHan = Convert.ToInt32(reader["DaGiaHan"]);
                            }
                        }

                        int conDuocGiaHan = thoiHanGoc / 2 - daGiaHan;

                        if (conDuocGiaHan <= 0)
                            throw new Exception(
                                "Văn phòng đã sử dụng hết thời gian gia hạn."
                            );

                        if (soThang > conDuocGiaHan)
                            throw new Exception(
                                "Chỉ được gia hạn tối đa " +
                                conDuocGiaHan + " tháng."
                            );

                        decimal noTienThue;
                        decimal noDichVu;

                        using (SqlCommand command = new SqlCommand(
                            @"SELECT ISNULL(SUM(
                                  CASE WHEN k.SoTienPhaiThu > ISNULL(t.DaTra, 0)
                                       THEN k.SoTienPhaiThu - ISNULL(t.DaTra, 0)
                                       ELSE 0 END
                              ), 0)
                              FROM KyThanhToan k
                              OUTER APPLY
                              (
                                  SELECT SUM(x.SoTien) AS DaTra
                                  FROM ThanhToanTienThue x
                                  WHERE x.MaKy = k.MaKy
                              ) t
                              WHERE k.MaHD = @MaHD
                                AND k.MaPhong = @MaPhong",
                            connection, transaction))
                        {
                            command.Parameters.AddWithValue("@MaHD", maHD);
                            command.Parameters.AddWithValue("@MaPhong", maPhong);
                            noTienThue = Convert.ToDecimal(command.ExecuteScalar());
                        }

                        using (SqlCommand command = new SqlCommand(
                            @"SELECT ISNULL(SUM(
                                  CASE WHEN h.TongTien > ISNULL(t.DaTra, 0)
                                       THEN h.TongTien - ISNULL(t.DaTra, 0)
                                       ELSE 0 END
                              ), 0)
                              FROM HoaDonDichVu h
                              OUTER APPLY
                              (
                                  SELECT SUM(x.SoTien) AS DaTra
                                  FROM ThanhToanDichVu x
                                  WHERE x.MaHoaDon = h.MaHoaDon
                              ) t
                              WHERE h.MaHD = @MaHD
                                AND h.MaPhong = @MaPhong",
                            connection, transaction))
                        {
                            command.Parameters.AddWithValue("@MaHD", maHD);
                            command.Parameters.AddWithValue("@MaPhong", maPhong);
                            noDichVu = Convert.ToDecimal(command.ExecuteScalar());
                        }

                        if (noTienThue > 0 || noDichVu > 0)
                            throw new Exception(
                                "Không được gia hạn khi còn nợ tiền thuê " +
                                "hoặc phí dịch vụ."
                            );

                        DateTime ngayBatDauMoi = ngayKetThuc.AddDays(1);
                        DateTime ngayKetThucMoi = ngayKetThuc.AddMonths(soThang);

                        using (SqlCommand command = new SqlCommand(
                            @"INSERT INTO PhieuGiaHan
                              (MaGiaHan, MaHD, MaPhong, NgayLap,
                               SoThangGiaHan, NgayBatDauMoi,
                               NgayKetThucMoi, TrangThai)
                              VALUES
                              (@MaGiaHan, @MaHD, @MaPhong, GETDATE(),
                               @SoThang, @NgayBatDauMoi,
                               @NgayKetThucMoi, N'Đã duyệt')",
                            connection, transaction))
                        {
                            command.Parameters.AddWithValue("@MaGiaHan", maGiaHan.Trim());
                            command.Parameters.AddWithValue("@MaHD", maHD);
                            command.Parameters.AddWithValue("@MaPhong", maPhong);
                            command.Parameters.AddWithValue("@SoThang", soThang);
                            command.Parameters.Add("@NgayBatDauMoi", SqlDbType.Date)
                                .Value = ngayBatDauMoi;
                            command.Parameters.Add("@NgayKetThucMoi", SqlDbType.Date)
                                .Value = ngayKetThucMoi;

                            command.ExecuteNonQuery();
                        }

                        using (SqlCommand command = new SqlCommand(
                            @"UPDATE ChiTietHopDong
                              SET NgayKetThuc = @NgayKetThucMoi,
                                  ThoiHanThue = ThoiHanThue + @SoThang
                              WHERE MaHD = @MaHD AND MaPhong = @MaPhong",
                            connection, transaction))
                        {
                            command.Parameters.AddWithValue("@MaHD", maHD);
                            command.Parameters.AddWithValue("@MaPhong", maPhong);
                            command.Parameters.AddWithValue("@SoThang", soThang);
                            command.Parameters.Add("@NgayKetThucMoi", SqlDbType.Date)
                                .Value = ngayKetThucMoi;

                            command.ExecuteNonQuery();
                        }

                        using (SqlCommand command = new SqlCommand(
                            @"UPDATE HopDongThue
                              SET NgayKetThuc =
                              (
                                  SELECT MAX(NgayKetThuc)
                                  FROM ChiTietHopDong
                                  WHERE MaHD = @MaHD
                              )
                              WHERE MaHD = @MaHD",
                            connection, transaction))
                        {
                            command.Parameters.AddWithValue("@MaHD", maHD);
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
