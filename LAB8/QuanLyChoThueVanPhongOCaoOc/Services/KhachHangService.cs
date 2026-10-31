
using System;
using System.Data;
using QuanLyChoThueVanPhong.Data;

namespace QuanLyChoThueVanPhong.Services
{
    public class KhachHangService
    {
        public DataTable LayDanhSach()
        {
            return Db.Query(
                @"SELECT MaKH, TenCongTy, DiaChi, DienThoai,
                         Email, NguoiDaiDien
                  FROM KhachHang
                  ORDER BY MaKH"
            );
        }

        public DataTable TimKiem(string tuKhoa)
        {
            return Db.Query(
                @"SELECT MaKH, TenCongTy, DiaChi, DienThoai,
                         Email, NguoiDaiDien
                  FROM KhachHang
                  WHERE MaKH LIKE @TuKhoa
                     OR TenCongTy LIKE @TuKhoa
                     OR DiaChi LIKE @TuKhoa
                     OR DienThoai LIKE @TuKhoa
                     OR Email LIKE @TuKhoa
                     OR NguoiDaiDien LIKE @TuKhoa
                  ORDER BY MaKH",
                Db.P("@TuKhoa", "%" + tuKhoa.Trim() + "%")
            );
        }

        public void Them(
            string maKH,
            string tenCongTy,
            string diaChi,
            string dienThoai,
            string email,
            string nguoiDaiDien)
        {
            KiemTraDuLieu(
                maKH, tenCongTy, dienThoai, email, nguoiDaiDien
            );

            Db.Execute(
                @"INSERT INTO KhachHang
                  (MaKH, TenCongTy, DiaChi, DienThoai, Email, NguoiDaiDien)
                  VALUES
                  (@MaKH, @TenCongTy, @DiaChi, @DienThoai, @Email, @NguoiDaiDien)",
                Db.P("@MaKH", maKH),
                Db.P("@TenCongTy", tenCongTy),
                Db.P("@DiaChi", diaChi),
                Db.P("@DienThoai", dienThoai),
                Db.P("@Email", email),
                Db.P("@NguoiDaiDien", nguoiDaiDien)
            );
        }

        public void Sua(
            string maKH,
            string tenCongTy,
            string diaChi,
            string dienThoai,
            string email,
            string nguoiDaiDien)
        {
            KiemTraDuLieu(
                maKH, tenCongTy, dienThoai, email, nguoiDaiDien
            );

            int ketQua = Db.Execute(
                @"UPDATE KhachHang
                  SET TenCongTy = @TenCongTy,
                      DiaChi = @DiaChi,
                      DienThoai = @DienThoai,
                      Email = @Email,
                      NguoiDaiDien = @NguoiDaiDien
                  WHERE MaKH = @MaKH",
                Db.P("@MaKH", maKH),
                Db.P("@TenCongTy", tenCongTy),
                Db.P("@DiaChi", diaChi),
                Db.P("@DienThoai", dienThoai),
                Db.P("@Email", email),
                Db.P("@NguoiDaiDien", nguoiDaiDien)
            );

            if (ketQua == 0)
                throw new Exception("Không tìm thấy khách hàng cần sửa.");
        }

        public void Xoa(string maKH)
        {
            if (string.IsNullOrWhiteSpace(maKH))
                throw new Exception("Vui lòng chọn khách hàng cần xóa.");

            int ketQua = Db.Execute(
                "DELETE FROM KhachHang WHERE MaKH = @MaKH",
                Db.P("@MaKH", maKH)
            );

            if (ketQua == 0)
                throw new Exception("Không tìm thấy khách hàng cần xóa.");
        }

        private void KiemTraDuLieu(
            string maKH,
            string tenCongTy,
            string dienThoai,
            string email,
            string nguoiDaiDien)
        {
            if (string.IsNullOrWhiteSpace(maKH))
                throw new Exception("Mã khách hàng không được để trống.");

            if (string.IsNullOrWhiteSpace(tenCongTy))
                throw new Exception("Tên công ty không được để trống.");

            if (string.IsNullOrWhiteSpace(nguoiDaiDien))
                throw new Exception("Người đại diện không được để trống.");

            if (!string.IsNullOrWhiteSpace(email))
            {
                try
                {
                    var diaChiEmail = new System.Net.Mail.MailAddress(email);
                    if (diaChiEmail.Address != email.Trim())
                        throw new Exception();
                }
                catch
                {
                    throw new Exception("Email không đúng định dạng.");
                }
            }

            if (!string.IsNullOrWhiteSpace(dienThoai))
            {
                foreach (char kyTu in dienThoai)
                {
                    if (!char.IsDigit(kyTu) && kyTu != '+' &&
                        kyTu != ' ' && kyTu != '-')
                        throw new Exception("Số điện thoại không hợp lệ.");
                }
            }
        }
    }
}
