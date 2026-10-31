
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using QuanLyChoThueVanPhong.Services;

namespace QuanLyChoThueVanPhong.Forms
{
    public partial class FrmTang : Form
    {
        private readonly TangService tangService = new TangService();

        public FrmTang()
        {
            InitializeComponent();
        }

        private void FrmTang_Load(object sender, EventArgs e)
        {
            NapDuLieu();
        }

        private void NapDuLieu()
        {
            try
            {
                dgvTang.DataSource = tangService.LayDanhSach();
                DinhDangBang();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Không thể tải danh sách tầng.\n" + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void DinhDangBang()
        {
            if (dgvTang.Columns.Contains("MaTang"))
                dgvTang.Columns["MaTang"].HeaderText = "Mã tầng";

            if (dgvTang.Columns.Contains("SoTang"))
                dgvTang.Columns["SoTang"].HeaderText = "Số tầng";

            if (dgvTang.Columns.Contains("MoTa"))
                dgvTang.Columns["MoTa"].HeaderText = "Mô tả";

            dgvTang.ClearSelection();
        }

        private void LamMoiNhapLieu()
        {
            txtMaTang.Clear();
            nudSoTang.Value = 1;
            txtMoTa.Clear();
            txtTimKiem.Clear();
            txtMaTang.Enabled = true;
            txtMaTang.Focus();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                tangService.Them(
                    txtMaTang.Text.Trim(),
                    (int)nudSoTang.Value,
                    txtMoTa.Text.Trim()
                );

                MessageBox.Show(
                    "Thêm tầng thành công.",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                NapDuLieu();
                LamMoiNhapLieu();
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627 || ex.Number == 2601)
                {
                    MessageBox.Show(
                        "Mã tầng hoặc số tầng đã tồn tại.",
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

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaTang.Enabled)
            {
                MessageBox.Show("Vui lòng chọn tầng trong danh sách.");
                return;
            }

            try
            {
                tangService.Sua(
                    txtMaTang.Text.Trim(),
                    (int)nudSoTang.Value,
                    txtMoTa.Text.Trim()
                );

                MessageBox.Show("Cập nhật tầng thành công.");

                NapDuLieu();
                LamMoiNhapLieu();
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627 || ex.Number == 2601)
                    MessageBox.Show("Số tầng đã tồn tại.");
                else
                    MessageBox.Show(ex.Message, "Lỗi SQL Server");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaTang.Enabled)
            {
                MessageBox.Show("Vui lòng chọn tầng cần xóa.");
                return;
            }

            DialogResult xacNhan = MessageBox.Show(
                "Bạn có chắc chắn muốn xóa tầng " + txtMaTang.Text + "?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (xacNhan != DialogResult.Yes)
                return;

            try
            {
                tangService.Xoa(txtMaTang.Text.Trim());

                MessageBox.Show("Xóa tầng thành công.");

                NapDuLieu();
                LamMoiNhapLieu();
            }
            catch (SqlException ex)
            {
                if (ex.Number == 547)
                {
                    MessageBox.Show(
                        "Không thể xóa tầng vì đang có văn phòng thuộc tầng này.",
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
                dgvTang.DataSource = tangService.TimKiem(txtTimKiem.Text);
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

        private void dgvTang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            DataGridViewRow row = dgvTang.Rows[e.RowIndex];

            if (row.IsNewRow)
                return;

            txtMaTang.Text = Convert.ToString(row.Cells["MaTang"].Value);
            txtMoTa.Text = Convert.ToString(row.Cells["MoTa"].Value);

            decimal soTang;

            if (decimal.TryParse(
                Convert.ToString(row.Cells["SoTang"].Value),
                out soTang
            ))
            {
                if (soTang >= nudSoTang.Minimum &&
                    soTang <= nudSoTang.Maximum)
                {
                    nudSoTang.Value = soTang;
                }
            }

            txtMaTang.Enabled = false;
        }
    }
}
