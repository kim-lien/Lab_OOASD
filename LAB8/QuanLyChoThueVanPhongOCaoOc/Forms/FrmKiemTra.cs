
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using QuanLyChoThueVanPhong.Services;

namespace QuanLyChoThueVanPhong.Forms
{
    public partial class FrmKiemTra : Form
    {
        private readonly KiemTraService service = new KiemTraService();
        private bool dangChonPhieu = false;

        public FrmKiemTra()
        {
            InitializeComponent();
        }

        private void FrmKiemTra_Load(object sender, EventArgs e)
        {
            try
            {
                cboVanPhong.DisplayMember = "MaPhong";
                cboVanPhong.ValueMember = "MaPhong";
                cboVanPhong.DataSource = service.LayVanPhong();

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
            dgvKiemTra.DataSource = service.LayDanhSach();
            DinhDangBang();
        }

        private void DinhDangBang()
        {
            if (dgvKiemTra.Columns.Contains("MaKiemTra"))
                dgvKiemTra.Columns["MaKiemTra"].HeaderText = "Mã kiểm tra";

            if (dgvKiemTra.Columns.Contains("MaPhong"))
                dgvKiemTra.Columns["MaPhong"].HeaderText = "Văn phòng";

            if (dgvKiemTra.Columns.Contains("MaTang"))
                dgvKiemTra.Columns["MaTang"].HeaderText = "Mã tầng";

            if (dgvKiemTra.Columns.Contains("NgayKiemTra"))
            {
                dgvKiemTra.Columns["NgayKiemTra"].HeaderText = "Ngày kiểm tra";
                dgvKiemTra.Columns["NgayKiemTra"].DefaultCellStyle.Format = "dd/MM/yyyy";
            }

            if (dgvKiemTra.Columns.Contains("TinhTrang"))
                dgvKiemTra.Columns["TinhTrang"].HeaderText = "Tình trạng";

            if (dgvKiemTra.Columns.Contains("KetLuan"))
                dgvKiemTra.Columns["KetLuan"].HeaderText = "Kết luận";

            if (dgvKiemTra.Columns.Contains("NguoiKiemTra"))
                dgvKiemTra.Columns["NguoiKiemTra"].HeaderText = "Người kiểm tra";

            dgvKiemTra.ClearSelection();
        }

        private void LamMoiNhapLieu(bool xoaTimKiem = true)
        {
            txtMaKiemTra.Clear();
            txtTinhTrang.Clear();
            txtKetLuan.Clear();
            txtNguoiKiemTra.Clear();

            if (xoaTimKiem)
                txtTimKiem.Clear();

            if (cboVanPhong.Items.Count > 0)
                cboVanPhong.SelectedIndex = 0;

            dtNgayKiemTra.Value = DateTime.Today;
            dangChonPhieu = false;
            txtMaKiemTra.ReadOnly = false;
            txtMaKiemTra.Focus();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                service.Them(
                    txtMaKiemTra.Text,
                    Convert.ToString(cboVanPhong.SelectedValue),
                    dtNgayKiemTra.Value,
                    txtTinhTrang.Text,
                    txtKetLuan.Text,
                    txtNguoiKiemTra.Text
                );

                MessageBox.Show("Thêm phiếu kiểm tra thành công.");
                NapDuLieu();
                LamMoiNhapLieu();
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627 || ex.Number == 2601)
                    MessageBox.Show("Mã phiếu kiểm tra đã tồn tại.");
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
                MessageBox.Show("Vui lòng chọn phiếu kiểm tra cần sửa.");
                return;
            }

            try
            {
                service.Sua(
                    txtMaKiemTra.Text,
                    Convert.ToString(cboVanPhong.SelectedValue),
                    dtNgayKiemTra.Value,
                    txtTinhTrang.Text,
                    txtKetLuan.Text,
                    txtNguoiKiemTra.Text
                );

                MessageBox.Show("Cập nhật phiếu kiểm tra thành công.");
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
            if (!dangChonPhieu)
            {
                MessageBox.Show("Vui lòng chọn phiếu kiểm tra cần xóa.");
                return;
            }

            if (MessageBox.Show(
                "Bạn có chắc chắn muốn xóa phiếu " +
                txtMaKiemTra.Text + "?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            ) != DialogResult.Yes)
                return;

            try
            {
                service.Xoa(txtMaKiemTra.Text);
                MessageBox.Show("Xóa phiếu kiểm tra thành công.");
                NapDuLieu();
                LamMoiNhapLieu();
            }
            catch (SqlException ex)
            {
                if (ex.Number == 547)
                    MessageBox.Show(
                        "Không thể xóa phiếu kiểm tra vì đã có phiếu xử phạt liên quan."
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
                dgvKiemTra.DataSource = service.TimKiem(txtTimKiem.Text);
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

        private void dgvKiemTra_CellClick(
            object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            DataGridViewRow row = dgvKiemTra.Rows[e.RowIndex];

            if (row.IsNewRow)
                return;

            txtMaKiemTra.Text =
                Convert.ToString(row.Cells["MaKiemTra"].Value);

            cboVanPhong.SelectedValue =
                Convert.ToString(row.Cells["MaPhong"].Value);

            txtTinhTrang.Text =
                Convert.ToString(row.Cells["TinhTrang"].Value);

            txtKetLuan.Text =
                Convert.ToString(row.Cells["KetLuan"].Value);

            txtNguoiKiemTra.Text =
                Convert.ToString(row.Cells["NguoiKiemTra"].Value);

            if (row.Cells["NgayKiemTra"].Value != DBNull.Value)
                dtNgayKiemTra.Value =
                    Convert.ToDateTime(row.Cells["NgayKiemTra"].Value);

            dangChonPhieu = true;
            txtMaKiemTra.ReadOnly = true;
        }
    }
}
