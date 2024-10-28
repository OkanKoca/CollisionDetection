using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static OOP_2._1.Form1;


namespace OOP_2._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void colHappened()
        {
            this.label4.Text = "COLLISION HAPPENED!";
        }
        public void noCol()
        {
            this.label4.Text = "NO COLLISION";
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dot dot = new Dot() { TopLevel = false, TopMost = true };
            dot.FormBorderStyle = FormBorderStyle.None;
            CircleForm circle = new CircleForm() { TopLevel = false, TopMost = true };
            circle.FormBorderStyle = FormBorderStyle.None;
            RectangleForm rect = new RectangleForm { TopLevel = false, TopMost = true };
            rect.FormBorderStyle = FormBorderStyle.None;
            Plane plane = new Plane() { TopLevel = false, TopMost = true };
            plane.FormBorderStyle = FormBorderStyle.None;
            SphereForm sphere = new SphereForm { TopLevel = false, TopMost = true };
            sphere.FormBorderStyle = FormBorderStyle.None;
            RectangularPrism rectPrism = new RectangularPrism() { TopLevel = false, TopMost = true };
            rectPrism.FormBorderStyle = FormBorderStyle.None;
            CylenderForm cylender = new CylenderForm() { TopLevel = false, TopMost = true };
            cylender.FormBorderStyle = FormBorderStyle.None;
            Square square = new Square() { TopLevel = false, TopMost = true };
            square.FormBorderStyle = FormBorderStyle.None;

            if (comboBox1.SelectedIndex == 0)
            {
                panel1.Controls.Add(dot);
                dot.Show();
                dot.BringToFront();
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                panel1.Controls.Add(plane);
                plane.Show();
                plane.BringToFront();
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                panel1.Controls.Add(rect);
                rect.Show();
                rect.BringToFront();
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                panel1.Controls.Add(circle);
                circle.Show();
                circle.BringToFront();
            }
            else if (comboBox1.SelectedIndex == 4)
            {
                panel1.Controls.Add(sphere);
                sphere.Show();
                sphere.BringToFront();
            }
            else if (comboBox1.SelectedIndex == 5)
            {
                panel1.Controls.Add(rectPrism);
                rectPrism.Show();
                rectPrism.BringToFront();
            }
            else if (comboBox1.SelectedIndex == 6)
            {
                panel1.Controls.Add(cylender);
                cylender.Show();
                cylender.BringToFront();
            }
            else if (comboBox1.SelectedIndex == 7)
            {
                panel1.Controls.Add(square);
                square.Show();
                square.BringToFront();
            }

            else
            {
                panel1.Show();
                MessageBox.Show("An object is not selected.");
            }



        }

        private void button2_Click(object sender, EventArgs e)
        {
            DotRectangleCollision dotRectangleCollision = new DotRectangleCollision() { TopLevel = false, TopMost = true };
            dotRectangleCollision.FormBorderStyle = FormBorderStyle.None;
            CircleRectangleCollision circRectangle = new CircleRectangleCollision() { TopLevel = false, TopMost = true };
            circRectangle.FormBorderStyle = FormBorderStyle.None;
            DotCircleCollision dotCircle = new DotCircleCollision() { TopLevel = false, TopMost = true };
            dotCircle.FormBorderStyle = FormBorderStyle.None;
            RectangleRectangleCollision rectRect = new RectangleRectangleCollision() { TopLevel = false, TopMost = true };
            rectRect.FormBorderStyle = FormBorderStyle.None;
            CircleCircleCollision circCirc = new CircleCircleCollision() { TopLevel = false, TopMost = true };
            circCirc.FormBorderStyle = FormBorderStyle.None;
            SphereSphereCollision spSp = new SphereSphereCollision() { TopLevel = false, TopMost = true };
            spSp.FormBorderStyle = FormBorderStyle.None;
            RectangularPrismCollision rectPrismCol = new RectangularPrismCollision() { TopLevel = false, TopMost = true };
            rectPrismCol.FormBorderStyle = FormBorderStyle.None;
            DotSphereCollision dotSphere = new DotSphereCollision() { TopLevel = false, TopMost = true };
            dotSphere.FormBorderStyle = FormBorderStyle.None;
            DotRectangularPrismCol dotRectPrism = new DotRectangularPrismCol() { TopLevel = false, TopMost = true };
            dotRectPrism.FormBorderStyle = FormBorderStyle.None;

            if (comboBox2.SelectedIndex == 0)
            {
                panel1.Controls.Add(dotRectangleCollision);
                dotRectangleCollision.Show();
                dotRectangleCollision.BringToFront();
            }
            else if (comboBox2.SelectedIndex == 1)
            {
                panel1.Controls.Add(circRectangle);
                circRectangle.Show();
                circRectangle.BringToFront();
            }
            else if (comboBox2.SelectedIndex == 2)
            {
                panel1.Controls.Add(dotCircle);
                dotCircle.Show();
                dotCircle.BringToFront();
            }
            else if (comboBox2.SelectedIndex == 3)
            {
                panel1.Controls.Add(rectRect);
                rectRect.Show();
                rectRect.BringToFront();
            }
            else if (comboBox2.SelectedIndex == 4)
            {
                panel1.Controls.Add(circCirc);
                circCirc.Show();
                circCirc.BringToFront();
            }
            else if(comboBox2.SelectedIndex == 5)
            {
                panel1.Controls.Add(spSp);
                spSp.Show();
                spSp.BringToFront();
            }
            else if(comboBox2.SelectedIndex == 6)
            {
                panel1.Controls.Add(rectPrismCol);
                rectPrismCol.Show();
                rectPrismCol.BringToFront();
            }
            else if (comboBox2.SelectedIndex == 7  )
            {
                panel1.Controls.Add(dotSphere);
                dotSphere.Show();
                dotSphere.BringToFront();
            }
            else if (comboBox2.SelectedIndex == 8)
            {
                panel1.Controls.Add(dotRectPrism);
                dotRectPrism.Show();
                dotRectPrism.BringToFront();
            }
            else
            {
                panel1.Show();
                MessageBox.Show("A collision is not selected.");
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
