using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace lab7
{
    public partial class Form1 : Form
    {
        private int num = 0;
        private bool isTree = false;
        private bool isStar = false;
        private bool isPresents = false;
        private bool isBalls = false;
        private bool isLights = false;
        private bool isGarland = false;

        WindowsMediaPlayer Music = new WindowsMediaPlayer();

        public Form1()
        {
            InitializeComponent();
            Music.URL = @"D:\Visual_Studio\LABS\lab7\lab7\bin\Debug\christmas-cinematic-dream-piano-9784.mp3";
            Music.controls.stop();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lightTimer.Enabled = false;
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            isTree = false;
            isStar = false;
            isPresents = false;
            isBalls = false;
            isLights = false;
            isGarland = false;
            Panel.Refresh();
            Music.controls.stop();
        }

        private void Panel_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = Panel.CreateGraphics();
            g.FillRectangle(Brushes.DodgerBlue, 0, 0, 360, 220);

            if (isTree)
            {
                drawTreeMethod();
            }
            if (isStar)
            {
                drawStarMethod();
            }
            if (isPresents)
            {
                drawPresentsMethod();
            }
            if (isBalls)
            {
                drawBallsMethod();
            }
            if (isLights)
            {
                drawLightsMethod();
            }
            if (isGarland)
            {
                drawGarlandMethod();
            }
        }

        private void lightTimer_Tick(object sender, EventArgs e)
        {
            num++;
            if (num % 2 == 0 && isLights)
            {
                drawLightsMethod();
            }
            if (num % 2 == 1 && isLights)
            {
                Graphics g = Panel.CreateGraphics();
                /////////////////////////////////////////////////////////////
                g.FillEllipse(Brushes.SkyBlue, 140, 60, 6, 6);
                g.FillEllipse(Brushes.SkyBlue, 150, 68, 6, 6);
                g.FillEllipse(Brushes.SkyBlue, 160, 75, 6, 6);
                g.FillEllipse(Brushes.SkyBlue, 171, 82, 6, 6);
                g.FillEllipse(Brushes.SkyBlue, 183, 89, 6, 6);
                g.FillEllipse(Brushes.SkyBlue, 193, 94, 6, 6);
                g.FillEllipse(Brushes.SkyBlue, 206, 99, 6, 6);
                /////////////////////////////////////////////////////////////
                g.FillEllipse(Brushes.SkyBlue, 140, 110, 6, 6);
                g.FillEllipse(Brushes.SkyBlue, 150, 118, 6, 6);
                g.FillEllipse(Brushes.SkyBlue, 160, 125, 6, 6);
                g.FillEllipse(Brushes.SkyBlue, 171, 132, 6, 6);
                g.FillEllipse(Brushes.SkyBlue, 183, 139, 6, 6);
                g.FillEllipse(Brushes.SkyBlue, 193, 145, 6, 6);
                g.FillEllipse(Brushes.SkyBlue, 204, 151, 6, 6);
                g.FillEllipse(Brushes.SkyBlue, 217, 157, 6, 6);
                /////////////////////////////////////////////////////////////
                g.FillEllipse(Brushes.SkyBlue, 122, 182, 6, 6);
                g.FillEllipse(Brushes.SkyBlue, 133, 188, 6, 6);
                g.FillEllipse(Brushes.SkyBlue, 144, 193, 6, 6);
                g.FillEllipse(Brushes.SkyBlue, 155, 199, 6, 6);
                g.FillEllipse(Brushes.SkyBlue, 167, 205, 6, 6);
                g.FillEllipse(Brushes.SkyBlue, 179, 210, 6, 6);
                g.FillEllipse(Brushes.SkyBlue, 191, 215, 6, 6);
                g.FillEllipse(Brushes.SkyBlue, 203, 219, 6, 6);
                g.FillEllipse(Brushes.SkyBlue, 216, 223, 6, 6);
            }
        }

        /////////Music
        private void musicButton_Click(object sender, EventArgs e)
        {
            Music.controls.play();
        }

        /////////Christmas tree
        private void drawTreeMethod()
        {
            Graphics g = Panel.CreateGraphics();
            Point[] p1 = new Point[3];
            p1[0].X = 180;
            p1[0].Y = 17;
            p1[1].X = 110;
            p1[1].Y = 100;
            p1[2].X = 255;
            p1[2].Y = 100;
            g.FillPolygon(Brushes.Green, p1);
            Point[] p2 = new Point[3];
            p2[0].X = 180;
            p2[0].Y = 70;
            p2[1].X = 90;
            p2[1].Y = 165;
            p2[2].X = 275;
            p2[2].Y = 165;
            g.FillPolygon(Brushes.Green, p2);
            Point[] p3 = new Point[3];
            p3[0].X = 180;
            p3[0].Y = 130;
            p3[1].X = 65;
            p3[1].Y = 230;
            p3[2].X = 295;
            p3[2].Y = 230;
            g.FillPolygon(Brushes.Green, p3);
            g.FillRectangle(Brushes.Brown, 165, 230, 30, 40);
        }
        private void drawTree_Click(object sender, EventArgs e)
        {
            drawTreeMethod();
            isTree = true;
        }

        /////////Star
        private void drawStarMethod()
        {
            Graphics g = Panel.CreateGraphics();
            Point[] g1 = new Point[10];
            g1[0].X = 180;
            g1[0].Y = 0;
            g1[1].X = 175;
            g1[1].Y = 10;
            g1[2].X = 165;
            g1[2].Y = 10;
            g1[3].X = 173;
            g1[3].Y = 15;
            g1[4].X = 170;
            g1[4].Y = 25;
            g1[5].X = 180;
            g1[5].Y = 18;
            g1[6].X = 190;
            g1[6].Y = 25;
            g1[7].X = 187;
            g1[7].Y = 15;
            g1[8].X = 195;
            g1[8].Y = 10;
            g1[9].X = 185;
            g1[9].Y = 10;
            g.FillPolygon(Brushes.Yellow, g1);
        }
        private void drawStar_Click(object sender, EventArgs e)
        {
            drawStarMethod();
            isStar = true;
        }

        /////////Presents
        private void drawPresentsMethod()
        {
            Graphics g = Panel.CreateGraphics();
            g.FillRectangle(Brushes.Red, 120, 240, 40, 40);
            g.FillRectangle(Brushes.Violet, 137, 240, 6, 40);
            g.FillRectangle(Brushes.Violet, 120, 257, 40, 6);

            g.FillRectangle(Brushes.Magenta, 173, 235, 80, 45);
            g.FillRectangle(Brushes.BlueViolet, 209, 235, 8, 45);
            g.FillRectangle(Brushes.BlueViolet, 173, 254, 80, 8);

            g.FillRectangle(Brushes.Blue, 150, 255, 30, 30);
            g.FillRectangle(Brushes.LightGreen, 163, 255, 4, 30);
            g.FillRectangle(Brushes.LightGreen, 150, 268, 30, 4);

            g.FillRectangle(Brushes.Orange, 245, 247, 36, 36);
            g.FillRectangle(Brushes.Yellow, 261, 247, 4, 36);
            g.FillRectangle(Brushes.Yellow, 245, 263, 36, 4);

            g.FillRectangle(Brushes.LimeGreen, 80, 254, 50, 30);
            g.FillRectangle(Brushes.RoyalBlue, 103, 254, 4, 30);
            g.FillRectangle(Brushes.RoyalBlue, 80, 267, 50, 4);
        }
        private void drawPresents_Click(object sender, EventArgs e)
        {
            drawPresentsMethod();
            isPresents = true;
        }

        /////////Balls
        private void drawBallsMethod()
        {
            Random rnd = new Random();
            Graphics g = Panel.CreateGraphics();
            int numberOfBalls = 0;
            do
            {
                numberOfBalls++;
                int color = rnd.Next(1,5);
                if(color == 1)
                {
                    int a = rnd.Next(140, 210);
                    int b = rnd.Next(70, 240);
                    g.DrawLine(Pens.Black, a+5, (b-10), a+5, b);
                    g.FillEllipse(Brushes.Red, a, b, 10, 10);

                }
                if(color == 2)
                {
                    int a = 0;
                    int b = 0;
                    int spot = rnd.Next(1, 4);
                    if(spot == 1)
                    {
                        a = rnd.Next(122, 235);
                        b = rnd.Next(90, 100);
                        g.DrawLine(Pens.Black, a + 5, (b - 10), a + 5, b);
                        g.FillEllipse(Brushes.Blue, a, b, 10, 10);
                    }
                    if (spot == 2)
                    {
                        a = rnd.Next(110, 250);
                        b = rnd.Next(150, 175);
                        g.DrawLine(Pens.Black, a + 5, (b - 10), a + 5, b);
                        g.FillEllipse(Brushes.Blue, a, b, 10, 10);
                    }
                    if (spot == 3)
                    {
                        a = rnd.Next(90, 260);
                        b = rnd.Next(215, 240);
                        g.DrawLine(Pens.Black, a + 5, (b - 10), a + 5, b);
                        g.FillEllipse(Brushes.Blue, a, b, 10, 10);
                    }
                }
                if(color == 3)
                {
                    int a = rnd.Next(155, 195);
                    int b = rnd.Next(50, 240);
                    g.DrawLine(Pens.Black, a + 5, (b - 10), a + 5, b);
                    g.FillEllipse(Brushes.Orange, a, b, 10, 10);
                }
                if (color == 4)
                {
                    int a = 0;
                    int b = 0;
                    int spot = rnd.Next(1, 4);
                    if (spot == 1)
                    {
                        a = rnd.Next(137, 215);
                        b = rnd.Next(70, 90);
                        g.DrawLine(Pens.Black, a + 5, (b - 10), a + 5, b);
                        g.FillEllipse(Brushes.Indigo, a, b, 10, 10);
                    }
                    if (spot == 2)
                    {
                        a = rnd.Next(130, 223);
                        b = rnd.Next(125, 140);
                        g.DrawLine(Pens.Black, a + 5, (b - 10), a + 5, b);
                        g.FillEllipse(Brushes.Indigo, a, b, 10, 10);
                    }
                    if (spot == 3)
                    {
                        a = rnd.Next(120, 230);
                        b = rnd.Next(185, 210);
                        g.DrawLine(Pens.Black, a + 5, (b - 10), a + 5, b);
                        g.FillEllipse(Brushes.Indigo, a, b, 10, 10);
                    }
                }
            } while (numberOfBalls < 40);
        }
        private void drawBalls_Click(object sender, EventArgs e)
        {
            drawBallsMethod();
            isBalls = true;
        }

        /////////Lights
        private void drawLightsMethod()
        {
            Graphics g = Panel.CreateGraphics();
            /////////////////////////////////////////////////////////////
            g.DrawLine(Pens.Black, 143, 63, 153, 71);
            g.DrawLine(Pens.Black, 153, 71, 163, 78);
            g.DrawLine(Pens.Black, 163, 78, 174, 85);
            g.DrawLine(Pens.Black, 174, 85, 186, 92);
            g.DrawLine(Pens.Black, 186, 92, 196, 97);
            g.DrawLine(Pens.Black, 196, 97, 209, 102);
            g.FillEllipse(Brushes.Yellow, 140, 60, 6, 6);
            g.FillEllipse(Brushes.Yellow, 150, 68, 6, 6);
            g.FillEllipse(Brushes.Yellow, 160, 75, 6, 6);
            g.FillEllipse(Brushes.Yellow, 171, 82, 6, 6);
            g.FillEllipse(Brushes.Yellow, 183, 89, 6, 6);
            g.FillEllipse(Brushes.Yellow, 193, 94, 6, 6);
            g.FillEllipse(Brushes.Yellow, 206, 99, 6, 6);
            /////////////////////////////////////////////////////////////
            g.DrawLine(Pens.Black, 143, 113, 153, 121);
            g.DrawLine(Pens.Black, 153, 121, 163, 128);
            g.DrawLine(Pens.Black, 163, 128, 174, 135);
            g.DrawLine(Pens.Black, 174, 135, 186, 142);
            g.DrawLine(Pens.Black, 186, 142, 196, 148);
            g.DrawLine(Pens.Black, 196, 148, 207, 154);
            g.DrawLine(Pens.Black, 207, 154, 220, 160);
            g.DrawLine(Pens.Black, 220, 160, 230, 162);
            g.FillEllipse(Brushes.Yellow, 140, 110, 6, 6);
            g.FillEllipse(Brushes.Yellow, 150, 118, 6, 6);
            g.FillEllipse(Brushes.Yellow, 160, 125, 6, 6);
            g.FillEllipse(Brushes.Yellow, 171, 132, 6, 6);
            g.FillEllipse(Brushes.Yellow, 183, 139, 6, 6);
            g.FillEllipse(Brushes.Yellow, 193, 145, 6, 6);
            g.FillEllipse(Brushes.Yellow, 204, 151, 6, 6);
            g.FillEllipse(Brushes.Yellow, 217, 157, 6, 6);
            /////////////////////////////////////////////////////////////
            g.DrawLine(Pens.Black, 120, 183, 125, 185);
            g.DrawLine(Pens.Black, 125, 185, 136, 191);
            g.DrawLine(Pens.Black, 136, 191, 147, 196);
            g.DrawLine(Pens.Black, 147, 196, 158, 202);
            g.DrawLine(Pens.Black, 158, 202, 170, 208);
            g.DrawLine(Pens.Black, 170, 208, 182, 212);
            g.DrawLine(Pens.Black, 182, 212, 194, 218);
            g.DrawLine(Pens.Black, 194, 218, 206, 222);
            g.DrawLine(Pens.Black, 206, 222, 219, 227);
            g.DrawLine(Pens.Black, 219, 227, 227, 228);
            g.FillEllipse(Brushes.Yellow, 122, 182, 6, 6);
            g.FillEllipse(Brushes.Yellow, 133, 188, 6, 6);
            g.FillEllipse(Brushes.Yellow, 144, 193, 6, 6);
            g.FillEllipse(Brushes.Yellow, 155, 199, 6, 6);
            g.FillEllipse(Brushes.Yellow, 167, 205, 6, 6);
            g.FillEllipse(Brushes.Yellow, 179, 210, 6, 6);
            g.FillEllipse(Brushes.Yellow, 191, 215, 6, 6);
            g.FillEllipse(Brushes.Yellow, 203, 219, 6, 6);
            g.FillEllipse(Brushes.Yellow, 216, 223, 6, 6);
        }
        private void drawLights_Click(object sender, EventArgs e)
        {
            isLights = true;
            lightTimer.Enabled = true;
            drawLightsMethod();
        }

        /////////Lights
        private void drawGarlandMethod()
        {
            Graphics g = Panel.CreateGraphics();
            Point[] p1 = new Point[9];
            p1[0].X = 217;
            p1[0].Y = 55;
            p1[1].X = 202;
            p1[1].Y = 75;
            p1[2].X = 173;
            p1[2].Y = 95;
            p1[3].X = 153;
            p1[3].Y = 100;
            p1[4].X = 145;
            p1[4].Y = 100;
            p1[5].X = 150;
            p1[5].Y = 95;
            p1[6].X = 170;
            p1[6].Y = 90;
            p1[7].X = 192;
            p1[7].Y = 75;
            p1[8].X = 211;
            p1[8].Y = 51;
            g.FillPolygon(Brushes.Plum, p1);
            Point[] p2 = new Point[8];
            p2[0].X = 230;
            p2[0].Y = 120;
            p2[1].X = 223;
            p2[1].Y = 114;
            p2[2].X = 190;
            p2[2].Y = 135;
            p2[3].X = 145;
            p2[3].Y = 154;
            p2[4].X = 125;
            p2[4].Y = 164;
            p2[5].X = 135;
            p2[5].Y = 164;
            p2[6].X = 170;
            p2[6].Y = 152;
            p2[7].X = 190;
            p2[7].Y = 144;
            g.FillPolygon(Brushes.RoyalBlue, p2);
            Point[] p3 = new Point[8];
            p3[0].X = 246;
            p3[0].Y = 186;
            p3[1].X = 239;
            p3[1].Y = 180;
            p3[2].X = 190;
            p3[2].Y = 205;
            p3[3].X = 160;
            p3[3].Y = 215;
            p3[4].X = 100;
            p3[4].Y = 230;
            p3[5].X = 125;
            p3[5].Y = 230;
            p3[6].X = 160;
            p3[6].Y = 223;
            p3[6].X = 185;
            p3[6].Y = 215;
            p3[7].X = 210;
            p3[7].Y = 205;
            g.FillPolygon(Brushes.Gold, p3);
        }
        private void drawGarland_Click(object sender, EventArgs e)
        {
            drawGarlandMethod();
            isGarland = true;
        }
    }
}
