using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_2._1
{
    internal class Cylender
    {
        point3d m; int r; int h;
        public Cylender()
        { M = new point3d(); R = 0; H = 0; }
        public Cylender(point3d m, int r, int h)
        {
            M = m ; R = r; H = h;
        }
        public int R { get => r ; set => r = value; }   
        public point3d M { get => m ; set => m = value; }
        public int H { get => h ; set => h = value; }
    }
}
