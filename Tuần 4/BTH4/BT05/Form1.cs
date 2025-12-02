using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace BT05
{
    public partial class quanlysinhvien : Form
    {
        List<Student> list = new List<Student>();

        public quanlysinhvien()
        {
            InitializeComponent();
        }

        private void quanlysinhvien_Load(object sender, EventArgs e)
        {
            LoadGrid(list);
        }

        private void menuAdd_Click(object sender, EventArgs e)
        {
            
        }

        private void menuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoadGrid(List<Student> data)
        {
            dgvList.DataSource = null;
            dgvList.DataSource = data;
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void menuAdd_Click_1(object sender, EventArgs e)
        {
            themsinhvien f = new themsinhvien();
            if (f.ShowDialog() == DialogResult.OK)
            {
                f.NewStudent.No = list.Count + 1;
                list.Add(f.NewStudent);
                LoadGrid(list);
            }
        }

        private void txtSearch_TextChanged_1(object sender, EventArgs e)
        {
            string s = txtSearch.Text.ToLower();
            var result = list.Where(t => t.Name.ToLower().Contains(s)).ToList();
            LoadGrid(result);
        }
    }
}
