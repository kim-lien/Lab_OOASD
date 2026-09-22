CREATE DATABASE QuanLyThuVien;
GO
USE QuanLyThuVien;
GO

-- 1. Bảng Nhân viên
CREATE TABLE NHANVIEN (
    MaNhanVien VARCHAR(20) PRIMARY KEY,
    Ho NVARCHAR(50),
    Ten NVARCHAR(50),
    Phai NVARCHAR(10),
    NgaySinh DATE,
    ChucVu NVARCHAR(50),
    SoDienThoai VARCHAR(15)
);

-- 2. Bảng Độc giả
CREATE TABLE DOCGIA (
    MaDocGia VARCHAR(20) PRIMARY KEY,
    Ho NVARCHAR(50),
    Ten NVARCHAR(50),
    NgaySinh DATE,
    Phai NVARCHAR(10),
    SoDienThoai VARCHAR(15),
    DiaChi NVARCHAR(200),
    Email VARCHAR(100),
    Anh3x4 VARCHAR(255)
);

-- 3. Bảng Thẻ độc giả
CREATE TABLE THEDOCGIA (
    MaThe VARCHAR(20) PRIMARY KEY,
    MaDocGia VARCHAR(20),
    NgayCap DATE,
    HanSuDung DATE,
    DaDongLePhi BIT,
    TrangThai NVARCHAR(50),
    CONSTRAINT FK_TheDocGia_DocGia FOREIGN KEY (MaDocGia) REFERENCES DOCGIA(MaDocGia)
);

-- 4. Bảng Nhà xuất bản
CREATE TABLE NHAXUATBAN (
    MaNhaXuatBan VARCHAR(20) PRIMARY KEY,
    DiaChi NVARCHAR(200),
    SoDienThoai VARCHAR(15)
);

-- 5. Bảng Thể loại
CREATE TABLE THELOAI (
    MaTheLoai VARCHAR(20) PRIMARY KEY,
    TenTheLoai NVARCHAR(100)
);

-- 6. Bảng Đầu sách
CREATE TABLE DAUSACH (
    MaDauSach VARCHAR(20) PRIMARY KEY,
    TenSach NVARCHAR(200),
    NamXuatBan INT,
    SoLuongHienCo INT,
    MaTheLoai VARCHAR(20),
    MaNhaXuatBan VARCHAR(20),
    CONSTRAINT FK_DauSach_TheLoai FOREIGN KEY (MaTheLoai) REFERENCES THELOAI(MaTheLoai),
    CONSTRAINT FK_DauSach_NXB FOREIGN KEY (MaNhaXuatBan) REFERENCES NHAXUATBAN(MaNhaXuatBan)
);

-- 7. Bảng Phiếu mượn
CREATE TABLE PHIEUMUON (
    MaPhieuMuon VARCHAR(20) PRIMARY KEY,
    MaDocGia VARCHAR(20),
    MaNhanVien VARCHAR(20),
    NgayMuon DATE,
    NgayHenTra DATE,
    CONSTRAINT FK_PhieuMuon_DocGia FOREIGN KEY (MaDocGia) REFERENCES DOCGIA(MaDocGia),
    CONSTRAINT FK_PhieuMuon_NhanVien FOREIGN KEY (MaNhanVien) REFERENCES NHANVIEN(MaNhanVien)
);

-- 8. Bảng Chi tiết phiếu mượn
CREATE TABLE CHITIETPHIEUMUON (
    MaChiTiet VARCHAR(20) PRIMARY KEY,
    MaPhieuMuon VARCHAR(20),
    MaDauSach VARCHAR(20),
    NgayTraThucTe DATE,
    TinhTrangTra NVARCHAR(100),
    CONSTRAINT UQ_PhieuMuon_DauSach UNIQUE (MaPhieuMuon, MaDauSach),
    CONSTRAINT FK_CTPM_PhieuMuon FOREIGN KEY (MaPhieuMuon) REFERENCES PHIEUMUON(MaPhieuMuon),
    CONSTRAINT FK_CTPM_DauSach FOREIGN KEY (MaDauSach) REFERENCES DAUSACH(MaDauSach)
);

-- 9. Bảng Phiếu phạt
CREATE TABLE PHIEUPHAT (
    MaPhieuPhat VARCHAR(20) PRIMARY KEY,
    MaChiTiet VARCHAR(20),
    MaNhanVien VARCHAR(20),
    NgayPhat DATE,
    LyDo NVARCHAR(200),
    PhiPhat DECIMAL(18,2),
    CONSTRAINT FK_PhieuPhat_CTPM FOREIGN KEY (MaChiTiet) REFERENCES CHITIETPHIEUMUON(MaChiTiet),
    CONSTRAINT FK_PhieuPhat_NhanVien FOREIGN KEY (MaNhanVien) REFERENCES NHANVIEN(MaNhanVien)
);

USE QuanLyThuVien;
GO

DELETE FROM PHIEUPHAT;
DELETE FROM CHITIETPHIEUMUON;
DELETE FROM PHIEUMUON;
DELETE FROM THEDOCGIA;
DELETE FROM DAUSACH;
DELETE FROM THELOAI;
DELETE FROM NHAXUATBAN;
DELETE FROM DOCGIA;
DELETE FROM NHANVIEN;
GO

INSERT INTO NHANVIEN
(
    MaNhanVien,
    Ho,
    Ten,
    Phai,
    NgaySinh,
    ChucVu,
    SoDienThoai
)
VALUES
('NV001', N'Nguyễn Minh', N'Khôi', N'Nam', '1998-04-12', N'Thủ thư', '0903123456'),
('NV002', N'Trần Thị', N'Ngọc Anh', N'Nữ', '1999-08-25', N'Thủ thư', '0918234567'),
('NV003', N'Lê Quốc', N'Bảo', N'Nam', '1997-11-03', N'Nhân viên thư viện', '0987345678'),
('NV004', N'Phạm Thùy', N'Dương', N'Nữ', '2000-02-18', N'Nhân viên thư viện', '0938456789'),
('NV005', N'Võ Hoàng', N'Nam', N'Nam', '1996-06-30', N'Thủ thư', '0979567890');
GO

INSERT INTO DOCGIA
(
    MaDocGia,
    Ho,
    Ten,
    NgaySinh,
    Phai,
    SoDienThoai,
    DiaChi,
    Email,
    Anh3x4
)
VALUES
(
    'DG001',
    N'Nguyễn Văn',
    N'Minh',
    '2002-05-14',
    N'Nam',
    '0905123456',
    N'25 Nguyễn Thị Minh Khai, Phường Bến Nghé, Quận 1, TP. Hồ Chí Minh',
    'nguyenminh.dg001@gmail.com',
    'DG001.jpg'
),
(
    'DG002',
    N'Trần Thị',
    N'Lan',
    '2001-09-21',
    N'Nữ',
    '0916234567',
    N'118 Lê Văn Sỹ, Phường 10, Quận Phú Nhuận, TP. Hồ Chí Minh',
    'tranlan.dg002@gmail.com',
    'DG002.jpg'
),
(
    'DG003',
    N'Lê Hoàng',
    N'Nam',
    '2003-01-08',
    N'Nam',
    '0987345123',
    N'56 Võ Văn Ngân, Phường Bình Thọ, TP. Thủ Đức, TP. Hồ Chí Minh',
    'lehoangnam.dg003@gmail.com',
    'DG003.jpg'
),
(
    'DG004',
    N'Phạm Ngọc',
    N'Hân',
    '2002-12-17',
    N'Nữ',
    '0938456123',
    N'82 Nguyễn Trãi, Phường Bến Thành, Quận 1, TP. Hồ Chí Minh',
    'phamngochan.dg004@gmail.com',
    'DG004.jpg'
),
(
    'DG005',
    N'Võ Minh',
    N'Thư',
    '2004-03-26',
    N'Nữ',
    '0979567123',
    N'15 Phan Văn Trị, Phường 14, Quận Bình Thạnh, TP. Hồ Chí Minh',
    'vominhthu.dg005@gmail.com',
    'DG005.jpg'
);
GO

INSERT INTO THEDOCGIA
(
    MaThe,
    MaDocGia,
    NgayCap,
    HanSuDung,
    DaDongLePhi,
    TrangThai
)
VALUES
(
    'THE001',
    'DG001',
    '2026-01-10',
    '2027-01-10',
    1,
    N'Đang hoạt động'
),
(
    'THE002',
    'DG002',
    '2026-02-15',
    '2027-02-15',
    1,
    N'Đang hoạt động'
),
(
    'THE003',
    'DG003',
    '2026-03-05',
    '2027-03-05',
    1,
    N'Đang hoạt động'
),
(
    'THE004',
    'DG004',
    '2026-04-20',
    '2027-04-20',
    1,
    N'Đang hoạt động'
),
(
    'THE005',
    'DG005',
    '2026-05-12',
    '2027-05-12',
    1,
    N'Đang hoạt động'
);
GO

INSERT INTO NHAXUATBAN
(
    MaNhaXuatBan,
    DiaChi,
    SoDienThoai
)
VALUES
(
    'NXB001',
    N'55 Quang Trung, Phường Nguyễn Du, Quận Hai Bà Trưng, Hà Nội',
    '02439434730'
),
(
    'NXB002',
    N'161B Lý Chính Thắng, Phường Võ Thị Sáu, Quận 3, TP. Hồ Chí Minh',
    '02838468068'
),
(
    'NXB003',
    N'81 Trần Hưng Đạo, Phường Trần Hưng Đạo, Quận Hoàn Kiếm, Hà Nội',
    '02438220808'
),
(
    'NXB004',
    N'18 Nguyễn Trường Tộ, Phường Tân Thành, Quận Tân Phú, TP. Hồ Chí Minh',
    '02838130010'
),
(
    'NXB005',
    N'175 Giảng Võ, Phường Cát Linh, Quận Đống Đa, Hà Nội',
    '02438515241'
);
GO

INSERT INTO THELOAI
(
    MaTheLoai,
    TenTheLoai
)
VALUES
('TL001', N'Kỹ năng sống'),
('TL002', N'Tiểu thuyết'),
('TL003', N'Văn học Việt Nam'),
('TL004', N'Khoa học và Công nghệ'),
('TL005', N'Giáo dục');
GO

INSERT INTO DAUSACH
(
    MaDauSach,
    TenSach,
    NamXuatBan,
    SoLuongHienCo,
    MaTheLoai,
    MaNhaXuatBan
)
VALUES
(
    'S001',
    N'Đắc Nhân Tâm',
    2024,
    12,
    'TL001',
    'NXB002'
),
(
    'S002',
    N'Nhà Giả Kim',
    2023,
    10,
    'TL002',
    'NXB004'
),
(
    'S003',
    N'Dế Mèn Phiêu Lưu Ký',
    2022,
    15,
    'TL003',
    'NXB001'
),
(
    'S004',
    N'Tuổi Trẻ Đáng Giá Bao Nhiêu',
    2024,
    8,
    'TL001',
    'NXB002'
),
(
    'S005',
    N'Tôi Tài Giỏi, Bạn Cũng Thế',
    2023,
    9,
    'TL005',
    'NXB005'
);
GO

INSERT INTO PHIEUMUON
(
    MaPhieuMuon,
    MaDocGia,
    MaNhanVien,
    NgayMuon,
    NgayHenTra
)
VALUES
(
    'PM260901001',
    'DG001',
    'NV001',
    '2026-09-01',
    '2026-09-08'
),
(
    'PM260902002',
    'DG002',
    'NV002',
    '2026-09-02',
    '2026-09-09'
),
(
    'PM260903003',
    'DG003',
    'NV003',
    '2026-09-03',
    '2026-09-10'
),
(
    'PM260904004',
    'DG004',
    'NV004',
    '2026-09-04',
    '2026-09-11'
),
(
    'PM260905005',
    'DG005',
    'NV005',
    '2026-09-05',
    '2026-09-12'
);
GO

INSERT INTO CHITIETPHIEUMUON
(
    MaChiTiet,
    MaPhieuMuon,
    MaDauSach,
    NgayTraThucTe,
    TinhTrangTra
)
VALUES
(
    'CT260901001',
    'PM260901001',
    'S001',
    '2026-09-08',
    N'Bình thường'
),
(
    'CT260902002',
    'PM260902002',
    'S002',
    '2026-09-12',
    N'Bình thường'
),
(
    'CT260903003',
    'PM260903003',
    'S003',
    '2026-09-14',
    N'Rách/Hư hỏng'
),
(
    'CT260904004',
    'PM260904004',
    'S004',
    '2026-09-16',
    N'Mất'
),
(
    'CT260905005',
    'PM260905005',
    'S005',
    '2026-09-15',
    N'Rách/Hư hỏng'
);
GO

INSERT INTO PHIEUPHAT
(
    MaPhieuPhat,
    MaChiTiet,
    MaNhanVien,
    NgayPhat,
    LyDo,
    PhiPhat
)
VALUES
(
    'PP260905001',
    'CT260902002',
    'NV002',
    '2026-09-12',
    N'Trả sách quá hạn',
    20000
),
(
    'PP260906002',
    'CT260903003',
    'NV003',
    '2026-09-14',
    N'Sách bị rách và hư hỏng',
    50000
),
(
    'PP260907003',
    'CT260904004',
    'NV004',
    '2026-09-16',
    N'Mất sách',
    150000
),
(
    'PP260908004',
    'CT260905005',
    'NV005',
    '2026-09-15',
    N'Sách bị hư hỏng',
    40000
),
(
    'PP260909005',
    'CT260901001',
    'NV001',
    '2026-09-08',
    N'Bìa sách bị hư hỏng',
    30000
);
GO
