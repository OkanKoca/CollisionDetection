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
    public partial class Plane : Form
    {
        rectangle rect = new rectangle();
        Rectangle r;
        
        public Plane()
        {
            InitializeComponent();
            this.Paint += Plane_Paint;
        }

        private void Plane_Load(object sender, EventArgs e)
        {
            rect.M.X = 225;
            rect.M.Y = 200;
            rect.En = 200;
            rect.Boy = 150;
            r = new Rectangle(rect.M.X, rect.M.Y, rect.En, rect.Boy);
        }
        private void Plane_Paint(object sender, PaintEventArgs e) 
        {
            PointF point1 = new PointF(rect.M.X, rect.M.Y);
            PointF point2 = new PointF(rect.M.X + rect.En, rect.M.Y);
            PointF point3 = new PointF(450,225);
            PointF point4 = new PointF(250,225);
            //PointF point5 = new PointF(250, 150);
            //PointF point6 = new PointF(225, 125);
            //PointF point9 = new PointF(225, 200);
            //PointF point7 = new PointF(250, 225);
            //PointF point8 = new PointF(225, 125);
            //PointF point10 = new PointF(425, 125);
            //PointF point11 = new PointF(450, 150);
            //PointF point12 = new PointF(250, 150);
            //PointF point13 = new PointF(450, 225);
            //PointF point14 = new PointF(450, 150);
            //PointF point15 = new PointF(425, 200);
            //PointF point16 = new PointF(425, 125);



            PointF[] points = new PointF[] { point1, point2, point3, point4 /*point5 ,point6, point9, point7, point8, point10, point11, point12, point13, point14, point15, point16*/ };

            Pen pen = new Pen(Color.White, 2);

            e.Graphics.DrawPolygon(pen, points);
        }
    }
}
