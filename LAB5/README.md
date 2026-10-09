# Quản lý công ty du lịch

# Thông tin sinh viên
Họ và tên: Nguyễn Thị Kim Liên
MSSV: 1250080097
Tên bài Lab: LAB 3 – Quản lý công ty du lịch
## Công nghệ
- C# Windows Forms, .NET Framework 4.7.2
- SQL Server / LocalDB
- ADO.NET (`System.Data.SqlClient`)

## Chạy dự án bằng VS Code
1. Cài Visual Studio Build Tools với workload .NET desktop build tools hoặc Visual Studio có hỗ trợ .NET Framework 4.7.2.
2. Cài extension SQL Server (mssql) trong VS Code.
3. Mở SQL Server/LocalDB và chạy `Database/QuanLyCongTyDuLich.sql`.
4. Nếu dùng SQL Server instance khác, sửa `Data Source` trong `App.config`.
5. Mở thư mục chứa `QuanLyCongTyDuLich.sln` trong VS Code.
6. Build bằng MSBuild:
   `msbuild QuanLyCongTyDuLich.sln /p:Configuration=Debug`
7. Chạy `bin/Debug/QuanLyCongTyDuLich.exe`.

## Các Form
- FrmMain: menu chức năng và kiểm tra kết nối SQL.
- FrmDanhMuc: xem/thêm/xóa phương tiện, điểm bán vé, hướng dẫn viên, điểm tham quan.
- FrmTour: CRUD tour.
- FrmChuyenLe: xem/thêm/xóa chuyến khách lẻ.
- FrmDangKyLe: đăng ký khách lẻ và thanh toán ngay.
- FrmDangKyDoan: đăng ký đoàn khách, đặt cọc.
- FrmPhanCongHDV: phân công hướng dẫn viên, kiểm tra trùng lịch.
- FrmKetThucKhaoSat: lưu khảo sát.
- FrmLuongThongKe: lương hướng dẫn viên, doanh thu và tour.

## Lưu ý
- Script SQL có lệnh DROP TABLE để tạo lại cấu trúc; sao lưu dữ liệu trước khi chạy lại.
- Bài toán nguồn không quy định cách xử lý đúng 12 khách. Script đang áp dụng khách lẻ 1-11, khách đoàn trên 12.
- Đây là bộ khung dự án đầy đủ về solution, forms, services và kết nối; cần chạy kiểm thử trong môi trường SQL Server thực tế trước khi nộp.
