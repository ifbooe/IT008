using System;
using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;

namespace BT06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadAllFonts();
        }

        private void LoadAllFonts()
        {
            InstalledFontCollection fonts = new InstalledFontCollection();

            foreach (FontFamily font in fonts.Families)
            {
                lstFont.Items.Add(font.Name);
            }
        }

        private void lstFont_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) return;

            string fontName = lstFont.Items[e.Index].ToString();

            e.DrawBackground();

            Font font = new Font(fontName, 14);
            e.Graphics.DrawString(fontName, font, Brushes.Black, e.Bounds);

            e.DrawFocusRectangle();
        }
    }
}
