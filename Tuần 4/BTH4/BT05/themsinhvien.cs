using System;
using System.Windows.Forms;

namespace BT05
{
    public partial class themsinhvien : Form
    {
        public Student NewStudent { get; set; }

        public themsinhvien()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            NewStudent = new Student()
            {
                Id = txtId.Text,
                Name = txtName.Text,
                Dept = cbDept.Text,
                Score = double.Parse(txtScore.Text)
            };

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
