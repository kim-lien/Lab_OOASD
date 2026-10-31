
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using QuanLyChoThueVanPhong.Services;

namespace QuanLyChoThueVanPhong.Forms
{
    public partial class FrmKhachHang : Form
    {
        private readonly KhachHangService service = new KhachHangService();
        private bool dangChonKhachHang = false;

        public FrmKhachHang()
        {
            InitializeComponent();
        }

        private void FrmKhachHang_Load(object sender, EventArgs e)
        {
            NapDuLieu();
            LamMoiNhapLieu(false);
        }

        private void NapDuLieu()
        {
            try
            {
                dgvKhachHang.DataSource = service.LayDanhSach();
                DinhDangBang();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Không thể tải danh sách khách hàng.\n" + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void DinhDangBang()
        {
            if (dgvKhachHang.Columns.Contains("MaKH"))
                dgvKhachHang.Columns["MaKH"].HeaderText = "Mã KH";

            if (dgvKhachHang.Columns.Contains("TenCongTy"))
                dgvKhachHang.Columns["TenCongTy"].HeaderText = "Tên công ty";

            if (dgvKhachHang.Columns.Contains("DiaChi"))
                dgvKhachHang.Columns["DiaChi"].HeaderText = "Địa chỉ";

            if (dgvKhachHang.Columns.Contains("DienThoai"))
                dgvKhachHang.Columns["DienThoai"].HeaderText = "Điện thoại";

            if (dgvKhachHang.Columns.Contains("Email"))
                dgvKhachHang.Columns["Email"].HeaderText = "Email";

            if (dgvKhachHang.Columns.Contains("NguoiDaiDien"))
                dgvKhachHang.Columns["NguoiDaiDien"].HeaderText = "Người đại diện";

            dgvKhachHang.ClearSelection();
        }

        private void LamMoiNhapLieu(bool xoaTimKiem = true)
        {
            txtMaKH.Clear();
            txtTenCongTy.Clear();
            txtDiaChi.Clear();
            txtDienThoai.Clear();
            txtEmail.Clear();
            txtNguoiDaiDien.Clear();

            if (xoaTimKiem)
                txtTimKiem.Clear();

            dangChonKhachHang = false;
            txtMaKH.ReadOnly = false;
            txtMaKH.Focus();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                service.Them(
                    txtMaKH.Text.Trim(),
                    txtTenCongTy.Text.Trim(),
                    txtDiaChi.Text.Trim(),
                    txtDienThoai.Text.Trim(),
                    txtEmail.Text.Trim(),
                    txtNguoiDaiDien.Text.Trim()
                );

                MessageBox.Show("Thêm khách hàng thành công.");
                NapDuLieu();
                LamMoiNhapLieu();
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627 || ex.Number == 2601)
                    MessageBox.Show("Mã khách hàng đã tồn tại.");
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
            if (!dangChonKhachHang)
            {
                MessageBox.Show("Vui lòng chọn khách hàng cần sửa.");
                return;
            }

            try
            {
                service.Sua(
                    txtMaKH.Text.Trim(),
                    txtTenCongTy.Text.Trim(),
                    txtDiaChi.Text.Trim(),
                    txtDienThoai.Text.Trim(),
                    txtEmail.Text.Trim(),
                    txtNguoiDaiDien.Text.Trim()
                );

                MessageBox.Show("Cập nhật khách hàng thành công.");
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
            if (!dangChonKhachHang)
            {
                MessageBox.Show("Vui lòng chọn khách hàng cần xóa.");
                return;
            }

            DialogResult xacNhan = MessageBox.Show(
                "Bạn có chắc chắn muốn xóa khách hàng " + txtMaKH.Text + "?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (xacNhan != DialogResult.Yes)
                return;

            try
            {
                service.Xoa(txtMaKH.Text.Trim());

                MessageBox.Show("Xóa khách hàng thành công.");
                NapDuLieu();
                LamMoiNhapLieu();
            }
            catch (SqlException ex)
            {
                if (ex.Number == 547)
                {
                    MessageBox.Show(
                        "Không thể xóa khách hàng vì đã phát sinh hợp đồng hoặc nhân viên liên quan.",
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
                MessageBox.Show(ex.Message, "Thông báo");
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                dgvKhachHang.DataSource = service.TimKiem(txtTimKiem.Text);
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

        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            DataGridViewRow row = dgvKhachHang.Rows[e.RowIndex];

            if (row.IsNewRow)
                return;

            txtMaKH.Text = Convert.ToString(row.Cells["MaKH"].Value);
            txtTenCongTy.Text = Convert.ToString(row.Cells["TenCongTy"].Value);
            txtDiaChi.Text = Convert.ToString(row.Cells["DiaChi"].Value);
            txtDienThoai.Text = Convert.ToString(row.Cells["DienThoai"].Value);
            txtEmail.Text = Convert.ToString(row.Cells["Email"].Value);
            txtNguoiDaiDien.Text = Convert.ToString(row.Cells["NguoiDaiDien"].Value);

            dangChonKhachHang = true;
            txtMaKH.ReadOnly = true;
        }
    }
}
