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
    public partial class RectangleRectangleCollision : Form
    {
        Rectangle r1;
        Rectangle r2;
        rectangle rect1 = new rectangle();
        rectangle rect2 = new rectangle();
        public RectangleRectangleCollision()
        {
            InitializeComponent();
            this.MouseMove += RectangleRectangleCollision_MouseMove;
            this.Paint += RectangleRectangleCollision_Paint;
        }

        private void RectangleRectangleCollision_Load(object sender, EventArgs e)
        {
            rect1.M.X = 200;
            rect1.M.Y = 200;
            rect1.En = 100;
            rect1.Boy = 140;
            rect2.En = 50;
            rect2.Boy = 100;
            r1 = new Rectangle(rect1.M.X, rect1.M.Y, rect1.En, rect1.Boy);
            r2 = new Rectangle(rect2.M.X, rect2.M.Y, rect2.En, rect2.Boy);
        }
        private void RectangleRectangleCollision_MouseMove(object sender, MouseEventArgs e)
        {
            
            rect2.M.X = e.X;
            rect2.M.Y = e.Y;
            r2.X = rect2.M.X;
            r2.Y = rect2.M.Y;
            Collision.rectangleCollision(rect1, rect2);
            Invalidate();
        }
        private void RectangleRectangleCollision_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(Brushes.Purple, r1);
            e.Graphics.FillRectangle(Brushes.Orange, r2);
        }
    }
}
