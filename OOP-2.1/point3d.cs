using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace OOP_2._1
{
    internal class point3d : point
    {
        int z;

        public point3d() : base()
        { z = 0; }
        public point3d(int x, int y, int z)
        {
            Z = z;
        }
        public int Z { get => z; set => z = value; }
    }
}
