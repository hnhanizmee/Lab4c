namespace WinFormsApp1
{
    partial class Bai6
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.Label lblC;
        private System.Windows.Forms.Label lblTien;
        private System.Windows.Forms.Label lblThanhTien;

        private System.Windows.Forms.Button btnChon;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnThoat;

        private System.Windows.Forms.Button[] ghe;

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

            lblA = new System.Windows.Forms.Label();
            lblB = new System.Windows.Forms.Label();
            lblC = new System.Windows.Forms.Label();

            lblTien = new System.Windows.Forms.Label();
            lblThanhTien = new System.Windows.Forms.Label();

            btnChon = new System.Windows.Forms.Button();
            btnHuy = new System.Windows.Forms.Button();
            btnThoat = new System.Windows.Forms.Button();

            ghe = new System.Windows.Forms.Button[15];

            Text = "Bài 6 - Bán vé rạp chiếu phim";

            ClientSize =
                new System.Drawing.Size(620, 430);

            StartPosition =
                System.Windows.Forms.FormStartPosition.CenterScreen;

            lblA.Text = "Lô A - 1000/vé";
            lblB.Text = "Lô B - 1500/vé";
            lblC.Text = "Lô C - 2000/vé";

            lblA.AutoSize = true;
            lblB.AutoSize = true;
            lblC.AutoSize = true;

            lblA.Location =
                new System.Drawing.Point(45, 40);

            lblB.Location =
                new System.Drawing.Point(235, 40);

            lblC.Location =
                new System.Drawing.Point(425, 40);

            Controls.Add(lblA);
            Controls.Add(lblB);
            Controls.Add(lblC);

            for (int i = 0; i < 15; i++)
            {
                Button button =
                    new System.Windows.Forms.Button();

                ghe[i] = button;

                button.Text =
                    (i + 1).ToString();

                button.Tag = i + 1;

                button.Size =
                    new System.Drawing.Size(85, 50);

                button.Location =
                    new System.Drawing.Point(
                        30 + (i % 5) * 115,
                        80 + (i / 5) * 65);

                button.BackColor =
                    System.Drawing.Color.White;

                button.Click += Ghe_Click;

                Controls.Add(button);
            }

            lblTien.Text = "Thành tiền:";
            lblTien.AutoSize = true;
            lblTien.Location =
                new System.Drawing.Point(30, 300);

            lblThanhTien.Text = "0";
            lblThanhTien.BorderStyle =
                System.Windows.Forms.BorderStyle.FixedSingle;

            lblThanhTien.TextAlign =
                System.Drawing.ContentAlignment.MiddleRight;

            lblThanhTien.Location =
                new System.Drawing.Point(130, 295);

            lblThanhTien.Size =
                new System.Drawing.Size(150, 30);

            btnChon.Text = "CHỌN";
            btnChon.Location =
                new System.Drawing.Point(310, 290);
            btnChon.Size =
                new System.Drawing.Size(80, 40);
            btnChon.Click += btnChon_Click;

            btnHuy.Text = "HỦY BỎ";
            btnHuy.Location =
                new System.Drawing.Point(400, 290);
            btnHuy.Size =
                new System.Drawing.Size(80, 40);
            btnHuy.Click += btnHuy_Click;

            btnThoat.Text = "THOÁT";
            btnThoat.Location =
                new System.Drawing.Point(490, 290);
            btnThoat.Size =
                new System.Drawing.Size(80, 40);
            btnThoat.Click += btnThoat_Click;

            Controls.Add(lblTien);
            Controls.Add(lblThanhTien);
            Controls.Add(btnChon);
            Controls.Add(btnHuy);
            Controls.Add(btnThoat);

            FormClosing += Bai6_FormClosing;
        }
    }
}