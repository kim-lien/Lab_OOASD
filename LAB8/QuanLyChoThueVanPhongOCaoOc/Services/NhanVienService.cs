
using System;
using System.Data;
using System.Data.SqlClient;
using QuanLyChoThueVanPhong.Data;

namespace QuanLyChoThueVanPhong.Services
{
    public class NhanVienService
    {
        public DataTable LayDanhSach()
        {
            return Db.Query(
                @"SELECT nv.MaNV, nv.MaKH, kh.TenCongTy,
                         nv.MaPhong, nv.HoTen, nv.ChucVu,
                         nv.DienThoai, nv.TrangThai
                  FROM NhanVienVanPhong nv
                  INNER JOIN KhachHang kh ON nv.MaKH = kh.MaKH
                  ORDER BY nv.MaNV"
            );
        }

        public DataTable LayKhachHang()
        {
            return Db.Query(
                @"SELECT MaKH, TenCongTy
                  FROM KhachHang
                  ORDER BY TenCongTy"
            );
        }

        public DataTable LayVanPhong(string maKH)
        {
            return Db.Query(
                @"SELECT DISTINCT vp.MaPhong
                  FROM VanPhong vp
                  INNER JOIN ChiTietHopDong ct
                      ON ct.MaPhong = vp.MaPhong
                  INNER JOIN HopDongThue hd
                      ON hd.MaHD = ct.MaHD
                  WHERE hd.MaKH = @MaKH
                  ORDER BY vp.MaPhong",
                Db.P("@MaKH", maKH)
            );
        }

        public DataTable TimKiem(string tuKhoa)
        {
            return Db.Query(
                @"SELECT nv.MaNV, nv.MaKH, kh.TenCongTy,
                         nv.MaPhong, nv.HoTen, nv.ChucVu,
                         nv.DienThoai, nv.TrangThai
                  FROM NhanVienVanPhong nv
                  INNER JOIN KhachHang kh ON nv.MaKH = kh.MaKH
                  WHERE nv.MaNV LIKE @TuKhoa
                     OR nv.HoTen LIKE @TuKhoa
                     OR kh.TenCongTy LIKE @TuKhoa
                     OR nv.MaPhong LIKE @TuKhoa
                     OR nv.ChucVu LIKE @TuKhoa
                     OR nv.DienThoai LIKE @TuKhoa
                  ORDER BY nv.MaNV",
                Db.P("@TuKhoa", "%" + tuKhoa.Trim() + "%")
            );
        }

        public bool HinhAnhLaNhiPhan()
        {
            object kieu = Db.Scalar(
                @"SELECT TYPE_NAME(c.user_type_id)
                  FROM sys.columns c
                  WHERE c.object_id = OBJECT_ID(N'dbo.NhanVienVanPhong')
                    AND c.name = N'HinhAnh'"
            );

            string tenKieu = Convert.ToString(kieu).ToLowerInvariant();

            return tenKieu == "varbinary"
                || tenKieu == "binary"
                || tenKieu == "image";
        }

        public object LayHinhAnh(string maNV)
        {
            object giaTri = Db.Scalar(
                @"SELECT HinhAnh
                  FROM NhanVienVanPhong
                  WHERE MaNV = @MaNV",
                Db.P("@MaNV", maNV)
            );

            return giaTri == DBNull.Value ? null : giaTri;
        }

        public void Them(
            string maNV,
            string maKH,
            string maPhong,
            string hoTen,
            object hinhAnh,
            string chucVu,
            string dienThoai,
            string trangThai)
        {
            KiemTra(maNV, maKH, maPhong, hoTen);

            Db.Execute(
                @"INSERT INTO NhanVienVanPhong
                  (MaNV, MaKH, MaPhong, HoTen, HinhAnh,
                   ChucVu, DienThoai, TrangThai)
                  VALUES
                  (@MaNV, @MaKH, @MaPhong, @HoTen, @HinhAnh,
                   @ChucVu, @DienThoai, @TrangThai)",
                Db.P("@MaNV", maNV.Trim()),
                Db.P("@MaKH", maKH),
                Db.P("@MaPhong", maPhong),
                Db.P("@HoTen", hoTen.Trim()),
                Db.P("@HinhAnh", hinhAnh),
                Db.P("@ChucVu", chucVu.Trim()),
                Db.P("@DienThoai", dienThoai.Trim()),
                Db.P("@TrangThai", trangThai)
            );
        }

        public void Sua(
            string maNV,
            string maKH,
            string maPhong,
            string hoTen,
            object hinhAnh,
            string chucVu,
            string dienThoai,
            string trangThai)
        {
            KiemTra(maNV, maKH, maPhong, hoTen);

            int ketQua = Db.Execute(
                @"UPDATE NhanVienVanPhong
                  SET MaKH = @MaKH,
                      MaPhong = @MaPhong,
                      HoTen = @HoTen,
                      HinhAnh = @HinhAnh,
                      ChucVu = @ChucVu,
                      DienThoai = @DienThoai,
                      TrangThai = @TrangThai
                  WHERE MaNV = @MaNV",
                Db.P("@MaNV", maNV.Trim()),
                Db.P("@MaKH", maKH),
                Db.P("@MaPhong", maPhong),
                Db.P("@HoTen", hoTen.Trim()),
                Db.P("@HinhAnh", hinhAnh),
                Db.P("@ChucVu", chucVu.Trim()),
                Db.P("@DienThoai", dienThoai.Trim()),
                Db.P("@TrangThai", trangThai)
            );

            if (ketQua == 0)
                throw new Exception("Không tìm thấy nhân viên cần sửa.");
        }

        public void Xoa(string maNV)
        {
            if (string.IsNullOrWhiteSpace(maNV))
                throw new Exception("Vui lòng chọn nhân viên cần xóa.");

            int ketQua = Db.Execute(
                @"DELETE FROM NhanVienVanPhong
                  WHERE MaNV = @MaNV",
                Db.P("@MaNV", maNV)
            );

            if (ketQua == 0)
                throw new Exception("Không tìm thấy nhân viên cần xóa.");
        }

        private void KiemTra(
            string maNV,
            string maKH,
            string maPhong,
            string hoTen)
        {
            if (string.IsNullOrWhiteSpace(maNV))
                throw new Exception("Mã nhân viên không được để trống.");

            if (string.IsNullOrWhiteSpace(maKH))
                throw new Exception("Vui lòng chọn khách hàng.");

            if (string.IsNullOrWhiteSpace(maPhong))
                throw new Exception("Vui lòng chọn văn phòng.");

            if (string.IsNullOrWhiteSpace(hoTen))
                throw new Exception("Họ tên nhân viên không được để trống.");

            object soLuong = Db.Scalar(
                @"SELECT COUNT(*)
                  FROM ChiTietHopDong ct
                  INNER JOIN HopDongThue hd
                      ON hd.MaHD = ct.MaHD
                  WHERE hd.MaKH = @MaKH
                    AND ct.MaPhong = @MaPhong",
                Db.P("@MaKH", maKH),
                Db.P("@MaPhong", maPhong)
            );

            if (Convert.ToInt32(soLuong) == 0)
                throw new Exception(
                    "Văn phòng không thuộc hợp đồng của khách hàng đã chọn."
                );
        }
    }
}
