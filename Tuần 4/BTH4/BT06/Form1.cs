using System;
using System.IO;
using System.Windows.Forms;

namespace BT06
{
    public partial class Form1 : Form
    {
        string sourcePath, destPath;

        public Form1()
        {
            InitializeComponent();
        }

        private void button_source_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dlg = new FolderBrowserDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                textBox_source.Text = dlg.SelectedPath;
            }
        }

        private void button_dest_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dlg = new FolderBrowserDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                textBox_dest.Text = dlg.SelectedPath;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_copy_Click(object sender, EventArgs e)
        {
            sourcePath = textBox_source.Text;
            destPath = textBox_dest.Text;

            if (!Directory.Exists(sourcePath) || !Directory.Exists(destPath))
            {
                MessageBox.Show("Đường dẫn không hợp lệ!");
                return;
            }

            string[] files = Directory.GetFiles(sourcePath);

            if (files.Length == 0)
            {
                MessageBox.Show("Thư mục nguồn không có file!");
                return;
            }

            progressBar_copy.Value = 0;
            progressBar_copy.Maximum = files.Length;

            foreach (string file in files)
            {
                string fileName = Path.GetFileName(file);
                string destFile = Path.Combine(destPath, fileName);

                File.Copy(file, destFile, true);

                progressBar_copy.Value++;

                label_status.Text = "Đang sao chép: " + fileName;

                toolTip1.SetToolTip(progressBar_copy, fileName);

                Application.DoEvents();
            }

            label_status.Text = "Hoàn tất sao chép!";
            MessageBox.Show("Sao chép hoàn tất!");
        }
    }
}
