using System;
using System.Drawing;
using System.Windows.Forms;

namespace BT08
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            int centerX = this.ClientSize.Width / 2;
            int centerY = this.ClientSize.Height / 2;
            int radius = 200;

            Pen penCircle = new Pen(Color.White, 2);
            g.DrawEllipse(penCircle,
                centerX - radius,
                centerY - radius,
                radius * 2,
                radius * 2);

            for (int i = 0; i < 60; i++)
            {
                double angle = i * 6 * Math.PI / 180;
                int r = (i % 5 == 0) ? 10 : 4;

                int x = centerX + (int)((radius - 10) * Math.Sin(angle));
                int y = centerY - (int)((radius - 10) * Math.Cos(angle));

                g.FillEllipse(Brushes.White, x - r / 2, y - r / 2, r, r);
            }

            DateTime now = DateTime.Now;

            DrawHand(g, now.Hour % 12 * 30 + now.Minute * 0.5, radius - 80, 6, Color.White);

            DrawHand(g, now.Minute * 6, radius - 50, 4, Color.White);

            DrawHand(g, now.Second * 6, radius - 30, 2, Color.White);
        }

        private void DrawHand(Graphics g, double angle, int length, int width, Color color)
        {
            int cx = this.ClientSize.Width / 2;
            int cy = this.ClientSize.Height / 2;

            double rad = Math.PI * angle / 180;

            int x = cx + (int)(length * Math.Sin(rad));
            int y = cy - (int)(length * Math.Cos(rad));

            Pen pen = new Pen(color, width);
            g.DrawLine(pen, cx, cy, x, y);
        }
    }
}
