
using System;
using System.Data;
using QuanLyChoThueVanPhong.Data;

namespace QuanLyChoThueVanPhong.Services
{
    public class ThongKeService
    {
        public DataTable LayTongQuan()
        {
            return Db.Query(
                @"SELECT
                    (SELECT COUNT(*) FROM Tang) AS SoTang,
                    (SELECT COUNT(*) FROM VanPhong) AS SoVanPhong,
                    (SELECT COUNT(*) FROM KhachHang) AS SoKhachHang,
                    (SELECT COUNT(*) FROM HopDongThue) AS SoHopDong,
                    (SELECT COUNT(*) FROM NhanVienVanPhong) AS SoNhanVien,
                    (SELECT COUNT(*) FROM TheGiuXe) AS SoTheXe"
            );
        }

        public DataTable LayTaiChinh(int nam)
        {
            return Db.Query(
                @"SELECT
                    (
                        SELECT ISNULL(SUM(SoTien), 0)
                        FROM ThanhToanTienThue
                        WHERE NgayThanhToan >= @TuNgay
                          AND NgayThanhToan < @DenNgay
                    ) AS DoanhThuThue,
                    (
                        SELECT ISNULL(SUM(SoTien), 0)
                        FROM ThanhToanDichVu
                        WHERE NgayThanhToan >= @TuNgay
                          AND NgayThanhToan < @DenNgay
                    ) AS DoanhThuDichVu,
                    (
                        SELECT ISNULL(SUM(SoTienPhat), 0)
                        FROM PhieuXuPhat
                        WHERE NgayLap >= @TuNgay
                          AND NgayLap < @DenNgay
                    ) AS TienXuPhat",
                Db.P("@TuNgay", new DateTime(nam, 1, 1)),
                Db.P("@DenNgay", new DateTime(nam + 1, 1, 1))
            );
        }

        public DataTable LayCongNo()
        {
            return Db.Query(
                @"SELECT
                    (
                        SELECT ISNULL(SUM(
                            CASE
                                WHEN k.SoTienPhaiThu > ISNULL(t.DaTra, 0)
                                THEN k.SoTienPhaiThu - ISNULL(t.DaTra, 0)
                                ELSE 0
                            END
                        ), 0)
                        FROM KyThanhToan k
                        OUTER APPLY
                        (
                            SELECT SUM(tt.SoTien) AS DaTra
                            FROM ThanhToanTienThue tt
                            WHERE tt.MaKy = k.MaKy
                        ) t
                    ) AS NoTienThue,
                    (
                        SELECT ISNULL(SUM(
                            CASE
                                WHEN h.TongTien > ISNULL(t.DaTra, 0)
                                THEN h.TongTien - ISNULL(t.DaTra, 0)
                                ELSE 0
                            END
                        ), 0)
                        FROM HoaDonDichVu h
                        OUTER APPLY
                        (
                            SELECT SUM(td.SoTien) AS DaTra
                            FROM ThanhToanDichVu td
                            WHERE td.MaHoaDon = h.MaHoaDon
                        ) t
                    ) AS NoDichVu"
            );
        }

        public DataTable LayDoanhThuTheoThang(int nam)
        {
            return Db.Query(
                @"WITH Thang AS
                  (
                      SELECT 1 AS Thang
                      UNION ALL SELECT 2
                      UNION ALL SELECT 3
                      UNION ALL SELECT 4
                      UNION ALL SELECT 5
                      UNION ALL SELECT 6
                      UNION ALL SELECT 7
                      UNION ALL SELECT 8
                      UNION ALL SELECT 9
                      UNION ALL SELECT 10
                      UNION ALL SELECT 11
                      UNION ALL SELECT 12
                  ),
                  Thue AS
                  (
                      SELECT MONTH(NgayThanhToan) AS Thang,
                             SUM(SoTien) AS TongTien
                      FROM ThanhToanTienThue
                      WHERE NgayThanhToan >= @TuNgay
                        AND NgayThanhToan < @DenNgay
                      GROUP BY MONTH(NgayThanhToan)
                  ),
                  DichVu AS
                  (
                      SELECT MONTH(NgayThanhToan) AS Thang,
                             SUM(SoTien) AS TongTien
                      FROM ThanhToanDichVu
                      WHERE NgayThanhToan >= @TuNgay
                        AND NgayThanhToan < @DenNgay
                      GROUP BY MONTH(NgayThanhToan)
                  )
                  SELECT m.Thang,
                         ISNULL(t.TongTien, 0) AS DoanhThuThue,
                         ISNULL(d.TongTien, 0) AS DoanhThuDichVu,
                         ISNULL(t.TongTien, 0) +
                         ISNULL(d.TongTien, 0) AS TongDoanhThu
                  FROM Thang m
                  LEFT JOIN Thue t ON m.Thang = t.Thang
                  LEFT JOIN DichVu d ON m.Thang = d.Thang
                  ORDER BY m.Thang",
                Db.P("@TuNgay", new DateTime(nam, 1, 1)),
                Db.P("@DenNgay", new DateTime(nam + 1, 1, 1))
            );
        }

        public DataTable LayTinhTrangVanPhong()
        {
            return Db.Query(
                @"SELECT TrangThai, COUNT(*) AS SoLuong
                  FROM VanPhong
                  GROUP BY TrangThai
                  ORDER BY TrangThai"
            );
        }

        public DataTable LayCongNoTheoHopDong()
        {
            return Db.Query(
                @"WITH NoThue AS
                  (
                      SELECT k.MaHD,
                             SUM(
                                 CASE
                                     WHEN k.SoTienPhaiThu > ISNULL(t.DaTra, 0)
                                     THEN k.SoTienPhaiThu - ISNULL(t.DaTra, 0)
                                     ELSE 0
                                 END
                             ) AS SoTienNo
                      FROM KyThanhToan k
                      OUTER APPLY
                      (
                          SELECT SUM(tt.SoTien) AS DaTra
                          FROM ThanhToanTienThue tt
                          WHERE tt.MaKy = k.MaKy
                      ) t
                      GROUP BY k.MaHD
                  ),
                  NoDichVu AS
                  (
                      SELECT h.MaHD,
                             SUM(
                                 CASE
                                     WHEN h.TongTien > ISNULL(t.DaTra, 0)
                                     THEN h.TongTien - ISNULL(t.DaTra, 0)
                                     ELSE 0
                                 END
                             ) AS SoTienNo
                      FROM HoaDonDichVu h
                      OUTER APPLY
                      (
                          SELECT SUM(td.SoTien) AS DaTra
                          FROM ThanhToanDichVu td
                          WHERE td.MaHoaDon = h.MaHoaDon
                      ) t
                      GROUP BY h.MaHD
                  )
                  SELECT hd.MaHD, kh.TenCongTy,
                         ISNULL(nt.SoTienNo, 0) AS NoTienThue,
                         ISNULL(nd.SoTienNo, 0) AS NoDichVu,
                         ISNULL(nt.SoTienNo, 0) +
                         ISNULL(nd.SoTienNo, 0) AS TongNo
                  FROM HopDongThue hd
                  INNER JOIN KhachHang kh ON hd.MaKH = kh.MaKH
                  LEFT JOIN NoThue nt ON hd.MaHD = nt.MaHD
                  LEFT JOIN NoDichVu nd ON hd.MaHD = nd.MaHD
                  WHERE ISNULL(nt.SoTienNo, 0) +
                        ISNULL(nd.SoTienNo, 0) > 0
                  ORDER BY TongNo DESC"
            );
        }
    }
}
