using System;
using System.Net.Mail;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Bai2 : Form
    {
        public Bai2()
        {
            InitializeComponent();
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            try
            {
                new MailAddress(txtEmail.Text.Trim());
                errorProvider1.SetError(txtEmail, "");
            }
            catch
            {
                errorProvider1.SetError(txtEmail, "Email không hợp lệ!");
            }
        }

        private bool KiemTra()
        {
            errorProvider1.Clear();

            bool hopLe = true;

            Control[] controls =
            {
                txtHoTen,
                txtEmail,
                txtTaiKhoan,
                txtMatKhau,
                txtXacNhan
            };

            foreach (Control control in controls)
            {
                if (string.IsNullOrWhiteSpace(control.Text))
                {
                    errorProvider1.SetError(control, "Bắt buộc nhập!");
                    hopLe = false;
                }
            }

            if (!hopLe)
                return false;

            try
            {
                new MailAddress(txtEmail.Text.Trim());
            }
            catch
            {
                errorProvider1.SetError(txtEmail, "Email không hợp lệ!");
                hopLe = false;
            }

            return hopLe;
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            if (!KiemTra())
                return;

            if (txtMatKhau.Text != txtXacNhan.Text)
            {
                MessageBox.Show(
                    "Mật khẩu xác nhận không khớp!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtXacNhan.Focus();
                return;
            }

            string thongTin =
                "Họ tên: " + txtHoTen.Text +
                "\nEmail: " + txtEmail.Text +
                "\nTài khoản: " + txtTaiKhoan.Text +
                "\nMật khẩu: " + txtMatKhau.Text +
                "\nXác nhận mật khẩu: " + txtXacNhan.Text;

            MessageBox.Show(
                thongTin,
                "Thông tin đăng ký",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtHoTen.Clear();
            txtEmail.Clear();
            txtTaiKhoan.Clear();
            txtMatKhau.Clear();
            txtXacNhan.Clear();

            errorProvider1.Clear();

            txtHoTen.Focus();
        }

        private void Bai2_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Bạn có muốn thoát?",
                "Thoát",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result != DialogResult.Yes)
            {
                e.Cancel = true;
            }
        }
    }
}