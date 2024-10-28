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
    public partial class CircleForm : Form
    {
        Circle circle = new Circle();
        Rectangle r;
        public CircleForm()
        {
            InitializeComponent();
            this.Paint += CircleForm_Paint;
        }

        private void CircleForm_Load(object sender, EventArgs e)
        {
            circle.M.x = 230;
            circle.M.y = 150;
            circle.R = 100;
            r = new Rectangle(circle.M.x, circle.M.y, circle.R, circle.R);
        }
        private void CircleForm_Paint(object sender, PaintEventArgs e) 
        {
            Pen pen = new Pen(Brushes.White, 4);
            e.Graphics.DrawEllipse(pen, r);
        }
    }
}
