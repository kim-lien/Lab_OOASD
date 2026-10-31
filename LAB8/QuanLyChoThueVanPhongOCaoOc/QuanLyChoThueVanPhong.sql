
USE master;
GO

IF DB_ID(N'QuanLyChoThueVanPhong') IS NOT NULL
BEGIN
    ALTER DATABASE QuanLyChoThueVanPhong SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
    DROP DATABASE QuanLyChoThueVanPhong;
END;
GO

CREATE DATABASE QuanLyChoThueVanPhong;
GO

USE QuanLyChoThueVanPhong;
GO

CREATE TABLE Tang (
    MaTang VARCHAR(20) PRIMARY KEY,
    SoTang INT NOT NULL UNIQUE,
    MoTa NVARCHAR(300)
);

CREATE TABLE VanPhong (
    MaPhong VARCHAR(20) PRIMARY KEY,
    MaTang VARCHAR(20) NOT NULL,
    DienTich DECIMAL(12,2) NOT NULL CHECK (DienTich > 0),
    HuongPhong NVARCHAR(100),
    DonGiaThue DECIMAL(18,2) NOT NULL CHECK (DonGiaThue > 0),
    TrangThai NVARCHAR(30) NOT NULL DEFAULT N'Trống',
    CONSTRAINT FK_VanPhong_Tang FOREIGN KEY (MaTang) REFERENCES Tang(MaTang),
    CONSTRAINT CK_VanPhong_TrangThai CHECK (TrangThai IN (N'Trống', N'Đang thuê', N'Bảo trì'))
);

CREATE TABLE KhachHang (
    MaKH VARCHAR(20) PRIMARY KEY,
    TenCongTy NVARCHAR(200) NOT NULL,
    DiaChi NVARCHAR(300),
    DienThoai VARCHAR(20),
    Email VARCHAR(150),
    NguoiDaiDien NVARCHAR(150) NOT NULL
);

CREATE TABLE HopDongThue (
    MaHD VARCHAR(20) PRIMARY KEY,
    MaKH VARCHAR(20) NOT NULL,
    NgayKy DATE NOT NULL,
    NgayBatDau DATE NOT NULL,
    NgayKetThuc DATE NOT NULL,
    ThoiHanThue INT NOT NULL CHECK (ThoiHanThue >= 6),
    TongTienThueThang DECIMAL(18,2) NOT NULL CHECK (TongTienThueThang >= 0),
    TrangThai NVARCHAR(30) NOT NULL DEFAULT N'Chờ thanh toán',
    NoiDung NVARCHAR(MAX),
    CONSTRAINT FK_HopDong_KhachHang FOREIGN KEY (MaKH) REFERENCES KhachHang(MaKH),
    CONSTRAINT CK_HopDong_Ngay CHECK (NgayKetThuc >= NgayBatDau),
    CONSTRAINT CK_HopDong_TrangThai CHECK (TrangThai IN (N'Chờ thanh toán', N'Đang hiệu lực', N'Hết hạn', N'Đã hủy'))
);

CREATE TABLE ChiTietHopDong (
    MaHD VARCHAR(20) NOT NULL,
    MaPhong VARCHAR(20) NOT NULL,
    DonGiaThue DECIMAL(18,2) NOT NULL CHECK (DonGiaThue > 0),
    ThoiHanThue INT NOT NULL CHECK (ThoiHanThue >= 6),
    NgayBatDau DATE NOT NULL,
    NgayKetThuc DATE NOT NULL,
    CONSTRAINT PK_ChiTietHopDong PRIMARY KEY (MaHD, MaPhong),
    CONSTRAINT FK_CTHD_HopDong FOREIGN KEY (MaHD) REFERENCES HopDongThue(MaHD),
    CONSTRAINT FK_CTHD_VanPhong FOREIGN KEY (MaPhong) REFERENCES VanPhong(MaPhong),
    CONSTRAINT CK_CTHD_Ngay CHECK (NgayKetThuc >= NgayBatDau)
);

CREATE TABLE PhieuGiaHan (
    MaGiaHan VARCHAR(20) PRIMARY KEY,
    MaHD VARCHAR(20) NOT NULL,
    MaPhong VARCHAR(20) NOT NULL,
    NgayLap DATE NOT NULL,
    SoThangGiaHan INT NOT NULL CHECK (SoThangGiaHan > 0),
    NgayBatDauMoi DATE NOT NULL,
    NgayKetThucMoi DATE NOT NULL,
    TrangThai NVARCHAR(30) NOT NULL DEFAULT N'Đã duyệt',
    CONSTRAINT FK_GiaHan_CTHD FOREIGN KEY (MaHD, MaPhong) REFERENCES ChiTietHopDong(MaHD, MaPhong),
    CONSTRAINT CK_GiaHan_Ngay CHECK (NgayKetThucMoi >= NgayBatDauMoi),
    CONSTRAINT CK_GiaHan_TrangThai CHECK (TrangThai IN (N'Đã duyệt', N'Đã hủy'))
);

CREATE TABLE KyThanhToan (
    MaKy VARCHAR(20) PRIMARY KEY,
    MaHD VARCHAR(20) NOT NULL,
    MaPhong VARCHAR(20) NOT NULL,
    ThangThu INT NOT NULL,
    LoaiKy VARCHAR(20) NOT NULL,
    NgayBatDauKy DATE NOT NULL,
    NgayDenHan DATE NOT NULL,
    SoTienPhaiThu DECIMAL(18,2) NOT NULL CHECK (SoTienPhaiThu > 0),
    TrangThai NVARCHAR(30) NOT NULL DEFAULT N'Chưa thanh toán',
    CONSTRAINT FK_Ky_CTHD FOREIGN KEY (MaHD, MaPhong) REFERENCES ChiTietHopDong(MaHD, MaPhong),
    CONSTRAINT UQ_KyThanhToan UNIQUE (MaHD, MaPhong, ThangThu),
    CONSTRAINT CK_Ky_Loai CHECK (
        (LoaiKy = 'TRA_TRUOC' AND ThangThu = 1)
        OR (LoaiKy = 'HANG_THANG' AND ThangThu >= 7)
    ),
    CONSTRAINT CK_Ky_TrangThai CHECK (TrangThai IN (N'Chưa thanh toán', N'Thanh toán một phần', N'Đã thanh toán'))
);

CREATE TABLE ThanhToanTienThue (
    MaThanhToan VARCHAR(20) PRIMARY KEY,
    MaKy VARCHAR(20) NOT NULL,
    NgayThanhToan DATETIME2 NOT NULL DEFAULT SYSDATETIME(),
    SoTien DECIMAL(18,2) NOT NULL CHECK (SoTien > 0),
    HinhThucThanhToan NVARCHAR(100),
    GhiChu NVARCHAR(300),
    CONSTRAINT FK_TTTienThue_Ky FOREIGN KEY (MaKy) REFERENCES KyThanhToan(MaKy)
);

CREATE TABLE DichVu (
    MaDV VARCHAR(20) PRIMARY KEY,
    TenDV NVARCHAR(150) NOT NULL UNIQUE,
    DonViTinh NVARCHAR(50),
    DonGia DECIMAL(18,2) NOT NULL CHECK (DonGia >= 0),
    TrangThai NVARCHAR(30) NOT NULL DEFAULT N'Đang sử dụng',
    CONSTRAINT CK_DichVu_TrangThai CHECK (TrangThai IN (N'Đang sử dụng', N'Ngừng sử dụng'))
);

CREATE TABLE HoaDonDichVu (
    MaHoaDon VARCHAR(20) PRIMARY KEY,
    MaHD VARCHAR(20) NOT NULL,
    MaPhong VARCHAR(20) NOT NULL,
    Thang INT NOT NULL CHECK (Thang BETWEEN 1 AND 12),
    Nam INT NOT NULL CHECK (Nam BETWEEN 2000 AND 9999),
    NgayLap DATE NOT NULL,
    HanThanhToan DATE NOT NULL,
    TongTien DECIMAL(18,2) NOT NULL CHECK (TongTien >= 0),
    TrangThai NVARCHAR(30) NOT NULL DEFAULT N'Chưa thanh toán',
    CONSTRAINT FK_HDDV_CTHD FOREIGN KEY (MaHD, MaPhong) REFERENCES ChiTietHopDong(MaHD, MaPhong),
    CONSTRAINT UQ_HDDV_Ky UNIQUE (MaHD, MaPhong, Thang, Nam),
    CONSTRAINT CK_HDDV_Ngay CHECK (HanThanhToan >= NgayLap),
    CONSTRAINT CK_HDDV_TrangThai CHECK (TrangThai IN (N'Chưa thanh toán', N'Thanh toán một phần', N'Đã thanh toán'))
);

CREATE TABLE ChiTietHoaDon (
    MaHoaDon VARCHAR(20) NOT NULL,
    MaDV VARCHAR(20) NOT NULL,
    SoLuong DECIMAL(18,2) NOT NULL CHECK (SoLuong >= 0),
    DonGia DECIMAL(18,2) NOT NULL CHECK (DonGia >= 0),
    ThanhTien DECIMAL(18,2) NOT NULL,
    CONSTRAINT PK_ChiTietHoaDon PRIMARY KEY (MaHoaDon, MaDV),
    CONSTRAINT FK_CTHoaDon_HoaDon FOREIGN KEY (MaHoaDon) REFERENCES HoaDonDichVu(MaHoaDon),
    CONSTRAINT FK_CTHoaDon_DichVu FOREIGN KEY (MaDV) REFERENCES DichVu(MaDV),
    CONSTRAINT CK_CTHoaDon_Tien CHECK (ThanhTien = SoLuong * DonGia)
);

CREATE TABLE ThanhToanDichVu (
    MaTTDV VARCHAR(20) PRIMARY KEY,
    MaHoaDon VARCHAR(20) NOT NULL,
    NgayThanhToan DATETIME2 NOT NULL DEFAULT SYSDATETIME(),
    SoTien DECIMAL(18,2) NOT NULL CHECK (SoTien > 0),
    HinhThucThanhToan NVARCHAR(100),
    CONSTRAINT FK_TTDV_HoaDon FOREIGN KEY (MaHoaDon) REFERENCES HoaDonDichVu(MaHoaDon)
);

CREATE TABLE NhanVienVanPhong (
    MaNV VARCHAR(20) PRIMARY KEY,
    MaKH VARCHAR(20) NOT NULL,
    MaPhong VARCHAR(20) NOT NULL,
    HoTen NVARCHAR(150) NOT NULL,
    HinhAnh NVARCHAR(500),
    ChucVu NVARCHAR(100),
    DienThoai VARCHAR(20),
    TrangThai NVARCHAR(30) NOT NULL DEFAULT N'Đang làm việc',
    CONSTRAINT FK_NVVP_KhachHang FOREIGN KEY (MaKH) REFERENCES KhachHang(MaKH),
    CONSTRAINT FK_NVVP_VanPhong FOREIGN KEY (MaPhong) REFERENCES VanPhong(MaPhong)
);

CREATE TABLE TheGiuXe (
    MaThe VARCHAR(20) PRIMARY KEY,
    MaNV VARCHAR(20) NOT NULL,
    BienSoXe VARCHAR(30) NOT NULL,
    LoaiXe NVARCHAR(100),
    HangXe NVARCHAR(100),
    NgayCap DATE NOT NULL,
    TrangThai NVARCHAR(30) NOT NULL DEFAULT N'Đang sử dụng',
    CONSTRAINT FK_TheGiuXe_NV FOREIGN KEY (MaNV) REFERENCES NhanVienVanPhong(MaNV),
    CONSTRAINT CK_TheGiuXe_TrangThai CHECK (TrangThai IN (N'Đang sử dụng', N'Đã khóa'))
);

CREATE TABLE PhieuKiemTra (
    MaKiemTra VARCHAR(20) PRIMARY KEY,
    MaPhong VARCHAR(20) NOT NULL,
    NgayKiemTra DATE NOT NULL,
    TinhTrang NVARCHAR(500),
    KetLuan NVARCHAR(500),
    NguoiKiemTra NVARCHAR(150),
    CONSTRAINT FK_KiemTra_VanPhong FOREIGN KEY (MaPhong) REFERENCES VanPhong(MaPhong)
);

CREATE TABLE PhieuXuPhat (
    MaPhat VARCHAR(20) PRIMARY KEY,
    MaKiemTra VARCHAR(20) NOT NULL UNIQUE,
    NgayLap DATE NOT NULL,
    LyDo NVARCHAR(500) NOT NULL,
    SoTienPhat DECIMAL(18,2) NOT NULL CHECK (SoTienPhat >= 0),
    TrangThai NVARCHAR(30) NOT NULL DEFAULT N'Chưa xử lý',
    CONSTRAINT FK_XuPhat_KiemTra FOREIGN KEY (MaKiemTra) REFERENCES PhieuKiemTra(MaKiemTra)
);
GO

CREATE INDEX IX_CTHD_PhongNgay
ON ChiTietHopDong(MaPhong, NgayBatDau, NgayKetThuc);

CREATE INDEX IX_Ky_NgayDenHan
ON KyThanhToan(NgayDenHan);

CREATE INDEX IX_HoaDon_HanThanhToan
ON HoaDonDichVu(HanThanhToan);

CREATE UNIQUE INDEX UX_TheGiuXe_HieuLuc
ON TheGiuXe(MaNV, BienSoXe)
WHERE TrangThai = N'Đang sử dụng';
GO

CREATE TYPE DanhSachPhongThue AS TABLE (
    MaPhong VARCHAR(20) PRIMARY KEY
);
GO

CREATE TYPE DanhSachDichVu AS TABLE (
    MaDV VARCHAR(20) PRIMARY KEY,
    SoLuong DECIMAL(18,2) NOT NULL
);
GO

CREATE OR ALTER PROCEDURE sp_LapHopDong
    @MaHD VARCHAR(20),
    @MaKH VARCHAR(20),
    @NgayKy DATE,
    @NgayBatDau DATE,
    @ThoiHanThue INT,
    @DanhSachPhong DanhSachPhongThue READONLY
AS
BEGIN
    SET NOCOUNT ON;
    SET XACT_ABORT ON;

    DECLARE @NgayKetThuc DATE;
    DECLARE @TongTien DECIMAL(18,2);
    DECLARE @MaPhong VARCHAR(20);
    DECLARE @Thang INT;
    DECLARE @KetQuaKhoa INT;

    IF @ThoiHanThue IS NULL OR @ThoiHanThue < 6
        THROW 50001, N'Thời gian thuê tối thiểu 6 tháng.', 1;

    IF NOT EXISTS (SELECT 1 FROM @DanhSachPhong)
        THROW 50002, N'Chưa chọn văn phòng.', 1;

    IF @NgayKy IS NULL OR @NgayBatDau IS NULL
        THROW 50003, N'Ngày ký hoặc ngày bắt đầu không hợp lệ.', 1;

    SET @NgayKetThuc = DATEADD(DAY, -1, DATEADD(MONTH, @ThoiHanThue, @NgayBatDau));

    BEGIN TRY
        SET TRANSACTION ISOLATION LEVEL SERIALIZABLE;
        BEGIN TRANSACTION;

        IF NOT EXISTS (SELECT 1 FROM KhachHang WHERE MaKH = @MaKH)
            THROW 50004, N'Khách hàng không tồn tại.', 1;

        IF EXISTS (
            SELECT 1
            FROM @DanhSachPhong ds
            LEFT JOIN VanPhong vp ON vp.MaPhong = ds.MaPhong
            WHERE vp.MaPhong IS NULL OR vp.TrangThai = N'Bảo trì'
        )
            THROW 50005, N'Có văn phòng không khả dụng.', 1;

        DECLARE curPhong CURSOR LOCAL FAST_FORWARD FOR
            SELECT MaPhong FROM @DanhSachPhong ORDER BY MaPhong;

        OPEN curPhong;
        FETCH NEXT FROM curPhong INTO @MaPhong;

        WHILE @@FETCH_STATUS = 0
        BEGIN
            EXEC @KetQuaKhoa = sp_getapplock
                @Resource = @MaPhong,
                @LockMode = 'Exclusive',
                @LockOwner = 'Transaction',
                @LockTimeout = 10000;

            IF @KetQuaKhoa < 0
                THROW 50006, N'Không thể khóa lịch thuê phòng.', 1;

            FETCH NEXT FROM curPhong INTO @MaPhong;
        END;

        CLOSE curPhong;
        DEALLOCATE curPhong;

        IF EXISTS (
            SELECT 1
            FROM @DanhSachPhong ds
            JOIN ChiTietHopDong ct ON ct.MaPhong = ds.MaPhong
            JOIN HopDongThue hd ON hd.MaHD = ct.MaHD
            WHERE hd.TrangThai <> N'Đã hủy'
              AND ct.NgayBatDau <= @NgayKetThuc
              AND ct.NgayKetThuc >= @NgayBatDau
        )
            THROW 50007, N'Văn phòng bị trùng lịch thuê.', 1;

        SELECT @TongTien = SUM(vp.DonGiaThue)
        FROM @DanhSachPhong ds
        JOIN VanPhong vp ON vp.MaPhong = ds.MaPhong;

        INSERT INTO HopDongThue (
            MaHD, MaKH, NgayKy, NgayBatDau, NgayKetThuc,
            ThoiHanThue, TongTienThueThang, TrangThai
        )
        VALUES (
            @MaHD, @MaKH, @NgayKy, @NgayBatDau, @NgayKetThuc,
            @ThoiHanThue, @TongTien, N'Chờ thanh toán'
        );

        INSERT INTO ChiTietHopDong (
            MaHD, MaPhong, DonGiaThue,
            ThoiHanThue, NgayBatDau, NgayKetThuc
        )
        SELECT
            @MaHD, vp.MaPhong, vp.DonGiaThue,
            @ThoiHanThue, @NgayBatDau, @NgayKetThuc
        FROM @DanhSachPhong ds
        JOIN VanPhong vp ON vp.MaPhong = ds.MaPhong;

        INSERT INTO KyThanhToan (
            MaKy, MaHD, MaPhong, ThangThu, LoaiKy,
            NgayBatDauKy, NgayDenHan, SoTienPhaiThu, TrangThai
        )
        SELECT
            LEFT('K' + REPLACE(CONVERT(VARCHAR(36), NEWID()), '-', ''), 20),
            @MaHD, MaPhong, 1, 'TRA_TRUOC',
            @NgayBatDau, @NgayKy, DonGiaThue * 6, N'Chưa thanh toán'
        FROM ChiTietHopDong
        WHERE MaHD = @MaHD;

        SET @Thang = 7;

        WHILE @Thang <= @ThoiHanThue
        BEGIN
            INSERT INTO KyThanhToan (
                MaKy, MaHD, MaPhong, ThangThu, LoaiKy,
                NgayBatDauKy, NgayDenHan, SoTienPhaiThu, TrangThai
            )
            SELECT
                LEFT('K' + REPLACE(CONVERT(VARCHAR(36), NEWID()), '-', ''), 20),
                @MaHD, MaPhong, @Thang, 'HANG_THANG',
                DATEADD(MONTH, @Thang - 1, @NgayBatDau),
                DATEADD(MONTH, @Thang - 1, @NgayBatDau),
                DonGiaThue, N'Chưa thanh toán'
            FROM ChiTietHopDong
            WHERE MaHD = @MaHD;

            SET @Thang = @Thang + 1;
        END;

        COMMIT TRANSACTION;
        SET TRANSACTION ISOLATION LEVEL READ COMMITTED;

        SELECT @MaHD AS MaHD, @TongTien AS TienMoiThang,
               @TongTien * 6 AS TienTraTruoc;
    END TRY
    BEGIN CATCH
        IF CURSOR_STATUS('local', 'curPhong') >= 0
            CLOSE curPhong;

        IF CURSOR_STATUS('local', 'curPhong') >= -1
            DEALLOCATE curPhong;

        IF @@TRANCOUNT > 0
            ROLLBACK TRANSACTION;

        SET TRANSACTION ISOLATION LEVEL READ COMMITTED;
        THROW;
    END CATCH
END;
GO

CREATE OR ALTER PROCEDURE sp_ThanhToanTienThue
    @MaThanhToan VARCHAR(20),
    @MaKy VARCHAR(20),
    @SoTien DECIMAL(18,2),
    @HinhThuc NVARCHAR(100)
AS
BEGIN
    SET NOCOUNT ON;
    SET XACT_ABORT ON;

    DECLARE @PhaiThu DECIMAL(18,2);
    DECLARE @DaThu DECIMAL(18,2);
    DECLARE @MaHD VARCHAR(20);

    BEGIN TRY
        BEGIN TRANSACTION;

        SELECT @PhaiThu = SoTienPhaiThu, @MaHD = MaHD
        FROM KyThanhToan WITH (UPDLOCK, HOLDLOCK)
        WHERE MaKy = @MaKy;

        IF @PhaiThu IS NULL
            THROW 50010, N'Kỳ thanh toán không tồn tại.', 1;

        SELECT @DaThu = COALESCE(SUM(SoTien), 0)
        FROM ThanhToanTienThue
        WHERE MaKy = @MaKy;

        IF @SoTien IS NULL OR @SoTien <= 0 OR @SoTien > @PhaiThu - @DaThu
            THROW 50011, N'Số tiền thanh toán không hợp lệ.', 1;

        INSERT INTO ThanhToanTienThue (
            MaThanhToan, MaKy, NgayThanhToan,
            SoTien, HinhThucThanhToan
        )
        VALUES (
            @MaThanhToan, @MaKy, SYSDATETIME(),
            @SoTien, @HinhThuc
        );

        SET @DaThu = @DaThu + @SoTien;

        UPDATE KyThanhToan
        SET TrangThai =
            CASE WHEN @DaThu = @PhaiThu
                 THEN N'Đã thanh toán'
                 ELSE N'Thanh toán một phần'
            END
        WHERE MaKy = @MaKy;

        IF NOT EXISTS (
            SELECT 1
            FROM KyThanhToan
            WHERE MaHD = @MaHD
              AND LoaiKy = 'TRA_TRUOC'
              AND TrangThai <> N'Đã thanh toán'
        )
        BEGIN
            UPDATE HopDongThue
            SET TrangThai = N'Đang hiệu lực'
            WHERE MaHD = @MaHD
              AND TrangThai = N'Chờ thanh toán';
        END;

        COMMIT TRANSACTION;

        SELECT N'Thanh toán tiền thuê thành công' AS ThongBao;
    END TRY
    BEGIN CATCH
        IF @@TRANCOUNT > 0
            ROLLBACK TRANSACTION;
        THROW;
    END CATCH
END;
GO

CREATE OR ALTER PROCEDURE sp_LapHoaDonDichVu
    @MaHoaDon VARCHAR(20),
    @MaHD VARCHAR(20),
    @MaPhong VARCHAR(20),
    @Thang INT,
    @Nam INT,
    @DanhSachDichVu DanhSachDichVu READONLY
AS
BEGIN
    SET NOCOUNT ON;
    SET XACT_ABORT ON;

    DECLARE @TongTien DECIMAL(18,2);
    DECLARE @NgayLap DATE;

    IF @Thang IS NULL OR @Thang NOT BETWEEN 1 AND 12
       OR @Nam IS NULL OR @Nam NOT BETWEEN 2000 AND 9999
        THROW 50020, N'Tháng hoặc năm không hợp lệ.', 1;

    SET @NgayLap = EOMONTH(DATEFROMPARTS(@Nam, @Thang, 1));

    IF @NgayLap > CAST(GETDATE() AS DATE)
        THROW 50021, N'Chưa đến cuối tháng.', 1;

    IF NOT EXISTS (SELECT 1 FROM @DanhSachDichVu)
        THROW 50022, N'Chưa có dữ liệu dịch vụ.', 1;

    IF EXISTS (SELECT 1 FROM @DanhSachDichVu WHERE SoLuong IS NULL OR SoLuong < 0)
        THROW 50023, N'Số lượng dịch vụ không hợp lệ.', 1;

    BEGIN TRY
        BEGIN TRANSACTION;

        IF NOT EXISTS (
            SELECT 1 FROM ChiTietHopDong
            WHERE MaHD = @MaHD AND MaPhong = @MaPhong
              AND NgayBatDau <= @NgayLap
              AND NgayKetThuc >= DATEFROMPARTS(@Nam, @Thang, 1)
        )
            THROW 50024, N'Văn phòng không thuộc hợp đồng trong kỳ.', 1;

        IF EXISTS (
            SELECT 1 FROM HoaDonDichVu
            WHERE MaHD = @MaHD AND MaPhong = @MaPhong
              AND Thang = @Thang AND Nam = @Nam
        )
            THROW 50025, N'Hóa đơn tháng đã tồn tại.', 1;

        IF EXISTS (
            SELECT 1
            FROM @DanhSachDichVu ds
            LEFT JOIN DichVu dv ON dv.MaDV = ds.MaDV
            WHERE dv.MaDV IS NULL
        )
            THROW 50026, N'Dịch vụ không tồn tại.', 1;

        SELECT @TongTien = SUM(ds.SoLuong * dv.DonGia)
        FROM @DanhSachDichVu ds
        JOIN DichVu dv ON dv.MaDV = ds.MaDV;

        INSERT INTO HoaDonDichVu (
            MaHoaDon, MaHD, MaPhong, Thang, Nam,
            NgayLap, HanThanhToan, TongTien, TrangThai
        )
        VALUES (
            @MaHoaDon, @MaHD, @MaPhong, @Thang, @Nam,
            @NgayLap, @NgayLap, @TongTien, N'Chưa thanh toán'
        );

        INSERT INTO ChiTietHoaDon (
            MaHoaDon, MaDV, SoLuong, DonGia, ThanhTien
        )
        SELECT @MaHoaDon, ds.MaDV, ds.SoLuong,
               dv.DonGia, ds.SoLuong * dv.DonGia
        FROM @DanhSachDichVu ds
        JOIN DichVu dv ON dv.MaDV = ds.MaDV;

        COMMIT TRANSACTION;

        SELECT @MaHoaDon AS MaHoaDon, @TongTien AS TongTien;
    END TRY
    BEGIN CATCH
        IF @@TRANCOUNT > 0
            ROLLBACK TRANSACTION;
        THROW;
    END CATCH
END;
GO

CREATE OR ALTER PROCEDURE sp_ThanhToanDichVu
    @MaTTDV VARCHAR(20),
    @MaHoaDon VARCHAR(20),
    @SoTien DECIMAL(18,2),
    @HinhThuc NVARCHAR(100)
AS
BEGIN
    SET NOCOUNT ON;
    SET XACT_ABORT ON;

    DECLARE @TongTien DECIMAL(18,2);
    DECLARE @DaTra DECIMAL(18,2);

    BEGIN TRY
        BEGIN TRANSACTION;

        SELECT @TongTien = TongTien
        FROM HoaDonDichVu WITH (UPDLOCK, HOLDLOCK)
        WHERE MaHoaDon = @MaHoaDon;

        IF @TongTien IS NULL
            THROW 50030, N'Hóa đơn không tồn tại.', 1;

        SELECT @DaTra = COALESCE(SUM(SoTien), 0)
        FROM ThanhToanDichVu
        WHERE MaHoaDon = @MaHoaDon;

        IF @SoTien IS NULL OR @SoTien <= 0 OR @SoTien > @TongTien - @DaTra
            THROW 50031, N'Số tiền thanh toán không hợp lệ.', 1;

        INSERT INTO ThanhToanDichVu (
            MaTTDV, MaHoaDon, NgayThanhToan,
            SoTien, HinhThucThanhToan
        )
        VALUES (
            @MaTTDV, @MaHoaDon, SYSDATETIME(),
            @SoTien, @HinhThuc
        );

        SET @DaTra = @DaTra + @SoTien;

        UPDATE HoaDonDichVu
        SET TrangThai =
            CASE WHEN @DaTra = @TongTien
                 THEN N'Đã thanh toán'
                 ELSE N'Thanh toán một phần'
            END
        WHERE MaHoaDon = @MaHoaDon;

        COMMIT TRANSACTION;

        SELECT N'Thanh toán dịch vụ thành công' AS ThongBao;
    END TRY
    BEGIN CATCH
        IF @@TRANCOUNT > 0
            ROLLBACK TRANSACTION;
        THROW;
    END CATCH
END;
GO

CREATE OR ALTER PROCEDURE sp_LapPhieuGiaHan
    @MaGiaHan VARCHAR(20),
    @MaHD VARCHAR(20),
    @MaPhong VARCHAR(20),
    @SoThangGiaHan INT
AS
BEGIN
    SET NOCOUNT ON;
    SET XACT_ABORT ON;

    DECLARE @ThoiHanGoc INT;
    DECLARE @DaGiaHan INT;
    DECLARE @NgayKetThucCu DATE;
    DECLARE @NgayBatDauMoi DATE;
    DECLARE @NgayKetThucMoi DATE;
    DECLARE @NgayBatDauGoc DATE;
    DECLARE @DonGia DECIMAL(18,2);
    DECLARE @Thang INT;
    DECLARE @TongThang INT;
    DECLARE @KetQuaKhoa INT;

    IF @SoThangGiaHan IS NULL OR @SoThangGiaHan <= 0
        THROW 50040, N'Số tháng gia hạn không hợp lệ.', 1;

    BEGIN TRY
        SET TRANSACTION ISOLATION LEVEL SERIALIZABLE;
        BEGIN TRANSACTION;

        EXEC @KetQuaKhoa = sp_getapplock
            @Resource = @MaPhong,
            @LockMode = 'Exclusive',
            @LockOwner = 'Transaction',
            @LockTimeout = 10000;

        IF @KetQuaKhoa < 0
            THROW 50041, N'Không thể khóa lịch thuê phòng.', 1;

        SELECT
            @ThoiHanGoc = ct.ThoiHanThue,
            @NgayBatDauGoc = ct.NgayBatDau,
            @NgayKetThucCu = ct.NgayKetThuc,
            @DonGia = ct.DonGiaThue
        FROM ChiTietHopDong ct WITH (UPDLOCK, HOLDLOCK)
        JOIN HopDongThue hd ON hd.MaHD = ct.MaHD
        WHERE ct.MaHD = @MaHD
          AND ct.MaPhong = @MaPhong
          AND hd.TrangThai = N'Đang hiệu lực';

        IF @ThoiHanGoc IS NULL
            THROW 50042, N'Hợp đồng hoặc phòng thuê không hợp lệ.', 1;

        SELECT @DaGiaHan = COALESCE(SUM(SoThangGiaHan), 0)
        FROM PhieuGiaHan
        WHERE MaHD = @MaHD
          AND MaPhong = @MaPhong
          AND TrangThai = N'Đã duyệt';

        IF (@DaGiaHan + @SoThangGiaHan) * 2 > @ThoiHanGoc
            THROW 50043, N'Thời gian gia hạn vượt quá một nửa thời gian thuê.', 1;

        IF EXISTS (
            SELECT 1
            FROM KyThanhToan k
            WHERE k.MaHD = @MaHD
              AND k.MaPhong = @MaPhong
              AND k.NgayDenHan <= CAST(GETDATE() AS DATE)
              AND k.SoTienPhaiThu > (
                  SELECT COALESCE(SUM(t.SoTien), 0)
                  FROM ThanhToanTienThue t
                  WHERE t.MaKy = k.MaKy
              )
        )
            THROW 50044, N'Văn phòng còn nợ tiền thuê.', 1;

        IF EXISTS (
            SELECT 1
            FROM HoaDonDichVu h
            WHERE h.MaHD = @MaHD
              AND h.MaPhong = @MaPhong
              AND h.TongTien > (
                  SELECT COALESCE(SUM(t.SoTien), 0)
                  FROM ThanhToanDichVu t
                  WHERE t.MaHoaDon = h.MaHoaDon
              )
        )
            THROW 50045, N'Văn phòng còn nợ tiền dịch vụ.', 1;

        SET @NgayBatDauMoi = DATEADD(DAY, 1, @NgayKetThucCu);
        SET @NgayKetThucMoi = DATEADD(DAY, -1, DATEADD(MONTH, @SoThangGiaHan, @NgayBatDauMoi));

        IF EXISTS (
            SELECT 1
            FROM ChiTietHopDong ct
            JOIN HopDongThue hd ON hd.MaHD = ct.MaHD
            WHERE ct.MaPhong = @MaPhong
              AND ct.MaHD <> @MaHD
              AND hd.TrangThai <> N'Đã hủy'
              AND ct.NgayBatDau <= @NgayKetThucMoi
              AND ct.NgayKetThuc >= @NgayBatDauMoi
        )
            THROW 50046, N'Thời gian gia hạn trùng lịch thuê khác.', 1;

        INSERT INTO PhieuGiaHan (
            MaGiaHan, MaHD, MaPhong, NgayLap,
            SoThangGiaHan, NgayBatDauMoi,
            NgayKetThucMoi, TrangThai
        )
        VALUES (
            @MaGiaHan, @MaHD, @MaPhong, CAST(GETDATE() AS DATE),
            @SoThangGiaHan, @NgayBatDauMoi,
            @NgayKetThucMoi, N'Đã duyệt'
        );

        UPDATE ChiTietHopDong
        SET NgayKetThuc = @NgayKetThucMoi
        WHERE MaHD = @MaHD AND MaPhong = @MaPhong;

        SET @Thang = @ThoiHanGoc + @DaGiaHan + 1;
        SET @TongThang = @ThoiHanGoc + @DaGiaHan + @SoThangGiaHan;

        WHILE @Thang <= @TongThang
        BEGIN
            INSERT INTO KyThanhToan (
                MaKy, MaHD, MaPhong, ThangThu, LoaiKy,
                NgayBatDauKy, NgayDenHan, SoTienPhaiThu, TrangThai
            )
            VALUES (
                LEFT('K' + REPLACE(CONVERT(VARCHAR(36), NEWID()), '-', ''), 20),
                @MaHD, @MaPhong, @Thang, 'HANG_THANG',
                DATEADD(MONTH, @Thang - 1, @NgayBatDauGoc),
                DATEADD(MONTH, @Thang - 1, @NgayBatDauGoc),
                @DonGia, N'Chưa thanh toán'
            );

            SET @Thang = @Thang + 1;
        END;

        UPDATE HopDongThue
        SET NgayKetThuc = (
            SELECT MAX(NgayKetThuc)
            FROM ChiTietHopDong
            WHERE MaHD = @MaHD
        )
        WHERE MaHD = @MaHD;

        COMMIT TRANSACTION;
        SET TRANSACTION ISOLATION LEVEL READ COMMITTED;

        SELECT @MaGiaHan AS MaGiaHan,
               @NgayKetThucMoi AS NgayKetThucMoi,
               N'Gia hạn thành công' AS ThongBao;
    END TRY
    BEGIN CATCH
        IF @@TRANCOUNT > 0
            ROLLBACK TRANSACTION;

        SET TRANSACTION ISOLATION LEVEL READ COMMITTED;
        THROW;
    END CATCH
END;
GO

BEGIN TRANSACTION;

INSERT INTO Tang (MaTang, SoTang, MoTa)
VALUES
('T01', 1, N'Tầng trệt và văn phòng'),
('T02', 2, N'Tầng văn phòng nhỏ'),
('T03', 3, N'Tầng văn phòng tiêu chuẩn'),
('T04', 4, N'Tầng văn phòng cao cấp'),
('T05', 5, N'Tầng văn phòng doanh nghiệp');

INSERT INTO VanPhong (MaPhong, MaTang, DienTich, HuongPhong, DonGiaThue, TrangThai)
VALUES
('VP101', 'T01', 50, N'Đông', 10000000, N'Đang thuê'),
('VP201', 'T02', 65, N'Tây', 13000000, N'Đang thuê'),
('VP301', 'T03', 80, N'Nam', 16000000, N'Đang thuê'),
('VP401', 'T04', 100, N'Bắc', 20000000, N'Đang thuê'),
('VP501', 'T05', 120, N'Đông Nam', 25000000, N'Đang thuê');

INSERT INTO KhachHang (MaKH, TenCongTy, DiaChi, DienThoai, Email, NguoiDaiDien)
VALUES
('KH001', N'Công ty Minh Phát', N'Quận 1, TP.HCM', '0901000001', 'minhphat@example.com', N'Nguyễn Văn An'),
('KH002', N'Công ty Hoàng Gia', N'Quận 3, TP.HCM', '0901000002', 'hoanggia@example.com', N'Trần Văn Bình'),
('KH003', N'Công ty Thành Công', N'Quận 5, TP.HCM', '0901000003', 'thanhcong@example.com', N'Lê Thị Hoa'),
('KH004', N'Công ty Phú Hưng', N'Quận 7, TP.HCM', '0901000004', 'phuhung@example.com', N'Phạm Quốc Huy'),
('KH005', N'Công ty An Bình', N'Thủ Đức, TP.HCM', '0901000005', 'anbinh@example.com', N'Võ Minh Tâm');

INSERT INTO HopDongThue (
    MaHD, MaKH, NgayKy, NgayBatDau, NgayKetThuc,
    ThoiHanThue, TongTienThueThang, TrangThai, NoiDung
)
VALUES
('HD001', 'KH001', '2026-01-05', '2026-01-10', '2027-01-09', 12, 10000000, N'Đang hiệu lực', N'Thuê văn phòng tầng 1'),
('HD002', 'KH002', '2026-02-05', '2026-02-10', '2027-02-09', 12, 13000000, N'Đang hiệu lực', N'Thuê văn phòng tầng 2'),
('HD003', 'KH003', '2026-03-05', '2026-03-10', '2027-03-09', 12, 16000000, N'Đang hiệu lực', N'Thuê văn phòng tầng 3'),
('HD004', 'KH004', '2026-04-05', '2026-04-10', '2027-04-09', 12, 20000000, N'Đang hiệu lực', N'Thuê văn phòng tầng 4'),
('HD005', 'KH005', '2026-05-05', '2026-05-10', '2027-05-09', 12, 25000000, N'Đang hiệu lực', N'Thuê văn phòng tầng 5');

INSERT INTO ChiTietHopDong (
    MaHD, MaPhong, DonGiaThue, ThoiHanThue, NgayBatDau, NgayKetThuc
)
VALUES
('HD001', 'VP101', 10000000, 12, '2026-01-10', '2027-02-09'),
('HD002', 'VP201', 13000000, 12, '2026-02-10', '2027-03-09'),
('HD003', 'VP301', 16000000, 12, '2026-03-10', '2027-04-09'),
('HD004', 'VP401', 20000000, 12, '2026-04-10', '2027-05-09'),
('HD005', 'VP501', 25000000, 12, '2026-05-10', '2027-06-09');

INSERT INTO PhieuGiaHan (
    MaGiaHan, MaHD, MaPhong, NgayLap,
    SoThangGiaHan, NgayBatDauMoi, NgayKetThucMoi, TrangThai
)
VALUES
('GH001', 'HD001', 'VP101', '2026-09-01', 1, '2027-01-10', '2027-02-09', N'Đã duyệt'),
('GH002', 'HD002', 'VP201', '2026-09-05', 1, '2027-02-10', '2027-03-09', N'Đã duyệt'),
('GH003', 'HD003', 'VP301', '2026-09-10', 1, '2027-03-10', '2027-04-09', N'Đã duyệt'),
('GH004', 'HD004', 'VP401', '2026-09-15', 1, '2027-04-10', '2027-05-09', N'Đã duyệt'),
('GH005', 'HD005', 'VP501', '2026-09-20', 1, '2027-05-10', '2027-06-09', N'Đã duyệt');

INSERT INTO KyThanhToan (
    MaKy, MaHD, MaPhong, ThangThu, LoaiKy,
    NgayBatDauKy, NgayDenHan, SoTienPhaiThu, TrangThai
)
VALUES
('K001', 'HD001', 'VP101', 1, 'TRA_TRUOC', '2026-01-10', '2026-01-05', 60000000, N'Đã thanh toán'),
('K002', 'HD002', 'VP201', 1, 'TRA_TRUOC', '2026-02-10', '2026-02-05', 78000000, N'Đã thanh toán'),
('K003', 'HD003', 'VP301', 1, 'TRA_TRUOC', '2026-03-10', '2026-03-05', 96000000, N'Đã thanh toán'),
('K004', 'HD004', 'VP401', 1, 'TRA_TRUOC', '2026-04-10', '2026-04-05', 120000000, N'Đã thanh toán'),
('K005', 'HD005', 'VP501', 1, 'TRA_TRUOC', '2026-05-10', '2026-05-05', 150000000, N'Đã thanh toán');

INSERT INTO ThanhToanTienThue (
    MaThanhToan, MaKy, NgayThanhToan,
    SoTien, HinhThucThanhToan, GhiChu
)
VALUES
('TT001', 'K001', '2026-01-05', 60000000, N'Chuyển khoản', N'Thanh toán trước 6 tháng'),
('TT002', 'K002', '2026-02-05', 78000000, N'Chuyển khoản', N'Thanh toán trước 6 tháng'),
('TT003', 'K003', '2026-03-05', 96000000, N'Tiền mặt', N'Thanh toán trước 6 tháng'),
('TT004', 'K004', '2026-04-05', 120000000, N'Chuyển khoản', N'Thanh toán trước 6 tháng'),
('TT005', 'K005', '2026-05-05', 150000000, N'Chuyển khoản', N'Thanh toán trước 6 tháng');

INSERT INTO DichVu (MaDV, TenDV, DonViTinh, DonGia, TrangThai)
VALUES
('DV001', N'Điện', N'kWh', 3500, N'Đang sử dụng'),
('DV002', N'Nước', N'm3', 18000, N'Đang sử dụng'),
('DV003', N'Internet', N'Tháng', 500000, N'Đang sử dụng'),
('DV004', N'Vệ sinh', N'Tháng', 300000, N'Đang sử dụng'),
('DV005', N'Bảo vệ', N'Tháng', 400000, N'Đang sử dụng');

INSERT INTO HoaDonDichVu (
    MaHoaDon, MaHD, MaPhong, Thang, Nam,
    NgayLap, HanThanhToan, TongTien, TrangThai
)
VALUES
('HDDV001', 'HD001', 'VP101', 8, 2026, '2026-08-31', '2026-08-31', 700000, N'Đã thanh toán'),
('HDDV002', 'HD002', 'VP201', 8, 2026, '2026-08-31', '2026-08-31', 900000, N'Đã thanh toán'),
('HDDV003', 'HD003', 'VP301', 8, 2026, '2026-08-31', '2026-08-31', 500000, N'Đã thanh toán'),
('HDDV004', 'HD004', 'VP401', 8, 2026, '2026-08-31', '2026-08-31', 300000, N'Đã thanh toán'),
('HDDV005', 'HD005', 'VP501', 8, 2026, '2026-08-31', '2026-08-31', 400000, N'Đã thanh toán');

INSERT INTO ChiTietHoaDon (
    MaHoaDon, MaDV, SoLuong, DonGia, ThanhTien
)
VALUES
('HDDV001', 'DV001', 200, 3500, 700000),
('HDDV002', 'DV002', 50, 18000, 900000),
('HDDV003', 'DV003', 1, 500000, 500000),
('HDDV004', 'DV004', 1, 300000, 300000),
('HDDV005', 'DV005', 1, 400000, 400000);

INSERT INTO ThanhToanDichVu (
    MaTTDV, MaHoaDon, NgayThanhToan, SoTien, HinhThucThanhToan
)
VALUES
('TTDV001', 'HDDV001', '2026-08-31', 700000, N'Chuyển khoản'),
('TTDV002', 'HDDV002', '2026-08-31', 900000, N'Chuyển khoản'),
('TTDV003', 'HDDV003', '2026-08-31', 500000, N'Tiền mặt'),
('TTDV004', 'HDDV004', '2026-08-31', 300000, N'Chuyển khoản'),
('TTDV005', 'HDDV005', '2026-08-31', 400000, N'Chuyển khoản');

INSERT INTO NhanVienVanPhong (
    MaNV, MaKH, MaPhong, HoTen, HinhAnh, ChucVu, DienThoai, TrangThai
)
VALUES
('NV001', 'KH001', 'VP101', N'Nguyễn Văn Nam', N'NV001.jpg', N'Kế toán', '0902000001', N'Đang làm việc'),
('NV002', 'KH002', 'VP201', N'Trần Thị Hoa', N'NV002.jpg', N'Nhân sự', '0902000002', N'Đang làm việc'),
('NV003', 'KH003', 'VP301', N'Lê Văn Hùng', N'NV003.jpg', N'Kinh doanh', '0902000003', N'Đang làm việc'),
('NV004', 'KH004', 'VP401', N'Phạm Thị Lan', N'NV004.jpg', N'Trưởng phòng', '0902000004', N'Đang làm việc'),
('NV005', 'KH005', 'VP501', N'Võ Minh Đức', N'NV005.jpg', N'Nhân viên IT', '0902000005', N'Đang làm việc');

INSERT INTO TheGiuXe (
    MaThe, MaNV, BienSoXe, LoaiXe, HangXe, NgayCap, TrangThai
)
VALUES
('THE001', 'NV001', '59A-12345', N'Xe máy', N'Honda', '2026-01-10', N'Đang sử dụng'),
('THE002', 'NV002', '59B-23456', N'Xe máy', N'Yamaha', '2026-02-10', N'Đang sử dụng'),
('THE003', 'NV003', '59C-34567', N'Ô tô', N'Toyota', '2026-03-10', N'Đang sử dụng'),
('THE004', 'NV004', '59D-45678', N'Xe máy', N'Honda', '2026-04-10', N'Đang sử dụng'),
('THE005', 'NV005', '59E-56789', N'Ô tô', N'Hyundai', '2026-05-10', N'Đang sử dụng');

INSERT INTO PhieuKiemTra (
    MaKiemTra, MaPhong, NgayKiemTra,
    TinhTrang, KetLuan, NguoiKiemTra
)
VALUES
('KT001', 'VP101', '2026-09-01', N'Tường bị thay đổi kết cấu', N'Vi phạm quy định', N'Nguyễn Văn Hải'),
('KT002', 'VP201', '2026-09-02', N'Tự ý tháo vách ngăn', N'Vi phạm quy định', N'Trần Văn Long'),
('KT003', 'VP301', '2026-09-03', N'Thay đổi hệ thống điện', N'Vi phạm quy định', N'Lê Văn Tuấn'),
('KT004', 'VP401', '2026-09-04', N'Tự ý cải tạo trần', N'Vi phạm quy định', N'Phạm Văn Dũng'),
('KT005', 'VP501', '2026-09-05', N'Thay đổi bố trí cửa', N'Vi phạm quy định', N'Võ Văn Minh');

INSERT INTO PhieuXuPhat (
    MaPhat, MaKiemTra, NgayLap,
    LyDo, SoTienPhat, TrangThai
)
VALUES
('XP001', 'KT001', '2026-09-01', N'Tự ý thay đổi kết cấu tường', 2000000, N'Chưa xử lý'),
('XP002', 'KT002', '2026-09-02', N'Tự ý tháo vách ngăn', 1500000, N'Đã xử lý'),
('XP003', 'KT003', '2026-09-03', N'Tự ý thay đổi hệ thống điện', 3000000, N'Chưa xử lý'),
('XP004', 'KT004', '2026-09-04', N'Tự ý cải tạo trần', 2500000, N'Đã xử lý'),
('XP005', 'KT005', '2026-09-05', N'Tự ý thay đổi bố trí cửa', 2000000, N'Chưa xử lý');

COMMIT TRANSACTION;
GO

SELECT 'Tang' AS TenBang, COUNT(*) AS SoBanGhi FROM Tang
UNION ALL SELECT 'VanPhong', COUNT(*) FROM VanPhong
UNION ALL SELECT 'KhachHang', COUNT(*) FROM KhachHang
UNION ALL SELECT 'HopDongThue', COUNT(*) FROM HopDongThue
UNION ALL SELECT 'ChiTietHopDong', COUNT(*) FROM ChiTietHopDong
UNION ALL SELECT 'PhieuGiaHan', COUNT(*) FROM PhieuGiaHan
UNION ALL SELECT 'KyThanhToan', COUNT(*) FROM KyThanhToan
UNION ALL SELECT 'ThanhToanTienThue', COUNT(*) FROM ThanhToanTienThue
UNION ALL SELECT 'DichVu', COUNT(*) FROM DichVu
UNION ALL SELECT 'HoaDonDichVu', COUNT(*) FROM HoaDonDichVu
UNION ALL SELECT 'ChiTietHoaDon', COUNT(*) FROM ChiTietHoaDon
UNION ALL SELECT 'ThanhToanDichVu', COUNT(*) FROM ThanhToanDichVu
UNION ALL SELECT 'NhanVienVanPhong', COUNT(*) FROM NhanVienVanPhong
UNION ALL SELECT 'TheGiuXe', COUNT(*) FROM TheGiuXe
UNION ALL SELECT 'PhieuKiemTra', COUNT(*) FROM PhieuKiemTra
UNION ALL SELECT 'PhieuXuPhat', COUNT(*) FROM PhieuXuPhat;
GO
