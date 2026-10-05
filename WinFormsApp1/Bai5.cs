using System;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Bai5 : Form
    {
        public Bai5()
        {
            InitializeComponent();
        }

        private string DocHaiChuSo(int n)
        {
            string[] so =
            {
                "không",
                "một",
                "hai",
                "ba",
                "bốn",
                "năm",
                "sáu",
                "bảy",
                "tám",
                "chín"
            };

            if (n < 10)
                return so[n];

            if (n == 10)
                return "mười";

            int hangChuc = n / 10;
            int hangDonVi = n % 10;

            string ketQua =
                so[hangChuc] + " mươi";

            if (hangDonVi == 0)
                return ketQua;

            if (hangDonVi == 1)
                return ketQua + " mốt";

            if (hangDonVi == 4)
                return ketQua + " tư";

            if (hangDonVi == 5)
                return ketQua + " lăm";

            return ketQua + " " + so[hangDonVi];
        }

        private string DocSo(int n)
        {
            string[] so =
            {
                "không",
                "một",
                "hai",
                "ba",
                "bốn",
                "năm",
                "sáu",
                "bảy",
                "tám",
                "chín"
            };

            if (n < 100)
                return DocHaiChuSo(n);

            int hangTram = n / 100;
            int haiChuSo = n % 100;

            if (haiChuSo == 0)
            {
                return so[hangTram] + " trăm";
            }

            if (haiChuSo < 10)
            {
                return so[hangTram]
                       + " trăm lẻ "
                       + so[haiChuSo];
            }

            return so[hangTram]
                   + " trăm "
                   + DocHaiChuSo(haiChuSo);
        }

        private void btnThucHien_Click(
            object sender,
            EventArgs e)
        {
            if (!int.TryParse(
                    txtSo.Text,
                    out int n) ||
                n < 1 ||
                n > 999)
            {
                MessageBox.Show(
                    "Vui lòng nhập số nguyên dương từ 1 đến 999!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtSo.Focus();
                return;
            }

            txtKetQua.Text = DocSo(n);
        }

        private void btnXoa_Click(
            object sender,
            EventArgs e)
        {
            txtSo.Clear();
            txtKetQua.Clear();

            txtSo.Focus();
        }

        private void btnThoat_Click(
            object sender,
            EventArgs e)
        {
            Close();
        }

        private void Bai5_FormClosing(
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