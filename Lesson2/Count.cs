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
        DateTime start = new DateTime();
        public int Min(int a, int b, int c)
        {
            return a < b ?
                a < c ? a : c
                : b < c ? b : c;
        }
        public static int Long(int a)
        {
            int count = 0;
            while (a != 0)
            {
                a /= 10;
                count++;
            }
            return count;
        }
        public static int Long(int a, string Recursia)
        {
            if (a == 0) return 0;
            else return Long(a / 10) + 1;
        }
        public int Sum()
        {
            int a; int sum = 0;
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
        public int SumOfLong(int i)
        {
            int count = 0;
            while (i != 0)
            {
                count += i % 10;
                i /= 10;
            }
            return count;
        }
        public bool Check(int a)
        {
            if (a > 0 && a % 2 != 0) return true;
            else return false;
        }
        public int GoodNumber(int max)
        {
            int count = 0;
            start = DateTime.Now;
            for (int i = 1; i < max; i++)
            {
                if (i % SumOfLong(i) == 0)
                {
                    count++;
                }
            }
            return count;
        }
        public TimeSpan Timer()
        {
            DateTime end = DateTime.Now;
            return start - end;
        }
        public void FromTo(int a,int b)
        {
            if (a != b)
                if (a > b)
                {
                    Console.Write($"{b} ");
                    FromTo(a, b + 1);
                }
                else 
                {
                    Console.Write($"{a} ");
                    FromTo(a + 1, b);
                }
            else if (a == b) Console.WriteLine($"{a} ");
        }
        public int SumFromTo (int a, int b)
        {
            if (a == b) return 0;
            else return a < b ? SumFromTo(a + 1, b) + a : SumFromTo(a, b + 1) + b;
        }
    }

}
