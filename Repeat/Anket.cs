using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repeat
{
    class Anket
    {
        public static Person Interview()
        {
            Person copy = new Person();
            copy.FName = Console.ReadLine();
            copy.LName = Console.ReadLine();
            copy.Age = Console.ReadLine();
            copy.Hight = Console.ReadLine();
            copy.Weight = Console.ReadLine();
            return copy;
        }
        public static void ToString(Person copy)
        {
            Console.WriteLine($"{copy.FName} {copy.LName} {copy.Age} {copy.Hight} {copy.Weight}");
        }
        public static double IMT(Person copy)
        {
            double i;
            double m = Convert.ToDouble(copy.Weight);
            double h = (Convert.ToDouble(copy.Hight))/100;
            return i = m / (h * h);
        }
    }
    class Person
    {
        public string FName { get; set; }
        public string LName { get; set; }
        public string Age { get; set; }
        public string Hight { get; set; }
        public string Weight { get; set; }
        public string City { get; set; }

    }
}
