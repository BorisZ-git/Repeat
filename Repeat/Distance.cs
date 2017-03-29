using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repeat
{
    class Distance
    {
        static int x1,x2;
        static int y1,y2;
        public Distance()
        {
            x1 = Convert.ToInt32(Console.ReadLine());
            y1 = Convert.ToInt32(Console.ReadLine());
            x2 = Convert.ToInt32(Console.ReadLine());
            y2 = Convert.ToInt32(Console.ReadLine());
        }
        public double Count()
        {
            double r = Math.Sqrt(Math.Pow(x2 * x1, 2) + Math.Pow(y2 * y1, 2));
            return r;
        }
    }
}
