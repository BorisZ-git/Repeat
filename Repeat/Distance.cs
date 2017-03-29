using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repeat
{
    /// <summary>
    /// класс для расчета расстояния
    /// </summary>
    class Distance
    {
        static int x1,x2;
        static int y1,y2;
        /// <summary>
        /// конструктор задает точки
        /// </summary>
        public Distance()
        {
            x1 = Convert.ToInt32(Console.ReadLine());
            y1 = Convert.ToInt32(Console.ReadLine());
            x2 = Convert.ToInt32(Console.ReadLine());
            y2 = Convert.ToInt32(Console.ReadLine());
        }
        /// <summary>
        /// метод с расчетами
        /// </summary>
        /// <returns>расстояние</returns>
        public double Count()
        {
            double r = Math.Sqrt(Math.Pow(x2 * x1, 2) + Math.Pow(y2 * y1, 2));
            return r;
        }
    }
}
