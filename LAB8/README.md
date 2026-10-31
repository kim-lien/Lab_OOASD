# README – LAB 8

## 1. THÔNG TIN SINH VIÊN

- **Họ và tên:** Nguyễn Thị Kim Liên
- **MSSV:** 1250080097
- **Bài thực hành:** LAB 8
- **Tên bài:** Quản lý cho thuê văn phòng ở cao ốc

## 2. MÔI TRƯỜNG PHÁT TRIỂN

| Thành phần | Công nghệ / Phiên bản |
|---|---|
| IDE | Visual Studio 2022 |
| Ngôn ngữ lập trình | C# |
| Nền tảng | Windows Forms |
| Framework | .NET Framework 4.7.2 |
| Hệ quản trị cơ sở dữ liệu | Microsoft SQL Server |
| Công cụ quản lý CSDL | SQL Server Management Studio (SSMS) |
| Truy cập dữ liệu | ADO.NET – System.Data.SqlClient |
| Kiến trúc | Windows Forms → Services → Data → SQL Server |
| Hệ điều hành | Windows |



## 3. MỤC TIÊU BÀI THỰC HÀNH

Xây dựng ứng dụng quản lý cho thuê văn phòng ở cao ốc nhằm hỗ trợ quản lý thông tin tầng, văn phòng, khách hàng, hợp đồng thuê, thanh toán tiền thuê, dịch vụ, gia hạn hợp đồng và các hoạt động quản lý liên quan.

Ứng dụng được xây dựng bằng C# Windows Forms và sử dụng SQL Server để lưu trữ dữ liệu.

Hệ thống hướng đến việc kiểm tra và áp dụng các quy tắc nghiệp vụ:

- Thời hạn thuê văn phòng tối thiểu 6 tháng.
- Khách hàng thanh toán trước tiền thuê 6 tháng đầu tiên.
- Từ tháng thứ 7 trở đi, tiền thuê được thanh toán vào đầu mỗi tháng.
- Chi phí dịch vụ được thanh toán vào cuối tháng.
- Thời gian gia hạn không vượt quá 1/2 thời gian thuê ban đầu.
- Chỉ được gia hạn khi đã hoàn tất các khoản công nợ theo quy định.

## 4. NỘI DUNG ĐÃ THỰC HIỆN

### 4.1. Phân tích và thiết kế hệ thống

Đã xây dựng các nội dung:

- Phân tích yêu cầu nghiệp vụ quản lý cho thuê văn phòng.
- Xác định Actor và Use Case của hệ thống.
- Xây dựng Class Diagram.
- Xây dựng Use Case Diagram tổng quát và phân rã.
- Xây dựng Activity Diagram cho quy trình thuê và thanh toán.
- Xây dựng Sequence Diagram cho nghiệp vụ gia hạn hợp đồng.

### 4.2. Xây dựng cơ sở dữ liệu

Thiết kế cơ sở dữ liệu `QuanLyChoThueVanPhong` trên SQL Server, gồm 16 bảng:

1. Tang
2. VanPhong
3. KhachHang
4. HopDongThue
5. ChiTietHopDong
6. PhieuGiaHan
7. KyThanhToan
8. ThanhToanTienThue
9. DichVu
10. HoaDonDichVu
11. ChiTietHoaDon
12. ThanhToanDichVu
13. NhanVienVanPhong
14. TheGiuXe
15. PhieuKiemTra
16. PhieuXuPhat

Các bảng sử dụng khóa chính, khóa ngoại và các ràng buộc dữ liệu để bảo đảm tính toàn vẹn thông tin.

### 4.3. Xây dựng ứng dụng Windows Forms

Đã xây dựng mã nguồn cho 15 Form:

| STT | Tên Form | Chức năng |
|---|---|---|
| 1 | FrmMain | Giao diện chính |
| 2 | FrmTang | Quản lý tầng |
| 3 | FrmVanPhong | Quản lý văn phòng |
| 4 | FrmKhachHang | Quản lý khách hàng |
| 5 | FrmHopDong | Quản lý hợp đồng thuê |
| 6 | FrmThanhToanThue | Thanh toán tiền thuê |
| 7 | FrmDichVu | Quản lý dịch vụ |
| 8 | FrmHoaDonDichVu | Lập hóa đơn dịch vụ |
| 9 | FrmThanhToanDichVu | Thanh toán dịch vụ |
| 10 | FrmGiaHan | Gia hạn hợp đồng |
| 11 | FrmNhanVien | Quản lý nhân viên |
| 12 | FrmTheGiuXe | Quản lý thẻ giữ xe |
| 13 | FrmKiemTra | Kiểm tra văn phòng |
| 14 | FrmXuPhat | Quản lý xử phạt |
| 15 | FrmThongKe | Thống kê hệ thống |

Mã nguồn được tổ chức theo các thư mục:

```text
QuanLyChoThueVanPhong/
├── Data/
│   └── Db.cs
├── Services/
│   ├── TangService.cs
│   ├── VanPhongService.cs
│   ├── KhachHangService.cs
│   ├── HopDongService.cs
│   ├── ThanhToanThueService.cs
│   ├── DichVuService.cs
│   ├── HoaDonDichVuService.cs
│   ├── ThanhToanDichVuService.cs
│   ├── GiaHanService.cs
│   ├── NhanVienService.cs
│   ├── TheGiuXeService.cs
│   ├── KiemTraService.cs
│   ├── XuPhatService.cs
│   └── ThongKeService.cs
├── Forms/
│   └── Các Form và file Designer tương ứng
├── App.config
└── Program.cs
```

## 5. KẾT QUẢ THỰC HIỆN

Ứng dụng đã được chạy thử với dữ liệu khách hàng, văn phòng và hợp đồng thuê.

### 5.1. Tạo khách hàng

- Mã khách hàng: KH006
- Tên công ty: Công ty TNHH ABC
- Kết quả: Thêm khách hàng thành công, dữ liệu được lưu trong SQL Server.

### 5.2. Tạo văn phòng

- Mã văn phòng: VP102
- Tầng: T01
- Diện tích: 50 m²
- Hướng: Đông
- Đơn giá: 10.000.000 VNĐ/tháng
- Trạng thái ban đầu: Trống
- Kết quả: Thêm văn phòng thành công.

### 5.3. Lập hợp đồng thuê

- Mã hợp đồng: HD006
- Khách hàng: KH006
- Văn phòng: VP102
- Ngày bắt đầu: 01/11/2026
- Ngày kết thúc: 31/10/2027
- Thời hạn thuê: 12 tháng
- Tiền thuê: 10.000.000 VNĐ/tháng

Kết quả: Hợp đồng được tạo và lưu vào cơ sở dữ liệu.

### 5.4. Thanh toán tiền thuê

Khách hàng đã thực hiện thanh toán trước 6 tháng đầu:

60.000.000 VNĐ = 10.000.000 VNĐ × 6 tháng.

Kết quả kiểm tra SQL Server:

- Loại kỳ: TRA_TRUOC
- Số tiền phải thu: 60.000.000 VNĐ
- Số tiền thanh toán: 60.000.000 VNĐ
- Trạng thái: Đã thanh toán
- Hình thức: Chuyển khoản

Hệ thống đã tạo lịch thanh toán từ tháng 7 đến tháng 12, mỗi kỳ 10.000.000 VNĐ với ngày đến hạn vào đầu tháng.

### 5.5. Kiểm tra gia hạn

Với hợp đồng HD006:

- Thời hạn thuê ban đầu: 12 tháng.
- Giới hạn gia hạn: 6 tháng.
- Thời gian đã gia hạn: 0 tháng.
- Công nợ tiền thuê còn lại: 60.000.000 VNĐ.

Kết quả quan sát: Nút xác nhận gia hạn không được kích hoạt khi hợp đồng đang còn nợ.

### 5.6. Kiểm tra dịch vụ

Hệ thống hiển thị danh sách dịch vụ điện, nước, internet, vệ sinh và bảo vệ.

Khi chọn dịch vụ nhưng nhập số lượng không hợp lệ, chương trình hiển thị thông báo yêu cầu kiểm tra lại.

Việc lập hóa đơn dịch vụ tháng 11/2026 chưa được hoàn tất do chưa đến cuối kỳ thanh toán.

## 6. LỖI GẶP PHẢI VÀ CÁCH KHẮC PHỤC

| STT | Lỗi / Vấn đề | Nguyên nhân | Cách khắc phục |
|---|---|---|---|
| 1 | Không có văn phòng trống để lập hợp đồng | Các văn phòng mẫu đang có trạng thái Đang thuê | Tạo văn phòng VP102 với trạng thái Trống |
| 2 | Không thể lập hóa đơn khi chọn dịch vụ | Số lượng dịch vụ chưa hợp lệ | Nhập số lượng lớn hơn 0 và xác nhận giá trị trong DataGridView |
| 3 | Chưa lập được hóa đơn dịch vụ tháng 11/2026 | Chưa đến thời điểm lập hóa đơn cuối tháng | Kiểm tra lại khi đến cuối kỳ hoặc sử dụng môi trường kiểm thử phù hợp |
| 4 | Không thể nhấn Xác nhận gia hạn | Hợp đồng còn công nợ tiền thuê | Cần thanh toán đầy đủ công nợ theo điều kiện nghiệp vụ |
| 5 | Có thể xảy ra lỗi kết nối SQL Server trên máy khác | Tên SQL Server hoặc chuỗi kết nối khác với máy phát triển | Cập nhật cấu hình trong App.config |

## 7. HƯỚNG DẪN GIẢNG VIÊN CHẠY LẠI CHƯƠNG TRÌNH

### Bước 1. Chuẩn bị môi trường

Máy kiểm tra cần cài đặt:

- Visual Studio 2022 hỗ trợ phát triển ứng dụng .NET Framework.
- .NET Framework 4.7.2 Developer Pack.
- Microsoft SQL Server.
- SQL Server Management Studio.

### Bước 2. Khởi tạo cơ sở dữ liệu

1. Mở SQL Server Management Studio.
2. Kết nối đến SQL Server.
3. Mở script SQL tạo cơ sở dữ liệu được nộp kèm bài thực hành.
4. Thực thi script để tạo database `QuanLyChoThueVanPhong`.
5. Kiểm tra các bảng và dữ liệu mẫu.

Lưu ý: Không chạy lại script có thao tác xóa bảng trên cơ sở dữ liệu đang chứa dữ liệu cần giữ.

### Bước 3. Mở Project

1. Giải nén thư mục mã nguồn nếu được nộp dưới dạng ZIP.
2. Mở file `QuanLyChoThueVanPhong.sln` bằng Visual Studio 2022.
3. Kiểm tra cấu hình Target Framework là .NET Framework 4.7.2.


### Bước 5. Biên dịch và chạy ứng dụng

1. Chọn Build → Rebuild Solution.
2. Kiểm tra cửa sổ Error List.
3. Nhấn F5 để chạy ứng dụng.
4. Giao diện chính FrmMain xuất hiện.
5. Chọn các chức năng để kiểm tra.

### Bước 6. Kiểm tra các chức năng chính

Giảng viên có thể thực hiện:

1. Mở FrmKhachHang để kiểm tra danh sách khách hàng.
2. Mở FrmVanPhong để kiểm tra trạng thái văn phòng.
3. Mở FrmHopDong để kiểm tra hợp đồng HD006.
4. Kiểm tra kỳ trả trước 6 tháng đầu.
5. Mở FrmThanhToanThue để xem lịch sử thanh toán.
6. Kiểm tra lịch thanh toán từ tháng 7 đến tháng 12.
7. Mở FrmGiaHan để kiểm tra giới hạn thời gian và điều kiện công nợ.
8. Mở FrmThongKe để xem doanh thu và công nợ.


