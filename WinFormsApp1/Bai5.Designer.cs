using static System.Net.Mime.MediaTypeNames;

namespace WinFormsApp1
{
    partial class Bai5
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblSo;
        private System.Windows.Forms.Label lblKetQua;

        private System.Windows.Forms.TextBox txtSo;
        private System.Windows.Forms.TextBox txtKetQua;

        private System.Windows.Forms.Button btnThucHien;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThoat;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components =
                new System.ComponentModel.Container();

            lblSo = new System.Windows.Forms.Label();
            lblKetQua = new System.Windows.Forms.Label();

            txtSo = new System.Windows.Forms.TextBox();
            txtKetQua = new System.Windows.Forms.TextBox();

            btnThucHien = new System.Windows.Forms.Button();
            btnXoa = new System.Windows.Forms.Button();
            btnThoat = new System.Windows.Forms.Button();

            lblSo.Text = "Nhập số (1-999):";
            lblSo.AutoSize = true;
            lblSo.Location =
                new System.Drawing.Point(35, 50);

            txtSo.Location =
                new System.Drawing.Point(180, 47);
            txtSo.Size =
                new System.Drawing.Size(240, 27);

            lblKetQua.Text = "Kết quả:";
            lblKetQua.AutoSize = true;
            lblKetQua.Location =
                new System.Drawing.Point(35, 95);

            txtKetQua.Location =
                new System.Drawing.Point(180, 92);
            txtKetQua.Size =
                new System.Drawing.Size(240, 27);
            txtKetQua.ReadOnly = true;

            btnThucHien.Text = "Thực hiện";
            btnThucHien.Location =
                new System.Drawing.Point(180, 145);
            btnThucHien.Size =
                new System.Drawing.Size(100, 35);
            btnThucHien.Click += btnThucHien_Click;

            btnXoa.Text = "Xóa";
            btnXoa.Location =
                new System.Drawing.Point(290, 145);
            btnXoa.Size =
                new System.Drawing.Size(60, 35);
            btnXoa.Click += btnXoa_Click;

            btnThoat.Text = "Thoát";
            btnThoat.Location =
                new System.Drawing.Point(360, 145);
            btnThoat.Size =
                new System.Drawing.Size(60, 35);
            btnThoat.Click += btnThoat_Click;

            Controls.Add(lblSo);
            Controls.Add(txtSo);

            Controls.Add(lblKetQua);
            Controls.Add(txtKetQua);

            Controls.Add(btnThucHien);
            Controls.Add(btnXoa);
            Controls.Add(btnThoat);

            ClientSize =
                new System.Drawing.Size(470, 230);

            StartPosition =
                System.Windows.Forms.FormStartPosition.CenterScreen;

            Text = "Bài 5 - Đọc số thành chữ";

            FormClosing += Bai5_FormClosing;
        }
    }
}