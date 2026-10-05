using System;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Bai3 : Form
    {
        public Bai3()
        {
            InitializeComponent();
        }

        private long UCLN(long a, long b)
        {
            while (b != 0)
            {
                long r = a % b;
                a = b;
                b = r;
            }

            return a;
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            if (!long.TryParse(txtA.Text, out long a) ||
                !long.TryParse(txtB.Text, out long b))
            {
                MessageBox.Show(
                    "Vui lòng nhập hai số nguyên hợp lệ!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            long x = Math.Abs(a);
            long y = Math.Abs(b);

            if (x == 0 && y == 0)
            {
                MessageBox.Show(
                    "Không thể tính UCLN và BCNN của 0 và 0!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            long ucln = UCLN(x, y);

            long bcnn;

            if (x == 0 || y == 0)
            {
                bcnn = 0;
            }
            else
            {
                bcnn = Math.Abs((a / ucln) * b);
            }

            txtUCLN.Text = ucln.ToString();
            txtBCNN.Text = bcnn.ToString();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtA.Clear();
            txtB.Clear();
            txtUCLN.Clear();
            txtBCNN.Clear();

            txtA.Focus();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Bai3_FormClosing(
            object sender,
            FormClosingEventArgs e)
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