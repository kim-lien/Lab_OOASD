
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using QuanLyChoThueVanPhong.Services;

namespace QuanLyChoThueVanPhong.Forms
{
    public partial class FrmHoaDonDichVu : Form
    {
        private readonly HoaDonDichVuService service =
            new HoaDonDichVuService();

        private DataTable bangDichVu;

        public FrmHoaDonDichVu()
        {
            InitializeComponent();
        }

        private void FrmHoaDonDichVu_Load(object sender, EventArgs e)
        {
            try
            {
                cboHopDong.DisplayMember = "MaHD";
                cboHopDong.ValueMember = "MaHD";
                cboHopDong.DataSource = service.LayHopDong();

                nudThang.Value = DateTime.Today.Month;
                nudNam.Value = DateTime.Today.Year;

                NapDichVu();
                NapHoaDon();
                LamMoiNhapLieu(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi tải dữ liệu");
            }
        }

        private void NapDichVu()
        {
            bangDichVu = service.LayDichVu();

            dgvDichVu.DataSource = null;
            dgvDichVu.Columns.Clear();
            dgvDichVu.AutoGenerateColumns = true;
            dgvDichVu.DataSource = bangDichVu;

            foreach (DataGridViewColumn cot in dgvDichVu.Columns)
                cot.ReadOnly = true;

            DataGridViewCheckBoxColumn cotChon =
                new DataGridViewCheckBoxColumn();

            cotChon.Name = "Chon";
            cotChon.HeaderText = "Chọn";
            cotChon.Width = 65;
            cotChon.TrueValue = true;
            cotChon.FalseValue = false;
            cotChon.ReadOnly = false;
            dgvDichVu.Columns.Insert(0, cotChon);

            DataGridViewTextBoxColumn cotSoLuong =
                new DataGridViewTextBoxColumn();

            cotSoLuong.Name = "SoLuongNhap";
            cotSoLuong.HeaderText = "Số lượng";
            cotSoLuong.Width = 130;
            cotSoLuong.ReadOnly = false;
            dgvDichVu.Columns.Add(cotSoLuong);

            dgvDichVu.Columns["MaDV"].HeaderText = "Mã DV";
            dgvDichVu.Columns["TenDV"].HeaderText = "Tên dịch vụ";
            dgvDichVu.Columns["DonViTinh"].HeaderText = "Đơn vị";
            dgvDichVu.Columns["DonGia"].HeaderText = "Đơn giá";
            dgvDichVu.Columns["DonGia"].DefaultCellStyle.Format = "N0";
            dgvDichVu.ClearSelection();
        }

        private void NapPhong()
        {
            cboPhong.DataSource = null;

            if (cboHopDong.SelectedValue == null ||
                cboHopDong.SelectedValue is DataRowView)
                return;

            cboPhong.DisplayMember = "MaPhong";
            cboPhong.ValueMember = "MaPhong";
            cboPhong.DataSource = service.LayPhong(
                Convert.ToString(cboHopDong.SelectedValue)
            );
        }

        private void NapHoaDon()
        {
            dgvHoaDon.DataSource = service.LayHoaDon();
            DinhDangHoaDon();
        }

        private void DinhDangHoaDon()
        {
            if (dgvHoaDon.Columns.Contains("MaHoaDon"))
                dgvHoaDon.Columns["MaHoaDon"].HeaderText = "Mã hóa đơn";

            if (dgvHoaDon.Columns.Contains("MaHD"))
                dgvHoaDon.Columns["MaHD"].HeaderText = "Hợp đồng";

            if (dgvHoaDon.Columns.Contains("MaPhong"))
                dgvHoaDon.Columns["MaPhong"].HeaderText = "Văn phòng";

            if (dgvHoaDon.Columns.Contains("TongTien"))
            {
                dgvHoaDon.Columns["TongTien"].HeaderText = "Tổng tiền";
                dgvHoaDon.Columns["TongTien"].DefaultCellStyle.Format = "N0";
            }

            dgvHoaDon.ClearSelection();
        }

        private void LamMoiNhapLieu(bool xoaTimKiem = true)
        {
            txtMaHoaDon.Clear();
            lblTongTien.Text = "0 VNĐ";

            if (xoaTimKiem)
                txtTimKiem.Clear();

            dgvDichVu.EndEdit();

            foreach (DataGridViewRow row in dgvDichVu.Rows)
            {
                if (row.IsNewRow)
                    continue;

                row.Cells["Chon"].Value = false;
                row.Cells["SoLuongNhap"].Value = null;
            }

            dgvChiTiet.DataSource = null;
            txtMaHoaDon.Focus();
        }

        private void cboHopDong_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                NapPhong();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi tải văn phòng");
            }
        }

        private void dgvDichVu_CurrentCellDirtyStateChanged(
            object sender, EventArgs e)
        {
            if (dgvDichVu.IsCurrentCellDirty)
                dgvDichVu.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }

        private void dgvDichVu_CellValueChanged(
            object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
                TinhTongTien();
        }

        private void TinhTongTien()
        {
            if (!dgvDichVu.Columns.Contains("Chon") ||
                !dgvDichVu.Columns.Contains("SoLuongNhap"))
                return;

            decimal tongTien = 0;

            foreach (DataGridViewRow row in dgvDichVu.Rows)
            {
                if (row.IsNewRow)
                    continue;

                bool chon = Convert.ToBoolean(
                    row.Cells["Chon"].Value ?? false
                );

                if (!chon)
                    continue;

                decimal soLuong;

                if (!decimal.TryParse(
                    Convert.ToString(row.Cells["SoLuongNhap"].Value),
                    out soLuong))
                    continue;

                if (soLuong < 0)
                    continue;

                decimal donGia = Convert.ToDecimal(
                    row.Cells["DonGia"].Value
                );

                tongTien += soLuong * donGia;
            }

            lblTongTien.Text = tongTien.ToString("N0") + " VNĐ";
        }

        private DataTable LayDichVuDaChon()
        {
            dgvDichVu.EndEdit();

            DataTable table = new DataTable();
            table.Columns.Add("MaDV", typeof(string));
            table.Columns.Add("SoLuong", typeof(decimal));

            foreach (DataGridViewRow row in dgvDichVu.Rows)
            {
                if (row.IsNewRow)
                    continue;

                bool chon = Convert.ToBoolean(
                    row.Cells["Chon"].Value ?? false
                );

                if (!chon)
                    continue;

                decimal soLuong;

                if (!decimal.TryParse(
                    Convert.ToString(row.Cells["SoLuongNhap"].Value),
                    out soLuong) || soLuong < 0)
                {
                    throw new Exception(
                        "Số lượng của dịch vụ " +
                        Convert.ToString(row.Cells["TenDV"].Value) +
                        " không hợp lệ."
                    );
                }

                table.Rows.Add(
                    Convert.ToString(row.Cells["MaDV"].Value),
                    soLuong
                );
            }

            return table;
        }

        private void btnLapHoaDon_Click(object sender, EventArgs e)
        {
            try
            {
                if (cboHopDong.SelectedValue == null ||
                    cboPhong.SelectedValue == null)
                    throw new Exception("Chưa chọn hợp đồng và văn phòng.");

                DataTable dsDichVu = LayDichVuDaChon();

                if (dsDichVu.Rows.Count == 0)
                    throw new Exception("Vui lòng chọn dịch vụ.");

                if (MessageBox.Show(
                    "Xác nhận lập hóa đơn " + txtMaHoaDon.Text.Trim() +
                    " với tổng tiền " + lblTongTien.Text + "?",
                    "Xác nhận",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                ) != DialogResult.Yes)
                    return;

                service.LapHoaDon(
                    txtMaHoaDon.Text.Trim(),
                    Convert.ToString(cboHopDong.SelectedValue),
                    Convert.ToString(cboPhong.SelectedValue),
                    (int)nudThang.Value,
                    (int)nudNam.Value,
                    dsDichVu
                );

                MessageBox.Show(
                    "Lập hóa đơn dịch vụ thành công.",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                NapHoaDon();
                LamMoiNhapLieu();
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627 || ex.Number == 2601)
                    MessageBox.Show("Mã hóa đơn hoặc hóa đơn tháng đã tồn tại.");
                else
                    MessageBox.Show(ex.Message, "Lỗi SQL Server");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo");
            }
        }

        private void dgvHoaDon_CellClick(
            object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            string maHoaDon = Convert.ToString(
                dgvHoaDon.Rows[e.RowIndex].Cells["MaHoaDon"].Value
            );

            try
            {
                dgvChiTiet.DataSource = service.LayChiTiet(maHoaDon);

                if (dgvChiTiet.Columns.Contains("DonGia"))
                    dgvChiTiet.Columns["DonGia"].DefaultCellStyle.Format = "N0";

                if (dgvChiTiet.Columns.Contains("ThanhTien"))
                    dgvChiTiet.Columns["ThanhTien"].DefaultCellStyle.Format = "N0";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi tải chi tiết");
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                dgvHoaDon.DataSource = service.TimKiem(txtTimKiem.Text);
                DinhDangHoaDon();
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
                NapDichVu();
                NapHoaDon();
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
