namespace WinFormsApp1
{
    partial class Bai6
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.Label lblManHinh;

        private System.Windows.Forms.Label lblLoA;
        private System.Windows.Forms.Label lblLoB;
        private System.Windows.Forms.Label lblLoC;

        private System.Windows.Forms.Label lblChuThich;
        private System.Windows.Forms.Label lblTrang;
        private System.Windows.Forms.Label lblXanh;
        private System.Windows.Forms.Label lblVang;

        private System.Windows.Forms.Label lblThanhTienText;
        private System.Windows.Forms.Label lblThanhTien;

        private System.Windows.Forms.Button btnChon;
        private System.Windows.Forms.Button btnHuyBo;
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
            components = new System.ComponentModel.Container();

            lblTieuDe = new System.Windows.Forms.Label();
            lblManHinh = new System.Windows.Forms.Label();

            lblLoA = new System.Windows.Forms.Label();
            lblLoB = new System.Windows.Forms.Label();
            lblLoC = new System.Windows.Forms.Label();

            lblChuThich = new System.Windows.Forms.Label();
            lblTrang = new System.Windows.Forms.Label();
            lblXanh = new System.Windows.Forms.Label();
            lblVang = new System.Windows.Forms.Label();

            lblThanhTienText = new System.Windows.Forms.Label();
            lblThanhTien = new System.Windows.Forms.Label();

            btnChon = new System.Windows.Forms.Button();
            btnHuyBo = new System.Windows.Forms.Button();
            btnThoat = new System.Windows.Forms.Button();

            // ==========================================
            // FORM
            // ==========================================

            this.Text = "Bài 6 - Quản lý bán vé rạp chiếu phim";

            this.ClientSize =
                new System.Drawing.Size(650, 520);

            this.StartPosition =
                System.Windows.Forms.FormStartPosition.CenterScreen;

            this.FormClosing +=
                new System.Windows.Forms.FormClosingEventHandler(
                    this.Bai6_FormClosing);

            // ==========================================
            // TIÊU ĐỀ
            // ==========================================

            lblTieuDe.Text =
                "QUẢN LÝ BÁN VÉ RẠP CHIẾU PHIM";

            lblTieuDe.AutoSize = true;

            lblTieuDe.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    16F,
                    System.Drawing.FontStyle.Bold);

            lblTieuDe.Location =
                new System.Drawing.Point(145, 20);

            // ==========================================
            // MÀN HÌNH
            // ==========================================

            lblManHinh.Text = "MÀN HÌNH";

            lblManHinh.TextAlign =
                System.Drawing.ContentAlignment.MiddleCenter;

            lblManHinh.BorderStyle =
                System.Windows.Forms.BorderStyle.FixedSingle;

            lblManHinh.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    10F,
                    System.Drawing.FontStyle.Bold);

            lblManHinh.Location =
                new System.Drawing.Point(160, 65);

            lblManHinh.Size =
                new System.Drawing.Size(330, 35);

            // ==========================================
            // LÔ A
            // ==========================================

            lblLoA.Text =
                "Lô A\n1000/vé";

            lblLoA.TextAlign =
                System.Drawing.ContentAlignment.MiddleCenter;

            lblLoA.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    10F,
                    System.Drawing.FontStyle.Bold);

            lblLoA.Location =
                new System.Drawing.Point(35, 125);

            lblLoA.Size =
                new System.Drawing.Size(80, 55);

            // ==========================================
            // LÔ B
            // ==========================================

            lblLoB.Text =
                "Lô B\n1500/vé";

            lblLoB.TextAlign =
                System.Drawing.ContentAlignment.MiddleCenter;

            lblLoB.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    10F,
                    System.Drawing.FontStyle.Bold);

            lblLoB.Location =
                new System.Drawing.Point(35, 195);

            lblLoB.Size =
                new System.Drawing.Size(80, 55);

            // ==========================================
            // LÔ C
            // ==========================================

            lblLoC.Text =
                "Lô C\n2000/vé";

            lblLoC.TextAlign =
                System.Drawing.ContentAlignment.MiddleCenter;

            lblLoC.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    10F,
                    System.Drawing.FontStyle.Bold);

            lblLoC.Location =
                new System.Drawing.Point(35, 265);

            lblLoC.Size =
                new System.Drawing.Size(80, 55);

            // ==========================================
            // TẠO 15 GHẾ
            // ==========================================

            for (int i = 0; i < 15; i++)
            {
                System.Windows.Forms.Button btn =
                    new System.Windows.Forms.Button();

                int soGhe = i + 1;

                btn.Name =
                    "btnGhe" + soGhe;

                btn.Text =
                    soGhe.ToString();

                btn.Tag = soGhe;

                btn.Size =
                    new System.Drawing.Size(65, 50);

                int hang = i / 5;
                int cot = i % 5;

                btn.Location =
                    new System.Drawing.Point(
                        140 + cot * 75,
                        125 + hang * 70);

                btn.BackColor =
                    System.Drawing.Color.White;

                btn.ForeColor =
                    System.Drawing.Color.Black;

                btn.Font =
                    new System.Drawing.Font(
                        "Segoe UI",
                        11F,
                        System.Drawing.FontStyle.Bold);

                btn.FlatStyle =
                    System.Windows.Forms.FlatStyle.Flat;

                btn.Cursor =
                    System.Windows.Forms.Cursors.Hand;

                btn.Click +=
                    new System.EventHandler(
                        this.Ghe_Click);

                this.Controls.Add(btn);

                // Gán vào mảng ghe
                ghe[i] = btn;
            }

            // ==========================================
            // CHÚ THÍCH
            // ==========================================

            lblChuThich.Text = "CHÚ THÍCH:";

            lblChuThich.AutoSize = true;

            lblChuThich.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    9F,
                    System.Drawing.FontStyle.Bold);

            lblChuThich.Location =
                new System.Drawing.Point(35, 345);

            // Ghế trắng
            lblTrang.Text = "Chưa bán";

            lblTrang.AutoSize = true;

            lblTrang.Location =
                new System.Drawing.Point(140, 345);

            // Ghế xanh
            lblXanh.Text = "Đang chọn";

            lblXanh.AutoSize = true;

            lblXanh.Location =
                new System.Drawing.Point(260, 345);

            // Ghế vàng
            lblVang.Text = "Đã bán";

            lblVang.AutoSize = true;

            lblVang.Location =
                new System.Drawing.Point(390, 345);

            // ==========================================
            // THÀNH TIỀN
            // ==========================================

            lblThanhTienText.Text =
                "Thành Tiền:";

            lblThanhTienText.AutoSize = true;

            lblThanhTienText.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    10F,
                    System.Drawing.FontStyle.Bold);

            lblThanhTienText.Location =
                new System.Drawing.Point(35, 390);

            lblThanhTien.Text = "0";

            lblThanhTien.TextAlign =
                System.Drawing.ContentAlignment.MiddleRight;

            lblThanhTien.BorderStyle =
                System.Windows.Forms.BorderStyle.FixedSingle;

            lblThanhTien.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    11F,
                    System.Drawing.FontStyle.Bold);

            lblThanhTien.Location =
                new System.Drawing.Point(140, 385);

            lblThanhTien.Size =
                new System.Drawing.Size(150, 35);

            // ==========================================
            // BUTTON CHỌN
            // ==========================================

            btnChon.Text = "CHỌN";

            btnChon.Location =
                new System.Drawing.Point(315, 380);

            btnChon.Size =
                new System.Drawing.Size(85, 40);

            btnChon.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    9F,
                    System.Drawing.FontStyle.Bold);

            btnChon.Click +=
                new System.EventHandler(
                    this.btnChon_Click);

            // ==========================================
            // BUTTON HỦY BỎ
            // ==========================================

            btnHuyBo.Text = "HỦY BỎ";

            btnHuyBo.Location =
                new System.Drawing.Point(410, 380);

            btnHuyBo.Size =
                new System.Drawing.Size(85, 40);

            btnHuyBo.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    9F,
                    System.Drawing.FontStyle.Bold);

            btnHuyBo.Click +=
                new System.EventHandler(
                    this.btnHuyBo_Click);

            // ==========================================
            // BUTTON THOÁT
            // ==========================================

            btnThoat.Text = "THOÁT";

            btnThoat.Location =
                new System.Drawing.Point(505, 380);

            btnThoat.Size =
                new System.Drawing.Size(85, 40);

            btnThoat.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    9F,
                    System.Drawing.FontStyle.Bold);

            btnThoat.Click +=
                new System.EventHandler(
                    this.btnThoat_Click);

            // ==========================================
            // ADD CONTROLS
            // ==========================================

            this.Controls.Add(lblTieuDe);
            this.Controls.Add(lblManHinh);

            this.Controls.Add(lblLoA);
            this.Controls.Add(lblLoB);
            this.Controls.Add(lblLoC);

            this.Controls.Add(lblChuThich);
            this.Controls.Add(lblTrang);
            this.Controls.Add(lblXanh);
            this.Controls.Add(lblVang);

            this.Controls.Add(lblThanhTienText);
            this.Controls.Add(lblThanhTien);

            this.Controls.Add(btnChon);
            this.Controls.Add(btnHuyBo);
            this.Controls.Add(btnThoat);
        }
    }
}