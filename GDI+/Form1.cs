using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GDI_
{
    public partial class Form1 : Form
    {
        Brush p = new SolidBrush(Color.Blue);
        Brush pp = new SolidBrush(Color.Black);
        Brush b = new SolidBrush(Color.White);
        //Pen pen = new Pen(Color.Orange, (float)2.0);
        Brush pen = new SolidBrush(Color.Orange);
        Brush penn = new SolidBrush(Color.Blue);
        Brush pe = new SolidBrush(Color.Red);
        Brush pee = new SolidBrush(Color.Green);

        // Point point1 = new Point(50, 50);
        //Point point2 = new Point(100, 25);
        //Point point3 = new Point(200, 5);
        //Point point4 = new Point(250, 50);
        //Point point5 = new Point(300, 100);
        //Point point6 = new Point(350, 200);
        //Point point7 = new Point(250, 250);
        List<Point> curvePoints = new List<Point>();
        List<Point> Arrow = new List<Point>();
        List<Point> Asteroids = new List<Point>();
        List<Point> Bullet = new List<Point>();

        float x1 = 10;
        float y1 = 10;
        float x2 = 648;
        float y2 = 300;

        float xx1 = 0;
        float yy1 = 0;
        float xx2 = 668;
        float yy2 = 330;

        public Form1()
        {
            InitializeComponent();

            curvePoints.Add(new Point(50, 170));
            curvePoints.Add(new Point(100, 140));
            curvePoints.Add(new Point(150, 170));
            curvePoints.Add(new Point(150, 200));
            curvePoints.Add(new Point(100, 230));
            curvePoints.Add(new Point(50, 200));

            Arrow.Add(new Point(100, 150));
            Arrow.Add(new Point(110, 160));
            Arrow.Add(new Point(105, 160));
            Arrow.Add(new Point(105, 210));
            Arrow.Add(new Point(95, 210));
            Arrow.Add(new Point(95, 160));
            Arrow.Add(new Point(90, 160));

            Asteroids.Add(new Point(320, 100));
            Asteroids.Add(new Point(330, 120));
            Asteroids.Add(new Point(350, 123));
            Asteroids.Add(new Point(335, 133));
            Asteroids.Add(new Point(340, 153));
            Asteroids.Add(new Point(320, 140));
            Asteroids.Add(new Point(300, 153));
            Asteroids.Add(new Point(305, 133));
            Asteroids.Add(new Point(290, 123));
            Asteroids.Add(new Point(310, 120));

            Bullet.Add(new Point(100, 110));
            Bullet.Add(new Point(105, 120));
            Bullet.Add(new Point(115, 125));
            Bullet.Add(new Point(105, 130));
            Bullet.Add(new Point(100, 140));
            Bullet.Add(new Point(95, 130));
            Bullet.Add(new Point(85, 125));
            Bullet.Add(new Point(95, 120));
            // curvePoints.Add(new Point(250, 250));
        }

        private void paint(object sender, PaintEventArgs e)
        {
            e.Graphics.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias; e.Graphics.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            e.Graphics.FillRectangle(pp, xx1, yy1, xx2, yy2);
            e.Graphics.FillRectangle(p,x1,y1,x2,y2);
            e.Graphics.FillEllipse(b, 50, 50, 25 , 25);
            e.Graphics.FillEllipse(b, 150, 60, 25, 25);
            e.Graphics.FillEllipse(b, 300, 210, 25, 25);
            e.Graphics.FillEllipse(b, 515, 120, 25, 25);
            e.Graphics.FillEllipse(b, 420, 75, 25, 25);
            e.Graphics.FillPolygon(pen, curvePoints.ToArray());
            e.Graphics.FillPolygon(penn, Arrow.ToArray());
            e.Graphics.FillPolygon(pe, Asteroids.ToArray());
            e.Graphics.FillPolygon(pee, Bullet.ToArray());
        }
    }
}
