using System.Drawing;
using System.Windows.Forms;

namespace QuanLyBenhAn;

partial class MainForm
{
    private System.ComponentModel.IContainer? components = null;

    // Phần giao diện nghiệp vụ được xây dựng trong BuildBN/BuildPK/BuildToa.
    // Tách file Designer để Visual Studio nhận diện đây là Windows Form.
    private void InitializeComponent()
    {
        SuspendLayout();
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1220, 750);
        Name = "MainForm";
        Text = "Quản lý hồ sơ bệnh án";
        ResumeLayout(false);
    }

    protected override void Dispose(bool disposing)
    {
        if (disposing) components?.Dispose();
        base.Dispose(disposing);
    }
}
