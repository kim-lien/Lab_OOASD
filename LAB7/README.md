# LAB 7 – XÂY DỰNG HỆ THỐNG QUẢN LÝ NHÂN SỰ

## 1. Thông tin sinh viên

- **Họ và tên:** Nguyễn Thị Kim Liên
- **Mã số sinh viên:** 1250080097
- **Bài thực hành:** LAB 7
- **Tên bài:** Xây dựng hệ thống quản lý nhân sự
- **Tên dự án:** QuanLyNhanSu

## 2. Môi trường thực hiện

| Thành phần | Công nghệ / Phiên bản |
|---|---|
| Ngôn ngữ lập trình | C# |
| Nền tảng | .NET Framework 4.7.2 |
| Giao diện | Windows Forms (WinForms) |
| IDE | Microsoft Visual Studio |
| Cơ sở dữ liệu | Microsoft SQL Server |
| Công cụ quản lý CSDL | SQL Server Management Studio (SSMS) |
| Kết nối CSDL | ADO.NET – System.Data.SqlClient |
| Hệ điều hành | Windows |

Ứng dụng sử dụng SQL Server Authentication theo cơ chế **Windows Authentication**.

Thông tin cấu hình kết nối:

- **Server:** ADMIN
- **Database:** QuanLyNhanSu
- **Connection String Name:** QuanLyNhanSuDB

## 3. Mục tiêu bài thực hành

Xây dựng ứng dụng quản lý nhân sự bằng C# Windows Forms, kết nối cơ sở dữ liệu SQL Server nhằm quản lý thông tin nhân viên và các nghiệp vụ nhân sự trong doanh nghiệp.

Các mục tiêu chính:

- Thiết kế cơ sở dữ liệu quản lý nhân sự.
- Xây dựng giao diện quản lý bằng Windows Forms.
- Kết nối và thao tác dữ liệu với SQL Server.
- Thực hiện các chức năng thêm, sửa, xóa, tìm kiếm và hiển thị dữ liệu.
- Quản lý các nghiệp vụ tuyển dụng, hợp đồng, bảo hiểm, chấm công và tiền lương.
- Xây dựng chức năng thống kê và báo cáo.

## 4. Nội dung đã thực hiện

### 4.1. Thiết kế cơ sở dữ liệu

Đã xây dựng cơ sở dữ liệu `QuanLyNhanSu` trên SQL Server gồm **21 bảng**, phục vụ các nghiệp vụ quản lý nhân sự.

Cơ sở dữ liệu được thiết kế với khóa chính, khóa ngoại và các ràng buộc dữ liệu nhằm đảm bảo tính toàn vẹn thông tin.

### 4.2. Xây dựng giao diện Windows Forms

Ứng dụng gồm màn hình chính và các nhóm chức năng:

| STT | Nhóm chức năng | Nội dung |
|---|---|---|
| 1 | Quản lý danh mục | Phòng ban, nhân viên, chức vụ |
| 2 | Quản lý tuyển dụng | Quyết định tuyển dụng |
| 3 | Quản lý hợp đồng – bảo hiểm | Hợp đồng lao động, hồ sơ bảo hiểm |
| 4 | Quản lý lương – chức vụ | Quyết định lương, quyết định chức vụ |
| 5 | Quản lý kế hoạch – chấm công | Kế hoạch tuần, ca làm việc, phân công và chấm công |
| 6 | Quản lý phụ trội | Phiếu phụ trội, chi tiết phụ trội |
| 7 | Quản lý khen thưởng – kỷ luật | Quyết định khen thưởng, phiếu chi, quyết định kỷ luật, phiếu thu |
| 8 | Quản lý bảng lương | Bảng lương và chi tiết bảng lương |
| 9 | Thống kê – báo cáo | Thống kê nhân viên, tuyển dụng, chấm công, khen thưởng – kỷ luật và lương |

Các Form được thiết kế với các thành phần như TextBox, ComboBox, NumericUpDown, DateTimePicker, Button và DataGridView.

### 4.3. Xử lý chức năng

Các chức năng đã được xây dựng trong mã nguồn:

- **Thêm:** Nhập và lưu dữ liệu mới.
- **Sửa:** Cập nhật thông tin đã tồn tại.
- **Xóa:** Xóa dữ liệu sau khi xác nhận.
- **Tìm kiếm:** Tra cứu theo mã hoặc thông tin liên quan.
- **Hiển thị:** Đưa dữ liệu từ SQL Server lên DataGridView.
- **Kiểm tra dữ liệu:** Kiểm tra trường bắt buộc, giá trị hợp lệ và dữ liệu trùng lặp.
- **Thống kê:** Tổng hợp dữ liệu nhân sự theo các tiêu chí lựa chọn.
- **Xuất báo cáo:** Xuất kết quả thống kê ra định dạng CSV.

### 4.4. Cấu trúc chương trình

Dự án được tổ chức theo mô hình phân chia trách nhiệm:

- **Forms:** Hiển thị giao diện và xử lý tương tác người dùng.
- **Services:** Xử lý nghiệp vụ và các truy vấn dữ liệu.
- **Data:** Quản lý kết nối SQL Server thông qua lớp `Db.cs`.
- **Database:** Lưu trữ tập lệnh SQL tạo cơ sở dữ liệu.
- **App.config:** Lưu thông tin cấu hình kết nối.

Cách tổ chức này giúp mã nguồn dễ quản lý, bảo trì và mở rộng.

## 5. Kết quả thực hiện

Đã xây dựng mã nguồn cho hệ thống quản lý nhân sự bằng C# WinForms, kết nối với cơ sở dữ liệu SQL Server.

Các kết quả chính:

- Thiết kế cơ sở dữ liệu gồm 21 bảng có liên kết.
- Xây dựng giao diện cho các nhóm nghiệp vụ nhân sự.
- Triển khai các thao tác CRUD thông qua ADO.NET.
- Bổ sung kiểm tra dữ liệu đầu vào.
- Xây dựng chức năng tìm kiếm và thống kê.
- Bổ sung chức năng xuất báo cáo CSV.

**Lưu ý:** Các chức năng cần được kiểm thử trực tiếp trên máy chạy chương trình để xác nhận hoạt động đầy đủ.

## 6. Lỗi gặp phải và cách khắc phục

### 6.1. Lỗi CS0165 – Use of unassigned local variable

**Hiện tượng:** Visual Studio báo lỗi các biến `phuCap` và `docHai` chưa được gán giá trị trong `FrmQuyetDinhLuong.cs`.

**Nguyên nhân:** Biến được sử dụng trong phép tính khi trình biên dịch chưa xác định chắc chắn đã được khởi tạo.

**Cách khắc phục:** Khởi tạo giá trị ban đầu cho các biến trước khi sử dụng.

```csharp
decimal luong = 0;
decimal phuCap = 0;
decimal docHai = 0;
```

### 6.2. Lỗi trùng tên file Form

**Hiện tượng:** Visual Studio thông báo file `FrmPhieuChiKhenThuong.cs` đã tồn tại.

**Nguyên nhân:** Tạo thêm Windows Form có tên trùng với file hiện có trong dự án.

**Cách khắc phục:** Kiểm tra Solution Explorer, sử dụng chức năng Show All Files và mở file đã tồn tại để chỉnh sửa thay vì tạo file mới.

### 6.3. Form mở lên nhưng không hiển thị nội dung

**Hiện tượng:** `FrmBangLuongThongKe` mở thành công nhưng giao diện trống.

**Nguyên nhân:** Form chưa được thiết kế đầy đủ hoặc chưa khai báo các Control trong `InitializeComponent()`.

**Cách khắc phục:** Bổ sung mã giao diện trong file `.Designer.cs`, khai báo các nút điều hướng và gán sự kiện Click tương ứng.

### 6.4. Lỗi ràng buộc dữ liệu SQL Server

**Nguyên nhân:** Dữ liệu có thể không đáp ứng khóa chính, khóa ngoại hoặc điều kiện kiểm tra của bảng.

**Cách khắc phục:**

- Kiểm tra mã dữ liệu trước khi thêm.
- Chọn các bản ghi liên quan đã tồn tại.
- Kiểm tra giá trị số và ngày tháng.
- Xử lý ngoại lệ bằng `try-catch`.
- Hiển thị thông báo lỗi để người dùng điều chỉnh dữ liệu.

## 7. Hướng dẫn cài đặt và chạy chương trình

### Bước 1. Chuẩn bị môi trường

Máy tính cần có:

1. Microsoft Visual Studio hỗ trợ C# Windows Forms.
2. .NET Framework 4.7.2 Developer Pack.
3. Microsoft SQL Server.
4. SQL Server Management Studio.

### Bước 2. Khởi tạo cơ sở dữ liệu

1. Mở SQL Server Management Studio.
2. Kết nối đến SQL Server bằng Windows Authentication.
3. Mở file SQL trong thư mục `Database`.
4. Thực thi tập lệnh bằng nút **Execute**.
5. Kiểm tra cơ sở dữ liệu `QuanLyNhanSu` đã được tạo.

Có thể sử dụng câu lệnh:

```sql
USE QuanLyNhanSu;

SELECT COUNT(*) AS TongSoBang
FROM INFORMATION_SCHEMA.TABLES
WHERE TABLE_TYPE = 'BASE TABLE';
```

Kết quả mong đợi: **21 bảng**.

### Bước 3. Cấu hình kết nối

Mở file `App.config` trong dự án và kiểm tra cấu hình:

```xml
<connectionStrings>
  <add name="QuanLyNhanSuDB"
       connectionString="Data Source=ADMIN;Initial Catalog=QuanLyNhanSu;Integrated Security=True;TrustServerCertificate=True"
       providerName="System.Data.SqlClient" />
</connectionStrings>
```

Nếu giảng viên sử dụng máy có tên SQL Server khác, thay `ADMIN` bằng tên máy chủ hoặc SQL Server instance tương ứng.

Tài khoản Windows đang chạy ứng dụng phải được cấp quyền truy cập cơ sở dữ liệu.

### Bước 4. Mở dự án

1. Mở Microsoft Visual Studio.
2. Chọn **File → Open → Project/Solution**.
3. Chọn file Solution `.sln` của dự án.
4. Kiểm tra các thư mục `Forms`, `Services`, `Data` và `Database`.

### Bước 5. Biên dịch chương trình

1. Chọn **Build → Rebuild Solution**.
2. Kiểm tra danh sách lỗi trong **Error List**.
3. Đảm bảo chương trình không còn lỗi biên dịch trước khi chạy.

### Bước 6. Chạy ứng dụng

1. Nhấn **F5** hoặc chọn **Start**.
2. Màn hình chính `FrmMain` xuất hiện.
3. Chọn nhóm chức năng cần kiểm tra.
4. Thực hiện các thao tác thêm, sửa, xóa và tìm kiếm.

### Bước 7. Kiểm tra chức năng thống kê

1. Mở chức năng **Thống kê – Báo cáo**.
2. Chọn nhóm thống kê.
3. Chọn tháng, năm và phòng ban nếu cần.
4. Nhấn **Thống kê** để hiển thị kết quả.
5. Nhấn **Xuất báo cáo** để lưu dữ liệu thành file CSV.

## 8. Hướng dẫn kiểm thử dành cho giảng viên

Giảng viên có thể kiểm tra theo trình tự:

1. **Kết nối database:** Xác nhận chương trình truy cập được SQL Server.
2. **Quản lý danh mục:** Thêm phòng ban, nhân viên và chức vụ.
3. **Quản lý nghiệp vụ:** Thử thêm, sửa, xóa các quyết định và hồ sơ liên quan.
4. **Quản lý chấm công:** Tạo dữ liệu chấm công và xem danh sách.
5. **Quản lý tiền lương:** Tạo bảng lương, nhập chi tiết và kiểm tra tổng tiền.
6. **Thống kê – Báo cáo:** Chọn tiêu chí, xem dữ liệu và xuất CSV.

Khi kiểm thử chức năng thêm dữ liệu, cần nhập đúng mã khóa ngoại đã tồn tại trong cơ sở dữ liệu.
