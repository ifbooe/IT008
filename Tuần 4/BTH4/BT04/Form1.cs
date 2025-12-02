using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace BT04
{
    public partial class Form1 : Form
    {
        private string currentFile = "";  

        public Form1()
        {
            InitializeComponent();
            LoadFontAndSize();  
            AddShortcuts();      
                      
            menuNew.ShortcutKeys = Keys.Control | Keys.N;
            menuNew.ShowShortcutKeys = true;
            menuNew.Text = "Tạo văn bản mới";

            menuSave.ShortcutKeys = Keys.Control | Keys.S;
            menuSave.ShowShortcutKeys = true;
            menuSave.Text = "Lưu nội dung văn bản";

        }

        private void LoadFontAndSize()
        {
            foreach (FontFamily font in FontFamily.Families)
                cbFont.Items.Add(font.Name);

            int[] sizes = { 8, 9, 10, 11, 12, 14, 16, 18, 20, 22, 24, 26, 28, 36, 48, 72 };
            foreach (int s in sizes)
                cbSize.Items.Add(s);

            cbFont.Text = "Tahoma";
            cbSize.Text = "14";
            rtb.Font = new Font("Tahoma", 14);
        }


        private void AddShortcuts()
        {
            this.KeyPreview = true;
            this.KeyDown += Form1_KeyDown;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.N) 
                CreateNew();
            else if (e.Control && e.KeyCode == Keys.S) 
                SaveFile();
        }


        private void CreateNew()
        {
            rtb.Clear();
            cbFont.Text = "Tahoma";
            cbSize.Text = "14";
            rtb.Font = new Font("Tahoma", 14);
            currentFile = ""; 
        }

        private void btnNew_Click(object sender, EventArgs e) => CreateNew();
        private void menuNew_Click(object sender, EventArgs e) => CreateNew();


        private void menuOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Text file (*.txt)|*.txt|Rich text (*.rtf)|*.rtf";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                currentFile = dlg.FileName;

                if (currentFile.EndsWith(".rtf"))
                    rtb.LoadFile(currentFile);
                else
                    rtb.Text = File.ReadAllText(currentFile);

                cbFont.Text = rtb.Font.Name;
                cbSize.Text = rtb.Font.Size.ToString();
            }
        }


        private void SaveFile()
        {
            if (currentFile == "")
            {
                SaveFileDialog dlg = new SaveFileDialog();
                dlg.Filter = "Rich text (*.rtf)|*.rtf";

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    currentFile = dlg.FileName;
                    rtb.SaveFile(currentFile);
                    MessageBox.Show("Đã lưu văn bản!", "Thông báo");
                }
            }
            else
            {
                rtb.SaveFile(currentFile);
                MessageBox.Show("Lưu thành công!", "Thông báo");
            }
        }

        private void btnSave_Click(object sender, EventArgs e) => SaveFile();
        private void menuSave_Click(object sender, EventArgs e) => SaveFile();

        private void menuFont_Click(object sender, EventArgs e)
        {
            FontDialog dlg = new FontDialog();
            dlg.Font = rtb.Font;

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                rtb.Font = dlg.Font;
                cbFont.Text = dlg.Font.Name;
                cbSize.Text = dlg.Font.Size.ToString();
            }
        }

        private void btnB_Click(object sender, EventArgs e)
        {
            ToggleStyle(FontStyle.Bold);
        }

        private void btnI_Click(object sender, EventArgs e)
        {
            ToggleStyle(FontStyle.Italic);
        }

        private void btnU_Click(object sender, EventArgs e)
        {
            ToggleStyle(FontStyle.Underline);
        }

        private void ToggleStyle(FontStyle style)
        {
            Font current = rtb.SelectionFont ?? rtb.Font;
            FontStyle newStyle = current.Style;

            if (current.Style.HasFlag(style))
                newStyle &= ~style;
            else
                newStyle |= style;   

            rtb.SelectionFont = new Font(current.FontFamily, current.Size, newStyle);
        }

        private void menuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
