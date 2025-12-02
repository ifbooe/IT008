using System;
using System.Windows.Forms;

namespace BT08
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void TinhTongTien()
        {
            long tong = 0;
            foreach (ListViewItem item in lvDanhSach.Items)
            {
                tong += long.Parse(item.SubItems[4].Text);
            }
            txtTongTien.Text = tong.ToString();
        }

        private void btnThemCapNhat_Click(object sender, EventArgs e)
        {
            if (txtSoTK.Text.Trim() == "" ||
                txtTen.Text.Trim() == "" ||
                txtDiaChi.Text.Trim() == "" ||
                txtSoTien.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            ListViewItem itemTonTai = null;
            foreach (ListViewItem item in lvDanhSach.Items)
            {
                if (item.SubItems[1].Text == txtSoTK.Text.Trim())
                {
                    itemTonTai = item;
                    break;
                }
            }

            if (itemTonTai == null)   
            {
                ListViewItem item = new ListViewItem((lvDanhSach.Items.Count + 1).ToString());
                item.SubItems.Add(txtSoTK.Text);
                item.SubItems.Add(txtTen.Text);
                item.SubItems.Add(txtDiaChi.Text);
                item.SubItems.Add(txtSoTien.Text);

                lvDanhSach.Items.Add(item);

                TinhTongTien();
                MessageBox.Show("Thêm mới dữ liệu thành công!");
            }
            else   
            {
                itemTonTai.SubItems[2].Text = txtTen.Text;
                itemTonTai.SubItems[3].Text = txtDiaChi.Text;
                itemTonTai.SubItems[4].Text = txtSoTien.Text;

                TinhTongTien();
                MessageBox.Show("Cập nhật dữ liệu thành công!");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string soTK = txtSoTK.Text.Trim();
            ListViewItem itemCanXoa = null;

            foreach (ListViewItem item in lvDanhSach.Items)
            {
                if (item.SubItems[1].Text == soTK)
                {
                    itemCanXoa = item;
                    break;
                }
            }

            if (itemCanXoa == null)
            {
                MessageBox.Show("Không tìm thấy số tài khoản cần xóa");
                return;
            }

            DialogResult result = MessageBox.Show(
                "Bạn có chắc chắn muốn xóa tài khoản này?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.Yes)
            {
                lvDanhSach.Items.Remove(itemCanXoa);

                for (int i = 0; i < lvDanhSach.Items.Count; i++)
                {
                    lvDanhSach.Items[i].SubItems[0].Text = (i + 1).ToString();
                }

                TinhTongTien();
                MessageBox.Show("Xóa tài khoản thành công");
            }
        }

        private void lvDanhSach_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvDanhSach.SelectedItems.Count == 0) return;

            ListViewItem item = lvDanhSach.SelectedItems[0];

            txtSoTK.Text = item.SubItems[1].Text;
            txtTen.Text = item.SubItems[2].Text;
            txtDiaChi.Text = item.SubItems[3].Text;
            txtSoTien.Text = item.SubItems[4].Text;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
