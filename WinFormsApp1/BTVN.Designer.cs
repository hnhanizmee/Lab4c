namespace WinFormsApp1
{
    partial class Bai7
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.TextBox txtManHinh;

        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btnChia;

        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btnNhan;

        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btnTru;

        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnCham;
        private System.Windows.Forms.Button btnBang;
        private System.Windows.Forms.Button btnCong;

        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnBackspace;

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

            txtManHinh = new System.Windows.Forms.TextBox();

            btn7 = new System.Windows.Forms.Button();
            btn8 = new System.Windows.Forms.Button();
            btn9 = new System.Windows.Forms.Button();
            btnChia = new System.Windows.Forms.Button();

            btn4 = new System.Windows.Forms.Button();
            btn5 = new System.Windows.Forms.Button();
            btn6 = new System.Windows.Forms.Button();
            btnNhan = new System.Windows.Forms.Button();

            btn1 = new System.Windows.Forms.Button();
            btn2 = new System.Windows.Forms.Button();
            btn3 = new System.Windows.Forms.Button();
            btnTru = new System.Windows.Forms.Button();

            btn0 = new System.Windows.Forms.Button();
            btnCham = new System.Windows.Forms.Button();
            btnBang = new System.Windows.Forms.Button();
            btnCong = new System.Windows.Forms.Button();

            btnXoa = new System.Windows.Forms.Button();
            btnBackspace = new System.Windows.Forms.Button();

            // =========================================
            // FORM
            // =========================================

            this.SuspendLayout();

            this.Text = "Bài 7 - Máy tính bỏ túi";

            this.ClientSize =
                new System.Drawing.Size(360, 470);

            this.StartPosition =
                System.Windows.Forms.FormStartPosition.CenterScreen;

            this.FormBorderStyle =
                System.Windows.Forms.FormBorderStyle.FixedSingle;

            this.MaximizeBox = false;

            this.FormClosing +=
                new System.Windows.Forms.FormClosingEventHandler(
                    this.Bai7_FormClosing);

            // =========================================
            // MÀN HÌNH
            // =========================================

            txtManHinh.Location =
                new System.Drawing.Point(20, 20);

            txtManHinh.Size =
                new System.Drawing.Size(320, 55);

            txtManHinh.Text = "0";

            txtManHinh.ReadOnly = true;

            txtManHinh.TextAlign =
                System.Windows.Forms.HorizontalAlignment.Right;

            txtManHinh.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    20F,
                    System.Drawing.FontStyle.Regular);

            txtManHinh.BackColor =
                System.Drawing.Color.White;

            // =========================================
            // NÚT XÓA
            // =========================================

            btnXoa.Text = "C";

            btnXoa.Location =
                new System.Drawing.Point(20, 90);

            btnXoa.Size =
                new System.Drawing.Size(155, 50);

            btnXoa.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    12F,
                    System.Drawing.FontStyle.Bold);

            btnXoa.Click +=
                new System.EventHandler(
                    this.btnXoa_Click);

            // =========================================
            // NÚT BACKSPACE
            // =========================================

            btnBackspace.Text = "←";

            btnBackspace.Location =
                new System.Drawing.Point(185, 90);

            btnBackspace.Size =
                new System.Drawing.Size(155, 50);

            btnBackspace.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    12F,
                    System.Drawing.FontStyle.Bold);

            btnBackspace.Click +=
                new System.EventHandler(
                    this.btnBackspace_Click);

            // =========================================
            // HÀNG 7 8 9 /
            // =========================================

            btn7.Text = "7";
            btn7.Location =
                new System.Drawing.Point(20, 155);
            btn7.Size =
                new System.Drawing.Size(75, 55);

            btn8.Text = "8";
            btn8.Location =
                new System.Drawing.Point(105, 155);
            btn8.Size =
                new System.Drawing.Size(75, 55);

            btn9.Text = "9";
            btn9.Location =
                new System.Drawing.Point(190, 155);
            btn9.Size =
                new System.Drawing.Size(75, 55);

            btnChia.Text = "/";
            btnChia.Location =
                new System.Drawing.Point(275, 155);
            btnChia.Size =
                new System.Drawing.Size(65, 55);

            // =========================================
            // HÀNG 4 5 6 *
            // =========================================

            btn4.Text = "4";
            btn4.Location =
                new System.Drawing.Point(20, 220);
            btn4.Size =
                new System.Drawing.Size(75, 55);

            btn5.Text = "5";
            btn5.Location =
                new System.Drawing.Point(105, 220);
            btn5.Size =
                new System.Drawing.Size(75, 55);

            btn6.Text = "6";
            btn6.Location =
                new System.Drawing.Point(190, 220);
            btn6.Size =
                new System.Drawing.Size(75, 55);

            btnNhan.Text = "*";
            btnNhan.Location =
                new System.Drawing.Point(275, 220);
            btnNhan.Size =
                new System.Drawing.Size(65, 55);

            // =========================================
            // HÀNG 1 2 3 -
            // =========================================

            btn1.Text = "1";
            btn1.Location =
                new System.Drawing.Point(20, 285);
            btn1.Size =
                new System.Drawing.Size(75, 55);

            btn2.Text = "2";
            btn2.Location =
                new System.Drawing.Point(105, 285);
            btn2.Size =
                new System.Drawing.Size(75, 55);

            btn3.Text = "3";
            btn3.Location =
                new System.Drawing.Point(190, 285);
            btn3.Size =
                new System.Drawing.Size(75, 55);

            btnTru.Text = "-";
            btnTru.Location =
                new System.Drawing.Point(275, 285);
            btnTru.Size =
                new System.Drawing.Size(65, 55);

            // =========================================
            // HÀNG 0 . = +
            // =========================================

            btn0.Text = "0";
            btn0.Location =
                new System.Drawing.Point(20, 350);
            btn0.Size =
                new System.Drawing.Size(75, 55);

            btnCham.Text = ".";
            btnCham.Location =
                new System.Drawing.Point(105, 350);
            btnCham.Size =
                new System.Drawing.Size(75, 55);

            btnBang.Text = "=";
            btnBang.Location =
                new System.Drawing.Point(190, 350);
            btnBang.Size =
                new System.Drawing.Size(75, 55);

            btnCong.Text = "+";
            btnCong.Location =
                new System.Drawing.Point(275, 350);
            btnCong.Size =
                new System.Drawing.Size(65, 55);

            // =========================================
            // FONT CHO CÁC NÚT
            // =========================================

            System.Drawing.Font fontNut =
                new System.Drawing.Font(
                    "Segoe UI",
                    12F,
                    System.Drawing.FontStyle.Bold);

            btn7.Font = fontNut;
            btn8.Font = fontNut;
            btn9.Font = fontNut;
            btnChia.Font = fontNut;

            btn4.Font = fontNut;
            btn5.Font = fontNut;
            btn6.Font = fontNut;
            btnNhan.Font = fontNut;

            btn1.Font = fontNut;
            btn2.Font = fontNut;
            btn3.Font = fontNut;
            btnTru.Font = fontNut;

            btn0.Font = fontNut;
            btnCham.Font = fontNut;
            btnBang.Font = fontNut;
            btnCong.Font = fontNut;

            // =========================================
            // GÁN EVENT CHO CÁC NÚT SỐ
            // =========================================

            btn0.Click +=
                new System.EventHandler(
                    this.btnSo_Click);

            btn1.Click +=
                new System.EventHandler(
                    this.btnSo_Click);

            btn2.Click +=
                new System.EventHandler(
                    this.btnSo_Click);

            btn3.Click +=
                new System.EventHandler(
                    this.btnSo_Click);

            btn4.Click +=
                new System.EventHandler(
                    this.btnSo_Click);

            btn5.Click +=
                new System.EventHandler(
                    this.btnSo_Click);

            btn6.Click +=
                new System.EventHandler(
                    this.btnSo_Click);

            btn7.Click +=
                new System.EventHandler(
                    this.btnSo_Click);

            btn8.Click +=
                new System.EventHandler(
                    this.btnSo_Click);

            btn9.Click +=
                new System.EventHandler(
                    this.btnSo_Click);

            // =========================================
            // GÁN EVENT PHÉP TOÁN
            // =========================================

            btnCong.Click +=
                new System.EventHandler(
                    this.btnPhepToan_Click);

            btnTru.Click +=
                new System.EventHandler(
                    this.btnPhepToan_Click);

            btnNhan.Click +=
                new System.EventHandler(
                    this.btnPhepToan_Click);

            btnChia.Click +=
                new System.EventHandler(
                    this.btnPhepToan_Click);

            // =========================================
            // EVENT DẤU CHẤM
            // =========================================

            btnCham.Click +=
                new System.EventHandler(
                    this.btnCham_Click);

            // =========================================
            // EVENT =
            // =========================================

            btnBang.Click +=
                new System.EventHandler(
                    this.btnBang_Click);

            // =========================================
            // ADD CONTROLS
            // =========================================

            this.Controls.Add(txtManHinh);

            this.Controls.Add(btnXoa);
            this.Controls.Add(btnBackspace);

            this.Controls.Add(btn7);
            this.Controls.Add(btn8);
            this.Controls.Add(btn9);
            this.Controls.Add(btnChia);

            this.Controls.Add(btn4);
            this.Controls.Add(btn5);
            this.Controls.Add(btn6);
            this.Controls.Add(btnNhan);

            this.Controls.Add(btn1);
            this.Controls.Add(btn2);
            this.Controls.Add(btn3);
            this.Controls.Add(btnTru);

            this.Controls.Add(btn0);
            this.Controls.Add(btnCham);
            this.Controls.Add(btnBang);
            this.Controls.Add(btnCong);

            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}