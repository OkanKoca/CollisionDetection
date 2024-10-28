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
    public partial class SphereForm : Form
    {
        Sphere sphere = new Sphere();
        Rectangle r;
        public SphereForm()
        {
            InitializeComponent();
            this.Paint += SphereForm_Paint;
            
        }

        private void SphereForm_Load(object sender, EventArgs e)
        {
            sphere.M.x = 250;
            sphere.M.y = 200;
            sphere.R = 75;
        }
        private void SphereForm_Paint(object sender, PaintEventArgs e)
        {
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
