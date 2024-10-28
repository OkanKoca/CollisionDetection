using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_2._1
{
    public partial class DotSphereCollision : Form
    {
        Sphere dot = new Sphere();
        Sphere sphere = new Sphere();
        Rectangle r;
        public DotSphereCollision()
        {
            InitializeComponent();
            this.Paint += DotSphereCollision_Paint;
            this.MouseMove += DotSphereCollision_MouseMove;
        }

        private void DotSphereCollision_Load(object sender, EventArgs e)
        {
            dot.M.X = 100;
            dot.M.Y = 100;
            dot.R = 3;
            sphere.M.X = 200;
            sphere.M.Y = 200;
            sphere.R = 64;
        }
        private void DotSphereCollision_MouseMove(object sender, MouseEventArgs e)
        {
            dot.M.X = e.X;
            dot.M.Y = e.Y;
            Collision.sphereCollision(dot, sphere);
            Invalidate();
        }
        private void DotSphereCollision_Paint(object sender,PaintEventArgs e)
        {
            e.Graphics.FillEllipse(Brushes.Orange, dot.M.X - dot.R, dot.M.Y - dot.R, 2 * dot.R, 2 * dot.R);

            GraphicsPath gPath = new GraphicsPath();
            r = new Rectangle(sphere.M.x - sphere.R, sphere.M.y - sphere.R, sphere.R * 2, sphere.R * 2);
            gPath.AddEllipse(r);

            PathGradientBrush gradientBrush = new PathGradientBrush(gPath);
            gradientBrush.CenterPoint = new PointF(sphere.M.x, sphere.M.y);
            gradientBrush.CenterColor = Color.White;
            gradientBrush.SurroundColors = new Color[] { Color.Purple };

            e.Graphics.FillPath(gradientBrush, gPath);

            gPath.Dispose();
        }
    }
}
