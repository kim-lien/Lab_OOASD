
using System;
using System.Windows.Forms;
using QuanLyChoThueVanPhong.Data;

namespace QuanLyChoThueVanPhong.Forms
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void MoForm(string tenForm)
        {
            MessageBox.Show(
                "Chức năng " + tenForm + " sẽ được xây dựng ở bước tiếp theo.",
                "Thông báo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        private void btnTang_Click(object sender, EventArgs e)
        {
            using (FrmTang frm = new FrmTang())
            {
                frm.ShowDialog(this);
            }
        }


        private void btnVanPhong_Click(object sender, EventArgs e)
        {
            using (FrmVanPhong frm = new FrmVanPhong())
            {
                frm.ShowDialog(this);
            }
        }



        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            using (FrmKhachHang frm = new FrmKhachHang())
            {
                frm.ShowDialog(this);
            }
        }



        private void btnHopDong_Click(object sender, EventArgs e)
        {
            using (FrmHopDong frm = new FrmHopDong())
            {
                frm.ShowDialog(this);
            }
        }



        private void btnGiaHan_Click(object sender, EventArgs e)
        {
            using (FrmGiaHan frm = new FrmGiaHan())
            {
                frm.ShowDialog(this);
            }
        }



        private void btnTienThue_Click(object sender, EventArgs e)
        {
            using (FrmThanhToanThue frm = new FrmThanhToanThue())
            {
                frm.ShowDialog(this);
            }
        }



        private void btnDichVu_Click(object sender, EventArgs e)
        {
            using (FrmDichVu frm = new FrmDichVu())
            {
                frm.ShowDialog(this);
            }
        }



        private void btnHoaDonDV_Click(object sender, EventArgs e)
        {
            using (FrmHoaDonDichVu frm = new FrmHoaDonDichVu())
            {
                frm.ShowDialog(this);
            }
        }



        private void btnThanhToanDV_Click(object sender, EventArgs e)
        {
            using (FrmThanhToanDichVu frm = new FrmThanhToanDichVu())
            {
                frm.ShowDialog(this);
            }
        }



        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            using (FrmNhanVien frm = new FrmNhanVien())
            {
                frm.ShowDialog(this);
            }
        }



        private void btnTheXe_Click(object sender, EventArgs e)
        {
            using (FrmTheGiuXe frm = new FrmTheGiuXe())
            {
                frm.ShowDialog(this);
            }
        }



        private void btnKiemTra_Click(object sender, EventArgs e)
        {
            using (FrmKiemTra frm = new FrmKiemTra())
            {
                frm.ShowDialog(this);
            }
        }



        private void btnXuPhat_Click(object sender, EventArgs e)
        {
            using (FrmXuPhat frm = new FrmXuPhat())
            {
                frm.ShowDialog(this);
            }
        }



        private void btnThongKe_Click(object sender, EventArgs e)
        {
            using (FrmThongKe frm = new FrmThongKe())
            {
                frm.ShowDialog(this);
            }
        }


        private void btnKetNoi_Click(object sender, EventArgs e)
        {
            try
            {
                bool ketQua = Db.TestConnection();

                if (ketQua)
                {
                    object soBang = Db.Scalar(
                        "SELECT COUNT(*) FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_TYPE = 'BASE TABLE'"
                    );

                    MessageBox.Show(
                        "Kết nối SQL Server thành công!\n" +
                        "Database: QuanLyChoThueVanPhong\n" +
                        "Số bảng: " + soBang,
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Không thể kết nối SQL Server.\n\n" + ex.Message,
                    "Lỗi kết nối",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult ketQua = MessageBox.Show(
                "Bạn có muốn thoát chương trình?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (ketQua == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void lblPhuDe_Click(object sender, EventArgs e)
        {

        }
    }
}
