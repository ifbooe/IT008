using System;
using System.Drawing;
using System.Windows.Forms;

namespace BT09
{
    public partial class Form1 : Form
    {
        ComboBox cboShape;

        public Form1()
        {
            InitializeComponent();
            InitComboBox();
        }

        private void InitComboBox()
        {
            cboShape = new ComboBox();
            cboShape.DropDownStyle = ComboBoxStyle.DropDownList;
            cboShape.Items.AddRange(new string[]
            {
                "Circle",
                "Square",
                "Ellipse",
                "Pie",
                "Filled Circle",
                "Filled Square",
                "Filled Ellipse",
                "Filled Pie"
            });

            cboShape.SelectedIndex = 0;
            cboShape.Location = new Point(20, 20);
            cboShape.SelectedIndexChanged += (s, e) => this.Invalidate();

            this.Controls.Add(cboShape);
            this.Paint += Form1_Paint;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            Pen pen = new Pen(Color.DarkRed, 3);
            Brush brush = Brushes.DarkRed;

            Rectangle rectEllipse = new Rectangle(200, 100, 300, 200);
            int size = 200;
            Rectangle rectCircle = new Rectangle(250, 100, size, size);

            string shape = cboShape.SelectedItem.ToString();

            switch (shape)
            {
                case "Circle":
                    g.DrawEllipse(pen, rectCircle);
                    break;

                case "Square":
                    g.DrawRectangle(pen, rectCircle);
                    break;

                case "Ellipse":
                    g.DrawEllipse(pen, rectEllipse);
                    break;

                case "Pie":
                    g.DrawEllipse(pen, rectCircle);
                    g.DrawPie(pen, rectCircle, 0, 120);
                    break;

                case "Filled Circle":
                    g.FillEllipse(brush, rectCircle);
                    break;

                case "Filled Square":
                    g.FillRectangle(brush, rectCircle);
                    break;

                case "Filled Ellipse":
                    g.FillEllipse(brush, rectEllipse);
                    break;

                case "Filled Pie":
                    g.FillPie(brush, rectCircle, 0, 120);
                    g.DrawEllipse(pen, rectCircle);
                    g.DrawPie(pen, rectCircle, 0, 120);
                    break;
            }
        }
    }
}
