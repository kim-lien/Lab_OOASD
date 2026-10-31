
using System;
using System.Data;
using System.Data.SqlClient;
using QuanLyChoThueVanPhong.Data;

namespace QuanLyChoThueVanPhong.Services
{
    public class TangService
    {
        public DataTable LayDanhSach()
        {
            return Db.Query(
                "SELECT MaTang, SoTang, MoTa FROM Tang ORDER BY SoTang"
            );
        }

        public DataTable TimKiem(string tuKhoa)
        {
            return Db.Query(
                @"SELECT MaTang, SoTang, MoTa
                  FROM Tang
                  WHERE MaTang LIKE @TuKhoa
                     OR CAST(SoTang AS VARCHAR(20)) LIKE @TuKhoa
                     OR MoTa LIKE @TuKhoa
                  ORDER BY SoTang",
                Db.P("@TuKhoa", "%" + tuKhoa.Trim() + "%")
            );
        }

        public void Them(string maTang, int soTang, string moTa)
        {
            if (string.IsNullOrWhiteSpace(maTang))
                throw new Exception("Mã tầng không được để trống.");

            if (soTang < 0)
                throw new Exception("Số tầng không hợp lệ.");

            Db.Execute(
                @"INSERT INTO Tang (MaTang, SoTang, MoTa)
                  VALUES (@MaTang, @SoTang, @MoTa)",
                Db.P("@MaTang", maTang),
                Db.P("@SoTang", soTang),
                Db.P("@MoTa", moTa)
            );
        }

        public void Sua(string maTang, int soTang, string moTa)
        {
            if (string.IsNullOrWhiteSpace(maTang))
                throw new Exception("Vui lòng chọn tầng cần sửa.");

            int ketQua = Db.Execute(
                @"UPDATE Tang
                  SET SoTang = @SoTang,
                      MoTa = @MoTa
                  WHERE MaTang = @MaTang",
                Db.P("@MaTang", maTang),
                Db.P("@SoTang", soTang),
                Db.P("@MoTa", moTa)
            );

            if (ketQua == 0)
                throw new Exception("Không tìm thấy tầng cần sửa.");
        }

        public void Xoa(string maTang)
        {
            if (string.IsNullOrWhiteSpace(maTang))
                throw new Exception("Vui lòng chọn tầng cần xóa.");

            int ketQua = Db.Execute(
                "DELETE FROM Tang WHERE MaTang = @MaTang",
                Db.P("@MaTang", maTang)
            );

            if (ketQua == 0)
                throw new Exception("Không tìm thấy tầng cần xóa.");
        }
    }
}
