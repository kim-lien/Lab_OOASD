
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using QuanLyChoThueVanPhong.Services;

namespace QuanLyChoThueVanPhong.Forms
{
    public partial class FrmXuPhat : Form
    {
        private readonly XuPhatService service = new XuPhatService();
        private bool dangChonPhieu = false;

        public FrmXuPhat()
        {
            InitializeComponent();
        }

        private void FrmXuPhat_Load(object sender, EventArgs e)
        {
            try
            {
                cboPhieuKiemTra.DisplayMember = "MaKiemTra";
                cboPhieuKiemTra.ValueMember = "MaKiemTra";
                cboPhieuKiemTra.DataSource = service.LayPhieuKiemTra();

                NapDuLieu();
                LamMoiNhapLieu(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi tải dữ liệu");
            }
        }

        private void NapDuLieu()
        {
            dgvXuPhat.DataSource = service.LayDanhSach();
            DinhDangBang();
        }

        private void DinhDangBang()
        {
            if (dgvXuPhat.Columns.Contains("MaPhat"))
                dgvXuPhat.Columns["MaPhat"].HeaderText = "Mã phạt";

            if (dgvXuPhat.Columns.Contains("MaKiemTra"))
                dgvXuPhat.Columns["MaKiemTra"].HeaderText = "Phiếu kiểm tra";

            if (dgvXuPhat.Columns.Contains("MaPhong"))
                dgvXuPhat.Columns["MaPhong"].HeaderText = "Văn phòng";

            if (dgvXuPhat.Columns.Contains("NgayKiemTra"))
            {
                dgvXuPhat.Columns["NgayKiemTra"].HeaderText = "Ngày kiểm tra";
                dgvXuPhat.Columns["NgayKiemTra"].DefaultCellStyle.Format =
                    "dd/MM/yyyy";
            }

            if (dgvXuPhat.Columns.Contains("NgayLap"))
            {
                dgvXuPhat.Columns["NgayLap"].HeaderText = "Ngày lập";
                dgvXuPhat.Columns["NgayLap"].DefaultCellStyle.Format =
                    "dd/MM/yyyy";
            }

            if (dgvXuPhat.Columns.Contains("LyDo"))
                dgvXuPhat.Columns["LyDo"].HeaderText = "Lý do";

            if (dgvXuPhat.Columns.Contains("SoTienPhat"))
            {
                dgvXuPhat.Columns["SoTienPhat"].HeaderText = "Số tiền phạt";
                dgvXuPhat.Columns["SoTienPhat"].DefaultCellStyle.Format = "N0";
            }

            if (dgvXuPhat.Columns.Contains("TrangThai"))
                dgvXuPhat.Columns["TrangThai"].HeaderText = "Trạng thái";

            dgvXuPhat.ClearSelection();
        }

        private void LamMoiNhapLieu(bool xoaTimKiem = true)
        {
            txtMaPhat.Clear();
            txtLyDo.Clear();
            txtTrangThai.Clear();

            nudSoTienPhat.Value = 0;
            dtNgayLap.Value = DateTime.Today;

            if (cboPhieuKiemTra.Items.Count > 0)
                cboPhieuKiemTra.SelectedIndex = 0;

            if (xoaTimKiem)
                txtTimKiem.Clear();

            dangChonPhieu = false;
            txtMaPhat.ReadOnly = false;
            txtMaPhat.Focus();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                service.Them(
                    txtMaPhat.Text.Trim(),
                    Convert.ToString(cboPhieuKiemTra.SelectedValue),
                    dtNgayLap.Value,
                    txtLyDo.Text.Trim(),
                    nudSoTienPhat.Value,
                    txtTrangThai.Text.Trim()
                );

                MessageBox.Show("Thêm phiếu xử phạt thành công.");

                NapDuLieu();
                LamMoiNhapLieu();
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627 || ex.Number == 2601)
                    MessageBox.Show("Mã phiếu xử phạt đã tồn tại.");
                else if (ex.Number == 547)
                    MessageBox.Show("Phiếu kiểm tra không hợp lệ.");
                else
                    MessageBox.Show(ex.Message, "Lỗi SQL Server");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (!dangChonPhieu)
            {
                MessageBox.Show("Vui lòng chọn phiếu xử phạt cần sửa.");
                return;
            }

            try
            {
                service.Sua(
                    txtMaPhat.Text.Trim(),
                    Convert.ToString(cboPhieuKiemTra.SelectedValue),
                    dtNgayLap.Value,
                    txtLyDo.Text.Trim(),
                    nudSoTienPhat.Value,
                    txtTrangThai.Text.Trim()
                );

                MessageBox.Show("Cập nhật phiếu xử phạt thành công.");

                NapDuLieu();
                LamMoiNhapLieu();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Lỗi SQL Server");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (!dangChonPhieu)
            {
                MessageBox.Show("Vui lòng chọn phiếu xử phạt cần xóa.");
                return;
            }

            DialogResult xacNhan = MessageBox.Show(
                "Bạn có chắc chắn muốn xóa phiếu " + txtMaPhat.Text + "?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (xacNhan != DialogResult.Yes)
                return;

            try
            {
                service.Xoa(txtMaPhat.Text.Trim());

                MessageBox.Show("Xóa phiếu xử phạt thành công.");

                NapDuLieu();
                LamMoiNhapLieu();
            }
            catch (SqlException ex)
            {
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
                dgvXuPhat.DataSource = service.TimKiem(txtTimKiem.Text);
                DinhDangBang();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi tìm kiếm");
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            try
            {
                NapDuLieu();
                LamMoiNhapLieu();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi làm mới");
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvXuPhat_CellClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            DataGridViewRow row = dgvXuPhat.Rows[e.RowIndex];

            if (row.IsNewRow)
                return;

            txtMaPhat.Text =
                Convert.ToString(row.Cells["MaPhat"].Value);

            cboPhieuKiemTra.SelectedValue =
                Convert.ToString(row.Cells["MaKiemTra"].Value);

            txtLyDo.Text =
                Convert.ToString(row.Cells["LyDo"].Value);

            txtTrangThai.Text =
                Convert.ToString(row.Cells["TrangThai"].Value);

            if (row.Cells["NgayLap"].Value != DBNull.Value)
            {
                dtNgayLap.Value =
                    Convert.ToDateTime(row.Cells["NgayLap"].Value);
            }

            decimal soTien =
                Convert.ToDecimal(row.Cells["SoTienPhat"].Value);

            nudSoTienPhat.Value = Math.Min(
                nudSoTienPhat.Maximum,
                Math.Max(nudSoTienPhat.Minimum, soTien)
            );

            dangChonPhieu = true;
            txtMaPhat.ReadOnly = true;
        }
    }
}
