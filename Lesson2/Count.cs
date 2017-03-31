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
        public bool Check(int a)
        {
            if (a > 0 && a % 2 != 0) return true;
            else return false;
        }
        public double IMT(int m, int h)
        {                       
            return  m / (h * h);
        }
        public string IMT_Interpreted(double i)
        {
            string str = null;
            if (i < 16) str = "Выраженный дефицит массы тела";
            if (i > 16 && i < 18.5) str = "Недостаточная (дефицит) масса тела";
            if (i >= 18.5 && i > 25) str = "Норма";
            if (i >= 25 && i < 30) str = "Избыточная масса тела (предожирение)";
            if (i > 30 && i < 35) str = "Ожирение первой степени";
            if (i > 35 && i < 40) str = "Ожирение второй степени";
            if (i > 40) str = "Ожирение третьей степени (морбидное)";
            return str;
        }

    }
}
