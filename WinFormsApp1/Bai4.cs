using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Bai4 : Form
    {
        private readonly List<int> ds = new List<int>();

        public Bai4()
        {
            InitializeComponent();
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(
                    txtNhapSo.Text.Trim(),
                    out int n))
            {
                MessageBox.Show(
                    "Vui lòng nhập số nguyên!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtNhapSo.Focus();
                return;
            }

            ds.Add(n);

            txtDay.Text =
                string.Join(" ", ds);

            txtNhapSo.Clear();
            txtNhapSo.Focus();
        }

        private void btnTong_Click(object sender, EventArgs e)
        {
            if (ds.Count == 0)
            {
                MessageBox.Show("Chưa có số nào!");
                return;
            }

            txtTong.Text =
                ds.Sum().ToString();
        }

        private void btnTongChan_Click(object sender, EventArgs e)
        {
            if (ds.Count == 0)
            {
                MessageBox.Show("Chưa có số nào!");
                return;
            }

            txtTongChan.Text =
                ds.Where(x => x % 2 == 0)
                  .Sum()
                  .ToString();
        }

        private void btnTongLe_Click(object sender, EventArgs e)
        {
            if (ds.Count == 0)
            {
                MessageBox.Show("Chưa có số nào!");
                return;
            }

            txtTongLe.Text =
                ds.Where(x => x % 2 != 0)
                  .Sum()
                  .ToString();
        }

        private void btnTiepTuc_Click(object sender, EventArgs e)
        {
            ds.Clear();

            txtNhapSo.Clear();
            txtDay.Clear();
            txtTong.Clear();
            txtTongChan.Clear();
            txtTongLe.Clear();

            txtNhapSo.Focus();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Bai4_FormClosing(
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