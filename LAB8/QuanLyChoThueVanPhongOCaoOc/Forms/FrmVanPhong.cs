
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using QuanLyChoThueVanPhong.Services;

namespace QuanLyChoThueVanPhong.Forms
{
    public partial class FrmVanPhong : Form
    {
        private readonly VanPhongService service = new VanPhongService();
        private bool dangChonVanPhong = false;

        public FrmVanPhong()
        {
            InitializeComponent();
        }

        private void FrmVanPhong_Load(object sender, EventArgs e)
        {
            try
            {
                cboTang.DisplayMember = "SoTang";
                cboTang.ValueMember = "MaTang";
                cboTang.DataSource = service.LayDanhSachTang();

                cboTrangThai.Items.Clear();
                cboTrangThai.Items.Add("Trống");
                cboTrangThai.Items.Add("Đang thuê");
                cboTrangThai.Items.Add("Bảo trì");
                cboTrangThai.SelectedIndex = 0;

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
            dgvVanPhong.DataSource = service.LayDanhSach();
            DinhDangBang();
        }

        private void DinhDangBang()
        {
            if (dgvVanPhong.Columns.Contains("MaPhong"))
                dgvVanPhong.Columns["MaPhong"].HeaderText = "Mã văn phòng";

            if (dgvVanPhong.Columns.Contains("MaTang"))
                dgvVanPhong.Columns["MaTang"].Visible = false;

            if (dgvVanPhong.Columns.Contains("SoTang"))
                dgvVanPhong.Columns["SoTang"].HeaderText = "Tầng";

            if (dgvVanPhong.Columns.Contains("DienTich"))
                dgvVanPhong.Columns["DienTich"].HeaderText = "Diện tích (m²)";

            if (dgvVanPhong.Columns.Contains("HuongPhong"))
                dgvVanPhong.Columns["HuongPhong"].HeaderText = "Hướng phòng";

            if (dgvVanPhong.Columns.Contains("DonGiaThue"))
            {
                dgvVanPhong.Columns["DonGiaThue"].HeaderText = "Đơn giá thuê";
                dgvVanPhong.Columns["DonGiaThue"].DefaultCellStyle.Format = "N0";
            }

            if (dgvVanPhong.Columns.Contains("TrangThai"))
                dgvVanPhong.Columns["TrangThai"].HeaderText = "Trạng thái";

            dgvVanPhong.ClearSelection();
        }

        private void LamMoiNhapLieu(bool xoaTimKiem = true)
        {
            txtMaPhong.Clear();
            txtHuongPhong.Clear();

            nudDienTich.Value = nudDienTich.Minimum;
            nudDonGia.Value = nudDonGia.Minimum;

            if (cboTang.Items.Count > 0)
                cboTang.SelectedIndex = 0;

            if (cboTrangThai.Items.Count > 0)
                cboTrangThai.SelectedIndex = 0;

            if (xoaTimKiem)
                txtTimKiem.Clear();

            dangChonVanPhong = false;
            txtMaPhong.ReadOnly = false;
            txtMaPhong.Focus();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                service.Them(
                    txtMaPhong.Text.Trim(),
                    Convert.ToString(cboTang.SelectedValue),
                    nudDienTich.Value,
                    txtHuongPhong.Text.Trim(),
                    nudDonGia.Value,
                    cboTrangThai.Text
                );

                MessageBox.Show("Thêm văn phòng thành công.");
                NapDuLieu();
                LamMoiNhapLieu();
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627 || ex.Number == 2601)
                    MessageBox.Show("Mã văn phòng đã tồn tại.");
                else if (ex.Number == 547)
                    MessageBox.Show("Tầng được chọn không tồn tại.");
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
            if (!dangChonVanPhong)
            {
                MessageBox.Show("Vui lòng chọn văn phòng cần sửa.");
                return;
            }

            try
            {
                service.Sua(
                    txtMaPhong.Text.Trim(),
                    Convert.ToString(cboTang.SelectedValue),
                    nudDienTich.Value,
                    txtHuongPhong.Text.Trim(),
                    nudDonGia.Value,
                    cboTrangThai.Text
                );

                MessageBox.Show("Cập nhật văn phòng thành công.");
                NapDuLieu();
                LamMoiNhapLieu();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi cập nhật");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (!dangChonVanPhong)
            {
                MessageBox.Show("Vui lòng chọn văn phòng cần xóa.");
                return;
            }

            DialogResult xacNhan = MessageBox.Show(
                "Bạn có chắc chắn muốn xóa văn phòng " + txtMaPhong.Text + "?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (xacNhan != DialogResult.Yes)
                return;

            try
            {
                service.Xoa(txtMaPhong.Text.Trim());
                MessageBox.Show("Xóa văn phòng thành công.");
                NapDuLieu();
                LamMoiNhapLieu();
            }
            catch (SqlException ex)
            {
                if (ex.Number == 547)
                {
                    MessageBox.Show(
                        "Không thể xóa văn phòng vì đã phát sinh hợp đồng, nhân viên hoặc phiếu kiểm tra.",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                }
                else
                {
                    MessageBox.Show(ex.Message, "Lỗi SQL Server");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                dgvVanPhong.DataSource = service.TimKiem(txtTimKiem.Text);
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

        private void dgvVanPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            DataGridViewRow row = dgvVanPhong.Rows[e.RowIndex];

            if (row.IsNewRow)
                return;

            txtMaPhong.Text = Convert.ToString(row.Cells["MaPhong"].Value);
            cboTang.SelectedValue = Convert.ToString(row.Cells["MaTang"].Value);
            txtHuongPhong.Text = Convert.ToString(row.Cells["HuongPhong"].Value);
            cboTrangThai.SelectedItem = Convert.ToString(row.Cells["TrangThai"].Value);

            decimal dienTich = Convert.ToDecimal(row.Cells["DienTich"].Value);
            decimal donGia = Convert.ToDecimal(row.Cells["DonGiaThue"].Value);

            nudDienTich.Value = Math.Min(
                nudDienTich.Maximum,
                Math.Max(nudDienTich.Minimum, dienTich)
            );

            nudDonGia.Value = Math.Min(
                nudDonGia.Maximum,
                Math.Max(nudDonGia.Minimum, donGia)
            );

            dangChonVanPhong = true;
            txtMaPhong.ReadOnly = true;
        }
    }
}
