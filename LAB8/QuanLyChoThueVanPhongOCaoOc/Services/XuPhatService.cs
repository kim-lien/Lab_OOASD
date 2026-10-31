
using System;
using System.Data;
using QuanLyChoThueVanPhong.Data;

namespace QuanLyChoThueVanPhong.Services
{
    public class XuPhatService
    {
        public DataTable LayDanhSach()
        {
            return Db.Query(
                @"SELECT xp.MaPhat, xp.MaKiemTra, kt.MaPhong,
                         kt.NgayKiemTra, xp.NgayLap, xp.LyDo,
                         xp.SoTienPhat, xp.TrangThai
                  FROM PhieuXuPhat xp
                  INNER JOIN PhieuKiemTra kt
                      ON xp.MaKiemTra = kt.MaKiemTra
                  ORDER BY xp.NgayLap DESC, xp.MaPhat"
            );
        }

        public DataTable LayPhieuKiemTra()
        {
            return Db.Query(
                @"SELECT MaKiemTra, MaPhong, NgayKiemTra
                  FROM PhieuKiemTra
                  ORDER BY NgayKiemTra DESC, MaKiemTra"
            );
        }

        public DataTable TimKiem(string tuKhoa)
        {
            return Db.Query(
                @"SELECT xp.MaPhat, xp.MaKiemTra, kt.MaPhong,
                         kt.NgayKiemTra, xp.NgayLap, xp.LyDo,
                         xp.SoTienPhat, xp.TrangThai
                  FROM PhieuXuPhat xp
                  INNER JOIN PhieuKiemTra kt
                      ON xp.MaKiemTra = kt.MaKiemTra
                  WHERE xp.MaPhat LIKE @TuKhoa
                     OR xp.MaKiemTra LIKE @TuKhoa
                     OR kt.MaPhong LIKE @TuKhoa
                     OR xp.LyDo LIKE @TuKhoa
                     OR xp.TrangThai LIKE @TuKhoa
                  ORDER BY xp.NgayLap DESC, xp.MaPhat",
                Db.P("@TuKhoa", "%" + tuKhoa.Trim() + "%")
            );
        }

        public void Them(
            string maPhat,
            string maKiemTra,
            DateTime ngayLap,
            string lyDo,
            decimal soTienPhat,
            string trangThai)
        {
            KiemTraDuLieu(
                maPhat, maKiemTra, ngayLap,
                lyDo, soTienPhat, trangThai
            );

            Db.Execute(
                @"INSERT INTO PhieuXuPhat
                  (MaPhat, MaKiemTra, NgayLap,
                   LyDo, SoTienPhat, TrangThai)
                  VALUES
                  (@MaPhat, @MaKiemTra, @NgayLap,
                   @LyDo, @SoTienPhat, @TrangThai)",
                Db.P("@MaPhat", maPhat.Trim()),
                Db.P("@MaKiemTra", maKiemTra),
                Db.P("@NgayLap", ngayLap.Date),
                Db.P("@LyDo", lyDo.Trim()),
                Db.P("@SoTienPhat", soTienPhat),
                Db.P("@TrangThai", trangThai)
            );
        }

        public void Sua(
            string maPhat,
            string maKiemTra,
            DateTime ngayLap,
            string lyDo,
            decimal soTienPhat,
            string trangThai)
        {
            KiemTraDuLieu(
                maPhat, maKiemTra, ngayLap,
                lyDo, soTienPhat, trangThai
            );

            int ketQua = Db.Execute(
                @"UPDATE PhieuXuPhat
                  SET MaKiemTra = @MaKiemTra,
                      NgayLap = @NgayLap,
                      LyDo = @LyDo,
                      SoTienPhat = @SoTienPhat,
                      TrangThai = @TrangThai
                  WHERE MaPhat = @MaPhat",
                Db.P("@MaPhat", maPhat.Trim()),
                Db.P("@MaKiemTra", maKiemTra),
                Db.P("@NgayLap", ngayLap.Date),
                Db.P("@LyDo", lyDo.Trim()),
                Db.P("@SoTienPhat", soTienPhat),
                Db.P("@TrangThai", trangThai)
            );

            if (ketQua == 0)
                throw new Exception("Không tìm thấy phiếu xử phạt cần sửa.");
        }

        public void Xoa(string maPhat)
        {
            if (string.IsNullOrWhiteSpace(maPhat))
                throw new Exception("Vui lòng chọn phiếu xử phạt cần xóa.");

            int ketQua = Db.Execute(
                @"DELETE FROM PhieuXuPhat
                  WHERE MaPhat = @MaPhat",
                Db.P("@MaPhat", maPhat.Trim())
            );

            if (ketQua == 0)
                throw new Exception("Không tìm thấy phiếu xử phạt cần xóa.");
        }

        private void KiemTraDuLieu(
            string maPhat,
            string maKiemTra,
            DateTime ngayLap,
            string lyDo,
            decimal soTienPhat,
            string trangThai)
        {
            if (string.IsNullOrWhiteSpace(maPhat))
                throw new Exception("Mã phiếu phạt không được để trống.");

            if (string.IsNullOrWhiteSpace(maKiemTra))
                throw new Exception("Vui lòng chọn phiếu kiểm tra.");

            if (ngayLap.Date > DateTime.Today)
                throw new Exception("Ngày lập không được sau ngày hiện tại.");

            if (string.IsNullOrWhiteSpace(lyDo))
                throw new Exception("Lý do xử phạt không được để trống.");

            if (soTienPhat <= 0)
                throw new Exception("Số tiền phạt phải lớn hơn 0.");

            if (string.IsNullOrWhiteSpace(trangThai))
                throw new Exception("Vui lòng chọn trạng thái xử phạt.");

            object ngayKiemTra = Db.Scalar(
                @"SELECT NgayKiemTra
                  FROM PhieuKiemTra
                  WHERE MaKiemTra = @MaKiemTra",
                Db.P("@MaKiemTra", maKiemTra)
            );

            if (ngayKiemTra == null || ngayKiemTra == DBNull.Value)
                throw new Exception("Phiếu kiểm tra không tồn tại.");

            if (ngayLap.Date < Convert.ToDateTime(ngayKiemTra).Date)
                throw new Exception(
                    "Ngày lập phiếu phạt không được trước ngày kiểm tra."
                );
        }
    }
}
