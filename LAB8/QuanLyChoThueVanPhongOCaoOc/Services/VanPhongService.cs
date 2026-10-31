
using System;
using System.Data;
using System.Data.SqlClient;
using QuanLyChoThueVanPhong.Data;

namespace QuanLyChoThueVanPhong.Services
{
    public class VanPhongService
    {
        public DataTable LayDanhSach()
        {
            return Db.Query(
                @"SELECT vp.MaPhong, vp.MaTang, t.SoTang,
                         vp.DienTich, vp.HuongPhong,
                         vp.DonGiaThue, vp.TrangThai
                  FROM VanPhong vp
                  INNER JOIN Tang t ON vp.MaTang = t.MaTang
                  ORDER BY t.SoTang, vp.MaPhong"
            );
        }

        public DataTable LayDanhSachTang()
        {
            return Db.Query(
                "SELECT MaTang, SoTang FROM Tang ORDER BY SoTang"
            );
        }

        public DataTable TimKiem(string tuKhoa)
        {
            return Db.Query(
                @"SELECT vp.MaPhong, vp.MaTang, t.SoTang,
                         vp.DienTich, vp.HuongPhong,
                         vp.DonGiaThue, vp.TrangThai
                  FROM VanPhong vp
                  INNER JOIN Tang t ON vp.MaTang = t.MaTang
                  WHERE vp.MaPhong LIKE @TuKhoa
                     OR vp.MaTang LIKE @TuKhoa
                     OR CAST(t.SoTang AS VARCHAR(20)) LIKE @TuKhoa
                     OR vp.HuongPhong LIKE @TuKhoa
                     OR vp.TrangThai LIKE @TuKhoa
                  ORDER BY t.SoTang, vp.MaPhong",
                Db.P("@TuKhoa", "%" + tuKhoa.Trim() + "%")
            );
        }

        public void Them(
            string maPhong,
            string maTang,
            decimal dienTich,
            string huongPhong,
            decimal donGiaThue,
            string trangThai)
        {
            KiemTraDuLieu(
                maPhong, maTang, dienTich, donGiaThue, trangThai
            );

            Db.Execute(
                @"INSERT INTO VanPhong
                  (MaPhong, MaTang, DienTich, HuongPhong, DonGiaThue, TrangThai)
                  VALUES
                  (@MaPhong, @MaTang, @DienTich, @HuongPhong, @DonGiaThue, @TrangThai)",
                Db.P("@MaPhong", maPhong),
                Db.P("@MaTang", maTang),
                Db.P("@DienTich", dienTich),
                Db.P("@HuongPhong", huongPhong),
                Db.P("@DonGiaThue", donGiaThue),
                Db.P("@TrangThai", trangThai)
            );
        }

        public void Sua(
            string maPhong,
            string maTang,
            decimal dienTich,
            string huongPhong,
            decimal donGiaThue,
            string trangThai)
        {
            KiemTraDuLieu(
                maPhong, maTang, dienTich, donGiaThue, trangThai
            );

            int ketQua = Db.Execute(
                @"UPDATE VanPhong
                  SET MaTang = @MaTang,
                      DienTich = @DienTich,
                      HuongPhong = @HuongPhong,
                      DonGiaThue = @DonGiaThue,
                      TrangThai = @TrangThai
                  WHERE MaPhong = @MaPhong",
                Db.P("@MaPhong", maPhong),
                Db.P("@MaTang", maTang),
                Db.P("@DienTich", dienTich),
                Db.P("@HuongPhong", huongPhong),
                Db.P("@DonGiaThue", donGiaThue),
                Db.P("@TrangThai", trangThai)
            );

            if (ketQua == 0)
                throw new Exception("Không tìm thấy văn phòng cần sửa.");
        }

        public void Xoa(string maPhong)
        {
            if (string.IsNullOrWhiteSpace(maPhong))
                throw new Exception("Vui lòng chọn văn phòng cần xóa.");

            int ketQua = Db.Execute(
                "DELETE FROM VanPhong WHERE MaPhong = @MaPhong",
                Db.P("@MaPhong", maPhong)
            );

            if (ketQua == 0)
                throw new Exception("Không tìm thấy văn phòng cần xóa.");
        }

        private void KiemTraDuLieu(
            string maPhong,
            string maTang,
            decimal dienTich,
            decimal donGiaThue,
            string trangThai)
        {
            if (string.IsNullOrWhiteSpace(maPhong))
                throw new Exception("Mã văn phòng không được để trống.");

            if (string.IsNullOrWhiteSpace(maTang))
                throw new Exception("Vui lòng chọn tầng.");

            if (dienTich <= 0)
                throw new Exception("Diện tích phải lớn hơn 0.");

            if (donGiaThue <= 0)
                throw new Exception("Đơn giá thuê phải lớn hơn 0.");

            if (trangThai != "Trống" &&
                trangThai != "Đang thuê" &&
                trangThai != "Bảo trì")
            {
                throw new Exception("Trạng thái văn phòng không hợp lệ.");
            }
        }
    }
}
