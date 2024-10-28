using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_2._1
{
    public partial class CircleCircleCollision : Form
    {
        Rectangle circle1;
        Rectangle circle2;
        Circle c1 = new Circle();
        Circle c2 = new Circle();
        public CircleCircleCollision()
        {
            InitializeComponent();
            this.Paint += CircleCircleCollision_Paint;
            this.MouseMove += CircleCircleCollision_MouseMove;
        }

        private void CircleCircleCollision_Load(object sender, EventArgs e)
        {

            c1.R = 32;
            c2.M.X = 200;
            c2.M.Y = 150;
            c2.R = 50;
            circle1 = new Rectangle(c1.M.X, c1.M.Y, c1.R, c1.R);
            circle2 = new Rectangle(c2.M.X, c2.M.Y, c2.R, c2.R);
        }
        private void CircleCircleCollision_MouseMove(object sender , MouseEventArgs e)
        {
            c1.M.X = e.X;
            c1.M.Y = e.Y;
            circle1.X = c1.M.X - c1.R;
            circle1.Y = c1.M.Y - c1.R;
            Collision.circleCollision(c1, c2);
            Invalidate();
        }
        private void CircleCircleCollision_Paint(object sender, PaintEventArgs e)
        {
            Pen orangePen = new Pen(Color.Orange, 4);
            Pen purplePen = new Pen(Color.Purple, 4);

            e.Graphics.DrawEllipse(orangePen, c1.M.X - c1.R, c1.M.Y - c1.R, 2 * c1.R, 2 * c1.R);
            e.Graphics.DrawEllipse(purplePen, c2.M.X - c2.R, c2.M.Y - c2.R, 2 * c2.R, 2 * c2.R);
        }

    }
}
