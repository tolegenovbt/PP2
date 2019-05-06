using System;
using System.Drawing;
using System.Windows.Forms;

namespace RectangleDrawer
{
    public partial class Form1 : Form
    {
        Point pointStart; //= new Point();
        Point pointFinish; // = new Point();
        Pen pen;
        Graphics gfx;

        bool isStart;

        public Form1()
        {
            InitializeComponent();
            pointStart = new Point();
            pointFinish = new Point();
            isStart = false;
            pen = new Pen(Color.Green, 10);
            gfx = this.CreateGraphics(); // this = this Form
            gfx.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            label1.Text = e.Location.ToString();
            isStart = !isStart; // true => false, false => true

            if (isStart)
            {
                pointStart = e.Location;
            } else
            {
                pointFinish = e.Location;
                Point[] s = RP(pointStart, pointFinish);
                
                gfx.DrawRectangle(pen, s[0].X,s[0].Y, s[1].X-s[0].X, s[1].Y - s[0].Y);
            }
        }
        private Point[] RP(Point p1, Point p2)
        {
            Point[] s = new Point[2];
            s[0] = new Point(Min(p1.X,p2.X), Min(p1.Y, p2.Y));
            s[1] = new Point(Max(p2.X,p1.X), Max(p1.Y, p2.Y));
            return s;
        }
        private int Min(int x, int y)
        {
            if (x > y)
                return y;
            else
                return x;
        }
        private int Max(int x, int y)
        {
            if (x < y)
                return y;
            else
                return x;
        }
       

        private void button1_Click(object sender, EventArgs e)
        {
            SolidBrush solidBrush = new SolidBrush(Color.FromArgb(159, 220, 70));
            gfx.FillEllipse(solidBrush, 20, 20, 100, 150);
            gfx.FillRectangle(solidBrush, 200, 200, 100, 150);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
