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
    }
    class Person
    {
        public string FName { get; set; }
        public string LName { get; set; }
        public string Age { get; set; }
        public string Hight { get; set; }
        public string Weight { get; set; }
    }
}
