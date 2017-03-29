using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repeat
{
    class Change
    {
        static int a, b, c;
        public Change()
        {
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
        }
        public void ActChange()
        {
            c = a;
            a = b;
            b = c;
        }
        public void ActChange(string str)
        {
            a = a + b;
            b = a - b;
            a = a - b;
        }
    }
}
