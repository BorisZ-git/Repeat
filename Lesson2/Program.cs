using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Boris Z
#region *** Task 1***
//Написать метод возвращающий минимальное из трех чисел;
#endregion *** Task 1***
#region *** Task 2***
//Написать метод подсчета количества цифр числа;
#endregion *** Task 2***
#region *** Task 3***
//С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных
//положительных чисел;
#endregion *** Task 3***
#region *** Task 4***
/*
 * Реализовать метод проверки логина и пароля. На вход подается логин и пароль. На выходе
истина, если прошел авторизацию, и ложь, если не прошел. Используя метод проверки логина и
пароля, написать программу: пользователь вводит логин и пароль, программа пропускает его
дальше или не пропускает. С помощью цикла do while ограничить ввод пароля тремя попытками;
 */
#endregion *** Task 4***
#region *** Task 5***
/*
а) Написать программу, которая запрашивает массу и рост человека, вычисляет его индекс
     массы и сообщает, нужно ли человеку похудеть, набрать вес или все в норме;
б)  Рассчитать, насколько кг похудеть или сколько кг набрать для нормализации веса.
          
*/
#endregion *** Task 5***
#region *** Task 6***
//    * Написать программу подсчета количества “Хороших” чисел в диапазоне от 1 до 1 000 000.
//Хорошим называется число, которое делится на сумму своих цифр.Реализовать подсчет
//   времени выполнения программы, используя структуру DateTime.
#endregion *** Task 6***
#region *** Task 7***
//    a) Разработать рекурсивный метод, который выводит на экран числа от a до b;
//б) * Разработать рекурсивный метод, который считает сумму чисел от a до b.
#endregion *** Task 7***

namespace Lesson2
{
    class Program
    {

        static void Main(string[] args)
        {
            /*
             * Тернарная операция
             * Перечисления
             * Оператор выбора
             * continue
             * рекурсия =>
            */

            #region *** Task 1***

            //Count copy = new Count();
            //Console.WriteLine(copy.Min(100, 120, 13));

            #endregion *** Task 1***
            #region *** Task 2***

            //Console.WriteLine(Count.Long(12345));
            //Console.WriteLine(Count.Long(123,"Recursia"));

            #endregion *** Task 2***
            #region *** Task 3***

            //Count copy = new Count();
            //Console.WriteLine(copy.Sum());
            //Console.WriteLine(copy.Sum("Use Continue"));

            #endregion *** Task 3***
            #region *** Task 4***

            //Personal user = new Personal("log", "pass");
            //user.Identification();

            #endregion *** Task 4***
            #region *** Task 5***

            //Personal user2 = new Personal(69, 192);
            //Console.WriteLine(user2.IMT_Weight());

            #endregion *** Task 5***
            #region *** Task 6***

            //Count copy = new Count();
            //Console.WriteLine(copy.GoodNumber(1000000));
            //Console.WriteLine(copy.Timer());

            #endregion *** Task 6***
            #region *** Task 7***

            Count copy = new Count();
            copy.FromTo(1, 10);
            Console.WriteLine(copy.SumFromTo(1, 5));

            #endregion *** Task 7***
        }

    }
}
