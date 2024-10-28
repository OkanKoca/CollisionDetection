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
    public partial class RectangleForm : Form
    {
        rectangle rectangle = new rectangle();
        Rectangle r;
        public RectangleForm()
        {
            InitializeComponent();
            this.Paint += RectangleForm_Paint;
        }

        private void RectangleForm_Load(object sender, EventArgs e)
        {
            rectangle.M.x = 180;
            rectangle.M.y = 150;
            rectangle.En = 250;
            rectangle.Boy = 100;
            r = new Rectangle(rectangle.M.x, rectangle.M.y, rectangle.En, rectangle.Boy);
        }
        private void RectangleForm_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Brushes.White, 4);
            e.Graphics.DrawRectangle(pen, r);
        }
    }
}
