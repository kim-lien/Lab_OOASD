
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using QuanLyChoThueVanPhong.Services;

namespace QuanLyChoThueVanPhong.Forms
{
    public partial class FrmGiaHan : Form
    {
        private readonly GiaHanService service = new GiaHanService();
        private int soThangConLai = 0;

        public FrmGiaHan()
        {
            InitializeComponent();
        }

        private void FrmGiaHan_Load(object sender, EventArgs e)
        {
            try
            {
                cboHopDong.DisplayMember = "MaHD";
                cboHopDong.ValueMember = "MaHD";
                cboHopDong.DataSource = service.LayHopDong();

                NapLichSu();

                if (cboHopDong.Items.Count > 0)
                    NapVanPhong();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi tải dữ liệu");
            }
        }

        private void NapVanPhong()
        {
            cboVanPhong.DataSource = null;

            if (cboHopDong.SelectedValue == null ||
                cboHopDong.SelectedValue is DataRowView)
                return;

            cboVanPhong.DisplayMember = "MaPhong";
            cboVanPhong.ValueMember = "MaPhong";
            cboVanPhong.DataSource = service.LayVanPhong(
                Convert.ToString(cboHopDong.SelectedValue)
            );

            HienThiThongTin();
        }

        private void HienThiThongTin()
        {
            if (cboHopDong.SelectedValue == null ||
                cboVanPhong.SelectedValue == null ||
                cboHopDong.SelectedValue is DataRowView ||
                cboVanPhong.SelectedValue is DataRowView)
                return;

            try
            {
                string maHD = Convert.ToString(cboHopDong.SelectedValue);
                string maPhong = Convert.ToString(cboVanPhong.SelectedValue);

                DataTable thongTin = service.LayThongTin(maHD, maPhong);

                if (thongTin.Rows.Count == 0)
                    return;

                DataRow row = thongTin.Rows[0];

                txtNgayKetThuc.Text =
                    Convert.ToDateTime(row["NgayKetThuc"]).ToString("dd/MM/yyyy");

                txtThoiHanGoc.Text = Convert.ToString(row["ThoiHanGoc"]);
                txtDaGiaHan.Text = Convert.ToString(row["DaGiaHan"]);

                soThangConLai = Math.Max(
                    0, Convert.ToInt32(row["ConDuocGiaHan"])
                );

                txtConDuocGiaHan.Text = soThangConLai.ToString();

                nudSoThang.Value = 1;
                btnGiaHan.Enabled = soThangConLai > 0;

                DataTable congNo = service.LayCongNo(maHD, maPhong);

                if (congNo.Rows.Count > 0)
                {
                    txtNoTienThue.Text =
                        Convert.ToDecimal(congNo.Rows[0]["NoTienThue"]).ToString("N0");

                    txtNoDichVu.Text =
                        Convert.ToDecimal(congNo.Rows[0]["NoDichVu"]).ToString("N0");

                    decimal tongNo =
                        Convert.ToDecimal(congNo.Rows[0]["NoTienThue"]) +
                        Convert.ToDecimal(congNo.Rows[0]["NoDichVu"]);

                    btnGiaHan.Enabled = soThangConLai > 0 && tongNo == 0;
                }

                CapNhatNgayMoi();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi thông tin gia hạn");
            }
        }

        private void CapNhatNgayMoi()
        {
            DateTime ngayKetThuc;

            if (!DateTime.TryParseExact(
                txtNgayKetThuc.Text,
                "dd/MM/yyyy",
                System.Globalization.CultureInfo.InvariantCulture,
                System.Globalization.DateTimeStyles.None,
                out ngayKetThuc))
                return;

            txtNgayBatDauMoi.Text =
                ngayKetThuc.AddDays(1).ToString("dd/MM/yyyy");

            txtNgayKetThucMoi.Text =
                ngayKetThuc.AddMonths((int)nudSoThang.Value)
                    .ToString("dd/MM/yyyy");
        }

        private void NapLichSu()
        {
            dgvGiaHan.DataSource = service.LayLichSu();
            DinhDangBang();
        }

        private void DinhDangBang()
        {
            if (dgvGiaHan.Columns.Contains("MaGiaHan"))
                dgvGiaHan.Columns["MaGiaHan"].HeaderText = "Mã gia hạn";

            if (dgvGiaHan.Columns.Contains("MaHD"))
                dgvGiaHan.Columns["MaHD"].HeaderText = "Hợp đồng";

            if (dgvGiaHan.Columns.Contains("MaPhong"))
                dgvGiaHan.Columns["MaPhong"].HeaderText = "Văn phòng";

            if (dgvGiaHan.Columns.Contains("NgayLap"))
                dgvGiaHan.Columns["NgayLap"].HeaderText = "Ngày lập";

            if (dgvGiaHan.Columns.Contains("SoThangGiaHan"))
                dgvGiaHan.Columns["SoThangGiaHan"].HeaderText = "Số tháng";

            if (dgvGiaHan.Columns.Contains("NgayBatDauMoi"))
                dgvGiaHan.Columns["NgayBatDauMoi"].HeaderText = "Bắt đầu mới";

            if (dgvGiaHan.Columns.Contains("NgayKetThucMoi"))
                dgvGiaHan.Columns["NgayKetThucMoi"].HeaderText = "Kết thúc mới";

            if (dgvGiaHan.Columns.Contains("TrangThai"))
                dgvGiaHan.Columns["TrangThai"].HeaderText = "Trạng thái";

            dgvGiaHan.ClearSelection();
        }

        private void cboHopDong_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboVanPhong != null)
                NapVanPhong();
        }

        private void cboVanPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtNgayKetThuc != null)
                HienThiThongTin();
        }

        private void nudSoThang_ValueChanged(object sender, EventArgs e)
        {
            if (txtNgayKetThuc != null)
                CapNhatNgayMoi();
        }

        private void btnGiaHan_Click(object sender, EventArgs e)
        {
            try
            {
                if (nudSoThang.Value > soThangConLai)
                    throw new Exception(
                        "Số tháng gia hạn không được vượt quá " +
                        soThangConLai + " tháng."
                    );

                if (MessageBox.Show(
                    "Xác nhận gia hạn văn phòng " + cboVanPhong.Text +
                    " thêm " + nudSoThang.Value + " tháng?",
                    "Xác nhận",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                ) != DialogResult.Yes)
                    return;

                service.GiaHan(
                    txtMaGiaHan.Text.Trim(),
                    Convert.ToString(cboHopDong.SelectedValue),
                    Convert.ToString(cboVanPhong.SelectedValue),
                    (int)nudSoThang.Value
                );

                MessageBox.Show("Gia hạn thành công.");

                txtMaGiaHan.Clear();
                HienThiThongTin();
                NapLichSu();
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627 || ex.Number == 2601)
                    MessageBox.Show("Mã phiếu gia hạn đã tồn tại.");
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
                dgvGiaHan.DataSource = service.TimKiem(txtTimKiem.Text);
                DinhDangBang();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi tìm kiếm");
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaGiaHan.Clear();
            txtTimKiem.Clear();

            HienThiThongTin();
            NapLichSu();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
