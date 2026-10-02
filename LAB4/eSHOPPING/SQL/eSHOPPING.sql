IF DB_ID(N'eSHOPPING') IS NULL
    CREATE DATABASE eSHOPPING;
GO
USE eSHOPPING;
GO

IF OBJECT_ID('dbo.ChiTietDonHang','U') IS NOT NULL DROP TABLE dbo.ChiTietDonHang;
IF OBJECT_ID('dbo.ThanhToan','U') IS NOT NULL DROP TABLE dbo.ThanhToan;
IF OBJECT_ID('dbo.DonHang','U') IS NOT NULL DROP TABLE dbo.DonHang;
IF OBJECT_ID('dbo.ChiTietGioHang','U') IS NOT NULL DROP TABLE dbo.ChiTietGioHang;
IF OBJECT_ID('dbo.GioHang','U') IS NOT NULL DROP TABLE dbo.GioHang;
IF OBJECT_ID('dbo.SanPham','U') IS NOT NULL DROP TABLE dbo.SanPham;
IF OBJECT_ID('dbo.NhomSanPham','U') IS NOT NULL DROP TABLE dbo.NhomSanPham;
IF OBJECT_ID('dbo.KhachHang','U') IS NOT NULL DROP TABLE dbo.KhachHang;
GO

CREATE TABLE KhachHang
(
    MaKH INT IDENTITY(1,1) PRIMARY KEY,
    HoTen NVARCHAR(150) NOT NULL,
    NgaySinh DATE NULL,
    CMNDPassport NVARCHAR(50) NULL,
    DiaChi NVARCHAR(300) NOT NULL,
    DienThoai VARCHAR(20) NOT NULL,
    TenDangNhap VARCHAR(50) NOT NULL UNIQUE,
    MatKhau NVARCHAR(200) NOT NULL,
    Email VARCHAR(150) NULL
);

CREATE TABLE NhomSanPham
(
    MaNhom INT IDENTITY(1,1) PRIMARY KEY,
    TenNhom NVARCHAR(100) NOT NULL UNIQUE
);

CREATE TABLE SanPham
(
    MaSP INT IDENTITY(1,1) PRIMARY KEY,
    TenSP NVARCHAR(200) NOT NULL,
    NhaSanXuat NVARCHAR(150) NULL,
    HinhAnh NVARCHAR(500) NULL,
    MoTa NVARCHAR(MAX) NULL,
    ThongSoKyThuat NVARCHAR(MAX) NULL,
    GiaBan DECIMAL(18,2) NOT NULL CHECK (GiaBan >= 0),
    TonKho INT NOT NULL CHECK (TonKho >= 0),
    MaNhom INT NOT NULL,
    CONSTRAINT FK_SanPham_Nhom FOREIGN KEY(MaNhom) REFERENCES NhomSanPham(MaNhom)
);

CREATE TABLE GioHang
(
    MaGioHang INT IDENTITY(1,1) PRIMARY KEY,
    MaKH INT NOT NULL,
    NgayTao DATETIME NOT NULL DEFAULT GETDATE(),
    CONSTRAINT FK_GioHang_KhachHang FOREIGN KEY(MaKH) REFERENCES KhachHang(MaKH)
);

CREATE TABLE ChiTietGioHang
(
    MaGioHang INT NOT NULL,
    MaSP INT NOT NULL,
    SoLuong INT NOT NULL CHECK (SoLuong > 0),
    PRIMARY KEY(MaGioHang, MaSP),
    CONSTRAINT FK_CTGioHang_GioHang FOREIGN KEY(MaGioHang) REFERENCES GioHang(MaGioHang),
    CONSTRAINT FK_CTGioHang_SanPham FOREIGN KEY(MaSP) REFERENCES SanPham(MaSP)
);

CREATE TABLE DonHang
(
    MaDonHang INT IDENTITY(1,1) PRIMARY KEY,
    MaKH INT NOT NULL,
    HoTenNguoiNhan NVARCHAR(150) NOT NULL,
    DiaChiNguoiNhan NVARCHAR(300) NOT NULL,
    DienThoaiNguoiNhan VARCHAR(20) NOT NULL,
    LoaiGiaoHang NVARCHAR(100) NOT NULL,
    KhuVuc NVARCHAR(100) NOT NULL,
    PhiGiaoHang DECIMAL(18,2) NOT NULL,
    TongTienHang DECIMAL(18,2) NOT NULL,
    TongThanhToan DECIMAL(18,2) NOT NULL,
    TrangThai NVARCHAR(50) NOT NULL,
    ThoiGianDat DATETIME NOT NULL,
    CONSTRAINT FK_DonHang_KhachHang FOREIGN KEY(MaKH) REFERENCES KhachHang(MaKH)
);

CREATE TABLE ChiTietDonHang
(
    MaCTDH INT IDENTITY(1,1) PRIMARY KEY,
    MaDonHang INT NOT NULL,
    MaSP INT NOT NULL,
    SoLuong INT NOT NULL CHECK (SoLuong > 0),
    DonGia DECIMAL(18,2) NOT NULL CHECK (DonGia >= 0),
    CONSTRAINT FK_CTDH_DonHang FOREIGN KEY(MaDonHang) REFERENCES DonHang(MaDonHang),
    CONSTRAINT FK_CTDH_SanPham FOREIGN KEY(MaSP) REFERENCES SanPham(MaSP)
);

CREATE TABLE ThanhToan
(
    MaThanhToan INT IDENTITY(1,1) PRIMARY KEY,
    MaDonHang INT NOT NULL,
    LoaiThe NVARCHAR(50) NOT NULL,
    SoTheMasked VARCHAR(30) NOT NULL,
    MaGiaoDich VARCHAR(100) NOT NULL,
    TrangThai NVARCHAR(50) NOT NULL,
    ThoiGianThanhToan DATETIME NOT NULL,
    CONSTRAINT FK_ThanhToan_DonHang FOREIGN KEY(MaDonHang) REFERENCES DonHang(MaDonHang)
);
GO

INSERT INTO NhomSanPham (TenNhom)
VALUES
(N'Máy ảnh kỹ thuật số'),
(N'Điện thoại di động'),
(N'Laptop'),
(N'Thiết bị điện gia dụng'),
(N'Phụ kiện máy tính');
GO

INSERT INTO SanPham
(
    TenSP,
    NhaSanXuat,
    HinhAnh,
    MoTa,
    ThongSoKyThuat,
    GiaBan,
    TonKho,
    MaNhom
)
SELECT
    N'Canon EOS R50',
    N'Canon',
    N'canon-eos-r50.jpg',
    N'Máy ảnh mirrorless nhỏ gọn dành cho chụp ảnh và quay video.',
    N'APS-C; 24.2MP; 4K',
    18990000,
    12,
    MaNhom
FROM NhomSanPham
WHERE TenNhom = N'Máy ảnh kỹ thuật số';

INSERT INTO SanPham
(
    TenSP,
    NhaSanXuat,
    HinhAnh,
    MoTa,
    ThongSoKyThuat,
    GiaBan,
    TonKho,
    MaNhom
)
SELECT
    N'iPhone 16',
    N'Apple',
    N'iphone-16.jpg',
    N'Điện thoại thông minh Apple iPhone 16.',
    N'A18; 128GB; OLED 6.1 inch',
    21990000,
    15,
    MaNhom
FROM NhomSanPham
WHERE TenNhom = N'Điện thoại di động';

INSERT INTO SanPham
(
    TenSP,
    NhaSanXuat,
    HinhAnh,
    MoTa,
    ThongSoKyThuat,
    GiaBan,
    TonKho,
    MaNhom
)
SELECT
    N'ASUS Vivobook 15 X1504VA',
    N'ASUS',
    N'asus-vivobook-15.jpg',
    N'Laptop phục vụ học tập và công việc văn phòng.',
    N'Intel Core i5; RAM 16GB; SSD 512GB',
    16990000,
    8,
    MaNhom
FROM NhomSanPham
WHERE TenNhom = N'Laptop';

INSERT INTO SanPham
(
    TenSP,
    NhaSanXuat,
    HinhAnh,
    MoTa,
    ThongSoKyThuat,
    GiaBan,
    TonKho,
    MaNhom
)
SELECT
    N'Nồi chiên không dầu Philips HD9252/90',
    N'Philips',
    N'philips-hd9252.jpg',
    N'Nồi chiên không dầu sử dụng công nghệ Rapid Air.',
    N'Dung tích 4.1L; Công suất 1400W',
    2490000,
    18,
    MaNhom
FROM NhomSanPham
WHERE TenNhom = N'Thiết bị điện gia dụng';

INSERT INTO SanPham
(
    TenSP,
    NhaSanXuat,
    HinhAnh,
    MoTa,
    ThongSoKyThuat,
    GiaBan,
    TonKho,
    MaNhom
)
SELECT
    N'Logitech MX Master 3S',
    N'Logitech',
    N'logitech-mx-master-3s.jpg',
    N'Chuột không dây cao cấp dành cho văn phòng.',
    N'8000 DPI; Bluetooth; Logi Bolt',
    1990000,
    20,
    MaNhom
FROM NhomSanPham
WHERE TenNhom = N'Phụ kiện máy tính';
GO

INSERT INTO KhachHang
(
    HoTen,
    NgaySinh,
    CMNDPassport,
    DiaChi,
    DienThoai,
    TenDangNhap,
    MatKhau,
    Email
)
VALUES
(
    N'Nguyễn Minh Anh',
    '2002-05-14',
    N'079202001234',
    N'Quận 1, Thành phố Hồ Chí Minh',
    '0903123456',
    'minhanh',
    N'123456',
    'minhanh@gmail.com'
);

INSERT INTO KhachHang
(
    HoTen,
    NgaySinh,
    CMNDPassport,
    DiaChi,
    DienThoai,
    TenDangNhap,
    MatKhau,
    Email
)
VALUES
(
    N'Trần Hoàng Nam',
    '2001-11-22',
    N'079201005678',
    N'Quận Bình Thạnh, Thành phố Hồ Chí Minh',
    '0912345678',
    'hoangnam',
    N'123456',
    'hoangnam@gmail.com'
);

INSERT INTO KhachHang
(
    HoTen,
    NgaySinh,
    CMNDPassport,
    DiaChi,
    DienThoai,
    TenDangNhap,
    MatKhau,
    Email
)
VALUES
(
    N'Lê Ngọc Hân',
    '2003-03-08',
    N'079203009876',
    N'Thành phố Thủ Đức, Thành phố Hồ Chí Minh',
    '0987654321',
    'ngochan',
    N'123456',
    'ngochan@gmail.com'
);

INSERT INTO KhachHang
(
    HoTen,
    NgaySinh,
    CMNDPassport,
    DiaChi,
    DienThoai,
    TenDangNhap,
    MatKhau,
    Email
)
VALUES
(
    N'Phạm Quốc Huy',
    '2002-09-17',
    N'079202004321',
    N'Quận Tân Bình, Thành phố Hồ Chí Minh',
    '0934567890',
    'quochuy',
    N'123456',
    'quochuy@gmail.com'
);

INSERT INTO KhachHang
(
    HoTen,
    NgaySinh,
    CMNDPassport,
    DiaChi,
    DienThoai,
    TenDangNhap,
    MatKhau,
    Email
)
VALUES
(
    N'Võ Thùy Linh',
    '2003-12-01',
    N'079203001122',
    N'Quận Gò Vấp, Thành phố Hồ Chí Minh',
    '0978123456',
    'thuylinh',
    N'123456',
    'thuylinh@gmail.com'
);
GO

SELECT MaNhom, TenNhom
FROM NhomSanPham;

SELECT MaSP, TenSP, NhaSanXuat, GiaBan, TonKho, MaNhom
FROM SanPham;

SELECT MaKH, HoTen, DiaChi, DienThoai, TenDangNhap, Email
FROM KhachHang;