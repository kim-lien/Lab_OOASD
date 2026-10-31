
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using QuanLyChoThueVanPhong.Services;

namespace QuanLyChoThueVanPhong.Forms
{
    public partial class FrmNhanVien : Form
    {
        private readonly NhanVienService service = new NhanVienService();
        private bool dangChonNhanVien = false;
        private bool dangNapDuLieu = false;
        private object hinhAnhHienTai = null;
        private string duongDanAnhMoi = "";

        public FrmNhanVien()
        {
            InitializeComponent();
        }

        private void FrmNhanVien_Load(object sender, EventArgs e)
        {
            try
            {
                dangNapDuLieu = true;

                cboKhachHang.DisplayMember = "TenCongTy";
                cboKhachHang.ValueMember = "MaKH";
                cboKhachHang.DataSource = service.LayKhachHang();

                cboTrangThai.Items.Clear();
                cboTrangThai.Items.Add("Đang làm việc");
                cboTrangThai.Items.Add("Nghỉ việc");
                cboTrangThai.SelectedIndex = 0;

                dangNapDuLieu = false;

                NapVanPhong();
                NapDuLieu();
                LamMoiNhapLieu(false);
            }
            catch (Exception ex)
            {
                dangNapDuLieu = false;
                MessageBox.Show(ex.Message, "Lỗi tải dữ liệu");
            }
        }

        private void NapVanPhong()
        {
            if (dangNapDuLieu)
                return;

            dangNapDuLieu = true;

            try
            {
                cboVanPhong.DataSource = null;

                if (cboKhachHang.SelectedValue == null ||
                    cboKhachHang.SelectedValue is DataRowView)
                    return;

                cboVanPhong.DisplayMember = "MaPhong";
                cboVanPhong.ValueMember = "MaPhong";
                cboVanPhong.DataSource = service.LayVanPhong(
                    Convert.ToString(cboKhachHang.SelectedValue)
                );
            }
            finally
            {
                dangNapDuLieu = false;
            }
        }

        private void NapDuLieu()
        {
            dgvNhanVien.DataSource = service.LayDanhSach();

            if (dgvNhanVien.Columns.Contains("MaNV"))
                dgvNhanVien.Columns["MaNV"].HeaderText = "Mã nhân viên";

            if (dgvNhanVien.Columns.Contains("MaKH"))
                dgvNhanVien.Columns["MaKH"].Visible = false;

            if (dgvNhanVien.Columns.Contains("TenCongTy"))
                dgvNhanVien.Columns["TenCongTy"].HeaderText = "Công ty";

            if (dgvNhanVien.Columns.Contains("MaPhong"))
                dgvNhanVien.Columns["MaPhong"].HeaderText = "Văn phòng";

            if (dgvNhanVien.Columns.Contains("HoTen"))
                dgvNhanVien.Columns["HoTen"].HeaderText = "Họ tên";

            if (dgvNhanVien.Columns.Contains("ChucVu"))
                dgvNhanVien.Columns["ChucVu"].HeaderText = "Chức vụ";

            if (dgvNhanVien.Columns.Contains("DienThoai"))
                dgvNhanVien.Columns["DienThoai"].HeaderText = "Điện thoại";

            if (dgvNhanVien.Columns.Contains("TrangThai"))
                dgvNhanVien.Columns["TrangThai"].HeaderText = "Trạng thái";

            dgvNhanVien.ClearSelection();
        }

        private void LamMoiNhapLieu(bool xoaTimKiem = true)
        {
            txtMaNV.Clear();
            txtHoTen.Clear();
            txtChucVu.Clear();
            txtDienThoai.Clear();

            if (xoaTimKiem)
                txtTimKiem.Clear();

            if (cboKhachHang.Items.Count > 0)
                cboKhachHang.SelectedIndex = 0;

            if (cboTrangThai.Items.Count > 0)
                cboTrangThai.SelectedIndex = 0;

            hinhAnhHienTai = null;
            duongDanAnhMoi = "";
            XoaAnhHienThi();

            dangChonNhanVien = false;
            txtMaNV.ReadOnly = false;
            txtMaNV.Focus();
        }

        private void XoaAnhHienThi()
        {
            Image anhCu = picHinhAnh.Image;
            picHinhAnh.Image = null;

            if (anhCu != null)
                anhCu.Dispose();
        }

        private void HienThiAnh(object duLieu)
        {
            XoaAnhHienThi();

            try
            {
                if (duLieu is byte[])
                {
                    byte[] bytes = (byte[])duLieu;

                    using (MemoryStream stream = new MemoryStream(bytes))
                    using (Image anh = Image.FromStream(stream))
                    {
                        picHinhAnh.Image = new Bitmap(anh);
                    }
                }
                else if (duLieu != null)
                {
                    string duongDan = Convert.ToString(duLieu);

                    if (File.Exists(duongDan))
                    {
                        using (Image anh = Image.FromFile(duongDan))
                        {
                            picHinhAnh.Image = new Bitmap(anh);
                        }
                    }
                }
            }
            catch
            {
                XoaAnhHienThi();
            }
        }

        private object LayDuLieuAnh()
        {
            if (string.IsNullOrWhiteSpace(duongDanAnhMoi))
                return hinhAnhHienTai;

            if (service.HinhAnhLaNhiPhan())
                return File.ReadAllBytes(duongDanAnhMoi);

            return duongDanAnhMoi;
        }

        private void cboKhachHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!dangNapDuLieu)
            {
                try
                {
                    NapVanPhong();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi");
                }
            }
        }

        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.Title = "Chọn ảnh nhân viên";
                dialog.Filter = "Ảnh|*.jpg;*.jpeg;*.png;*.bmp";
                dialog.CheckFileExists = true;

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    duongDanAnhMoi = dialog.FileName;
                    HienThiAnh(duongDanAnhMoi);
                }
            }
        }

        private void btnXoaAnh_Click(object sender, EventArgs e)
        {
            duongDanAnhMoi = "";
            hinhAnhHienTai = null;
            XoaAnhHienThi();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                service.Them(
                    txtMaNV.Text.Trim(),
                    Convert.ToString(cboKhachHang.SelectedValue),
                    Convert.ToString(cboVanPhong.SelectedValue),
                    txtHoTen.Text.Trim(),
                    LayDuLieuAnh(),
                    txtChucVu.Text.Trim(),
                    txtDienThoai.Text.Trim(),
                    cboTrangThai.Text
                );

                MessageBox.Show("Thêm nhân viên thành công.");
                NapDuLieu();
                LamMoiNhapLieu();
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627 || ex.Number == 2601)
                    MessageBox.Show("Mã nhân viên đã tồn tại.");
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
            if (!dangChonNhanVien)
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần sửa.");
                return;
            }

            try
            {
                service.Sua(
                    txtMaNV.Text.Trim(),
                    Convert.ToString(cboKhachHang.SelectedValue),
                    Convert.ToString(cboVanPhong.SelectedValue),
                    txtHoTen.Text.Trim(),
                    LayDuLieuAnh(),
                    txtChucVu.Text.Trim(),
                    txtDienThoai.Text.Trim(),
                    cboTrangThai.Text
                );

                MessageBox.Show("Cập nhật nhân viên thành công.");
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
            if (!dangChonNhanVien)
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần xóa.");
                return;
            }

            if (MessageBox.Show(
                "Bạn có chắc chắn muốn xóa nhân viên " + txtHoTen.Text + "?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            ) != DialogResult.Yes)
                return;

            try
            {
                service.Xoa(txtMaNV.Text.Trim());

                MessageBox.Show("Xóa nhân viên thành công.");
                NapDuLieu();
                LamMoiNhapLieu();
            }
            catch (SqlException ex)
            {
                if (ex.Number == 547)
                    MessageBox.Show(
                        "Không thể xóa nhân viên đã có thẻ giữ xe. " +
                        "Hãy xử lý thẻ giữ xe trước."
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
                dgvNhanVien.DataSource = service.TimKiem(txtTimKiem.Text);
                dgvNhanVien.ClearSelection();
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

        private void dgvNhanVien_CellClick(
            object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            DataGridViewRow row = dgvNhanVien.Rows[e.RowIndex];

            if (row.IsNewRow)
                return;

            try
            {
                txtMaNV.Text = Convert.ToString(row.Cells["MaNV"].Value);
                txtHoTen.Text = Convert.ToString(row.Cells["HoTen"].Value);
                txtChucVu.Text = Convert.ToString(row.Cells["ChucVu"].Value);
                txtDienThoai.Text = Convert.ToString(row.Cells["DienThoai"].Value);

                cboKhachHang.SelectedValue =
                    Convert.ToString(row.Cells["MaKH"].Value);

                cboVanPhong.SelectedValue =
                    Convert.ToString(row.Cells["MaPhong"].Value);

                string trangThai = Convert.ToString(
                    row.Cells["TrangThai"].Value
                );

                int viTri = cboTrangThai.FindStringExact(trangThai);

                if (viTri >= 0)
                    cboTrangThai.SelectedIndex = viTri;
                else
                    cboTrangThai.Text = trangThai;

                hinhAnhHienTai = service.LayHinhAnh(txtMaNV.Text);
                duongDanAnhMoi = "";
                HienThiAnh(hinhAnhHienTai);

                dangChonNhanVien = true;
                txtMaNV.ReadOnly = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi chọn nhân viên");
            }
        }
    }
}
