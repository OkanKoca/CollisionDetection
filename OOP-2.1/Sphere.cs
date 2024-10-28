using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_2._1
{
    internal class Sphere
    {
        point3d m; int r;
        public Sphere()
        {
            M = new point3d();
            R = 0;
        }
        public Sphere(point3d m, int r)
        {
            M = m ; R = r;
        }
        public int R { get => r; set => r = value; }
        public point3d M { get => m; set => m = value; }
    }
}
