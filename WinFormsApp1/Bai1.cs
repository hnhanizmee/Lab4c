using System;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Bai1 : Form
    {
        public Bai1()
        {
            InitializeComponent();
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txtA.Text, out double a) ||
                !double.TryParse(txtB.Text, out double b))
            {
                MessageBox.Show(
                    "Vui lòng nhập số hợp lệ!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            txtCong.Text = (a + b).ToString();
            txtTru.Text = (a - b).ToString();
            txtNhan.Text = (a * b).ToString();

            if (b == 0)
            {
                txtChia.Text = "Không thể chia cho 0";
            }
            else
            {
                txtChia.Text = (a / b).ToString();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtA.Clear();
            txtB.Clear();
            txtCong.Clear();
            txtTru.Clear();
            txtNhan.Clear();
            txtChia.Clear();

            txtA.Focus();
        }
    }
}