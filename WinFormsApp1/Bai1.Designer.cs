namespace WinFormsApp1
{
    partial class Bai1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.Label lblCong;
        private System.Windows.Forms.Label lblTru;
        private System.Windows.Forms.Label lblNhan;
        private System.Windows.Forms.Label lblChia;

        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.TextBox txtCong;
        private System.Windows.Forms.TextBox txtTru;
        private System.Windows.Forms.TextBox txtNhan;
        private System.Windows.Forms.TextBox txtChia;

        private System.Windows.Forms.Button btnTinh;
        private System.Windows.Forms.Button btnXoa;

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
            this.lblA = new System.Windows.Forms.Label();
            this.lblB = new System.Windows.Forms.Label();
            this.lblCong = new System.Windows.Forms.Label();
            this.lblTru = new System.Windows.Forms.Label();
            this.lblNhan = new System.Windows.Forms.Label();
            this.lblChia = new System.Windows.Forms.Label();

            this.txtA = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.txtCong = new System.Windows.Forms.TextBox();
            this.txtTru = new System.Windows.Forms.TextBox();
            this.txtNhan = new System.Windows.Forms.TextBox();
            this.txtChia = new System.Windows.Forms.TextBox();

            this.btnTinh = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();

            this.SuspendLayout();

            // 
            // Bai1
            // 
            this.ClientSize = new System.Drawing.Size(500, 380);
            this.Name = "Bai1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bài 1 - Các phép toán";

            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Location = new System.Drawing.Point(50, 40);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(45, 20);
            this.lblA.Text = "Số A:";

            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(160, 37);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(250, 27);

            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.Location = new System.Drawing.Point(50, 85);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(45, 20);
            this.lblB.Text = "Số B:";

            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(160, 82);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(250, 27);

            // 
            // btnTinh
            // 
            this.btnTinh.Location = new System.Drawing.Point(160, 125);
            this.btnTinh.Name = "btnTinh";
            this.btnTinh.Size = new System.Drawing.Size(110, 35);
            this.btnTinh.Text = "Tính";
            this.btnTinh.UseVisualStyleBackColor = true;
            this.btnTinh.Click += new System.EventHandler(this.btnTinh_Click);

            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(290, 125);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(120, 35);
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);

            // 
            // lblCong
            // 
            this.lblCong.AutoSize = true;
            this.lblCong.Location = new System.Drawing.Point(50, 185);
            this.lblCong.Name = "lblCong";
            this.lblCong.Size = new System.Drawing.Size(50, 20);
            this.lblCong.Text = "A + B:";

            // 
            // txtCong
            // 
            this.txtCong.Location = new System.Drawing.Point(160, 182);
            this.txtCong.Name = "txtCong";
            this.txtCong.ReadOnly = true;
            this.txtCong.Size = new System.Drawing.Size(250, 27);

            // 
            // lblTru
            // 
            this.lblTru.AutoSize = true;
            this.lblTru.Location = new System.Drawing.Point(50, 225);
            this.lblTru.Name = "lblTru";
            this.lblTru.Size = new System.Drawing.Size(50, 20);
            this.lblTru.Text = "A - B:";

            // 
            // txtTru
            // 
            this.txtTru.Location = new System.Drawing.Point(160, 222);
            this.txtTru.Name = "txtTru";
            this.txtTru.ReadOnly = true;
            this.txtTru.Size = new System.Drawing.Size(250, 27);

            // 
            // lblNhan
            // 
            this.lblNhan.AutoSize = true;
            this.lblNhan.Location = new System.Drawing.Point(50, 265);
            this.lblNhan.Name = "lblNhan";
            this.lblNhan.Size = new System.Drawing.Size(50, 20);
            this.lblNhan.Text = "A × B:";

            // 
            // txtNhan
            // 
            this.txtNhan.Location = new System.Drawing.Point(160, 262);
            this.txtNhan.Name = "txtNhan";
            this.txtNhan.ReadOnly = true;
            this.txtNhan.Size = new System.Drawing.Size(250, 27);

            // 
            // lblChia
            // 
            this.lblChia.AutoSize = true;
            this.lblChia.Location = new System.Drawing.Point(50, 305);
            this.lblChia.Name = "lblChia";
            this.lblChia.Size = new System.Drawing.Size(50, 20);
            this.lblChia.Text = "A ÷ B:";

            // 
            // txtChia
            // 
            this.txtChia.Location = new System.Drawing.Point(160, 302);
            this.txtChia.Name = "txtChia";
            this.txtChia.ReadOnly = true;
            this.txtChia.Size = new System.Drawing.Size(250, 27);

            // 
            // Controls
            // 
            this.Controls.Add(this.lblA);
            this.Controls.Add(this.txtA);

            this.Controls.Add(this.lblB);
            this.Controls.Add(this.txtB);

            this.Controls.Add(this.btnTinh);
            this.Controls.Add(this.btnXoa);

            this.Controls.Add(this.lblCong);
            this.Controls.Add(this.txtCong);

            this.Controls.Add(this.lblTru);
            this.Controls.Add(this.txtTru);

            this.Controls.Add(this.lblNhan);
            this.Controls.Add(this.txtNhan);

            this.Controls.Add(this.lblChia);
            this.Controls.Add(this.txtChia);

            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}