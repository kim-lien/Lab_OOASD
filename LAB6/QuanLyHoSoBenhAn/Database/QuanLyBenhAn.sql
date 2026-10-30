-- SQL Server 2019+ / SQL Server Express
IF DB_ID(N'QuanLyBenhAn') IS NULL CREATE DATABASE QuanLyBenhAn;
GO
USE QuanLyBenhAn;
GO
-- Chạy lần đầu trên cơ sở dữ liệu trống.
CREATE TABLE BenhNhan (
 MaBN INT IDENTITY(1,1) PRIMARY KEY,
 HoTen NVARCHAR(100) NOT NULL,
 NgaySinh DATE NULL,
 DiaChi NVARCHAR(255) NULL,
 SoDienThoai VARCHAR(20) NULL,
 Anh3x4 NVARCHAR(500) NULL
);
CREATE TABLE Khoa (
 MaKhoa INT IDENTITY(1,1) PRIMARY KEY,
 TenKhoa NVARCHAR(100) NOT NULL UNIQUE,
 MoTa NVARCHAR(255) NULL,
 ViTri NVARCHAR(150) NULL,
 SoDienThoai VARCHAR(20) NULL
);
CREATE TABLE BacSi (
 MaBS INT IDENTITY(1,1) PRIMARY KEY,
 MaKhoa INT NOT NULL REFERENCES Khoa(MaKhoa),
 HoTen NVARCHAR(100) NOT NULL,
 ChuyenKhoa NVARCHAR(100) NULL,
 SoDienThoai VARCHAR(20) NULL
);
CREATE TABLE DangKyKhamBenh (
 MaDK INT IDENTITY(1,1) PRIMARY KEY,
 MaBN INT NOT NULL REFERENCES BenhNhan(MaBN),
 NgayDangKy DATETIME2 NOT NULL DEFAULT SYSDATETIME(),
 LoaiDangKy NVARCHAR(50) NOT NULL DEFAULT N'Khám bệnh',
 TrangThai NVARCHAR(30) NOT NULL DEFAULT N'Đã đăng ký'
);
CREATE TABLE LePhiNam (
 MaLePhi INT IDENTITY(1,1) PRIMARY KEY,
 MaBN INT NOT NULL REFERENCES BenhNhan(MaBN),
 NamDong INT NOT NULL,
 SoTien DECIMAL(18,2) NOT NULL CHECK (SoTien >= 0),
 NgayDong DATE NULL,
 TrangThai NVARCHAR(30) NOT NULL DEFAULT N'Chưa thanh toán',
 CONSTRAINT UQ_LePhiNam UNIQUE(MaBN, NamDong),
 CONSTRAINT CK_LePhiNam_Nam CHECK (NamDong BETWEEN 2000 AND 2200)
);
CREATE TABLE HoSoBenhAn (
 MaHoSo INT IDENTITY(1,1) PRIMARY KEY,
 MaBN INT NOT NULL UNIQUE REFERENCES BenhNhan(MaBN),
 NgayLap DATE NOT NULL DEFAULT CONVERT(date,GETDATE())
 -- LichSuKham trong tài liệu là tập phiếu khám; thể hiện qua bảng PhieuKham
);
CREATE TABLE PhieuKham (
 MaPhieuKham INT IDENTITY(1,1) PRIMARY KEY,
 MaHoSo INT NOT NULL REFERENCES HoSoBenhAn(MaHoSo),
 MaBS INT NOT NULL REFERENCES BacSi(MaBS),
 MaKhoa INT NOT NULL REFERENCES Khoa(MaKhoa),
 MaDK INT NULL UNIQUE REFERENCES DangKyKhamBenh(MaDK),
 NgayGioKham DATETIME2 NOT NULL DEFAULT SYSDATETIME(),
 TrieuChung NVARCHAR(MAX) NULL,
 ChanDoan NVARCHAR(MAX) NULL
);
CREATE TABLE XetNghiem (
 MaXN INT IDENTITY(1,1) PRIMARY KEY,
 MaPhieuKham INT NOT NULL REFERENCES PhieuKham(MaPhieuKham),
 TenXetNghiem NVARCHAR(150) NOT NULL,
 NgayXN DATETIME2 NULL,
 KetQua NVARCHAR(MAX) NULL
);
CREATE TABLE ToaThuoc (
 MaToa INT IDENTITY(1,1) PRIMARY KEY,
 MaPhieuKham INT NOT NULL UNIQUE REFERENCES PhieuKham(MaPhieuKham),
 NgayKeToa DATE NOT NULL DEFAULT CONVERT(date,GETDATE()),
 LoiDan NVARCHAR(MAX) NULL
);
CREATE TABLE Thuoc (
 MaThuoc INT IDENTITY(1,1) PRIMARY KEY,
 TenThuoc NVARCHAR(150) NOT NULL,
 DonViTinh NVARCHAR(50) NULL,
 CongDung NVARCHAR(255) NULL
);
CREATE TABLE ChiTietToaThuoc (
 MaCTToa INT IDENTITY(1,1) PRIMARY KEY,
 MaToa INT NOT NULL REFERENCES ToaThuoc(MaToa),
 MaThuoc INT NOT NULL REFERENCES Thuoc(MaThuoc),
 SoLuong INT NOT NULL CHECK (SoLuong > 0),
 LieuDung NVARCHAR(150) NOT NULL,
 CachDung NVARCHAR(255) NULL,
 CONSTRAINT UQ_ChiTietToaThuoc UNIQUE(MaToa, MaThuoc)
);
CREATE TABLE LichKhamDinhKy (
 MaLich INT IDENTITY(1,1) PRIMARY KEY,
 MaBN INT NOT NULL REFERENCES BenhNhan(MaBN),
 NgayGioHen DATETIME2 NOT NULL,
 TrangThai NVARCHAR(30) NOT NULL DEFAULT N'Đã đặt'
);
CREATE TABLE ThanhToanVienPhi (
 MaThanhToan INT IDENTITY(1,1) PRIMARY KEY,
 MaPhieuKham INT NOT NULL UNIQUE REFERENCES PhieuKham(MaPhieuKham),
 SoTien DECIMAL(18,2) NOT NULL CHECK (SoTien >= 0),
 NgayThanhToan DATETIME2 NULL,
 TrangThai NVARCHAR(30) NOT NULL DEFAULT N'Chưa thanh toán'
);
GO
CREATE INDEX IX_DangKy_MaBN ON DangKyKhamBenh(MaBN);
CREATE INDEX IX_PhieuKham_MaHoSo_Ngay ON PhieuKham(MaHoSo,NgayGioKham DESC);
CREATE INDEX IX_XetNghiem_PhieuKham ON XetNghiem(MaPhieuKham);
CREATE INDEX IX_ChiTietToa_MaToa ON ChiTietToaThuoc(MaToa);
CREATE INDEX IX_LichKham_BenhNhan ON LichKhamDinhKy(MaBN,NgayGioHen);
GO
INSERT INTO Khoa(TenKhoa, MoTa, ViTri) VALUES (N'Nội tổng quát',N'Khám và điều trị nội khoa',N'Tầng 1'),(N'Ngoại tổng quát',N'Khám và điều trị ngoại khoa',N'Tầng 2');
INSERT INTO BacSi(MaKhoa,HoTen,ChuyenKhoa) VALUES (1,N'Nguyễn Văn An',N'Nội khoa'),(2,N'Trần Thị Bình',N'Ngoại khoa');
INSERT INTO Thuoc(TenThuoc,DonViTinh,CongDung) VALUES (N'Paracetamol 500mg',N'Viên',N'Giảm đau, hạ sốt'),(N'ORS',N'Gói',N'Bù nước, điện giải');
GO

-- Chay SAU file QuanLyBenhAn.sql goc.
-- File goc da co 2 Khoa, 2 BacSi va 2 Thuoc.
USE QuanLyBenhAn;
GO
SET XACT_ABORT ON;
BEGIN TRY
    BEGIN TRANSACTION;

    -- Dam bao du lieu mau tu file goc o trang thai ban dau.
    IF (SELECT COUNT(*) FROM dbo.Khoa) <> 2
       OR (SELECT COUNT(*) FROM dbo.BacSi) <> 2
       OR (SELECT COUNT(*) FROM dbo.Thuoc) <> 2
       OR (SELECT COUNT(*) FROM dbo.BenhNhan) <> 0
       OR (SELECT COUNT(*) FROM dbo.DangKyKhamBenh) <> 0
       OR (SELECT COUNT(*) FROM dbo.LePhiNam) <> 0
       OR (SELECT COUNT(*) FROM dbo.HoSoBenhAn) <> 0
       OR (SELECT COUNT(*) FROM dbo.PhieuKham) <> 0
       OR (SELECT COUNT(*) FROM dbo.XetNghiem) <> 0
       OR (SELECT COUNT(*) FROM dbo.ToaThuoc) <> 0
       OR (SELECT COUNT(*) FROM dbo.ChiTietToaThuoc) <> 0
       OR (SELECT COUNT(*) FROM dbo.LichKhamDinhKy) <> 0
       OR (SELECT COUNT(*) FROM dbo.ThanhToanVienPhi) <> 0
        THROW 50001, N'Du lieu hien tai khong dung trang thai ban dau: 2 Khoa, 2 BacSi, 2 Thuoc; cac bang khac rong. Khong chen de tranh trung.', 1;

    -- 1. BenhNhan: them 3
    INSERT INTO dbo.BenhNhan (HoTen, NgaySinh, DiaChi, SoDienThoai, Anh3x4)
    VALUES
      (N'Phạm Minh Anh', '2000-04-12', N'TP. Hồ Chí Minh', '0901112233', N'minh_anh.jpg'),
      (N'Lê Thị Mai', '1997-09-18', N'Đồng Nai', '0902223344', N'thi_mai.jpg'),
      (N'Võ Quốc Bảo', '2002-01-25', N'Bình Dương', '0903334455', N'quoc_bao.jpg');

    -- 2. Khoa: da co 2, them 1
    INSERT INTO dbo.Khoa (TenKhoa, MoTa, ViTri, SoDienThoai)
    VALUES (N'Nhi khoa', N'Khám và điều trị bệnh nhi', N'Tầng 3', '02838220003');

    -- 3. BacSi: da co 2, them 1
    DECLARE @KhoaNhi INT = (SELECT MaKhoa FROM dbo.Khoa WHERE TenKhoa = N'Nhi khoa');
    INSERT INTO dbo.BacSi (MaKhoa, HoTen, ChuyenKhoa, SoDienThoai)
    VALUES (@KhoaNhi, N'Đặng Ngọc Hà', N'Nhi khoa', '0908887766');

    -- 4. Thuoc: da co 2, them 1
    INSERT INTO dbo.Thuoc (TenThuoc, DonViTinh, CongDung)
    VALUES (N'Cetirizine 10mg', N'Viên', N'Giảm triệu chứng dị ứng');

    DECLARE @BN1 INT = (SELECT MaBN FROM dbo.BenhNhan WHERE SoDienThoai = '0901112233');
    DECLARE @BN2 INT = (SELECT MaBN FROM dbo.BenhNhan WHERE SoDienThoai = '0902223344');
    DECLARE @BN3 INT = (SELECT MaBN FROM dbo.BenhNhan WHERE SoDienThoai = '0903334455');
    DECLARE @K1 INT = (SELECT MaKhoa FROM dbo.Khoa WHERE TenKhoa = N'Nội tổng quát');
    DECLARE @K2 INT = (SELECT MaKhoa FROM dbo.Khoa WHERE TenKhoa = N'Ngoại tổng quát');
    DECLARE @BS1 INT = (SELECT TOP(1) MaBS FROM dbo.BacSi WHERE HoTen = N'Nguyễn Văn An' ORDER BY MaBS);
    DECLARE @BS2 INT = (SELECT TOP(1) MaBS FROM dbo.BacSi WHERE HoTen = N'Trần Thị Bình' ORDER BY MaBS);
    DECLARE @BS3 INT = (SELECT MaBS FROM dbo.BacSi WHERE HoTen = N'Đặng Ngọc Hà');

    -- 5. DangKyKhamBenh: 3
    INSERT INTO dbo.DangKyKhamBenh (MaBN, NgayDangKy, LoaiDangKy, TrangThai)
    VALUES
      (@BN1, '2026-10-01T08:00:00', N'Khám bệnh', N'Đã đăng ký'),
      (@BN2, '2026-10-02T09:00:00', N'Khám bệnh', N'Đã đăng ký'),
      (@BN3, '2026-10-03T10:00:00', N'Khám bệnh', N'Đã đăng ký');

    -- 6. LePhiNam: 3; khong lap nam cho 1 benh nhan
    INSERT INTO dbo.LePhiNam (MaBN, NamDong, SoTien, NgayDong, TrangThai)
    VALUES
      (@BN1, 2026, 300000, '2026-10-01', N'Đã thanh toán'),
      (@BN2, 2026, 300000, '2026-10-02', N'Đã thanh toán'),
      (@BN3, 2026, 300000, '2026-10-03', N'Đã thanh toán');

    -- 7. HoSoBenhAn: 3; moi benh nhan 1 ho so
    INSERT INTO dbo.HoSoBenhAn (MaBN, NgayLap)
    VALUES (@BN1, '2026-10-01'), (@BN2, '2026-10-02'), (@BN3, '2026-10-03');

    DECLARE @HS1 INT = (SELECT MaHoSo FROM dbo.HoSoBenhAn WHERE MaBN = @BN1);
    DECLARE @HS2 INT = (SELECT MaHoSo FROM dbo.HoSoBenhAn WHERE MaBN = @BN2);
    DECLARE @HS3 INT = (SELECT MaHoSo FROM dbo.HoSoBenhAn WHERE MaBN = @BN3);
    DECLARE @DK1 INT = (SELECT MaDK FROM dbo.DangKyKhamBenh WHERE MaBN = @BN1);
    DECLARE @DK2 INT = (SELECT MaDK FROM dbo.DangKyKhamBenh WHERE MaBN = @BN2);
    DECLARE @DK3 INT = (SELECT MaDK FROM dbo.DangKyKhamBenh WHERE MaBN = @BN3);

    -- 8. PhieuKham: 3, gan dung dang ky/ho so/khoa/bac si
    INSERT INTO dbo.PhieuKham (MaHoSo, MaBS, MaKhoa, MaDK, NgayGioKham, TrieuChung, ChanDoan)
    VALUES
      (@HS1, @BS1, @K1, @DK1, '2026-10-01T08:30:00', N'Sốt, đau đầu', N'Cảm cúm'),
      (@HS2, @BS2, @K2, @DK2, '2026-10-02T09:30:00', N'Đau bụng', N'Rối loạn tiêu hóa'),
      (@HS3, @BS3, @KhoaNhi, @DK3, '2026-10-03T10:30:00', N'Hắt hơi, sổ mũi', N'Viêm mũi dị ứng');

    DECLARE @PK1 INT = (SELECT MaPhieuKham FROM dbo.PhieuKham WHERE MaDK = @DK1);
    DECLARE @PK2 INT = (SELECT MaPhieuKham FROM dbo.PhieuKham WHERE MaDK = @DK2);
    DECLARE @PK3 INT = (SELECT MaPhieuKham FROM dbo.PhieuKham WHERE MaDK = @DK3);

    -- 9. XetNghiem: 3; lien ket voi PhieuKham
    INSERT INTO dbo.XetNghiem (MaPhieuKham, TenXetNghiem, NgayXN, KetQua)
    VALUES
      (@PK1, N'Công thức máu', '2026-10-01T09:00:00', N'Chỉ số trong giới hạn tham chiếu'),
      (@PK2, N'Siêu âm bụng', '2026-10-02T10:00:00', N'Chưa thấy bất thường rõ'),
      (@PK3, N'Xét nghiệm dị ứng', '2026-10-03T11:00:00', N'Cần bác sĩ đánh giá cùng triệu chứng');

    -- 10. ToaThuoc: 3; moi PhieuKham toi da 1 toa
    INSERT INTO dbo.ToaThuoc (MaPhieuKham, NgayKeToa, LoiDan)
    VALUES
      (@PK1, '2026-10-01', N'Nghỉ ngơi, uống đủ nước'),
      (@PK2, '2026-10-02', N'Ăn uống hợp vệ sinh'),
      (@PK3, '2026-10-03', N'Tránh tiếp xúc tác nhân gây dị ứng');

    DECLARE @T1 INT = (SELECT MaToa FROM dbo.ToaThuoc WHERE MaPhieuKham = @PK1);
    DECLARE @T2 INT = (SELECT MaToa FROM dbo.ToaThuoc WHERE MaPhieuKham = @PK2);
    DECLARE @T3 INT = (SELECT MaToa FROM dbo.ToaThuoc WHERE MaPhieuKham = @PK3);
    DECLARE @TH1 INT = (SELECT TOP(1) MaThuoc FROM dbo.Thuoc WHERE TenThuoc = N'Paracetamol 500mg' ORDER BY MaThuoc);
    DECLARE @TH2 INT = (SELECT TOP(1) MaThuoc FROM dbo.Thuoc WHERE TenThuoc = N'ORS' ORDER BY MaThuoc);
    DECLARE @TH3 INT = (SELECT TOP(1) MaThuoc FROM dbo.Thuoc WHERE TenThuoc = N'Cetirizine 10mg' ORDER BY MaThuoc);

    -- 11. ChiTietToaThuoc: 3; thong tin minh hoa phuc vu kiem thu, KHONG la chi dinh y khoa
    INSERT INTO dbo.ChiTietToaThuoc (MaToa, MaThuoc, SoLuong, LieuDung, CachDung)
    VALUES
      (@T1, @TH1, 6, N'Theo chỉ định bác sĩ', N'Đọc hướng dẫn trên toa'),
      (@T2, @TH2, 3, N'Theo chỉ định bác sĩ', N'Pha theo hướng dẫn được kê'),
      (@T3, @TH3, 5, N'Theo chỉ định bác sĩ', N'Sử dụng theo toa');

    -- 12. LichKhamDinhKy: 3, ba benh nhan, cac ngay khac nhau
    INSERT INTO dbo.LichKhamDinhKy (MaBN, NgayGioHen, TrangThai)
    VALUES
      (@BN1, '2026-12-01T08:00:00', N'Đã đặt'),
      (@BN2, '2026-12-02T09:00:00', N'Đã đặt'),
      (@BN3, '2026-12-03T10:00:00', N'Đã đặt');

    -- 13. ThanhToanVienPhi: 3, 1 thanh toan/1 phieu kham
    INSERT INTO dbo.ThanhToanVienPhi (MaPhieuKham, SoTien, NgayThanhToan, TrangThai)
    VALUES
      (@PK1, 150000, '2026-10-01T12:00:00', N'Đã thanh toán'),
      (@PK2, 200000, '2026-10-02T12:00:00', N'Đã thanh toán'),
      (@PK3, 180000, '2026-10-03T12:00:00', N'Đã thanh toán');

    -- Xac nhan moi bang dung 3 dong truoc khi COMMIT.
    IF (SELECT COUNT(*) FROM dbo.BenhNhan) <> 3 OR
       (SELECT COUNT(*) FROM dbo.Khoa) <> 3 OR
       (SELECT COUNT(*) FROM dbo.BacSi) <> 3 OR
       (SELECT COUNT(*) FROM dbo.DangKyKhamBenh) <> 3 OR
       (SELECT COUNT(*) FROM dbo.LePhiNam) <> 3 OR
       (SELECT COUNT(*) FROM dbo.HoSoBenhAn) <> 3 OR
       (SELECT COUNT(*) FROM dbo.PhieuKham) <> 3 OR
       (SELECT COUNT(*) FROM dbo.XetNghiem) <> 3 OR
       (SELECT COUNT(*) FROM dbo.ToaThuoc) <> 3 OR
       (SELECT COUNT(*) FROM dbo.Thuoc) <> 3 OR
       (SELECT COUNT(*) FROM dbo.ChiTietToaThuoc) <> 3 OR
       (SELECT COUNT(*) FROM dbo.LichKhamDinhKy) <> 3 OR
       (SELECT COUNT(*) FROM dbo.ThanhToanVienPhi) <> 3
        THROW 50002, N'So dong khong dung 3 moi bang, rollback.', 1;

    COMMIT TRANSACTION;
    PRINT N'Thanh cong: 13 bang, moi bang 3 dong.';
END TRY
BEGIN CATCH
    IF @@TRANCOUNT > 0 ROLLBACK TRANSACTION;
    THROW;
END CATCH;
GO
-- Kiem tra ket qua
SELECT 'BenhNhan' AS TenBang, COUNT(*) AS SoDong FROM dbo.BenhNhan
UNION ALL SELECT 'Khoa', COUNT(*) FROM dbo.Khoa
UNION ALL SELECT 'BacSi', COUNT(*) FROM dbo.BacSi
UNION ALL SELECT 'DangKyKhamBenh', COUNT(*) FROM dbo.DangKyKhamBenh

