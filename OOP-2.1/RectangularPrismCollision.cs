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
    public partial class RectangularPrismCollision : Form
    {
        point p = new point();
        point p2 = new point();
        public RectangularPrismCollision()
        {
            InitializeComponent();
            this.Paint += RectangularPrismCollision_Paint;
            this.MouseMove += RectangularPrismCollision_MouseMove;
        }

        private void RectangularPrismCollision_Load(object sender, EventArgs e)
        {

        }
        private void RectangularPrismCollision_MouseMove(object sender, MouseEventArgs e)
        {
            p2.x = e.X;
            p2.y = e.Y;
            Collision.rectangleCollision(new rectangle(p, 75, 150), new rectangle(p2, 75, 150));
            Invalidate();
        }
        private void RectangularPrismCollision_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            float width = 75.0f;
            float height = 150.0f;
            float depth = 25.0f;



            p.x = 150;
            p.y = 175   ;

            GraphicsPath gPath = new GraphicsPath();
            gPath.AddPolygon(new PointF[]
            {
                new PointF(p.x, p.y),
                new PointF(p.x+ width, p.y),
                new PointF(p.x+width+depth, p.y+depth),
                new PointF(p.x+depth, p.y+depth)
            });
            gPath.CloseFigure();
            gPath.AddPolygon(new PointF[]
            {
                new PointF(p.x, p.y),
                new PointF(p.x+ depth, p.y+ depth),
                new PointF(p.x+depth, p.y+depth+ height),
                new PointF(p.x, p.y+height)
            });
            gPath.CloseFigure();
            gPath.AddPolygon(new PointF[]
            {
                new PointF(p.x + depth, p.y + height + depth),
                new PointF(p.x+ width + depth, p.y+ depth + height),
                new PointF(p.x+width, p.y+ height),
                new PointF(p.x, p.y+height)
            });
            gPath.CloseFigure();
            gPath.AddPolygon(new PointF[]
            {
                new PointF(p.x + width, p.y),
                new PointF(p.x+ width + depth, p.y+ depth),
                new PointF(p.x+width+depth, p.y+ height+ depth),
                new PointF(p.x+width, p.y+height)
            });
            gPath.CloseFigure();
            //g.FillPath(Brushes.Purple, gPath);

            g.DrawPath(Pens.White, gPath);



            GraphicsPath gPath2 = new GraphicsPath();
            gPath.AddPolygon(new PointF[]
            {
                new PointF(p2.x, p2.y),
                new PointF(p2.x+ width, p2.y),
                new PointF(p2.x+width+depth, p2.y+depth),
                new PointF(p2.x+depth, p2.y+depth)
            });
            gPath.CloseFigure();
            gPath.AddPolygon(new PointF[]
            {
                new PointF(p2.x, p2.y),
                new PointF(p2.x+ depth, p2.y+ depth),
                new PointF(p2.x+depth, p2.y+depth+ height),
                new PointF(p2.x, p2.y+height)
            });
            gPath.CloseFigure();
            gPath.AddPolygon(new PointF[]
            {
                new PointF(p2.x + depth, p2.y + height + depth),
                new PointF(p2.x+ width + depth, p2.y+ depth + height),
                new PointF(p2.x+width, p2.y+ height),
                new PointF(p2.x, p2.y+height)
            });
            gPath.CloseFigure();
            gPath.AddPolygon(new PointF[]
            {
                new PointF(p2.x + width, p2.y),
                new PointF(p2.x+ width + depth, p2.y+ depth),
                new PointF(p2.x+width+depth, p2.y+ height+ depth),
                new PointF(p2.x+width, p2.y+height)
            });
            gPath.CloseFigure();
            //g.FillPath(Brushes.Purple, gPath);

            g.DrawPath(Pens.White, gPath);




        }
    }
}
