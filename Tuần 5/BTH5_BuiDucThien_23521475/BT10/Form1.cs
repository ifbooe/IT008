using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace BT10
{
    public partial class Form1 : Form
    {
        Bitmap bmp;
        Graphics g;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bmp = new Bitmap(picDraw.Width, picDraw.Height);
            picDraw.Image = bmp;
            g = Graphics.FromImage(bmp);

            cboDashStyle.DataSource = Enum.GetValues(typeof(DashStyle));
            cboLineJoin.DataSource = Enum.GetValues(typeof(LineJoin));
            cboDashCap.DataSource = Enum.GetValues(typeof(DashCap));
            cboStartCap.DataSource = Enum.GetValues(typeof(LineCap));
            cboEndCap.DataSource = Enum.GetValues(typeof(LineCap));

            for (int i = 1; i <= 10; i++)
                cboWidth.Items.Add(i);

            cboWidth.SelectedIndex = 2;

            cboDashStyle.SelectedIndexChanged += ComboChanged;
            cboWidth.SelectedIndexChanged += ComboChanged;
            cboLineJoin.SelectedIndexChanged += ComboChanged;
            cboDashCap.SelectedIndexChanged += ComboChanged;
            cboStartCap.SelectedIndexChanged += ComboChanged;
            cboEndCap.SelectedIndexChanged += ComboChanged;

            DrawDemo();
        }

        private void ComboChanged(object sender, EventArgs e)
        {
            DrawDemo();
        }

        private void DrawDemo()
        {
            g.Clear(Color.White);

            Pen pen = new Pen(Color.Red, Convert.ToInt32(cboWidth.SelectedItem));
            pen.DashStyle = (DashStyle)cboDashStyle.SelectedItem;
            pen.LineJoin = (LineJoin)cboLineJoin.SelectedItem;
            pen.DashCap = (DashCap)cboDashCap.SelectedItem;
            pen.StartCap = (LineCap)cboStartCap.SelectedItem;
            pen.EndCap = (LineCap)cboEndCap.SelectedItem;

            g.DrawLine(pen, 50, 50, 450, 50);

            Point[] pts =
            {
                new Point(200,150),
                new Point(300,250),
                new Point(400,150)
            };
            g.DrawLines(pen, pts);

            picDraw.Image = bmp;
        }
    }
}
