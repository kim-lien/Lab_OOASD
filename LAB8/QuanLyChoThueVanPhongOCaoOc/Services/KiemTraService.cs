
using System;
using System.Data;
using QuanLyChoThueVanPhong.Data;

namespace QuanLyChoThueVanPhong.Services
{
    public class KiemTraService
    {
        public DataTable LayDanhSach()
        {
            return Db.Query(
                @"SELECT pk.MaKiemTra, pk.MaPhong, vp.MaTang,
                         pk.NgayKiemTra, pk.TinhTrang,
                         pk.KetLuan, pk.NguoiKiemTra
                  FROM PhieuKiemTra pk
                  INNER JOIN VanPhong vp ON pk.MaPhong = vp.MaPhong
                  ORDER BY pk.NgayKiemTra DESC, pk.MaKiemTra"
            );
        }

        public DataTable LayVanPhong()
        {
            return Db.Query(
                @"SELECT MaPhong FROM VanPhong ORDER BY MaPhong"
            );
        }

        public DataTable TimKiem(string tuKhoa)
        {
            return Db.Query(
                @"SELECT pk.MaKiemTra, pk.MaPhong, vp.MaTang,
                         pk.NgayKiemTra, pk.TinhTrang,
                         pk.KetLuan, pk.NguoiKiemTra
                  FROM PhieuKiemTra pk
                  INNER JOIN VanPhong vp ON pk.MaPhong = vp.MaPhong
                  WHERE pk.MaKiemTra LIKE @TuKhoa
                     OR pk.MaPhong LIKE @TuKhoa
                     OR pk.TinhTrang LIKE @TuKhoa
                     OR pk.KetLuan LIKE @TuKhoa
                     OR pk.NguoiKiemTra LIKE @TuKhoa
                  ORDER BY pk.NgayKiemTra DESC",
                Db.P("@TuKhoa", "%" + tuKhoa.Trim() + "%")
            );
        }

        public void Them(
            string maKiemTra,
            string maPhong,
            DateTime ngayKiemTra,
            string tinhTrang,
            string ketLuan,
            string nguoiKiemTra)
        {
            KiemTraDuLieu(
                maKiemTra, maPhong, ngayKiemTra,
                tinhTrang, ketLuan, nguoiKiemTra
            );

            Db.Execute(
                @"INSERT INTO PhieuKiemTra
                  (MaKiemTra, MaPhong, NgayKiemTra,
                   TinhTrang, KetLuan, NguoiKiemTra)
                  VALUES
                  (@MaKiemTra, @MaPhong, @NgayKiemTra,
                   @TinhTrang, @KetLuan, @NguoiKiemTra)",
                Db.P("@MaKiemTra", maKiemTra.Trim()),
                Db.P("@MaPhong", maPhong),
                Db.P("@NgayKiemTra", ngayKiemTra.Date),
                Db.P("@TinhTrang", tinhTrang.Trim()),
                Db.P("@KetLuan", ketLuan.Trim()),
                Db.P("@NguoiKiemTra", nguoiKiemTra.Trim())
            );
        }

        public void Sua(
            string maKiemTra,
            string maPhong,
            DateTime ngayKiemTra,
            string tinhTrang,
            string ketLuan,
            string nguoiKiemTra)
        {
            KiemTraDuLieu(
                maKiemTra, maPhong, ngayKiemTra,
                tinhTrang, ketLuan, nguoiKiemTra
            );

            int ketQua = Db.Execute(
                @"UPDATE PhieuKiemTra
                  SET MaPhong = @MaPhong,
                      NgayKiemTra = @NgayKiemTra,
                      TinhTrang = @TinhTrang,
                      KetLuan = @KetLuan,
                      NguoiKiemTra = @NguoiKiemTra
                  WHERE MaKiemTra = @MaKiemTra",
                Db.P("@MaKiemTra", maKiemTra.Trim()),
                Db.P("@MaPhong", maPhong),
                Db.P("@NgayKiemTra", ngayKiemTra.Date),
                Db.P("@TinhTrang", tinhTrang.Trim()),
                Db.P("@KetLuan", ketLuan.Trim()),
                Db.P("@NguoiKiemTra", nguoiKiemTra.Trim())
            );

            if (ketQua == 0)
                throw new Exception("Không tìm thấy phiếu kiểm tra cần sửa.");
        }

        public void Xoa(string maKiemTra)
        {
            if (string.IsNullOrWhiteSpace(maKiemTra))
                throw new Exception("Vui lòng chọn phiếu kiểm tra cần xóa.");

            int ketQua = Db.Execute(
                @"DELETE FROM PhieuKiemTra
                  WHERE MaKiemTra = @MaKiemTra",
                Db.P("@MaKiemTra", maKiemTra.Trim())
            );

            if (ketQua == 0)
                throw new Exception("Không tìm thấy phiếu kiểm tra cần xóa.");
        }

        private void KiemTraDuLieu(
            string maKiemTra,
            string maPhong,
            DateTime ngayKiemTra,
            string tinhTrang,
            string ketLuan,
            string nguoiKiemTra)
        {
            if (string.IsNullOrWhiteSpace(maKiemTra))
                throw new Exception("Mã phiếu kiểm tra không được để trống.");

            if (string.IsNullOrWhiteSpace(maPhong))
                throw new Exception("Vui lòng chọn văn phòng.");

            if (ngayKiemTra.Date > DateTime.Today)
                throw new Exception("Ngày kiểm tra không được lớn hơn ngày hiện tại.");

            if (string.IsNullOrWhiteSpace(tinhTrang))
                throw new Exception("Vui lòng nhập tình trạng văn phòng.");

            if (string.IsNullOrWhiteSpace(ketLuan))
                throw new Exception("Vui lòng nhập kết luận kiểm tra.");

            if (string.IsNullOrWhiteSpace(nguoiKiemTra))
                throw new Exception("Vui lòng nhập người kiểm tra.");
        }
    }
}
