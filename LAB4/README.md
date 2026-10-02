# LAB4 

## 1. Thông tin sinh viên

- Họ tên: Nguyễn Thị Kim Liên
- MSSV: 1250080097
- Tên bài Lab: LAB4 - Hệ thống phần mềm cửa hàng online e-SHOPPING

## 2. Môi trường thực hiện

- Hệ điều hành: Windows
- IDE: Visual Studio Code
- Ngôn ngữ lập trình: C#
- Nền tảng: .NET Framework 4.7.2
- Giao diện: Windows Forms
- Cơ sở dữ liệu: Microsoft SQL Server
- Công cụ quản lý CSDL: SQL Server Management Studio / SQL Server
- Kiến trúc: UI → Service/Adapter → Data
- CSDL: eSHOPPING

## 3. Nội dung đã thực hiện

### 3.1. Phân tích nghiệp vụ

Phân tích nghiệp vụ hệ thống e-SHOPPING dựa trên yêu cầu của đề bài, gồm:

- Xem nhóm sản phẩm.
- Xem danh sách sản phẩm.
- Xem chi tiết sản phẩm.
- Thêm sản phẩm vào giỏ hàng.
- Xem và cập nhật giỏ hàng.
- Xóa sản phẩm khỏi giỏ hàng.
- Đăng nhập.
- Đăng ký tài khoản khách hàng.
- Đặt hàng.
- Nhập thông tin người nhận.
- Chọn phương thức giao hàng.
- Tính phí giao hàng.
- Thanh toán đơn hàng.

### 3.2. Xác định tác nhân và hệ thống bên ngoài

Các tác nhân/hệ thống bên ngoài được xác định:

- Khách hàng.
- Hệ thống quản lý sản phẩm.
- Dịch vụ thanh toán trực tuyến.
- Dịch vụ Email.

### 3.3. Mô hình UML

Đã thực hiện các nội dung:

- Biểu đồ Use Case.
- Đặc tả Use Case.
- Xác định Actor và chức năng của hệ thống.
- Phân biệt chức năng bên trong e-SHOPPING với các hệ thống/dịch vụ bên ngoài.
- Phân tích các chức năng chính của hệ thống.

### 3.4. Thiết kế cơ sở dữ liệu

Đã xây dựng CSDL `eSHOPPING` trên SQL Server với các bảng:

- `KhachHang`
- `NhomSanPham`
- `SanPham`
- `GioHang`
- `ChiTietGioHang`
- `DonHang`
- `ChiTietDonHang`
- `ThanhToan`

Trong đó các bảng `KhachHang`, `NhomSanPham` và `SanPham` đã được tạo dữ liệu mẫu để kiểm tra chương trình.

### 3.5. Xây dựng chương trình

Đã xây dựng prototype bằng C# WinForms với các thành phần:

- Form chính.
- Form đăng nhập.
- Form đăng ký tài khoản.
- Form quản lý khách hàng.
- Form quản lý nhóm sản phẩm.
- Form quản lý sản phẩm.
- Kết nối C# với SQL Server.
- Đọc và hiển thị dữ liệu từ CSDL.
- Thực hiện các chức năng CRUD đối với dữ liệu được xây dựng.

### 3.6. Kiểm thử

Đã xây dựng Test Case cho các chức năng chính và thực hiện kiểm tra theo hướng:

`Yêu cầu → UML → Form/Service → CSDL → Test Case`

## 4. Kết quả

- Kết nối được chương trình C# với CSDL `eSHOPPING`.
- Hiển thị được dữ liệu từ SQL Server lên giao diện.
- Các dữ liệu nhóm sản phẩm, sản phẩm và khách hàng được lưu trữ trong CSDL.
- Các chức năng giao diện chính của hệ thống e-SHOPPING được xây dựng.
- Có thể chạy chương trình từ Form Main.
- Các chức năng được kiểm tra bằng Test Case.

## 5. Lỗi gặp phải

### Lỗi kết nối SQL Server

Chương trình có thể xuất hiện lỗi:

`A network-related or instance-specific error occurred while establishing a connection to SQL Server`

Nguyên nhân có thể do tên SQL Server instance trong connection string không trùng với instance đang chạy.

### Lỗi khóa ngoại

Khi tạo dữ liệu sản phẩm có thể xảy ra lỗi:

`The INSERT statement conflicted with the FOREIGN KEY constraint`

Nguyên nhân là `MaNhom` của sản phẩm không tồn tại trong bảng `NhomSanPham`.

## 6. Cách khắc phục

- Kiểm tra SQL Server đang chạy.
- Kiểm tra đúng tên SQL Server instance.
- Kiểm tra connection string trong `App.config`.
- Kiểm tra database đang sử dụng là `eSHOPPING`.
- Khi thêm sản phẩm phải đảm bảo `MaNhom` tồn tại trong bảng `NhomSanPham`.
- Thực hiện tạo bảng `NhomSanPham` và dữ liệu nhóm trước khi thêm dữ liệu `SanPham`.
- Kiểm tra các khóa ngoại trước khi xóa dữ liệu trong các bảng có quan hệ.

## 7. Connection String

Chương trình sử dụng connection string:

    Server=.\SQLEXPRESS;
    Database=eSHOPPING;
    Trusted_Connection=True;
    TrustServerCertificate=True;

Tên connection string:

    eShoppingDb

## 8. Hướng dẫn chạy lại

### Bước 1: Chuẩn bị SQL Server

Mở SQL Server và đảm bảo SQL Server instance đang chạy.

### Bước 2: Tạo CSDL

Mở file SQL của LAB4 và thực thi script để:

- Tạo database `eSHOPPING`.
- Tạo các bảng.
- Tạo dữ liệu mẫu.

### Bước 3: Kiểm tra App.config

Kiểm tra connection string có đúng với SQL Server đang sử dụng.

### Bước 4: Mở project

Mở thư mục project `eSHOPPING` bằng Visual Studio Code.

### Bước 5: Chạy chương trình

Build và chạy project.

Chương trình sẽ mở Form Main, từ đó có thể truy cập các chức năng của hệ thống.

### Bước 6: Kiểm tra dữ liệu

Có thể kiểm tra dữ liệu trực tiếp trong database `eSHOPPING` hoặc thông qua các Form quản lý của chương trình.

## 9. Cấu trúc xử lý

Hệ thống được tổ chức theo mô hình:

    UI
     ↓
    Service / Adapter
     ↓
    Data
     ↓
    SQL Server

