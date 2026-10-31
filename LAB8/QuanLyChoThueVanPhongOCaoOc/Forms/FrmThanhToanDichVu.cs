
using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using QuanLyChoThueVanPhong.Services;

namespace QuanLyChoThueVanPhong.Forms
{
    public partial class FrmThanhToanDichVu : Form
    {
        private readonly ThanhToanDichVuService service =
            new ThanhToanDichVuService();

        private string maHoaDonDangChon = "";
        private decimal conNoDangChon = 0;

        public FrmThanhToanDichVu()
        {
            InitializeComponent();
        }

        private void FrmThanhToanDichVu_Load(object sender, EventArgs e)
        {
            cboHinhThuc.Items.Clear();
            cboHinhThuc.Items.Add("Tiền mặt");
            cboHinhThuc.Items.Add("Chuyển khoản");
            cboHinhThuc.SelectedIndex = 0;

            LamMoiNhapLieu();
            NapDuLieu();
        }

        private void NapDuLieu()
        {
            try
            {
                dgvHoaDon.DataSource = service.LayHoaDon();
                DinhDangBang();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi tải hóa đơn");
            }
        }

        private void DinhDangBang()
        {
            if (dgvHoaDon.Columns.Contains("MaHoaDon"))
                dgvHoaDon.Columns["MaHoaDon"].HeaderText = "Mã hóa đơn";

            if (dgvHoaDon.Columns.Contains("MaHD"))
                dgvHoaDon.Columns["MaHD"].HeaderText = "Hợp đồng";

            if (dgvHoaDon.Columns.Contains("MaPhong"))
                dgvHoaDon.Columns["MaPhong"].HeaderText = "Văn phòng";

            if (dgvHoaDon.Columns.Contains("Thang"))
                dgvHoaDon.Columns["Thang"].HeaderText = "Tháng";

            if (dgvHoaDon.Columns.Contains("Nam"))
                dgvHoaDon.Columns["Nam"].HeaderText = "Năm";

            if (dgvHoaDon.Columns.Contains("NgayLap"))
                dgvHoaDon.Columns["NgayLap"].HeaderText = "Ngày lập";

            if (dgvHoaDon.Columns.Contains("HanThanhToan"))
                dgvHoaDon.Columns["HanThanhToan"].HeaderText = "Hạn thanh toán";

            if (dgvHoaDon.Columns.Contains("TongTien"))
                dgvHoaDon.Columns["TongTien"].HeaderText = "Tổng tiền";

            if (dgvHoaDon.Columns.Contains("DaThanhToan"))
                dgvHoaDon.Columns["DaThanhToan"].HeaderText = "Đã trả";

            if (dgvHoaDon.Columns.Contains("ConNo"))
                dgvHoaDon.Columns["ConNo"].HeaderText = "Còn nợ";

            if (dgvHoaDon.Columns.Contains("TrangThai"))
                dgvHoaDon.Columns["TrangThai"].HeaderText = "Trạng thái";

            if (dgvHoaDon.Columns.Contains("TongTien"))
                dgvHoaDon.Columns["TongTien"].DefaultCellStyle.Format = "N0";

            if (dgvHoaDon.Columns.Contains("DaThanhToan"))
                dgvHoaDon.Columns["DaThanhToan"].DefaultCellStyle.Format = "N0";

            if (dgvHoaDon.Columns.Contains("ConNo"))
                dgvHoaDon.Columns["ConNo"].DefaultCellStyle.Format = "N0";

            dgvHoaDon.ClearSelection();
        }

        private void LamMoiNhapLieu()
        {
            txtMaTTDV.Clear();
            txtMaHoaDon.Clear();
            txtMaHD.Clear();
            txtMaPhong.Clear();
            txtTongTien.Clear();
            txtDaThanhToan.Clear();
            txtConNo.Clear();

            nudSoTien.Value = 0;

            maHoaDonDangChon = "";
            conNoDangChon = 0;

            btnThanhToan.Enabled = false;
            dgvLichSu.DataSource = null;
        }

        private void dgvHoaDon_CellClick(
            object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            DataGridViewRow row = dgvHoaDon.Rows[e.RowIndex];

            if (row.IsNewRow)
                return;

            maHoaDonDangChon =
                Convert.ToString(row.Cells["MaHoaDon"].Value);

            txtMaHoaDon.Text = maHoaDonDangChon;
            txtMaHD.Text = Convert.ToString(row.Cells["MaHD"].Value);
            txtMaPhong.Text = Convert.ToString(row.Cells["MaPhong"].Value);

            decimal tongTien =
                Convert.ToDecimal(row.Cells["TongTien"].Value);

            decimal daThanhToan =
                Convert.ToDecimal(row.Cells["DaThanhToan"].Value);

            conNoDangChon =
                Convert.ToDecimal(row.Cells["ConNo"].Value);

            txtTongTien.Text = tongTien.ToString("N0");
            txtDaThanhToan.Text = daThanhToan.ToString("N0");
            txtConNo.Text = conNoDangChon.ToString("N0");

            nudSoTien.Value = Math.Min(
                nudSoTien.Maximum,
                Math.Max(nudSoTien.Minimum, conNoDangChon)
            );

            btnThanhToan.Enabled = conNoDangChon > 0;

            try
            {
                dgvLichSu.DataSource = service.LayLichSu(maHoaDonDangChon);

                if (dgvLichSu.Columns.Contains("SoTien"))
                {
                    dgvLichSu.Columns["SoTien"].HeaderText = "Số tiền";
                    dgvLichSu.Columns["SoTien"].DefaultCellStyle.Format = "N0";
                }

                if (dgvLichSu.Columns.Contains("MaTTDV"))
                    dgvLichSu.Columns["MaTTDV"].HeaderText = "Mã thanh toán";

                if (dgvLichSu.Columns.Contains("NgayThanhToan"))
                    dgvLichSu.Columns["NgayThanhToan"].HeaderText = "Ngày thanh toán";

                if (dgvLichSu.Columns.Contains("HinhThucThanhToan"))
                    dgvLichSu.Columns["HinhThucThanhToan"].HeaderText = "Hình thức";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi lịch sử thanh toán");
            }
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(maHoaDonDangChon))
            {
                MessageBox.Show("Vui lòng chọn hóa đơn.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtMaTTDV.Text))
            {
                MessageBox.Show("Vui lòng nhập mã thanh toán.");
                return;
            }

            if (nudSoTien.Value <= 0)
            {
                MessageBox.Show("Số tiền thanh toán phải lớn hơn 0.");
                return;
            }

            if (nudSoTien.Value > conNoDangChon)
            {
                MessageBox.Show("Số tiền thanh toán vượt quá công nợ.");
                return;
            }

            DialogResult xacNhan = MessageBox.Show(
                "Xác nhận thanh toán hóa đơn " + maHoaDonDangChon +
                "\nSố tiền: " + nudSoTien.Value.ToString("N0") + " VNĐ",
                "Xác nhận thanh toán",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (xacNhan != DialogResult.Yes)
                return;

            try
            {
                service.ThanhToan(
                    txtMaTTDV.Text.Trim(),
                    maHoaDonDangChon,
                    nudSoTien.Value,
                    cboHinhThuc.Text
                );

                MessageBox.Show(
                    "Thanh toán dịch vụ thành công.",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                LamMoiNhapLieu();
                NapDuLieu();
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627 || ex.Number == 2601)
                    MessageBox.Show("Mã thanh toán đã tồn tại.");
                else
                    MessageBox.Show(ex.Message, "Lỗi SQL Server");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo");
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                dgvHoaDon.DataSource = service.TimKiem(txtTimKiem.Text);
                DinhDangBang();
                LamMoiNhapLieu();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi tìm kiếm");
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtTimKiem.Clear();
            LamMoiNhapLieu();
            NapDuLieu();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
