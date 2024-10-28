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
    public partial class RectangularPrism : Form
    {
        point p = new point();
        public RectangularPrism()
        {
            InitializeComponent();
            this.Paint += RectangularPrism_Paint;
        }

        private void RectangularPrism_Load(object sender, EventArgs e)
        {

        }
        private void RectangularPrism_Paint (object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            float width = 75.0f;
            float height = 150.0f;
            float depth = 25.0f;



            p.x = 150;
            p.y = 150;

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




        }
    }
}
