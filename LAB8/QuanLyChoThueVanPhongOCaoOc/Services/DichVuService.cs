
using System;
using System.Data;
using QuanLyChoThueVanPhong.Data;

namespace QuanLyChoThueVanPhong.Services
{
    public class DichVuService
    {
        public DataTable LayDanhSach()
        {
            return Db.Query(
                @"SELECT MaDV, TenDV, DonViTinh, DonGia, TrangThai
                  FROM DichVu ORDER BY MaDV"
            );
        }

        public DataTable TimKiem(string tuKhoa)
        {
            return Db.Query(
                @"SELECT MaDV, TenDV, DonViTinh, DonGia, TrangThai
                  FROM DichVu
                  WHERE MaDV LIKE @TuKhoa
                     OR TenDV LIKE @TuKhoa
                     OR DonViTinh LIKE @TuKhoa
                     OR TrangThai LIKE @TuKhoa
                  ORDER BY MaDV",
                Db.P("@TuKhoa", "%" + tuKhoa.Trim() + "%")
            );
        }

        public void Them(string maDV, string tenDV, string donViTinh,
                         decimal donGia, string trangThai)
        {
            KiemTra(maDV, tenDV, donGia, trangThai);

            Db.Execute(
                @"INSERT INTO DichVu(MaDV, TenDV, DonViTinh, DonGia, TrangThai)
                  VALUES(@MaDV, @TenDV, @DonViTinh, @DonGia, @TrangThai)",
                Db.P("@MaDV", maDV.Trim()),
                Db.P("@TenDV", tenDV.Trim()),
                Db.P("@DonViTinh", donViTinh.Trim()),
                Db.P("@DonGia", donGia),
                Db.P("@TrangThai", trangThai)
            );
        }

        public void Sua(string maDV, string tenDV, string donViTinh,
                        decimal donGia, string trangThai)
        {
            KiemTra(maDV, tenDV, donGia, trangThai);

            int ketQua = Db.Execute(
                @"UPDATE DichVu
                  SET TenDV = @TenDV,
                      DonViTinh = @DonViTinh,
                      DonGia = @DonGia,
                      TrangThai = @TrangThai
                  WHERE MaDV = @MaDV",
                Db.P("@MaDV", maDV.Trim()),
                Db.P("@TenDV", tenDV.Trim()),
                Db.P("@DonViTinh", donViTinh.Trim()),
                Db.P("@DonGia", donGia),
                Db.P("@TrangThai", trangThai)
            );

            if (ketQua == 0)
                throw new Exception("Không tìm thấy dịch vụ cần sửa.");
        }

        public void Xoa(string maDV)
        {
            if (string.IsNullOrWhiteSpace(maDV))
                throw new Exception("Vui lòng chọn dịch vụ cần xóa.");

            int ketQua = Db.Execute(
                "DELETE FROM DichVu WHERE MaDV = @MaDV",
                Db.P("@MaDV", maDV.Trim())
            );

            if (ketQua == 0)
                throw new Exception("Không tìm thấy dịch vụ cần xóa.");
        }

        private void KiemTra(string maDV, string tenDV,
                             decimal donGia, string trangThai)
        {
            if (string.IsNullOrWhiteSpace(maDV))
                throw new Exception("Mã dịch vụ không được để trống.");

            if (string.IsNullOrWhiteSpace(tenDV))
                throw new Exception("Tên dịch vụ không được để trống.");

            if (donGia < 0)
                throw new Exception("Đơn giá không được âm.");

            if (trangThai != "Đang sử dụng" &&
                trangThai != "Ngừng sử dụng")
                throw new Exception("Trạng thái dịch vụ không hợp lệ.");
        }
    }
}
