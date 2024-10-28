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
    public partial class DotRectangleCollision : Form
    {
        Form1 form = new Form1();
        Rectangle rect1;
        Rectangle rect2;
        rectangle rectangle = new rectangle();
        Circle circle = new Circle();

        public DotRectangleCollision()
        {
            InitializeComponent();
            this.Paint += DotRectangleCollision_Paint;
            this.MouseMove += DotRectangleCollision_MouseMove;
        }

        private void DotRectangleCollision_Load(object sender, EventArgs e)
        {
            circle.M.x = 200;
            circle.M.y = 250;
            circle.R = 2;
            rectangle.M.X = 200;
            rectangle.M.Y = 150;
            rectangle.En = 150;
            rectangle.Boy = 75;
            rect2 = new Rectangle(circle.M.x - circle.R, circle.M.y - circle.R, circle.R * 2, circle.R * 2);
            rect1 = new Rectangle(rectangle.M.X, rectangle.M.Y, rectangle.En, rectangle.Boy);
            
        }

        private void DotRectangleCollision_MouseMove(object sender, MouseEventArgs e)
        {
            circle.M.x = e.X;
            circle.M.y = e.Y;
            rect2 = new Rectangle(circle.M.x - circle.R, circle.M.y - circle.R, circle.R * 2, circle.R * 2);
            Collision.circleRectangleCollision(circle, rectangle);
            Invalidate();
        }

        private void DotRectangleCollision_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(Brushes.Purple, rect1);
            e.Graphics.FillEllipse(Brushes.Orange, rect2);
        }

    }
}
