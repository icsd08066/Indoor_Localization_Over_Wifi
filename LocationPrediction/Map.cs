using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace LocationPrediction
{
    public partial class Map : Form
    {
        Graphics draw_area;
       
        private int Est_x;
        private int Est_y;
      

        public Map(int Est_x, int Est_y)
        {
            // TODO: Complete member initialization
            InitializeComponent();
            draw_area = pictureBox1.CreateGraphics();
            this.Est_x = Est_x;
            this.Est_y = Est_y;
        }
        private void Draw_Estimated_Point()
        {
            int x = Fetch_to_Picture_X();
            int y = Fetch_to_Picture_Y();
            //Console.WriteLine(Est_x+"  ,  "+Est_y);
            Pen WhitewPen = new Pen(Color.LimeGreen);

            Point center = new Point(x, y);
            for (int i = 15; i <= 28; i = i + 3) {

                getCircle(draw_area, WhitewPen, center, i);
                Thread.Sleep(500);

            }

            textBox1.Location = new System.Drawing.Point(x + 35, y - 35);
            textBox1.Text = Est_x + " , " + Est_y; ;
            textBox1.Visible = true;
          
        }

        private void pictureBox1_LoadCompleted(object sender, AsyncCompletedEventArgs e)
        {
           // Draw_Estimated_Point();
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {          
            Draw_Estimated_Point();
            
            //this.textBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            
        }
        private void getCircle(Graphics drawingArea, Pen penToUse, Point center, int radius)
        {
            Rectangle rect = new Rectangle(center.X - radius, center.Y - radius, radius * 2, radius * 2);
            drawingArea.DrawEllipse(penToUse, rect);
        }
        private int Fetch_to_Picture_X() { 
            int EstX =  Est_x;
            if (EstX == -210) {
                return 622;
            }
            else if (EstX == -280)
            {
                return 583;
            }
            else if (EstX == -350)
            {
                return 542;
            }
            else if (EstX == -420)
            {
                return 504;
            }
            else if (EstX == -490)
            {
                return 465;
            }
            else if (EstX == -560)
            {
                return 425;
            }
            else if (EstX == -630)
            {
                return 384;
            }
            else if (EstX == -700)
            {
                return 345;
            }
            else if (EstX == -770)
            {
                return 305;
            }
            else if (EstX == -840)
            {
                return 265;
            }
            else if (EstX == -910)
            {
                return 225;
            }
            else if (EstX == -980)
            {
                return 185;
            }
            else if (EstX == -1050)
            {
                return 145;
            }
            else if (EstX == -1120)
            {
                return 104;
            }
            else if (EstX == -1190)
            {
                return 65;
            }
            else { return 0; }

        }
        private int Fetch_to_Picture_Y()
        {
            int EstY = Est_y;
            if (EstY == 70)
            {
                return 728;
            }
            else if (EstY == 140)
            {
                return 688;
            }else if (EstY == 210)
            {
                return 647;
            }
            else if (EstY == 280)
            {
                return 608;
            }
            else if (EstY == 350)
            {
                return 569;
            }
            else if (EstY == 420)
            {
                return 528;
            }
            else if (EstY == 490)
            {
                return 488;
            }
            else if (EstY == 560)
            {
                return 449;
            }
            else if (EstY == 630)
            {
                return 410;
            }
            else if (EstY == 700)
            {
                return 371;
            }
            else if (EstY == 770)
            {
                return 332;
            }
            else if (EstY == 840)
            {
                return 292;
            }
            else if (EstY == 910)
            {
                return 252;
            }
            else if (EstY == 980)
            {
                return 213;
            }
            else if (EstY == 1050)
            {
                return 172;
            }
            else if (EstY == 1120)
            {
                return 131;
            }
            else if (EstY == 1190)
            {
                return 92;
            }
            else if (EstY == 1260)
            {
                return 53;
            }
            else { return 333; }

        }
    }
}
