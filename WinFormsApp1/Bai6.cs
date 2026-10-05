using System;
using System.Drawing;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Bai6 : Form
    {
        private Button[] ghe;

        public Bai6()
        {
            InitializeComponent();
        }

        private long GiaVe(Button button)
        {
            int soGhe = (int)button.Tag;

            if (soGhe <= 5)
                return 1000;

            if (soGhe <= 10)
                return 1500;

            return 2000;
        }

        private void Ghe_Click(
            object sender,
            EventArgs e)
        {
            Button button = (Button)sender;

            if (button.BackColor == Color.Yellow)
            {
                MessageBox.Show(
                    "Ghế này đã được bán!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                return;
            }

            if (button.BackColor == Color.DodgerBlue)
            {
                button.BackColor = Color.White;
            }
            else
            {
                button.BackColor = Color.DodgerBlue;
            }

            CapNhatTien();
        }

        private void CapNhatTien()
        {
            long tongTien = 0;

            foreach (Button button in ghe)
            {
                if (button.BackColor == Color.DodgerBlue)
                {
                    tongTien += GiaVe(button);
                }
            }

            lblThanhTien.Text =
                tongTien.ToString();
        }

        private void btnChon_Click(
            object sender,
            EventArgs e)
        {
            long tongTien = 0;

            foreach (Button button in ghe)
            {
                if (button.BackColor == Color.DodgerBlue)
                {
                    button.BackColor = Color.Yellow;
                    tongTien += GiaVe(button);
                }
            }

            lblThanhTien.Text =
                tongTien.ToString();
        }

        private void btnHuy_Click(
            object sender,
            EventArgs e)
        {
            foreach (Button button in ghe)
            {
                if (button.BackColor == Color.DodgerBlue)
                {
                    button.BackColor = Color.White;
                }
            }

            lblThanhTien.Text = "0";
        }

        private void btnThoat_Click(
            object sender,
            EventArgs e)
        {
            Close();
        }

        private void Bai6_FormClosing(
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