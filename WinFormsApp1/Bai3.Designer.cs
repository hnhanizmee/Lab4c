namespace WinFormsApp1
{
    partial class Bai3
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.Label lblUCLN;
        private System.Windows.Forms.Label lblBCNN;

        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.TextBox txtUCLN;
        private System.Windows.Forms.TextBox txtBCNN;

        private System.Windows.Forms.Button btnTinh;
        private System.Windows.Forms.Button btnXoa;
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

            lblA = new System.Windows.Forms.Label();
            lblB = new System.Windows.Forms.Label();
            lblUCLN = new System.Windows.Forms.Label();
            lblBCNN = new System.Windows.Forms.Label();

            txtA = new System.Windows.Forms.TextBox();
            txtB = new System.Windows.Forms.TextBox();
            txtUCLN = new System.Windows.Forms.TextBox();
            txtBCNN = new System.Windows.Forms.TextBox();

            btnTinh = new System.Windows.Forms.Button();
            btnXoa = new System.Windows.Forms.Button();
            btnThoat = new System.Windows.Forms.Button();

            Label[] labels =
            {
                lblA,
                lblB,
                lblUCLN,
                lblBCNN
            };

            TextBox[] boxes =
            {
                txtA,
                txtB,
                txtUCLN,
                txtBCNN
            };

            string[] names =
            {
                "Số a:",
                "Số b:",
                "UCLN:",
                "BCNN:"
            };

            for (int i = 0; i < 4; i++)
            {
                labels[i].Text = names[i];
                labels[i].AutoSize = true;
                labels[i].Location =
                    new System.Drawing.Point(
                        45,
                        40 + i * 45);

                boxes[i].Location =
                    new System.Drawing.Point(
                        150,
                        37 + i * 45);

                boxes[i].Size =
                    new System.Drawing.Size(240, 27);
            }

            txtUCLN.ReadOnly = true;
            txtBCNN.ReadOnly = true;

            btnTinh.Text = "Tính";
            btnTinh.Location =
                new System.Drawing.Point(150, 220);
            btnTinh.Size =
                new System.Drawing.Size(75, 35);
            btnTinh.Click += btnTinh_Click;

            btnXoa.Text = "Xóa";
            btnXoa.Location =
                new System.Drawing.Point(235, 220);
            btnXoa.Size =
                new System.Drawing.Size(75, 35);
            btnXoa.Click += btnXoa_Click;

            btnThoat.Text = "Thoát";
            btnThoat.Location =
                new System.Drawing.Point(320, 220);
            btnThoat.Size =
                new System.Drawing.Size(70, 35);
            btnThoat.Click += btnThoat_Click;

            Controls.Add(lblA);
            Controls.Add(txtA);

            Controls.Add(lblB);
            Controls.Add(txtB);

            Controls.Add(lblUCLN);
            Controls.Add(txtUCLN);

            Controls.Add(lblBCNN);
            Controls.Add(txtBCNN);

            Controls.Add(btnTinh);
            Controls.Add(btnXoa);
            Controls.Add(btnThoat);

            ClientSize =
                new System.Drawing.Size(450, 300);

            StartPosition =
                System.Windows.Forms.FormStartPosition.CenterScreen;

            Text = "Bài 3 - UCLN và BCNN";

            FormClosing += Bai3_FormClosing;
        }
    }
}