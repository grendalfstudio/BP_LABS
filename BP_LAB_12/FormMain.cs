using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Drawing.Drawing2D;

namespace BP_LAB_12
{
    public partial class FormMain : Form
    {
        private Timer timer;
        private Graphics g;
        Trapezoid trapezoid1;
        Trapezoid trapezoid2;
        public FormMain()
        {
            InitializeComponent();
            g = pictureBoxMain.CreateGraphics();
            timer = new Timer();
            timer.Interval = 10;
            timer.Tick += Timer_Tick;
        }

        private void ButtonStart_Click(object sender, EventArgs e)
        {
            /// Initialization
            float firstAngle = float.Parse(textBoxFirstTrapezoid.Text);
            float secondAngle = float.Parse(textBoxSecondTrapezoid.Text);
            trapezoid1 = new Trapezoid(g, 50, 150, firstAngle);
            trapezoid2 = new Trapezoid(g, 500, 150, secondAngle);

            ///// Serializing the trapezoids
            //IFormatter formatter = new BinaryFormatter();
            //Stream stream1 = new FileStream("Trapezoid1.bin", FileMode.Create, FileAccess.Write, FileShare.None);
            //formatter.Serialize(stream1, trapezoid1);
            //stream1.Close();
            //Stream stream2 = new FileStream("Trapezoid2.bin", FileMode.Create, FileAccess.Write, FileShare.None);
            //formatter.Serialize(stream2, trapezoid2);
            //stream1.Close();

            ///Main actions
            trapezoid1.Draw();
            trapezoid2.Draw();
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            g.Clear(FormMain.DefaultBackColor);
            trapezoid1.Move(2, 0, 0.999F);
            trapezoid2.Move(-2, 0, 1.001F);
        }
    }
    [Serializable]
    class Trapezoid
    {
        private const int R = 50;
        private Graphics g;
        private PointF[] points;
        private readonly Pen pen;
        public Trapezoid(Graphics graphics, int x, int y, float angle)
        {
            g = graphics;
            pen = new Pen(Color.Red, 2);
            points = new PointF[4];
            points[1] = new PointF(x, y);
            points[2] = new PointF(x + R, y);
            points[3] = new PointF(points[2].X + (float)Math.Cos(angle) * R, points[2].Y + (float)Math.Sin(angle) * R);
            points[0] = new PointF(points[1].X - (float)Math.Cos(angle) * R, points[1].Y + (float)Math.Sin(angle) * R);
        }
        public void Draw()
        {
            g.DrawPolygon(pen, points);
        }
        public void Move(int offsetX, int offsetY, float scale)
        {
            Matrix m = new Matrix();
            m.Translate(offsetX, offsetY);
            m.TransformPoints(points);
            m.Reset();
            m.Scale(scale, scale);
            m.TransformPoints(points);
            g.DrawPolygon(pen, points);
        }
    }
}
