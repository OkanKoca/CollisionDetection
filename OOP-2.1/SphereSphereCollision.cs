using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_2._1
{
    public partial class SphereSphereCollision : Form
    {
        Sphere s1 = new Sphere();
        Sphere s2 = new Sphere();
        Rectangle r1;
        Rectangle r2;
        public SphereSphereCollision()
        {
            InitializeComponent();
            this.Paint += SphereSphereCollision_Paint;
            this.MouseMove += SphereSphereCollision_MouseMove;
        }

        private void SphereSphereCollision_Load(object sender, EventArgs e)
        {
            s1.M.X = 200;
            s1.M.Y = 150;
            s1.R = 30;
            s2.M.X = 250;
            s2.M.Y = 200;
            s2.R = 45;
        }
        private void SphereSphereCollision_MouseMove(object sender, MouseEventArgs e)
        {
            s1.M.X = e.X;
            s1.M.Y = e.Y;
            r1.X = s1.M.X - s1.R;
            r1.Y = s1.M.Y - s1.R;
            Collision.sphereCollision(s1, s2);
            Invalidate();
        }
        private void SphereSphereCollision_Paint(object sender, PaintEventArgs e)
        {
            GraphicsPath gPath = new GraphicsPath();
            r1 = new Rectangle(s1.M.x - s1.R, s1.M.y - s1.R, s1.R * 2, s1.R * 2);
            gPath.AddEllipse(r1);

            PathGradientBrush gradientBrush = new PathGradientBrush(gPath);
            gradientBrush.CenterPoint = new PointF(s1.M.x, s1.M.y);
            gradientBrush.CenterColor = Color.White;
            gradientBrush.SurroundColors = new Color[] { Color.Green };

            e.Graphics.FillPath(gradientBrush, gPath);

            GraphicsPath gPath2 = new GraphicsPath();
            r2 = new Rectangle(s2.M.x - s2.R, s2.M.y - s2.R, s2.R * 2, s2.R * 2);
            gPath2.AddEllipse(r2);

            PathGradientBrush gradientBrush2 = new PathGradientBrush(gPath2);
            gradientBrush2.CenterPoint = new PointF(s2.M.x, s2.M.y);
            gradientBrush2.CenterColor = Color.White;
            gradientBrush2.SurroundColors = new Color[] { Color.Purple };

            e.Graphics.FillPath(gradientBrush2, gPath2);

            gPath.Dispose();
        }
    }
}
