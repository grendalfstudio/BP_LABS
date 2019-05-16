using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        private Graphics graphics;
        private delegate void CollisionHandler();
        event CollisionHandler Collision;
        private float firstAngle;
        private float secondAngle;
        private Trapezoid trapezoid1;
        private Trapezoid trapezoid2;
        private United newFigure;
        private int counter;

        public FormMain()
        {
            InitializeComponent();
            g = pictureBoxMain.CreateGraphics();
            graphics = pictureBoxDeserialized.CreateGraphics();
            timer = new Timer();
            timer.Interval = 25;
            timer.Tick += Timer_Tick;
        }

        private void CollisionAlert()
        {
            labelColl.ForeColor = Color.Red;
        }

        private void ButtonStart_Click(object sender, EventArgs e)
        {
            /// Initialization
            firstAngle = float.Parse(textBoxFirstTrapezoid.Text);
            secondAngle = float.Parse(textBoxSecondTrapezoid.Text);
            trapezoid1 = new Trapezoid(g, 50, 150, firstAngle);
            trapezoid2 = new Trapezoid(g, 500, 150, secondAngle);
            newFigure = null;
            int progressMax = 0;

            /// Serializing the trapezoids
            IFormatter formatter = new BinaryFormatter();
            Stream stream1 = new FileStream("Trapezoid1.bin", FileMode.Create, FileAccess.Write, FileShare.None);
            formatter.Serialize(stream1, trapezoid1);
            stream1.Close();
            Stream stream2 = new FileStream("Trapezoid2.bin", FileMode.Create, FileAccess.Write, FileShare.None);
            formatter.Serialize(stream2, trapezoid2);
            stream2.Close();

            Collision += CollisionAlert;
            progressColl.Minimum = (int)trapezoid1.MaxRight();
            progressMax = Convert.ToInt32((trapezoid2.MaxLeft() - trapezoid1.MaxRight())/2 + trapezoid1.MaxRight());
            progressColl.Maximum = progressMax;
            ///Main actions
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (trapezoid1.MaxRight() - trapezoid2.MaxLeft() >= 0)      /// If figures got into collision
            {
                if (Collision != null)
                {
                    Collision();
                }
                if(newFigure == null)              /// First tick when figure got into collision
                {
                    progressColl.Value = progressColl.Maximum;
                    /// Rotation of trapezoid2
                    Matrix matrix = new Matrix();
                    matrix.RotateAt(-(180 - firstAngle - secondAngle), trapezoid2.points[0]);
                    matrix.TransformPoints(trapezoid2.points);
                    matrix.Reset();
                    /// Moving of trapezoid2 to unite them both
                    matrix.Translate(trapezoid1.points[3].X - trapezoid2.points[0].X, trapezoid1.points[0].Y - trapezoid2.points[0].Y);
                    matrix.TransformPoints(trapezoid2.points);
                    matrix.Reset();

                    /// Serializing the NewFigure
                    newFigure = new United(g, trapezoid1.points, trapezoid2.points);
                    IFormatter formatter = new BinaryFormatter();
                    Stream stream = new FileStream("NewFigure.bin", FileMode.Create, FileAccess.Write, FileShare.None);
                    formatter.Serialize(stream, newFigure);
                    stream.Close();
                    /// Deserializing the figures
                    /// Trapezoid1
                    Stream streamTrapezoid1 = new FileStream("Trapezoid1.bin", FileMode.Open, FileAccess.Read, FileShare.None);
                    Trapezoid figure1 = (Trapezoid)formatter.Deserialize(streamTrapezoid1);
                    streamTrapezoid1.Close();

                    matrix.Translate(0, -150);
                    matrix.TransformPoints(figure1.points);
                    matrix.Reset();
                    figure1.g = graphics;
                    figure1.pen = new Pen(Color.Red, 2);
                    figure1.Draw();
                    /// Trapezoid2
                    Stream streamTrapezoid2 = new FileStream("Trapezoid2.bin", FileMode.Open, FileAccess.Read, FileShare.None);
                    Trapezoid figure2 = (Trapezoid)formatter.Deserialize(streamTrapezoid2);
                    streamTrapezoid2.Close();

                    matrix.Translate(-450, -95);
                    matrix.TransformPoints(figure2.points);
                    matrix.Reset();
                    figure2.g = graphics;
                    figure2.pen = new Pen(Color.Red, 2);
                    figure2.Draw();

                    /// FigureNew
                    Stream streamNewFigure = new FileStream("NewFigure.bin", FileMode.Open, FileAccess.Read, FileShare.None);
                    United figureNew = (United)formatter.Deserialize(streamNewFigure);
                    streamNewFigure.Close();

                    matrix.Translate(-50, 50);
                    matrix.TransformPoints(figureNew.points);
                    matrix.Reset();
                    figureNew.g = graphics;
                    figureNew.pen = new Pen(Color.Red, 2);
                    figureNew.Draw();
                }
                g.Clear(FormMain.DefaultBackColor);
                /// Rotation of newFigure
                Matrix m = new Matrix();
                m.RotateAt(5, newFigure.points[2]);
                m.TransformPoints(newFigure.points);

                newFigure.Draw();
            }
            else
            {       /// Moving of trapezoids to the center
                g.Clear(FormMain.DefaultBackColor);

                progressColl.Value = (int)trapezoid1.MaxRight();
                trapezoid1.Move(2, 0);
                trapezoid1.Scale(1.01F);

                trapezoid2.Move(-2, 0);
                trapezoid2.Scale(1.01F);

                trapezoid1.Draw();
                trapezoid2.Draw();
            }
        }
    }
    [Serializable]
    class Trapezoid
    {
        private const int R = 50;

        [NonSerialized]
        public Pen pen;
        [NonSerialized]
        public Graphics g;
        public PointF[] points;
        public Trapezoid(Graphics graphics, int x, int y, float angle)
        {
            g = graphics;
            pen = new Pen(Color.Red, 2);

            float angleD = angle * (float)Math.PI / 180; 
            points = new PointF[4];
            points[1] = new PointF(x, y);
            points[2] = new PointF(x + R, y);
            points[3] = new PointF(points[2].X + (float)Math.Cos(angleD) * R, points[2].Y + (float)Math.Sin(angleD) * R);
            points[0] = new PointF(points[1].X - (float)Math.Cos(angleD) * R, points[1].Y + (float)Math.Sin(angleD) * R);
        }
        public void Draw()
        {
            g.DrawPolygon(pen, points);
        }
        public void Move(int offsetX, int offsetY)
        {
            Matrix m = new Matrix();
            m.Translate(offsetX, offsetY);
            m.TransformPoints(points);
        }
        public void Scale(float ratio)
        {
            float xCenter = (points[1].X + points[2].X) / 2;
            float yCenter = (points[0].Y + points[1].Y) / 2;
            points[0].X = xCenter - Math.Abs(xCenter - points[0].X) * ratio;
            points[0].Y = yCenter + Math.Abs(yCenter - points[0].Y) * ratio;

            points[1].X = xCenter - Math.Abs(xCenter - points[2].X) * ratio;
            points[1].Y = yCenter - Math.Abs(yCenter - points[1].Y) * ratio;

            points[2].X = xCenter + Math.Abs(xCenter - points[2].X) * ratio;
            points[2].Y = yCenter - Math.Abs(yCenter - points[2].Y) * ratio;

            points[3].X = xCenter + Math.Abs(xCenter - points[3].X) * ratio;
            points[3].Y = yCenter + Math.Abs(yCenter - points[3].Y) * ratio;
        }
        public float MaxRight()
        {
            float maxRight = points[0].X;
            maxRight = Math.Max(maxRight, points[1].X);
            maxRight = Math.Max(maxRight, points[2].X);
            maxRight = Math.Max(maxRight, points[3].X);
            return maxRight;
        }
        public float MaxLeft()
        {
            float maxLeft = points[0].X;
            maxLeft = Math.Min(maxLeft, points[1].X);
            maxLeft = Math.Min(maxLeft, points[2].X);
            maxLeft = Math.Min(maxLeft, points[3].X);
            return maxLeft;
        }
    }

    [Serializable]
    class United
    {
        private const int R = 50;

        [NonSerialized]
        public Pen pen;
        [NonSerialized]
        public Graphics g;
        public PointF[] points;
        public United(Graphics graphics, PointF[] trapezoid1, PointF[] trapezoid2)
        {
            g = graphics;
            pen = new Pen(Color.Red, 2);

            points = new PointF[6];
            points[0] = trapezoid1[0];
            points[1] = trapezoid1[1];
            points[2] = trapezoid1[2];

            points[3] = trapezoid2[2];
            points[4] = trapezoid2[3];
            points[5] = trapezoid2[0];
        }
        public void Draw()
        {
            g.DrawPolygon(pen, points);
        }
    }
}
