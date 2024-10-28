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
    public partial class DotRectangularPrismCol : Form
    {
        point p = new point();
        point p2 = new point();
        public DotRectangularPrismCol()
        {
            InitializeComponent();
            this.Paint += DotRectangularPrismCol_Paint;
            this.MouseMove += DotRectangularPrismCol_MouseMove;
        }

        private void DotRectangularPrismCol_Load(object sender, EventArgs e)
        {

        }
        private void DotRectangularPrismCol_MouseMove(object sender, MouseEventArgs e)
        {
            p2.x = e.X;
            p2.y = e.Y;
            Collision.rectangleCollision(new rectangle(p, 75, 150), new rectangle(p2, 3, 3));
            Invalidate();
        }
        private void DotRectangularPrismCol_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            float width = 75.0f;
            float height = 150.0f;
            float depth = 25.0f;

            float w2 = 3.0f;
            float h2 = 3.0f;
            float d2 = 3.0f;



            p.x = 150;
            p.y = 175;

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
                new PointF(p2.x+ w2, p2.y),
                new PointF(p2.x+w2+d2, p2.y+d2),
                new PointF(p2.x+d2, p2.y+d2)
            });
            gPath.CloseFigure();
            gPath.AddPolygon(new PointF[]
            {
                new PointF(p2.x, p2.y),
                new PointF(p2.x+ d2, p2.y+ d2),
                new PointF(p2.x+d2, p2.y+d2+ h2),
                new PointF(p2.x, p2.y+h2)
            });
            gPath.CloseFigure();
            gPath.AddPolygon(new PointF[]
            {
                new PointF(p2.x + d2, p2.y + h2 + d2),
                new PointF(p2.x+ w2 + d2, p2.y+ d2 + h2),
                new PointF(p2.x+w2, p2.y+ h2),
                new PointF(p2.x, p2.y+h2)
            });
            gPath.CloseFigure();
            gPath.AddPolygon(new PointF[]
            {
                new PointF(p2.x + w2, p2.y),
                new PointF(p2.x+ w2 + d2, p2.y+ d2),
                new PointF(p2.x+w2+d2, p2.y+ h2+ d2),
                new PointF(p2.x+w2, p2.y+h2)
            });
            gPath.CloseFigure();
            //g.FillPath(Brushes.Purple, gPath);

            g.DrawPath(Pens.Orange, gPath);




        }
    }
}
