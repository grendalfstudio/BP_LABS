using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BP_LAB_12
{
    public partial class FormMain : Form
    {
        private Timer timer;
        private Graphics g;
        public FormMain()
        {
            InitializeComponent();
            g = pictureBoxMain.CreateGraphics();
            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
        }

        private void DrawTrapezoid(int x, int y, float angle)
        {
            const int R = 50;
            PointF[] points = new PointF[4];
            Pen pen = new Pen(Color.Red, 2);
            points[1] = new PointF(x, y);
            points[2] = new PointF(x + R, y);
            points[3] = new PointF(points[2].X + (float)Math.Cos(angle) * R, points[2].Y + (float)Math.Sin(angle) * R);
            points[0] = new PointF(points[1].X - (float)Math.Cos(angle) * R, points[1].Y + (float)Math.Sin(angle) * R);
            g.DrawPolygon(pen, points);
        }
        
        private void ButtonStart_Click(object sender, EventArgs e)
        {
            float firstAngle = float.Parse(textBoxFirstTrapezoid.Text);
            float secondAngle = float.Parse(textBoxSecondTrapezoid.Text);
            DrawTrapezoid(50, 150, firstAngle);
            DrawTrapezoid(500, 150, secondAngle);
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {

        }
    }
}
