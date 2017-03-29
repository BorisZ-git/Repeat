using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repeat
{
    /// <summary>
    /// класс меняющий местами значения
    /// </summary>
    class Change
    {
        static int a, b, c;
        /// <summary>
        /// конструктор задает значения
        /// </summary>
        public Change()
        {
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
        }
        /// <summary>
        /// Меняет местами с использованием третьей переменной
        /// </summary>
        public void ActChange()
        {
            c = a;
            a = b;
            b = c;
            Console.WriteLine($"a = {a}; b = {b}");
        }
        /// <summary>
        /// без использования третье переменной
        /// </summary>
        /// <param name="str">пустышка для перегрузки</param>
        public void ActChange(string str)
        {
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine($"a = {a}; b = {b}");

        }
    }
}
