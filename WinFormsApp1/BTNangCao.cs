using System;
using System.Drawing;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class BTNangCao : Form
    {
        private Button[] ghe = new Button[15];

        public BTNangCao()
        {
            InitializeComponent();
        }

        private int LayGiaVe(int soGhe)
        {
            if (soGhe >= 1 && soGhe <= 5)
                return 1000;

            if (soGhe >= 6 && soGhe <= 10)
                return 1500;

            if (soGhe >= 11 && soGhe <= 15)
                return 2000;

            return 0;
        }

        private void Ghe_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            // Ghế đã bán
            if (btn.BackColor == Color.Yellow)
            {
                MessageBox.Show(
                    "Ghế số " + btn.Tag + " đã được bán!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                return;
            }

            // Ghế đang chọn -> bỏ chọn
            if (btn.BackColor == Color.DodgerBlue)
            {
                btn.BackColor = Color.White;
            }
            // Ghế chưa bán -> chọn
            else
            {
                btn.BackColor = Color.DodgerBlue;
            }
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            int tongTien = 0;
            bool coGhe = false;

            for (int i = 0; i < ghe.Length; i++)
            {
                Button btn = ghe[i];

                // Chỉ xử lý những ghế đang chọn màu xanh
                if (btn.BackColor == Color.DodgerBlue)
                {
                    int soGhe = Convert.ToInt32(btn.Tag);

                    tongTien += LayGiaVe(soGhe);

                    // Đã bán
                    btn.BackColor = Color.Yellow;

                    coGhe = true;
                }
            }

            // Xuất thành tiền
            lblThanhTien.Text = tongTien.ToString();

            if (!coGhe)
            {
                MessageBox.Show(
                    "Bạn chưa chọn ghế nào!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                lblThanhTien.Text = "0";
            }
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            // Những ghế đang chọn -> trả về chưa bán
            for (int i = 0; i < ghe.Length; i++)
            {
                if (ghe[i].BackColor == Color.DodgerBlue)
                {
                    ghe[i].BackColor = Color.White;
                }
            }

            // Thành tiền = 0
            lblThanhTien.Text = "0";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Bai6_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Bạn có muốn thoát chương trình không?",
                "Xác nhận thoát",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}