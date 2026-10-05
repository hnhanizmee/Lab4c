namespace WinFormsApp1
{
    partial class Bai2
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblTaiKhoan;
        private System.Windows.Forms.Label lblMatKhau;
        private System.Windows.Forms.Label lblXacNhan;

        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtTaiKhoan;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.TextBox txtXacNhan;

        private System.Windows.Forms.Button btnDangKy;
        private System.Windows.Forms.Button btnXoa;

        private System.Windows.Forms.ErrorProvider errorProvider1;

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
            components = new System.ComponentModel.Container();

            errorProvider1 =
                new System.Windows.Forms.ErrorProvider(components);

            lblTitle = new System.Windows.Forms.Label();
            lblHoTen = new System.Windows.Forms.Label();
            lblEmail = new System.Windows.Forms.Label();
            lblTaiKhoan = new System.Windows.Forms.Label();
            lblMatKhau = new System.Windows.Forms.Label();
            lblXacNhan = new System.Windows.Forms.Label();

            txtHoTen = new System.Windows.Forms.TextBox();
            txtEmail = new System.Windows.Forms.TextBox();
            txtTaiKhoan = new System.Windows.Forms.TextBox();
            txtMatKhau = new System.Windows.Forms.TextBox();
            txtXacNhan = new System.Windows.Forms.TextBox();

            btnDangKy = new System.Windows.Forms.Button();
            btnXoa = new System.Windows.Forms.Button();

            lblTitle.Text = "ĐĂNG KÝ TÀI KHOẢN";
            lblTitle.AutoSize = true;
            lblTitle.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    16F,
                    System.Drawing.FontStyle.Bold);

            lblTitle.Location =
                new System.Drawing.Point(120, 20);

            Label[] labels =
            {
                lblHoTen,
                lblEmail,
                lblTaiKhoan,
                lblMatKhau,
                lblXacNhan
            };

            TextBox[] textBoxes =
            {
                txtHoTen,
                txtEmail,
                txtTaiKhoan,
                txtMatKhau,
                txtXacNhan
            };

            string[] names =
            {
                "Họ tên (*)",
                "Địa chỉ email (*)",
                "Tài khoản (*)",
                "Mật khẩu (*)",
                "Xác nhận mật khẩu (*)"
            };

            for (int i = 0; i < labels.Length; i++)
            {
                labels[i].Text = names[i];
                labels[i].AutoSize = true;
                labels[i].Location =
                    new System.Drawing.Point(35, 70 + i * 45);

                textBoxes[i].Location =
                    new System.Drawing.Point(190, 67 + i * 45);

                textBoxes[i].Size =
                    new System.Drawing.Size(260, 27);
            }

            txtMatKhau.UseSystemPasswordChar = true;
            txtXacNhan.UseSystemPasswordChar = true;

            btnDangKy.Text = "Đăng ký";
            btnDangKy.Location =
                new System.Drawing.Point(190, 305);
            btnDangKy.Size =
                new System.Drawing.Size(110, 35);
            btnDangKy.Click += btnDangKy_Click;

            btnXoa.Text = "Xóa";
            btnXoa.Location =
                new System.Drawing.Point(315, 305);
            btnXoa.Size =
                new System.Drawing.Size(135, 35);
            btnXoa.Click += btnXoa_Click;

            txtEmail.Leave += txtEmail_Leave;

            AcceptButton = btnDangKy;

            Controls.Add(lblTitle);

            Controls.Add(lblHoTen);
            Controls.Add(txtHoTen);

            Controls.Add(lblEmail);
            Controls.Add(txtEmail);

            Controls.Add(lblTaiKhoan);
            Controls.Add(txtTaiKhoan);

            Controls.Add(lblMatKhau);
            Controls.Add(txtMatKhau);

            Controls.Add(lblXacNhan);
            Controls.Add(txtXacNhan);

            Controls.Add(btnDangKy);
            Controls.Add(btnXoa);

            ClientSize =
                new System.Drawing.Size(500, 370);

            StartPosition =
                System.Windows.Forms.FormStartPosition.CenterScreen;

            Text = "Bài 2 - Đăng ký tài khoản";

            FormClosing += Bai2_FormClosing;
        }
    }
}