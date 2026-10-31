
using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using QuanLyChoThueVanPhong.Services;

namespace QuanLyChoThueVanPhong.Forms
{
    public partial class FrmDichVu : Form
    {
        private readonly DichVuService service = new DichVuService();
        private bool dangChonDichVu = false;

        public FrmDichVu()
        {
            InitializeComponent();
        }

        private void FrmDichVu_Load(object sender, EventArgs e)
        {
            cboTrangThai.Items.Clear();
            cboTrangThai.Items.Add("Đang sử dụng");
            cboTrangThai.Items.Add("Ngừng sử dụng");
            cboTrangThai.SelectedIndex = 0;

            NapDuLieu();
            LamMoiNhapLieu(false);
        }

        private void NapDuLieu()
        {
            try
            {
                dgvDichVu.DataSource = service.LayDanhSach();
                DinhDangBang();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi tải dữ liệu");
            }
        }

        private void DinhDangBang()
        {
            if (dgvDichVu.Columns.Contains("MaDV"))
                dgvDichVu.Columns["MaDV"].HeaderText = "Mã dịch vụ";

            if (dgvDichVu.Columns.Contains("TenDV"))
                dgvDichVu.Columns["TenDV"].HeaderText = "Tên dịch vụ";

            if (dgvDichVu.Columns.Contains("DonViTinh"))
                dgvDichVu.Columns["DonViTinh"].HeaderText = "Đơn vị tính";

            if (dgvDichVu.Columns.Contains("DonGia"))
            {
                dgvDichVu.Columns["DonGia"].HeaderText = "Đơn giá";
                dgvDichVu.Columns["DonGia"].DefaultCellStyle.Format = "N0";
            }

            if (dgvDichVu.Columns.Contains("TrangThai"))
                dgvDichVu.Columns["TrangThai"].HeaderText = "Trạng thái";

            dgvDichVu.ClearSelection();
        }

        private void LamMoiNhapLieu(bool xoaTimKiem = true)
        {
            txtMaDV.Clear();
            txtTenDV.Clear();
            txtDonViTinh.Clear();
            nudDonGia.Value = 0;

            if (cboTrangThai.Items.Count > 0)
                cboTrangThai.SelectedIndex = 0;

            if (xoaTimKiem)
                txtTimKiem.Clear();

            dangChonDichVu = false;
            txtMaDV.ReadOnly = false;
            txtMaDV.Focus();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                service.Them(
                    txtMaDV.Text,
                    txtTenDV.Text,
                    txtDonViTinh.Text,
                    nudDonGia.Value,
                    cboTrangThai.Text
                );

                MessageBox.Show("Thêm dịch vụ thành công.");
                NapDuLieu();
                LamMoiNhapLieu();
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627 || ex.Number == 2601)
                    MessageBox.Show("Mã hoặc tên dịch vụ đã tồn tại.");
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
            if (!dangChonDichVu)
            {
                MessageBox.Show("Vui lòng chọn dịch vụ cần sửa.");
                return;
            }

            try
            {
                service.Sua(
                    txtMaDV.Text,
                    txtTenDV.Text,
                    txtDonViTinh.Text,
                    nudDonGia.Value,
                    cboTrangThai.Text
                );

                MessageBox.Show("Cập nhật dịch vụ thành công.");
                NapDuLieu();
                LamMoiNhapLieu();
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627 || ex.Number == 2601)
                    MessageBox.Show("Tên dịch vụ đã tồn tại.");
                else
                    MessageBox.Show(ex.Message, "Lỗi SQL Server");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (!dangChonDichVu)
            {
                MessageBox.Show("Vui lòng chọn dịch vụ cần xóa.");
                return;
            }

            if (MessageBox.Show(
                "Bạn có chắc chắn muốn xóa dịch vụ " + txtTenDV.Text + "?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            ) != DialogResult.Yes)
                return;

            try
            {
                service.Xoa(txtMaDV.Text);
                MessageBox.Show("Xóa dịch vụ thành công.");
                NapDuLieu();
                LamMoiNhapLieu();
            }
            catch (SqlException ex)
            {
                if (ex.Number == 547)
                    MessageBox.Show(
                        "Không thể xóa dịch vụ vì đã xuất hiện trong hóa đơn. " +
                        "Bạn có thể chuyển trạng thái sang Ngừng sử dụng."
                    );
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
                dgvDichVu.DataSource = service.TimKiem(txtTimKiem.Text);
                DinhDangBang();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi tìm kiếm");
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LamMoiNhapLieu();
            NapDuLieu();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvDichVu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            DataGridViewRow row = dgvDichVu.Rows[e.RowIndex];

            if (row.IsNewRow)
                return;

            txtMaDV.Text = Convert.ToString(row.Cells["MaDV"].Value);
            txtTenDV.Text = Convert.ToString(row.Cells["TenDV"].Value);
            txtDonViTinh.Text = Convert.ToString(row.Cells["DonViTinh"].Value);
            cboTrangThai.SelectedItem = Convert.ToString(row.Cells["TrangThai"].Value);

            decimal gia = Convert.ToDecimal(row.Cells["DonGia"].Value);

            nudDonGia.Value = Math.Min(
                nudDonGia.Maximum,
                Math.Max(nudDonGia.Minimum, gia)
            );

            dangChonDichVu = true;
            txtMaDV.ReadOnly = true;
        }
    }
}
