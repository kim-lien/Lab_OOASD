# Quản lý hồ sơ bệnh án — Lab 6

# Thông tin sinh viên
Họ và tên: Nguyễn Thị Kim Liên
MSSV: 1250080097
Tên bài Lab: # Lab 6 - Quản lý hồ sơ bệnh án
## Công nghệ
- C# Windows Forms, .NET Framework 4.7.2
- SQL Server / LocalDB
- ADO.NET (`System.Data.SqlClient`)

## Cấu trúc
- `QuanLyHoSoBenhAn.sln`, `QuanLyHoSoBenhAn.csproj`: Solution và Project
- `App.config`: Chuỗi kết nối SQL Server
- `Database/QuanLyBenhAn.sql`: Script tạo CSDL 13 bảng
- `Data/Db.cs`: Truy cập dữ liệu có tham số
- `Forms/MainForm.cs` + `.Designer.cs`: Giao diện WinForms
- `Forms/GenericTableForm.cs`: Giao diện thêm/sửa/xóa các bảng phụ
- `Services/BenhAnService.cs`: Truy vấn tra cứu tái sử dụng
- `Program.cs`: Khởi động chương trình

## Cách chạy
1. Cài workload **.NET desktop development** (Visual Studio 2022) và .NET 8 SDK.
2. Trong SSMS, mở và chạy `Database/QuanLyBenhAn.sql`.
3. Mở `QuanLyHoSoBenhAn.sln`.
4. Chỉnh `Data Source` trong `App.config` cho đúng máy SQL Server của bạn.
5. Restore NuGet packages và nhấn F5.

**Chú ý**: `.vs`, `bin`, `obj` sẽ được Visual Studio tự sinh, không đóng gói. `MainForm.Designer.cs` cung cấp phần khởi tạo giao diện chuẩn; các điều khiển nghiệp vụ được tạo bằng C# trong các hàm `Build...`, nên khi mở Designer sẽ không hiện đầy đủ giao diện chạy thực tế. Để kéo thả chỉnh từng điều khiển trong Designer cần chuyển các điều khiển đó vào `InitializeComponent`.

## Kết quả và phạm vi hoàn thành
- Đã xây dựng báo cáo phân tích nghiệp vụ, Class Diagram, Use Case Diagram, Activity Diagram và Sequence Diagram theo nội dung bài thực hành.
- Đã có mã nguồn giao diện WinForms và kết nối dữ liệu qua lớp Db; báo cáo minh họa giao diện bệnh nhân, phiếu khám, toa thuốc, khoa, bác sĩ, đăng ký khám, lệ phí, hồ sơ, xét nghiệm, thuốc, lịch định kỳ và viện phí.
Các quy tắc nghiệp vụ phức tạp (thu lệ phí trước khi cấp hồ sơ; chống trùng lịch khám trong quý; chỉ hoàn tất điều trị sau thanh toán; transaction khi ghi nhiều bảng) phải được kiểm tra trực tiếp bằng script, stored procedure hoặc mã ứng dụng trên máy chấm.
