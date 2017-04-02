using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{
    /// <summary>
    /// Класс содержащий вычесления
    /// </summary>
    class Count
    {
        //Math
        DateTime start = new DateTime();
        /// <summary>
        /// Находит минимальное переданное значение
        /// </summary>
        /// <param name="a">первое число</param>
        /// <param name="b">второе число</param>
        /// <param name="c">третее число</param>
        /// <returns>возвращает минимальное значение</returns>
        public int Min(int a, int b, int c)
        {
            return a < b ?
                a < c ? a : c
                : b < c ? b : c;
        }
        /// <summary>
        /// Считает количество цифр в числе
        /// </summary>
        /// <param name="a">число</param>
        /// <returns>возвращает количество цифр в числе</returns>
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
        /// <summary>
        /// Считает кол-во цифр в числе(Рекурсия)
        /// </summary>
        /// <param name="a">число</param>
        /// <param name="Recursia">метка для перегрузки</param>
        /// <returns>возвращает количество цифр в числе</returns>
        public static int Long(int a, string Recursia)
        {
            if (a == 0) return 0;
            else return Long(a / 10) + 1;
        }
        /// <summary>
        /// Считает сумму четных положительных введенных чисел до 0
        /// </summary>
        /// <returns>возвращает сумму четных положительных чисел</returns>
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
        /// <summary>
        /// Считает сумму четных положительных введенных чисел до 0
        /// </summary>
        /// <param name="use_continue">пустышка для перегрузки</param>
        /// <returns>возвращает сумму четных положительных чисел</returns>
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
        /// <summary>
        /// Считает сумму цифр в числе
        /// </summary>
        /// <param name="i">число</param>
        /// <returns>возвращает сумму цифр в числе</returns>
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
        /// <summary>
        /// проверяет на нечетность и положительность
        /// </summary>
        /// <param name="a">число</param>
        /// <returns>возвращает правду если число нечетное и положительное</returns>
        public bool Check(int a)
        {
            if (a > 0 && a % 2 != 0) return true;
            else return false;
        }
        /// <summary>
        /// Проверка на Хорошие числа
        /// </summary>
        /// <param name="max">до какого числа проверять</param>
        /// <returns>кол-во хороших чисел</returns>
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
        /// <summary>
        /// Устанавливает время конца операции
        /// </summary>
        /// <returns>возвращает затраченное время</returns>
        public TimeSpan Timer()
        {
            DateTime end = DateTime.Now;
            return start - end;
        }
        /// <summary>
        /// Выводит числа от до
        /// </summary>
        /// <param name="a">первое число</param>
        /// <param name="b">второе число</param>
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
        /// <summary>
        /// Выводит сумму чисел от до
        /// </summary>
        /// <param name="a">первое число</param>
        /// <param name="b">второе число</param>
        /// <returns>возвращается сумма чисел от и до</returns>
        public int SumFromTo (int a, int b)
        {
            if (a == b) return 0;
            else return a < b ? SumFromTo(a + 1, b) + a : SumFromTo(a, b + 1) + b;
        }
    }

}
