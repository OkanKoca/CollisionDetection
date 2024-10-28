using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_2._1
{
    internal class rectangle
    {
        point m; int en; int boy;
        public rectangle()
        {
            M = new point(); 
            En = 0; Boy = 0;
        }
        public rectangle(point p, int en, int boy)
        { M = p; En = en; Boy = boy; }
        public point M { get => m; set => m = value; }
        public int En { get => en; set => en = value; }
        public int Boy { get => boy; set => boy = value; }

    }
}
