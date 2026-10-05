using System;
using System.Globalization;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Bai7 : Form
    {
        private double soThuNhat = 0;
        private string phepToan = "";
        private bool dangNhapSoMoi = true;

        public Bai7()
        {
            InitializeComponent();
        }

        // ==============================
        // NHẬP SỐ
        // ==============================

        private void btnSo_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (dangNhapSoMoi)
            {
                txtManHinh.Text = btn.Text;
                dangNhapSoMoi = false;
            }
            else
            {
                if (btn.Text == "." && txtManHinh.Text.Contains("."))
                    return;

                if (txtManHinh.Text == "0" && btn.Text != ".")
                    txtManHinh.Text = btn.Text;
                else
                    txtManHinh.Text += btn.Text;
            }
        }

        // ==============================
        // PHÉP TOÁN + - * /
        // ==============================

        private void btnPhepToan_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (!double.TryParse(
                    txtManHinh.Text,
                    NumberStyles.Float,
                    CultureInfo.InvariantCulture,
                    out soThuNhat))
            {
                MessageBox.Show(
                    "Giá trị nhập không hợp lệ!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            phepToan = btn.Text;
            dangNhapSoMoi = true;
        }

        // ==============================
        // DẤU =
        // ==============================

        private void btnBang_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(phepToan))
                return;

            if (!double.TryParse(
                    txtManHinh.Text,
                    NumberStyles.Float,
                    CultureInfo.InvariantCulture,
                    out double soThuHai))
            {
                MessageBox.Show(
                    "Giá trị nhập không hợp lệ!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            double ketQua = 0;

            switch (phepToan)
            {
                case "+":
                    ketQua = soThuNhat + soThuHai;
                    break;

                case "-":
                    ketQua = soThuNhat - soThuHai;
                    break;

                case "*":
                    ketQua = soThuNhat * soThuHai;
                    break;

                case "/":
                    if (soThuHai == 0)
                    {
                        MessageBox.Show(
                            "Không thể chia cho 0!",
                            "Lỗi",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);

                        return;
                    }

                    ketQua = soThuNhat / soThuHai;
                    break;
            }

            txtManHinh.Text =
                ketQua.ToString(CultureInfo.InvariantCulture);

            phepToan = "";
            dangNhapSoMoi = true;
        }

        // ==============================
        // XÓA
        // ==============================

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtManHinh.Text = "0";

            soThuNhat = 0;
            phepToan = "";
            dangNhapSoMoi = true;
        }

        // ==============================
        // XÓA TỪNG KÝ TỰ
        // ==============================

        private void btnBackspace_Click(object sender, EventArgs e)
        {
            if (txtManHinh.Text.Length <= 1)
            {
                txtManHinh.Text = "0";
            }
            else
            {
                txtManHinh.Text =
                    txtManHinh.Text.Substring(
                        0,
                        txtManHinh.Text.Length - 1);
            }
        }

        // ==============================
        // DẤU CHẤM
        // ==============================

        private void btnCham_Click(object sender, EventArgs e)
        {
            if (dangNhapSoMoi)
            {
                txtManHinh.Text = "0.";
                dangNhapSoMoi = false;
                return;
            }

            if (!txtManHinh.Text.Contains("."))
            {
                txtManHinh.Text += ".";
            }
        }

        // ==============================
        // ĐÓNG FORM
        // ==============================

        private void Bai7_FormClosing(
            object sender,
            FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Bạn có muốn thoát chương trình không?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}