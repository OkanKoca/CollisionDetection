using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_2._1
{
    internal static class Collision
    {
        public static void circleCollision(Circle c1, Circle c2)
        {
            float d = (float)Math.Sqrt(Math.Pow((c1.M.X - c2.M.X), 2) + Math.Pow((c1.M.Y - c2.M.Y), 2));
            if (d < c1.R + c2.R)
                MessageBox.Show("Collision Happened!", "Collision");
        }

        public static void sphereCollision(Sphere s1, Sphere s2)
        {
            float d = (float)Math.Sqrt(Math.Pow((s1.M.X - s2.M.X), 2) +
                Math.Pow((s1.M.Y - s2.M.Y), 2) + Math.Pow((s1.M.Z - s2.M.Z), 2));
            if ((s1.R + s2.R) > (int)d)
                MessageBox.Show("Collision Happened!", "Collision");
        }
        public static void rectangleCollision(rectangle r1, rectangle r2)
        {
            int Xa = r1.M.X + r1.En / 2;
            int Ya = r1.M.Y + r1.Boy / 2;
            int Xb = r2.M.X + r2.En / 2;
            int Yb = r2.M.Y + r2.Boy / 2;

            if (Math.Abs(Xa - Xb) < (r1.En / 2 + r2.En / 2) && Math.Abs(Ya - Yb) < (r1.Boy / 2 + r2.Boy / 2))
                MessageBox.Show("Collision Happened!", "Collision");
        }
        public static void cylinderCollision(Cylender k1, Cylender k2)
        {
            point3d pa = new point3d(k1.M.X, k1.M.Y + k1.H / 2, k1.M.Z);
            point3d pb = new point3d(k2.M.X, k2.M.Y + k2.H / 2, k2.M.Z);
            float d = (float)Math.Sqrt(Math.Pow((pa.X - pb.X), 2) +
                Math.Pow((pa.Y - pb.Y), 2) + Math.Pow((pa.Z - pb.Z), 2));
            //Console.WriteLine(d);
            if ((k1.R + k2.R) > (int)d && Math.Abs(pa.Y - pb.Y) < ((k1.H + k2.H) / 2))
                MessageBox.Show("Collision Happened!", "Collision");
        }
        public static void circleRectangleCollision(Circle c, rectangle r)
        {
            Rectangle rect = new Rectangle(r.M.X, r.M.Y, r.En, r.Boy);
            float closestX = Math.Max(r.M.X, Math.Min(c.M.X, r.M.X + r.En));
            float closestY = Math.Max(r.M.Y, Math.Min(c.M.Y, r.M.Y + r.Boy));
            float distanceX = c.M.X - closestX;
            float distanceY = c.M.Y - closestY;
            float distanceSquared = (distanceX * distanceX) + (distanceY * distanceY);
            if (distanceSquared < (c.R * c.R))
            {
                MessageBox.Show("Collision happened!", "Collision");
            }



        }




    }
}
