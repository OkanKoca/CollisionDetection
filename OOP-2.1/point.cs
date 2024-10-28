using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_2._1
{
    internal class point
    {
         public int x;
         public int y;

        public point()
        { X = 0; Y = 0; }
        public point(int X, int Y) { x = X; y = Y; }
        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }

    }
}
