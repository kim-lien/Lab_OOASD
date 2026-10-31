
using System;
using System.Data;
using System.Data.SqlClient;
using QuanLyChoThueVanPhong.Data;

namespace QuanLyChoThueVanPhong.Services
{
    public class HopDongService
    {
        public DataTable LayKhachHang()
        {
            return Db.Query(
                @"SELECT MaKH, TenCongTy
                  FROM KhachHang
                  ORDER BY TenCongTy"
            );
        }

        public DataTable LayVanPhong()
        {
            return Db.Query(
                @"SELECT vp.MaPhong, t.SoTang, vp.DienTich,
                         vp.HuongPhong, vp.DonGiaThue, vp.TrangThai
                  FROM VanPhong vp
                  JOIN Tang t ON vp.MaTang = t.MaTang
                  WHERE vp.TrangThai <> N'Bảo trì'
                  ORDER BY t.SoTang, vp.MaPhong"
            );
        }

        public DataTable LayHopDong()
        {
            return Db.Query(
                @"SELECT hd.MaHD, kh.TenCongTy, hd.NgayKy,
                         hd.NgayBatDau, hd.NgayKetThuc,
                         hd.ThoiHanThue, hd.TongTienThueThang,
                         hd.TrangThai
                  FROM HopDongThue hd
                  JOIN KhachHang kh ON hd.MaKH = kh.MaKH
                  ORDER BY hd.NgayKy DESC, hd.MaHD"
            );
        }

        public DataTable LayChiTiet(string maHD)
        {
            return Db.Query(
                @"SELECT ct.MaPhong, t.SoTang, ct.DonGiaThue,
                         ct.ThoiHanThue, ct.NgayBatDau,
                         ct.NgayKetThuc
                  FROM ChiTietHopDong ct
                  JOIN VanPhong vp ON ct.MaPhong = vp.MaPhong
                  JOIN Tang t ON vp.MaTang = t.MaTang
                  WHERE ct.MaHD = @MaHD
                  ORDER BY ct.MaPhong",
                Db.P("@MaHD", maHD)
            );
        }

        public DataTable LayKyThanhToan(string maHD)
        {
            return Db.Query(
                @"SELECT MaKy, MaPhong, ThangThu, LoaiKy,
                         NgayDenHan, SoTienPhaiThu, TrangThai
                  FROM KyThanhToan
                  WHERE MaHD = @MaHD
                  ORDER BY MaPhong, ThangThu",
                Db.P("@MaHD", maHD)
            );
        }

        public DataTable TimKiem(string tuKhoa)
        {
            return Db.Query(
                @"SELECT hd.MaHD, kh.TenCongTy, hd.NgayKy,
                         hd.NgayBatDau, hd.NgayKetThuc,
                         hd.ThoiHanThue, hd.TongTienThueThang,
                         hd.TrangThai
                  FROM HopDongThue hd
                  JOIN KhachHang kh ON hd.MaKH = kh.MaKH
                  WHERE hd.MaHD LIKE @TuKhoa
                     OR kh.TenCongTy LIKE @TuKhoa
                     OR hd.TrangThai LIKE @TuKhoa
                  ORDER BY hd.NgayKy DESC",
                Db.P("@TuKhoa", "%" + tuKhoa.Trim() + "%")
            );
        }

        public void LapHopDong(
            string maHD,
            string maKH,
            DateTime ngayKy,
            DateTime ngayBatDau,
            int thoiHan,
            DataTable danhSachPhong)
        {
            if (string.IsNullOrWhiteSpace(maHD))
                throw new Exception("Mã hợp đồng không được để trống.");

            if (maHD.Length > 20)
                throw new Exception("Mã hợp đồng tối đa 20 ký tự.");

            if (string.IsNullOrWhiteSpace(maKH))
                throw new Exception("Vui lòng chọn khách hàng.");

            if (thoiHan < 6)
                throw new Exception("Thời hạn thuê tối thiểu là 6 tháng.");

            if (ngayBatDau.Date < ngayKy.Date)
                throw new Exception("Ngày bắt đầu thuê không được trước ngày ký.");

            if (danhSachPhong == null || danhSachPhong.Rows.Count == 0)
                throw new Exception("Phải chọn ít nhất một văn phòng.");

            using (SqlConnection connection = Db.OpenConnection())
            using (SqlCommand command = new SqlCommand("sp_LapHopDong", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.CommandTimeout = 60;

                command.Parameters.Add("@MaHD", SqlDbType.VarChar, 20).Value = maHD.Trim();
                command.Parameters.Add("@MaKH", SqlDbType.VarChar, 20).Value = maKH;
                command.Parameters.Add("@NgayKy", SqlDbType.Date).Value = ngayKy.Date;
                command.Parameters.Add("@NgayBatDau", SqlDbType.Date).Value = ngayBatDau.Date;
                command.Parameters.Add("@ThoiHanThue", SqlDbType.Int).Value = thoiHan;

                SqlParameter danhSach = command.Parameters.Add(
                    "@DanhSachPhong", SqlDbType.Structured
                );

                danhSach.TypeName = "dbo.DanhSachPhongThue";
                danhSach.Value = danhSachPhong;

                command.ExecuteNonQuery();
            }
        }
    }
}
