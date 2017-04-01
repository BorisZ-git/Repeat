using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{
    class Count
    {
        //Math

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
        public int Sum()
        {
            int a;  int sum = 0;
            do
            {
                 int.TryParse(Console.ReadLine(), out a);
                if (Check(a)) sum += a;
            } while (a != 0);             
            return sum;
        }
        public int Sum(string use_continue)
        {
            int a; int sum = 0;
            do
            {
                int.TryParse(Console.ReadLine(), out a);
                if (a != 0)
                {
                    if (Check(a)) sum += a;
                    continue;
                }
                break;
            } while (true);
            return sum;            

        }
        public int SumOfNumber(int i)
        {

        }
        public bool Check(int a)
        {
            if (a > 0 && a % 2 != 0) return true;
            else return false;
        }
        public int GoodNumber(int max)
        {
            int count = 0;
            for (int i = 0; i < max; i++) 
            {
                if (i % SumOfNumber(i) == 0)
                {
                    count++;
                }
            }
            return count;
        }


    }

}
