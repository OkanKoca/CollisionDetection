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
    public partial class CylenderForm : Form
    {
        public CylenderForm()
        {
            InitializeComponent();
            this.Paint += CylenderForm_Paint;
        }

        private void CylenderForm_Load(object sender, EventArgs e)
        {

        }
        private void CylenderForm_Paint(object sender, PaintEventArgs e)
        {

            GraphicsPath gPath = new GraphicsPath();
            gPath.AddArc(new Rectangle(212, 112, 100, 35), 180, 180);
            gPath.AddArc(new Rectangle(212, 312, 100, 35), 0, 180);

            GraphicsPath gPath2 = (GraphicsPath)gPath.Clone();
            RectangleF r = gPath2.GetBounds();

            float w = (r.Width + 4) / r.Width;
            float h = (r.Height + 4) / r.Height;
            gPath2.Transform(new Matrix(w, 0, 0, h, -2, -2));

            using (PathGradientBrush pathBrush = new PathGradientBrush(gPath2))
            {
                pathBrush.CenterColor = Color.Pink;
                pathBrush.SurroundColors = new Color[] { Color.Purple };
                pathBrush.FocusScales = new PointF( 0.71F, 0.71f);
                e.Graphics.FillPath(pathBrush, gPath);
            }

            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            using (LinearGradientBrush l = new LinearGradientBrush(new Rectangle(12, 12, 95, 35), Color.Purple, Color.Pink, LinearGradientMode.Vertical))
                {
                    using (Pen pen = new Pen(l, 4)) {
                    e.Graphics.DrawEllipse(pen, new Rectangle(217, 312, 95, 35));
                }
            }
            using (LinearGradientBrush l = new LinearGradientBrush(new Rectangle(217, 112, 95, 35), Color.Purple, Color.Pink, LinearGradientMode.Vertical))
            {
                using (Pen pen = new Pen(l,4))
                {
                    e.Graphics.DrawEllipse(pen, l.Rectangle);
                }
            }
        }
    }
}
