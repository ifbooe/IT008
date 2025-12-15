using System;
using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;

namespace BT04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadFont();
            LoadSize();

            SetDefault();
        }

        private void SetDefault()
        {
            cboFont.SelectedItem = "Arial";
            cboSize.SelectedItem = 28;
            radCenter.Checked = true;
            UpdateFont();
        }


        private void LoadFont()
        {
            InstalledFontCollection fonts = new InstalledFontCollection();
            foreach (FontFamily font in fonts.Families)
            {
                cboFont.Items.Add(font.Name);
            }
            cboFont.SelectedIndex = 0;
        }

        private void LoadSize()
        {
            for (int i = 8; i <= 40; i += 2)
            {
                cboSize.Items.Add(i);
            }
            cboSize.SelectedIndex = 5;
        }

        private void UpdateFont()
        {
            if (cboFont.SelectedItem == null || cboSize.SelectedItem == null)
                return;

            FontStyle style = FontStyle.Regular;

            if (chkBold.Checked)
                style |= FontStyle.Bold;
            if (chkItalic.Checked)
                style |= FontStyle.Italic;
            if (chkUnderline.Checked)
                style |= FontStyle.Underline;

            string fontName = cboFont.SelectedItem.ToString();
            float fontSize = float.Parse(cboSize.SelectedItem.ToString());

            lblText.Font = new Font(fontName, fontSize, style);
        }


        private void cboFont_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateFont();
        }

        private void cboSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateFont();
        }

        private void chkBold_CheckedChanged(object sender, EventArgs e)
        {
            UpdateFont();
        }

        private void chkItalic_CheckedChanged(object sender, EventArgs e)
        {
            UpdateFont();
        }

        private void chkUnderline_CheckedChanged(object sender, EventArgs e)
        {
            UpdateFont();
        }

        private void radLeft_CheckedChanged(object sender, EventArgs e)
        {
            lblText.TextAlign = ContentAlignment.MiddleLeft;
        }

        private void radCenter_CheckedChanged(object sender, EventArgs e)
        {
            lblText.TextAlign = ContentAlignment.MiddleCenter;
        }

        private void radRight_CheckedChanged(object sender, EventArgs e)
        {
            lblText.TextAlign = ContentAlignment.MiddleRight;
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                lblText.ForeColor = colorDialog1.Color;
            }
        }
    }
}
