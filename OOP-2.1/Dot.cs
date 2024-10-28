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
    public partial class Dot : Form
    {
        Rectangle rect;
        point point = new point();
        public Dot()
        {
            InitializeComponent();
            this.Paint += Dot_Paint;
        }

        private void Dot_Load(object sender, EventArgs e)
        {
            
            point.x = 300;
            point.y = 200;
            rect = new Rectangle(point.x, point.y, 10,10);

        }
        private void Dot_Paint(object sender, PaintEventArgs e) 
        {
            e.Graphics.FillEllipse(Brushes.White, rect);
        }
    }
}
