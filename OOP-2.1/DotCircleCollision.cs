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
    public partial class DotCircleCollision : Form
    {
        Rectangle circ1;
        Rectangle circ2;
        Circle c1 = new Circle();
        Circle c2 = new Circle();
        public DotCircleCollision()
        {
            InitializeComponent();
            this.Paint += DotCircleCollision_Paint;
            this.MouseMove += DotCircleCollision_MouseMove;
        }

        private void DotCircleCollision_Load(object sender, EventArgs e)
        {
            c1.M.X = 200;
            c1.M.Y = 200;
            c1.R = 56;
            c2.M.X = 100;
            c2.M.Y = 100;
            c2.R = 3;
            circ1 = new Rectangle(c1.M.X, c1.M.Y, c1.R * 2, c1.R * 2);
            circ2 = new Rectangle(c2.M.X, c2.M.Y, c2.R * 2, c2.R * 2);

        }
        private void DotCircleCollision_MouseMove(object sender, MouseEventArgs e) 
        {
            c2.M.X = e.X;
            c2.M.Y = e.Y;
            circ2.X = c2.M.X - c2.R;
            circ2.Y = c2.M.Y - c2.R;
            Collision.circleCollision(c1, c2);
            Invalidate();
        }
        private void DotCircleCollision_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.Purple, 8);
            e.Graphics.DrawEllipse(pen, c1.M.X - c1.R, c1.M.Y - c1.R, 2 * c1.R, 2 * c1.R);

            e.Graphics.FillEllipse(Brushes.Orange, c2.M.X - c2.R, c2.M.Y - c2.R, 2 * c2.R, 2 * c2.R);
        }

    }
}
