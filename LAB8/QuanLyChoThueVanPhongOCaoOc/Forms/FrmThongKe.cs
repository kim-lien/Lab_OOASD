
using System;
using System.Data;
using System.Windows.Forms;
using QuanLyChoThueVanPhong.Services;

namespace QuanLyChoThueVanPhong.Forms
{
    public partial class FrmThongKe : Form
    {
        private readonly ThongKeService service = new ThongKeService();

        public FrmThongKe()
        {
            InitializeComponent();
        }

        private void FrmThongKe_Load(object sender, EventArgs e)
        {
            nudNam.Value = DateTime.Today.Year;
            NapDuLieu();
        }

        private void NapDuLieu()
        {
            try
            {
                int nam = (int)nudNam.Value;

                DataTable tongQuan = service.LayTongQuan();
                DataTable taiChinh = service.LayTaiChinh(nam);
                DataTable congNo = service.LayCongNo();

                if (tongQuan.Rows.Count > 0)
                {
                    DataRow row = tongQuan.Rows[0];

                    lblSoTang.Text = Convert.ToString(row["SoTang"]);
                    lblSoVanPhong.Text = Convert.ToString(row["SoVanPhong"]);
                    lblSoKhachHang.Text = Convert.ToString(row["SoKhachHang"]);
                    lblSoHopDong.Text = Convert.ToString(row["SoHopDong"]);
                    lblSoNhanVien.Text = Convert.ToString(row["SoNhanVien"]);
                    lblSoTheXe.Text = Convert.ToString(row["SoTheXe"]);
                }

                if (taiChinh.Rows.Count > 0)
                {
                    DataRow row = taiChinh.Rows[0];

                    decimal doanhThuThue =
                        Convert.ToDecimal(row["DoanhThuThue"]);

                    decimal doanhThuDichVu =
                        Convert.ToDecimal(row["DoanhThuDichVu"]);

                    decimal tienXuPhat =
                        Convert.ToDecimal(row["TienXuPhat"]);

                    lblDoanhThuThue.Text =
                        doanhThuThue.ToString("N0") + " VNĐ";

                    lblDoanhThuDichVu.Text =
                        doanhThuDichVu.ToString("N0") + " VNĐ";

                    lblTongDoanhThu.Text =
                        (doanhThuThue + doanhThuDichVu).ToString("N0") + " VNĐ";

                    lblTienXuPhat.Text =
                        tienXuPhat.ToString("N0") + " VNĐ";
                }

                if (congNo.Rows.Count > 0)
                {
                    DataRow row = congNo.Rows[0];

                    decimal noThue =
                        Convert.ToDecimal(row["NoTienThue"]);

                    decimal noDichVu =
                        Convert.ToDecimal(row["NoDichVu"]);

                    lblNoTienThue.Text = noThue.ToString("N0") + " VNĐ";
                    lblNoDichVu.Text = noDichVu.ToString("N0") + " VNĐ";
                    lblTongCongNo.Text =
                        (noThue + noDichVu).ToString("N0") + " VNĐ";
                }

                dgvDoanhThu.DataSource =
                    service.LayDoanhThuTheoThang(nam);

                dgvVanPhong.DataSource =
                    service.LayTinhTrangVanPhong();

                dgvCongNo.DataSource =
                    service.LayCongNoTheoHopDong();

                DinhDangBang();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Không thể tải dữ liệu thống kê.\n" + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void DinhDangBang()
        {
            if (dgvDoanhThu.Columns.Contains("Thang"))
                dgvDoanhThu.Columns["Thang"].HeaderText = "Tháng";

            if (dgvDoanhThu.Columns.Contains("DoanhThuThue"))
            {
                dgvDoanhThu.Columns["DoanhThuThue"].HeaderText =
                    "Tiền thuê";

                dgvDoanhThu.Columns["DoanhThuThue"]
                    .DefaultCellStyle.Format = "N0";
            }

            if (dgvDoanhThu.Columns.Contains("DoanhThuDichVu"))
            {
                dgvDoanhThu.Columns["DoanhThuDichVu"].HeaderText =
                    "Dịch vụ";

                dgvDoanhThu.Columns["DoanhThuDichVu"]
                    .DefaultCellStyle.Format = "N0";
            }

            if (dgvDoanhThu.Columns.Contains("TongDoanhThu"))
            {
                dgvDoanhThu.Columns["TongDoanhThu"].HeaderText =
                    "Tổng doanh thu";

                dgvDoanhThu.Columns["TongDoanhThu"]
                    .DefaultCellStyle.Format = "N0";
            }

            if (dgvVanPhong.Columns.Contains("TrangThai"))
                dgvVanPhong.Columns["TrangThai"].HeaderText =
                    "Trạng thái văn phòng";

            if (dgvVanPhong.Columns.Contains("SoLuong"))
                dgvVanPhong.Columns["SoLuong"].HeaderText =
                    "Số lượng";

            if (dgvCongNo.Columns.Contains("MaHD"))
                dgvCongNo.Columns["MaHD"].HeaderText = "Mã hợp đồng";

            if (dgvCongNo.Columns.Contains("TenCongTy"))
                dgvCongNo.Columns["TenCongTy"].HeaderText = "Khách hàng";

            if (dgvCongNo.Columns.Contains("NoTienThue"))
            {
                dgvCongNo.Columns["NoTienThue"].HeaderText = "Nợ thuê";
                dgvCongNo.Columns["NoTienThue"].DefaultCellStyle.Format = "N0";
            }

            if (dgvCongNo.Columns.Contains("NoDichVu"))
            {
                dgvCongNo.Columns["NoDichVu"].HeaderText = "Nợ dịch vụ";
                dgvCongNo.Columns["NoDichVu"].DefaultCellStyle.Format = "N0";
            }

            if (dgvCongNo.Columns.Contains("TongNo"))
            {
                dgvCongNo.Columns["TongNo"].HeaderText = "Tổng nợ";
                dgvCongNo.Columns["TongNo"].DefaultCellStyle.Format = "N0";
            }

            dgvDoanhThu.ClearSelection();
            dgvVanPhong.ClearSelection();
            dgvCongNo.ClearSelection();
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            NapDuLieu();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            nudNam.Value = DateTime.Today.Year;
            NapDuLieu();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lblTongCongNo_Click(object sender, EventArgs e)
        {

        }

        private void lblNoDichVu_Click(object sender, EventArgs e)
        {

        }

        private void lblDoanhThuDichVu_Click(object sender, EventArgs e)
        {

        }
    }
}
