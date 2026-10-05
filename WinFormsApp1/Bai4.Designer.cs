namespace WinFormsApp1
{
    partial class Bai4
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblNhapSo;
        private System.Windows.Forms.Label lblDay;
        private System.Windows.Forms.Label lblTong;
        private System.Windows.Forms.Label lblTongChan;
        private System.Windows.Forms.Label lblTongLe;

        private System.Windows.Forms.TextBox txtNhapSo;
        private System.Windows.Forms.TextBox txtDay;
        private System.Windows.Forms.TextBox txtTong;
        private System.Windows.Forms.TextBox txtTongChan;
        private System.Windows.Forms.TextBox txtTongLe;

        private System.Windows.Forms.Button btnNhap;
        private System.Windows.Forms.Button btnTong;
        private System.Windows.Forms.Button btnTongChan;
        private System.Windows.Forms.Button btnTongLe;
        private System.Windows.Forms.Button btnTiepTuc;
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

            lblNhapSo = new System.Windows.Forms.Label();
            lblDay = new System.Windows.Forms.Label();
            lblTong = new System.Windows.Forms.Label();
            lblTongChan = new System.Windows.Forms.Label();
            lblTongLe = new System.Windows.Forms.Label();

            txtNhapSo = new System.Windows.Forms.TextBox();
            txtDay = new System.Windows.Forms.TextBox();
            txtTong = new System.Windows.Forms.TextBox();
            txtTongChan = new System.Windows.Forms.TextBox();
            txtTongLe = new System.Windows.Forms.TextBox();

            btnNhap = new System.Windows.Forms.Button();
            btnTong = new System.Windows.Forms.Button();
            btnTongChan = new System.Windows.Forms.Button();
            btnTongLe = new System.Windows.Forms.Button();
            btnTiepTuc = new System.Windows.Forms.Button();
            btnThoat = new System.Windows.Forms.Button();

            Label[] labels =
            {
                lblNhapSo,
                lblDay,
                lblTong,
                lblTongChan,
                lblTongLe
            };

            TextBox[] boxes =
            {
                txtNhapSo,
                txtDay,
                txtTong,
                txtTongChan,
                txtTongLe
            };

            string[] names =
            {
                "Nhập số:",
                "Dãy vừa nhập:",
                "Tổng:",
                "Tổng chẵn:",
                "Tổng lẻ:"
            };

            for (int i = 0; i < 5; i++)
            {
                labels[i].Text = names[i];
                labels[i].AutoSize = true;

                labels[i].Location =
                    new System.Drawing.Point(
                        30,
                        35 + i * 45);

                boxes[i].Location =
                    new System.Drawing.Point(
                        145,
                        32 + i * 45);

                boxes[i].Size =
                    new System.Drawing.Size(
                        360,
                        27);
            }

            txtDay.ReadOnly = true;
            txtTong.ReadOnly = true;
            txtTongChan.ReadOnly = true;
            txtTongLe.ReadOnly = true;

            btnNhap.Text = "Nhập";
            btnNhap.Location =
                new System.Drawing.Point(145, 255);
            btnNhap.Size =
                new System.Drawing.Size(80, 35);
            btnNhap.Click += btnNhap_Click;

            btnTong.Text = "Tính tổng";
            btnTong.Location =
                new System.Drawing.Point(235, 255);
            btnTong.Size =
                new System.Drawing.Size(90, 35);
            btnTong.Click += btnTong_Click;

            btnTongChan.Text = "Tổng chẵn";
            btnTongChan.Location =
                new System.Drawing.Point(335, 255);
            btnTongChan.Size =
                new System.Drawing.Size(90, 35);
            btnTongChan.Click += btnTongChan_Click;

            btnTongLe.Text = "Tổng lẻ";
            btnTongLe.Location =
                new System.Drawing.Point(435, 255);
            btnTongLe.Size =
                new System.Drawing.Size(70, 35);
            btnTongLe.Click += btnTongLe_Click;

            btnTiepTuc.Text = "Tiếp tục";
            btnTiepTuc.Location =
                new System.Drawing.Point(235, 300);
            btnTiepTuc.Size =
                new System.Drawing.Size(90, 35);
            btnTiepTuc.Click += btnTiepTuc_Click;

            btnThoat.Text = "Thoát";
            btnThoat.Location =
                new System.Drawing.Point(335, 300);
            btnThoat.Size =
                new System.Drawing.Size(90, 35);
            btnThoat.Click += btnThoat_Click;

            Controls.Add(lblNhapSo);
            Controls.Add(txtNhapSo);

            Controls.Add(lblDay);
            Controls.Add(txtDay);

            Controls.Add(lblTong);
            Controls.Add(txtTong);

            Controls.Add(lblTongChan);
            Controls.Add(txtTongChan);

            Controls.Add(lblTongLe);
            Controls.Add(txtTongLe);

            Controls.Add(btnNhap);
            Controls.Add(btnTong);
            Controls.Add(btnTongChan);
            Controls.Add(btnTongLe);
            Controls.Add(btnTiepTuc);
            Controls.Add(btnThoat);

            ClientSize =
                new System.Drawing.Size(540, 370);

            StartPosition =
                System.Windows.Forms.FormStartPosition.CenterScreen;

            Text = "Bài 4 - Dãy số nguyên";

            FormClosing += Bai4_FormClosing;
        }
    }
}