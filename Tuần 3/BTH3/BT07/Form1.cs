using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace BT07
{
    public partial class Form1 : Form
    {
        Button[] ghe = new Button[15];
        int[] gia = new int[15];    
        List<int> dangChon = new List<int>();

        public Form1()
        {
            InitializeComponent();
            TaoGhe();
            TaoGia();
        }

        void TaoGhe()
        {

            ghe[0] = btn1; ghe[1] = btn2; ghe[2] = btn3; ghe[3] = btn4; ghe[4] = btn5;
            ghe[5] = btn6; ghe[6] = btn7; ghe[7] = btn8; ghe[8] = btn9; ghe[9] = btn10;
            ghe[10] = btn11; ghe[11] = btn12; ghe[12] = btn13; ghe[13] = btn14; ghe[14] = btn15;

            for (int i = 0; i < 15; i++)
            {
                ghe[i].Tag = i;
                ghe[i].BackColor = Color.White;
                ghe[i].Click += ChonGhe;
            }
        }

        void TaoGia()
        {

            for (int i = 0; i < 5; i++) gia[i] = 5000;


            for (int i = 5; i < 10; i++) gia[i] = 6500;


            for (int i = 10; i < 15; i++) gia[i] = 8000;
        }

        void ChonGhe(object sender, EventArgs e)
        {
            Button b = sender as Button;
            int id = (int)b.Tag;

            if (b.BackColor == Color.Yellow)
            {
                MessageBox.Show("Ghế này bán rồi!");
                return;
            }

            if (b.BackColor == Color.White)
            {
                b.BackColor = Color.Blue;
                dangChon.Add(id);
            }
            else if (b.BackColor == Color.Blue)
            {
                b.BackColor = Color.White;
                dangChon.Remove(id);
            }
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            int tong = 0;

            foreach (int i in dangChon)
            {
                ghe[i].BackColor = Color.Yellow;
                tong += gia[i];
            }

            lblTien.Text = "Tiền: " + tong.ToString();
            dangChon.Clear();
        }


        private void btnHuy_Click(object sender, EventArgs e)
        {
            foreach (int i in dangChon)
                ghe[i].BackColor = Color.White;

            dangChon.Clear();
            lblTien.Text = "Tiền: 0";
        }


        private void btnKetThuc_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
