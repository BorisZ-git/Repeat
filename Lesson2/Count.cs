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
        public static int Long(int a)
        {
            int count = 0;
            while(a!=0)
            {
                a /= 10;
                count++;
            }
            return count;            
        }
        public static int Long(int a,string Recursia)
        {
            if (a == 0) return 0;
            else return Long(a / 10)+1;
        }
    }
}
