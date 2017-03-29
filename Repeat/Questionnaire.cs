using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repeat
{
    /// <summary>
    /// класс с методами опросника
    /// </summary>
    class Questionnaire
    {
        /// <summary>
        /// основной опросник
        /// </summary>
        /// <returns>экземпляр класс с вбитыми данными</returns>
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
        /// <summary>
        /// укороченный опросник
        /// </summary>
        /// <returns>экземпляр класс с вбитыми данными</returns>
        public static Person ShortInterview()
        {
            Person copy = new Person();
            copy.FName = Console.ReadLine();
            copy.LName = Console.ReadLine();
            copy.City = Console.ReadLine();
            return copy;
        }
        /// <summary>
        /// выводит данные на экран
        /// </summary>
        /// <param name="copy">принимает копию с вбитыми данными</param>
        public static void ToString(Person copy)
        {
            Console.WriteLine($"{copy.FName} {copy.LName} {copy.Age} {copy.Hight} {copy.Weight}");
        }
        /// <summary>
        /// выводит данные по центру экрана
        /// </summary>
        /// <param name="copy">принимает копию с вбитыми данными</param>
        /// <param name="x">пустышка для перегрузки метода</param>
        /// <param name="y">пустышка для перегрузки метода</param>
        public static void ToString(Person copy, int x,int y)
        {
            string str = $"{copy.FName} {copy.LName} {copy.City}";
            x = Console.BufferWidth / 2 - str.Length;
            y = Console.BufferHeight / 2;
            Console.SetCursorPosition(x, y);
            Console.WriteLine(str);
        }
        /// <summary>
        /// считает ИМТ на основании передаваемых данных
        /// </summary>
        /// <param name="copy">принимает копию с вбитыми данными</param>
        /// <returns>итоговое ИМТ</returns>
        public static double IMT(Person copy)
        {
            double i;
            double m = Convert.ToDouble(copy.Weight);
            double h = (Convert.ToDouble(copy.Hight))/100;
            return i = m / (h * h);
        }
    }
    /// <summary>
    /// содержит данные о респонденте
    /// </summary>
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
