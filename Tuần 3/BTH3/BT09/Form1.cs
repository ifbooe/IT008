using System;
using System.Windows.Forms;

namespace BT09
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (lbMonTrai.SelectedItem != null)
            {
                lbMonPhai.Items.Add(lbMonTrai.SelectedItem);
                lbMonTrai.Items.Remove(lbMonTrai.SelectedItem);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lbMonPhai.SelectedItem != null)
            {
                lbMonTrai.Items.Add(lbMonPhai.SelectedItem);
                lbMonPhai.Items.Remove(lbMonPhai.SelectedItem);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtMaSV.Text.Trim() == "" || txtHoTen.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập mã SV và họ tên!");
                return;
            }

            string gt = rdNam.Checked ? "Nam" : "Nữ";

            dgvDanhSach.Rows.Add(txtMaSV.Text, txtHoTen.Text, cboChuyenNganh.Text, gt, lbMonPhai.Items.Count);

            MessageBox.Show("Lưu thông tin thành công!");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvDanhSach.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn dòng cần xóa!");
                return;
            }

            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa sinh viên này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                dgvDanhSach.Rows.RemoveAt(dgvDanhSach.SelectedRows[0].Index);
                MessageBox.Show("Xóa thành công!");
            }
        }

        private void dgvDanhSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
