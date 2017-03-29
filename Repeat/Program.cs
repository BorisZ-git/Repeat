using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Boris Z
#region ***Task 1***
//1. Написать программу “Анкета”. Последовательно задаются вопросы(имя, фамилия, возраст,
//  рост, вес). В результатевся информация выводится в одну строчку.
//а)используя склеивание;
//б) используя форматированный вывод.
//1. Ввести вес и рост человека.Расчитать и вывести индекс массы тела(ИМТ)по формуле
// I=m/(h* h); где m­ масса тела в килограммах, h ­ рост в метрах
#endregion ***Task 1***
#region ***Task 2***
//3. а) Написать программу, которая подсчитывает расстояние между точками с координатами x1, y1
//и x2,y2 по формуле r = Math.Sqrt(Math.Pow(x2­x1, 2) + Math.Pow(y2­y1, 2).Вывести результат
//используя спецификатор формата .2f(с двумя знаками после запятой);
//б) * Выполните предыдущее задание оформив вычисления расстояния междуточками в виде
//    метода;

#endregion ***Task 2*** 
#region ***Task 3***
/*
 Написать программу обмена значениями двух переменных
а) с использованием третьей переменной;
б) *без использования третьей переменной
 */
#endregion ***Task 3***
#region ***Task 4***
/*
а) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.
б) *Сделайте задание, только вывод организуйте в центре экрана
в) **Сделайте задание  б с использованием собственных методов (например, Print(string ms, int
x,int y)
*/
#endregion ***Task 4***

namespace Repeat
{
    class Program
    {
        static void Main(string[] args)
        {
            #region ***Task 1***
            //Person first = Questionnaire.Interview();
            //Questionnaire.ToString(first);
            //Console.WriteLine(Questionnaire.IMT(first));
            #endregion ***Task 1***
            #region ***Task 2***
            //Distance p = new Distance();
            //Console.WriteLine($"{p.Count():f2}" );
            #endregion ***Task 2***
            #region ***Task 3***
            //Change variables = new Change();
            //variables.ActChange();
            //variables.ActChange("without C");
            #endregion ***Task 3***

        }
    }
}
