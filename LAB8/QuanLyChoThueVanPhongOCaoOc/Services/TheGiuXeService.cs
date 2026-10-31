
using System;
using System.Data;
using QuanLyChoThueVanPhong.Data;

namespace QuanLyChoThueVanPhong.Services
{
    public class TheGiuXeService
    {
        public DataTable LayDanhSach()
        {
            return Db.Query(
                @"SELECT tx.MaThe, tx.MaNV, nv.HoTen,
                         nv.MaPhong, tx.BienSoXe, tx.LoaiXe,
                         tx.HangXe, tx.NgayCap, tx.TrangThai
                  FROM TheGiuXe tx
                  INNER JOIN NhanVienVanPhong nv ON tx.MaNV = nv.MaNV
                  ORDER BY tx.MaThe"
            );
        }

        public DataTable LayNhanVien()
        {
            return Db.Query(
                @"SELECT MaNV, HoTen, MaPhong
                  FROM NhanVienVanPhong
                  ORDER BY HoTen, MaNV"
            );
        }

        public DataTable TimKiem(string tuKhoa)
        {
            return Db.Query(
                @"SELECT tx.MaThe, tx.MaNV, nv.HoTen,
                         nv.MaPhong, tx.BienSoXe, tx.LoaiXe,
                         tx.HangXe, tx.NgayCap, tx.TrangThai
                  FROM TheGiuXe tx
                  INNER JOIN NhanVienVanPhong nv ON tx.MaNV = nv.MaNV
                  WHERE tx.MaThe LIKE @TuKhoa
                     OR tx.MaNV LIKE @TuKhoa
                     OR nv.HoTen LIKE @TuKhoa
                     OR tx.BienSoXe LIKE @TuKhoa
                     OR tx.LoaiXe LIKE @TuKhoa
                     OR tx.HangXe LIKE @TuKhoa
                     OR tx.TrangThai LIKE @TuKhoa
                  ORDER BY tx.MaThe",
                Db.P("@TuKhoa", "%" + tuKhoa.Trim() + "%")
            );
        }

        public void Them(
            string maThe,
            string maNV,
            string bienSoXe,
            string loaiXe,
            string hangXe,
            DateTime ngayCap,
            string trangThai)
        {
            KiemTra(maThe, maNV, bienSoXe, loaiXe, trangThai);

            Db.Execute(
                @"INSERT INTO TheGiuXe
                  (MaThe, MaNV, BienSoXe, LoaiXe,
                   HangXe, NgayCap, TrangThai)
                  VALUES
                  (@MaThe, @MaNV, @BienSoXe, @LoaiXe,
                   @HangXe, @NgayCap, @TrangThai)",
                Db.P("@MaThe", maThe.Trim()),
                Db.P("@MaNV", maNV),
                Db.P("@BienSoXe", bienSoXe.Trim().ToUpperInvariant()),
                Db.P("@LoaiXe", loaiXe.Trim()),
                Db.P("@HangXe", hangXe.Trim()),
                Db.P("@NgayCap", ngayCap.Date),
                Db.P("@TrangThai", trangThai)
            );
        }

        public void Sua(
            string maThe,
            string maNV,
            string bienSoXe,
            string loaiXe,
            string hangXe,
            DateTime ngayCap,
            string trangThai)
        {
            KiemTra(maThe, maNV, bienSoXe, loaiXe, trangThai);

            int ketQua = Db.Execute(
                @"UPDATE TheGiuXe
                  SET MaNV = @MaNV,
                      BienSoXe = @BienSoXe,
                      LoaiXe = @LoaiXe,
                      HangXe = @HangXe,
                      NgayCap = @NgayCap,
                      TrangThai = @TrangThai
                  WHERE MaThe = @MaThe",
                Db.P("@MaThe", maThe.Trim()),
                Db.P("@MaNV", maNV),
                Db.P("@BienSoXe", bienSoXe.Trim().ToUpperInvariant()),
                Db.P("@LoaiXe", loaiXe.Trim()),
                Db.P("@HangXe", hangXe.Trim()),
                Db.P("@NgayCap", ngayCap.Date),
                Db.P("@TrangThai", trangThai)
            );

            if (ketQua == 0)
                throw new Exception("Không tìm thấy thẻ giữ xe cần sửa.");
        }

        public void Xoa(string maThe)
        {
            if (string.IsNullOrWhiteSpace(maThe))
                throw new Exception("Vui lòng chọn thẻ giữ xe cần xóa.");

            int ketQua = Db.Execute(
                @"DELETE FROM TheGiuXe
                  WHERE MaThe = @MaThe",
                Db.P("@MaThe", maThe.Trim())
            );

            if (ketQua == 0)
                throw new Exception("Không tìm thấy thẻ giữ xe cần xóa.");
        }

        private void KiemTra(
            string maThe,
            string maNV,
            string bienSoXe,
            string loaiXe,
            string trangThai)
        {
            if (string.IsNullOrWhiteSpace(maThe))
                throw new Exception("Mã thẻ không được để trống.");

            if (string.IsNullOrWhiteSpace(maNV))
                throw new Exception("Vui lòng chọn nhân viên.");

            if (string.IsNullOrWhiteSpace(bienSoXe))
                throw new Exception("Biển số xe không được để trống.");

            if (string.IsNullOrWhiteSpace(loaiXe))
                throw new Exception("Vui lòng chọn loại xe.");

            if (string.IsNullOrWhiteSpace(trangThai))
                throw new Exception("Vui lòng chọn trạng thái thẻ.");
        }
    }
}
