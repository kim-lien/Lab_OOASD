
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using QuanLyChoThueVanPhong.Services;

namespace QuanLyChoThueVanPhong.Forms
{
    public partial class FrmTheGiuXe : Form
    {
        private readonly TheGiuXeService service = new TheGiuXeService();
        private bool dangChonThe = false;

        public FrmTheGiuXe()
        {
            InitializeComponent();
        }

        private void FrmTheGiuXe_Load(object sender, EventArgs e)
        {
            try
            {
                cboNhanVien.DisplayMember = "HoTen";
                cboNhanVien.ValueMember = "MaNV";
                cboNhanVien.DataSource = service.LayNhanVien();

                cboLoaiXe.Items.Add("Xe máy");
                cboLoaiXe.Items.Add("Ô tô");
                cboLoaiXe.Items.Add("Xe đạp");

                cboTrangThai.Items.Add("Đang sử dụng");
                cboTrangThai.Items.Add("Ngừng sử dụng");
                cboTrangThai.Items.Add("Mất thẻ");

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
            dgvTheXe.DataSource = service.LayDanhSach();
            DinhDangBang();
        }

        private void DinhDangBang()
        {
            if (dgvTheXe.Columns.Contains("MaThe"))
                dgvTheXe.Columns["MaThe"].HeaderText = "Mã thẻ";

            if (dgvTheXe.Columns.Contains("MaNV"))
                dgvTheXe.Columns["MaNV"].HeaderText = "Mã NV";

            if (dgvTheXe.Columns.Contains("HoTen"))
                dgvTheXe.Columns["HoTen"].HeaderText = "Nhân viên";

            if (dgvTheXe.Columns.Contains("MaPhong"))
                dgvTheXe.Columns["MaPhong"].HeaderText = "Văn phòng";

            if (dgvTheXe.Columns.Contains("BienSoXe"))
                dgvTheXe.Columns["BienSoXe"].HeaderText = "Biển số xe";

            if (dgvTheXe.Columns.Contains("LoaiXe"))
                dgvTheXe.Columns["LoaiXe"].HeaderText = "Loại xe";

            if (dgvTheXe.Columns.Contains("HangXe"))
                dgvTheXe.Columns["HangXe"].HeaderText = "Hãng xe";

            if (dgvTheXe.Columns.Contains("NgayCap"))
            {
                dgvTheXe.Columns["NgayCap"].HeaderText = "Ngày cấp";
                dgvTheXe.Columns["NgayCap"].DefaultCellStyle.Format = "dd/MM/yyyy";
            }

            if (dgvTheXe.Columns.Contains("TrangThai"))
                dgvTheXe.Columns["TrangThai"].HeaderText = "Trạng thái";

            dgvTheXe.ClearSelection();
        }

        private void LamMoiNhapLieu(bool xoaTimKiem = true)
        {
            txtMaThe.Clear();
            txtBienSoXe.Clear();
            txtHangXe.Clear();

            if (xoaTimKiem)
                txtTimKiem.Clear();

            if (cboNhanVien.Items.Count > 0)
                cboNhanVien.SelectedIndex = 0;

            if (cboLoaiXe.Items.Count > 0)
                cboLoaiXe.SelectedIndex = 0;

            if (cboTrangThai.Items.Count > 0)
                cboTrangThai.SelectedIndex = 0;

            dtNgayCap.Value = DateTime.Today;

            dangChonThe = false;
            txtMaThe.ReadOnly = false;
            txtMaThe.Focus();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                service.Them(
                    txtMaThe.Text,
                    Convert.ToString(cboNhanVien.SelectedValue),
                    txtBienSoXe.Text,
                    cboLoaiXe.Text,
                    txtHangXe.Text,
                    dtNgayCap.Value,
                    cboTrangThai.Text
                );

                MessageBox.Show("Thêm thẻ giữ xe thành công.");
                NapDuLieu();
                LamMoiNhapLieu();
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627 || ex.Number == 2601)
                    MessageBox.Show("Mã thẻ hoặc biển số xe đã tồn tại.");
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
            if (!dangChonThe)
            {
                MessageBox.Show("Vui lòng chọn thẻ giữ xe cần sửa.");
                return;
            }

            try
            {
                service.Sua(
                    txtMaThe.Text,
                    Convert.ToString(cboNhanVien.SelectedValue),
                    txtBienSoXe.Text,
                    cboLoaiXe.Text,
                    txtHangXe.Text,
                    dtNgayCap.Value,
                    cboTrangThai.Text
                );

                MessageBox.Show("Cập nhật thẻ giữ xe thành công.");
                NapDuLieu();
                LamMoiNhapLieu();
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627 || ex.Number == 2601)
                    MessageBox.Show("Mã thẻ hoặc biển số xe đã tồn tại.");
                else
                    MessageBox.Show(ex.Message, "Lỗi SQL Server");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi cập nhật");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (!dangChonThe)
            {
                MessageBox.Show("Vui lòng chọn thẻ giữ xe cần xóa.");
                return;
            }

            if (MessageBox.Show(
                "Bạn có chắc chắn muốn xóa thẻ " + txtMaThe.Text + "?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            ) != DialogResult.Yes)
                return;

            try
            {
                service.Xoa(txtMaThe.Text);
                MessageBox.Show("Xóa thẻ giữ xe thành công.");
                NapDuLieu();
                LamMoiNhapLieu();
            }
            catch (SqlException ex)
            {
                if (ex.Number == 547)
                    MessageBox.Show("Không thể xóa thẻ vì có dữ liệu liên quan.");
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
                dgvTheXe.DataSource = service.TimKiem(txtTimKiem.Text);
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

        private void dgvTheXe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            DataGridViewRow row = dgvTheXe.Rows[e.RowIndex];

            if (row.IsNewRow)
                return;

            txtMaThe.Text = Convert.ToString(row.Cells["MaThe"].Value);
            txtBienSoXe.Text = Convert.ToString(row.Cells["BienSoXe"].Value);
            txtHangXe.Text = Convert.ToString(row.Cells["HangXe"].Value);

            cboNhanVien.SelectedValue =
                Convert.ToString(row.Cells["MaNV"].Value);

            string loaiXe = Convert.ToString(row.Cells["LoaiXe"].Value);
            int viTriLoai = cboLoaiXe.FindStringExact(loaiXe);

            if (viTriLoai >= 0)
                cboLoaiXe.SelectedIndex = viTriLoai;

            string trangThai = Convert.ToString(row.Cells["TrangThai"].Value);
            int viTriTrangThai = cboTrangThai.FindStringExact(trangThai);

            if (viTriTrangThai >= 0)
                cboTrangThai.SelectedIndex = viTriTrangThai;

            if (row.Cells["NgayCap"].Value != DBNull.Value)
                dtNgayCap.Value = Convert.ToDateTime(row.Cells["NgayCap"].Value);

            dangChonThe = true;
            txtMaThe.ReadOnly = true;
        }
    }
}
