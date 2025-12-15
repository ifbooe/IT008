using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace BT11
{
    public partial class Form1 : Form
    {
        Graphics g;
        Bitmap bmp;
        Point startPoint, endPoint;
        bool isDrawing = false;
        Color penColor = Color.Black;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bmp = new Bitmap(picDraw.Width, picDraw.Height);
            picDraw.Image = bmp;
            g = Graphics.FromImage(bmp);
            g.Clear(Color.White);
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                penColor = colorDialog1.Color;
        }

        private void picDraw_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDrawing = true;
                startPoint = e.Location;
            }
        }

        private void picDraw_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isDrawing) return;

            endPoint = e.Location;
            picDraw.Refresh();

            using (Graphics tempG = picDraw.CreateGraphics())
            {
                DrawShape(tempG);
            }
        }

        private void picDraw_MouseUp(object sender, MouseEventArgs e)
        {
            if (!isDrawing) return;

            isDrawing = false;
            endPoint = e.Location;
            DrawShape(g);
            picDraw.Image = bmp;
        }

        private void DrawShape(Graphics gr)
        {
            int w = int.Parse(txtWidth.Text);
            Pen pen = new Pen(penColor, w);

            Rectangle rect = new Rectangle(Math.Min(startPoint.X, endPoint.X), Math.Min(startPoint.Y, endPoint.Y), Math.Abs(startPoint.X - endPoint.X), Math.Abs(startPoint.Y - endPoint.Y));

            if (rdoLine.Checked)
            {
                gr.DrawLine(pen, startPoint, endPoint);
                return;
            }

            Brush brush = GetBrush(rect);

            if (rdoRectangle.Checked)
                gr.FillRectangle(brush, rect);
            else if (rdoEllipse.Checked)
                gr.FillEllipse(brush, rect);
        }

        private Brush GetBrush(Rectangle rect)
        {
            if (rdoSolid.Checked)
                return new SolidBrush(Color.Green);

            if (rdoHatch.Checked)
                return new HatchBrush(HatchStyle.Horizontal, Color.Blue, Color.Green);

            if (rdoTexture.Checked)
            {
                Bitmap texture = new Bitmap(40, 40);
                Graphics tg = Graphics.FromImage(texture);
                tg.Clear(Color.LightGray);
                tg.DrawEllipse(Pens.Blue, 5, 5, 30, 30);
                return new TextureBrush(texture);
            }

            if (rdoGradient.Checked)
            {
                Rectangle safeRect = rect;
                if (safeRect.Width == 0) safeRect.Width = 1;
                if (safeRect.Height == 0) safeRect.Height = 1;

                return new LinearGradientBrush(
                    safeRect,
                    Color.Red,
                    Color.Green,
                    LinearGradientMode.Vertical
                );
            }


            return new SolidBrush(Color.Green);
        }
    }
}
