using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{
    class Count
    {
        public int Min(int a, int b, int c)
        {           
            return a < b ?
                a < c ? a : c 
                : b < c ? b : c;
        }
    }
}
