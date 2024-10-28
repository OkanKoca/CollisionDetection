using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_2._1
{
    internal class Circle
    {
        point m;
        int r;
        public Circle()
        { M = new point(); R = 0; }

        public Circle(point p, int r)
        {
            M = p; R = r;
        }
        public int R {  get => r; set => r = value; }
        internal point M { get => m; set => m = value; }
    }
}
