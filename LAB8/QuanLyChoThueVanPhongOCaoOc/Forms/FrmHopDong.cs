
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using QuanLyChoThueVanPhong.Services;

namespace QuanLyChoThueVanPhong.Forms
{
    public partial class FrmHopDong : Form
    {
        private readonly HopDongService service = new HopDongService();

        public FrmHopDong()
        {
            InitializeComponent();
        }

        private void FrmHopDong_Load(object sender, EventArgs e)
        {
            try
            {
                cboKhachHang.DisplayMember = "TenCongTy";
                cboKhachHang.ValueMember = "MaKH";
                cboKhachHang.DataSource = service.LayKhachHang();

                NapVanPhong();
                NapHopDong();
                LamMoiNhapLieu();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi tải dữ liệu");
            }
        }

        private void NapVanPhong()
        {
            dgvVanPhong.DataSource = null;
            dgvVanPhong.Columns.Clear();
            dgvVanPhong.AutoGenerateColumns = true;
            dgvVanPhong.DataSource = service.LayVanPhong();


            foreach (DataGridViewColumn cot in dgvVanPhong.Columns)
            {
                cot.ReadOnly = true;
            }


            DataGridViewCheckBoxColumn cotChon =
                new DataGridViewCheckBoxColumn();

            cotChon.Name = "Chon";
            cotChon.HeaderText = "Chọn";
            cotChon.Width = 65;
            cotChon.TrueValue = true;
            cotChon.FalseValue = false;

            dgvVanPhong.Columns.Insert(0, cotChon);

            if (dgvVanPhong.Columns.Contains("MaPhong"))
                dgvVanPhong.Columns["MaPhong"].HeaderText = "Mã phòng";

            if (dgvVanPhong.Columns.Contains("SoTang"))
                dgvVanPhong.Columns["SoTang"].HeaderText = "Tầng";

            if (dgvVanPhong.Columns.Contains("DienTich"))
                dgvVanPhong.Columns["DienTich"].HeaderText = "Diện tích";

            if (dgvVanPhong.Columns.Contains("HuongPhong"))
                dgvVanPhong.Columns["HuongPhong"].HeaderText = "Hướng";

            if (dgvVanPhong.Columns.Contains("DonGiaThue"))
            {
                dgvVanPhong.Columns["DonGiaThue"].HeaderText = "Giá thuê/tháng";
                dgvVanPhong.Columns["DonGiaThue"].DefaultCellStyle.Format = "N0";
            }

            if (dgvVanPhong.Columns.Contains("TrangThai"))
                dgvVanPhong.Columns["TrangThai"].HeaderText = "Trạng thái";

            dgvVanPhong.ClearSelection();
        }

        private void NapHopDong()
        {
            dgvHopDong.DataSource = service.LayHopDong();
            DinhDangHopDong();
        }

        private void DinhDangHopDong()
        {
            if (dgvHopDong.Columns.Contains("MaHD"))
                dgvHopDong.Columns["MaHD"].HeaderText = "Mã HĐ";

            if (dgvHopDong.Columns.Contains("TenCongTy"))
                dgvHopDong.Columns["TenCongTy"].HeaderText = "Khách hàng";

            if (dgvHopDong.Columns.Contains("NgayKy"))
                dgvHopDong.Columns["NgayKy"].HeaderText = "Ngày ký";

            if (dgvHopDong.Columns.Contains("NgayBatDau"))
                dgvHopDong.Columns["NgayBatDau"].HeaderText = "Ngày bắt đầu";

            if (dgvHopDong.Columns.Contains("NgayKetThuc"))
                dgvHopDong.Columns["NgayKetThuc"].HeaderText = "Ngày kết thúc";

            if (dgvHopDong.Columns.Contains("ThoiHanThue"))
                dgvHopDong.Columns["ThoiHanThue"].HeaderText = "Số tháng";

            if (dgvHopDong.Columns.Contains("TongTienThueThang"))
            {
                dgvHopDong.Columns["TongTienThueThang"].HeaderText = "Tiền thuê/tháng";
                dgvHopDong.Columns["TongTienThueThang"].DefaultCellStyle.Format = "N0";
            }

            if (dgvHopDong.Columns.Contains("TrangThai"))
                dgvHopDong.Columns["TrangThai"].HeaderText = "Trạng thái";

            dgvHopDong.ClearSelection();
        }

        private void LamMoiNhapLieu()
        {
            txtMaHD.Clear();
            txtTimKiem.Clear();

            dtNgayKy.Value = DateTime.Today;
            dtNgayBatDau.Value = DateTime.Today;
            nudThoiHan.Value = 6;

            if (cboKhachHang.Items.Count > 0)
                cboKhachHang.SelectedIndex = 0;

            dgvVanPhong.EndEdit();

            foreach (DataGridViewRow row in dgvVanPhong.Rows)
            {
                if (!row.IsNewRow)
                    row.Cells["Chon"].Value = false;
            }

            lblTongTien.Text = "0 VNĐ";
            lblTraTruoc.Text = "0 VNĐ";

            dgvChiTiet.DataSource = null;
            dgvKyThanhToan.DataSource = null;
            txtMaHD.Focus();
        }

        private DataTable LayPhongDaChon()
        {
            dgvVanPhong.EndEdit();

            DataTable table = new DataTable();
            table.Columns.Add("MaPhong", typeof(string));

            foreach (DataGridViewRow row in dgvVanPhong.Rows)
            {
                if (row.IsNewRow)
                    continue;

                if (Convert.ToBoolean(row.Cells["Chon"].Value ?? false))
                {
                    string maPhong =
                        Convert.ToString(row.Cells["MaPhong"].Value);

                    table.Rows.Add(maPhong);
                }
            }

            return table;
        }

        private void TinhTien()
        {
            dgvVanPhong.EndEdit();

            decimal tongTien = 0;

            foreach (DataGridViewRow row in dgvVanPhong.Rows)
            {
                if (row.IsNewRow)
                    continue;

                if (Convert.ToBoolean(row.Cells["Chon"].Value ?? false))
                {
                    tongTien += Convert.ToDecimal(
                        row.Cells["DonGiaThue"].Value
                    );
                }
            }

            lblTongTien.Text = tongTien.ToString("N0") + " VNĐ";
            lblTraTruoc.Text = (tongTien * 6).ToString("N0") + " VNĐ";
        }

        private void dgvVanPhong_CurrentCellDirtyStateChanged(
            object sender, EventArgs e)
        {
            if (dgvVanPhong.IsCurrentCellDirty)
                dgvVanPhong.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }

        private void dgvVanPhong_CellValueChanged(
            object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 &&
                e.ColumnIndex >= 0 &&
                dgvVanPhong.Columns[e.ColumnIndex].Name == "Chon")
            {
                TinhTien();
            }
        }

        private void btnLapHopDong_Click(object sender, EventArgs e)
        {
            try
            {
                if (cboKhachHang.SelectedValue == null)
                    throw new Exception("Chưa có khách hàng được chọn.");

                DataTable danhSachPhong = LayPhongDaChon();

                if (danhSachPhong.Rows.Count == 0)
                    throw new Exception("Vui lòng chọn ít nhất một văn phòng.");

                DialogResult xacNhan = MessageBox.Show(
                    "Bạn có muốn lập hợp đồng " + txtMaHD.Text.Trim() + "?\n" +
                    "Số văn phòng: " + danhSachPhong.Rows.Count + "\n" +
                    "Tiền thuê/tháng: " + lblTongTien.Text + "\n" +
                    "Tiền thuê trả trước 6 tháng: " + lblTraTruoc.Text,
                    "Xác nhận lập hợp đồng",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (xacNhan != DialogResult.Yes)
                    return;

                service.LapHopDong(
                    txtMaHD.Text.Trim(),
                    Convert.ToString(cboKhachHang.SelectedValue),
                    dtNgayKy.Value,
                    dtNgayBatDau.Value,
                    (int)nudThoiHan.Value,
                    danhSachPhong
                );

                MessageBox.Show(
                    "Lập hợp đồng thành công.\n" +
                    "Hợp đồng đang chờ thanh toán trước 6 tháng đầu.",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                string maHDMoi = txtMaHD.Text.Trim();

                NapVanPhong();
                NapHopDong();
                LamMoiNhapLieu();
                HienThiChiTiet(maHDMoi);
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627 || ex.Number == 2601)
                    MessageBox.Show("Mã hợp đồng hoặc kỳ thanh toán đã tồn tại.");
                else
                    MessageBox.Show(ex.Message, "Lỗi SQL Server");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo");
            }
        }

        private void HienThiChiTiet(string maHD)
        {
            try
            {
                dgvChiTiet.DataSource = service.LayChiTiet(maHD);
                dgvKyThanhToan.DataSource = service.LayKyThanhToan(maHD);

                if (dgvChiTiet.Columns.Contains("DonGiaThue"))
                    dgvChiTiet.Columns["DonGiaThue"].DefaultCellStyle.Format = "N0";

                if (dgvKyThanhToan.Columns.Contains("SoTienPhaiThu"))
                    dgvKyThanhToan.Columns["SoTienPhaiThu"].DefaultCellStyle.Format = "N0";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi tải chi tiết");
            }
        }

        private void dgvHopDong_CellClick(
            object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            DataGridViewRow row = dgvHopDong.Rows[e.RowIndex];

            if (row.IsNewRow)
                return;

            string maHD = Convert.ToString(row.Cells["MaHD"].Value);
            HienThiChiTiet(maHD);
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                dgvHopDong.DataSource = service.TimKiem(txtTimKiem.Text);
                DinhDangHopDong();
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
                NapVanPhong();
                NapHopDong();
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
    }
}
