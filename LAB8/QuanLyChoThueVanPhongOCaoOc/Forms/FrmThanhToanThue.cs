
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using QuanLyChoThueVanPhong.Services;

namespace QuanLyChoThueVanPhong.Forms
{
    public partial class FrmThanhToanThue : Form
    {
        private readonly ThanhToanThueService service = new ThanhToanThueService();
        private string maKyDangChon = "";

        public FrmThanhToanThue()
        {
            InitializeComponent();
        }

        private void FrmThanhToanThue_Load(object sender, EventArgs e)
        {
            try
            {
                cboHopDong.DisplayMember = "MaHD";
                cboHopDong.ValueMember = "MaHD";
                cboHopDong.DataSource = service.LayHopDong();

                cboHinhThuc.Items.AddRange(new object[]
                {
                    "Tiền mặt",
                    "Chuyển khoản"
                });

                cboHinhThuc.SelectedIndex = 0;
                LamMoiNhapLieu();

                if (cboHopDong.Items.Count > 0)
                    NapKyThanhToan();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi tải dữ liệu");
            }
        }

        private void NapKyThanhToan()
        {
            if (cboHopDong.SelectedValue == null ||
                cboHopDong.SelectedValue is DataRowView)
                return;

            try
            {
                string maHD = Convert.ToString(cboHopDong.SelectedValue);
                dgvKyThanhToan.DataSource = service.LayKyThanhToan(maHD);
                DinhDangBang();
                dgvLichSu.DataSource = null;
                maKyDangChon = "";
                txtMaKy.Clear();
                txtMaPhong.Clear();
                txtThangThu.Clear();
                txtPhaiThu.Clear();
                txtDaThanhToan.Clear();
                txtConNo.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi tải kỳ thanh toán");
            }
        }

        private void DinhDangBang()
        {
            if (dgvKyThanhToan.Columns.Contains("MaKy"))
                dgvKyThanhToan.Columns["MaKy"].HeaderText = "Mã kỳ";

            if (dgvKyThanhToan.Columns.Contains("MaPhong"))
                dgvKyThanhToan.Columns["MaPhong"].HeaderText = "Mã phòng";

            if (dgvKyThanhToan.Columns.Contains("ThangThu"))
                dgvKyThanhToan.Columns["ThangThu"].HeaderText = "Tháng thứ";

            if (dgvKyThanhToan.Columns.Contains("LoaiKy"))
                dgvKyThanhToan.Columns["LoaiKy"].HeaderText = "Loại kỳ";

            if (dgvKyThanhToan.Columns.Contains("NgayDenHan"))
                dgvKyThanhToan.Columns["NgayDenHan"].HeaderText = "Ngày đến hạn";

            if (dgvKyThanhToan.Columns.Contains("SoTienPhaiThu"))
                dgvKyThanhToan.Columns["SoTienPhaiThu"].HeaderText = "Phải thu";

            if (dgvKyThanhToan.Columns.Contains("DaThanhToan"))
                dgvKyThanhToan.Columns["DaThanhToan"].HeaderText = "Đã thanh toán";

            if (dgvKyThanhToan.Columns.Contains("ConNo"))
                dgvKyThanhToan.Columns["ConNo"].HeaderText = "Còn nợ";

            if (dgvKyThanhToan.Columns.Contains("TrangThai"))
                dgvKyThanhToan.Columns["TrangThai"].HeaderText = "Trạng thái";

            if (dgvKyThanhToan.Columns.Contains("SoTienPhaiThu"))
                dgvKyThanhToan.Columns["SoTienPhaiThu"].DefaultCellStyle.Format = "N0";

            if (dgvKyThanhToan.Columns.Contains("DaThanhToan"))
                dgvKyThanhToan.Columns["DaThanhToan"].DefaultCellStyle.Format = "N0";

            if (dgvKyThanhToan.Columns.Contains("ConNo"))
                dgvKyThanhToan.Columns["ConNo"].DefaultCellStyle.Format = "N0";

            dgvKyThanhToan.ClearSelection();
        }

        private void LamMoiNhapLieu()
        {
            txtMaThanhToan.Clear();
            txtMaKy.Clear();
            txtMaPhong.Clear();
            txtThangThu.Clear();
            txtPhaiThu.Clear();
            txtDaThanhToan.Clear();
            txtConNo.Clear();

            nudSoTien.Value = 0;
            maKyDangChon = "";
        }

        private void cboHopDong_SelectedIndexChanged(object sender, EventArgs e)
        {
            NapKyThanhToan();
        }

        private void dgvKyThanhToan_CellClick(
            object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            DataGridViewRow row = dgvKyThanhToan.Rows[e.RowIndex];

            if (row.IsNewRow)
                return;

            maKyDangChon = Convert.ToString(row.Cells["MaKy"].Value);

            txtMaKy.Text = maKyDangChon;
            txtMaPhong.Text = Convert.ToString(row.Cells["MaPhong"].Value);
            txtThangThu.Text = Convert.ToString(row.Cells["ThangThu"].Value);
            txtPhaiThu.Text = Convert.ToDecimal(row.Cells["SoTienPhaiThu"].Value).ToString("N0");
            txtDaThanhToan.Text = Convert.ToDecimal(row.Cells["DaThanhToan"].Value).ToString("N0");
            txtConNo.Text = Convert.ToDecimal(row.Cells["ConNo"].Value).ToString("N0");

            decimal conNo = Convert.ToDecimal(row.Cells["ConNo"].Value);
            nudSoTien.Value = Math.Min(nudSoTien.Maximum, Math.Max(0, conNo));

            try
            {
                dgvLichSu.DataSource = service.LayLichSuThanhToan(maKyDangChon);

                if (dgvLichSu.Columns.Contains("SoTien"))
                    dgvLichSu.Columns["SoTien"].DefaultCellStyle.Format = "N0";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi lịch sử thanh toán");
            }
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(maKyDangChon))
            {
                MessageBox.Show("Vui lòng chọn kỳ thanh toán.");
                return;
            }

            if (nudSoTien.Value <= 0)
            {
                MessageBox.Show("Số tiền thanh toán phải lớn hơn 0.");
                return;
            }

            if (nudSoTien.Value > decimal.Parse(txtConNo.Text))
            {
                MessageBox.Show("Số tiền thanh toán vượt quá khoản còn nợ.");
                return;
            }

            DialogResult xacNhan = MessageBox.Show(
                "Xác nhận thanh toán " + nudSoTien.Value.ToString("N0") + " VNĐ?",
                "Xác nhận thanh toán",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (xacNhan != DialogResult.Yes)
                return;

            try
            {
                service.ThanhToan(
                    txtMaThanhToan.Text.Trim(),
                    maKyDangChon,
                    nudSoTien.Value,
                    cboHinhThuc.Text
                );

                MessageBox.Show(
                    "Thanh toán tiền thuê thành công.",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                NapKyThanhToan();
                LamMoiNhapLieu();
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

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LamMoiNhapLieu();
            NapKyThanhToan();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
