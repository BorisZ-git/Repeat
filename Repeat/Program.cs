﻿using System;
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
// I=m/(h* h); где m­ масса тела вкилограммах, h ­ рост в метрах
#endregion ***Task 1***
#region ***Task 2***
//3. а) Написать программу, котораяподсчитывает расстояниемежду точкамис координатамиx1, y1
//и x2,y2 поформуле r = Math.Sqrt(Math.Pow(x2­x1, 2) + Math.Pow(y2­y1, 2).Вывестирезультат
//используяспецификаторформата.2f(сдвумязнакамипослезапятой);
//б) * Выполнитепредыдущее заданиеоформив вычислениярасстояния междуточками ввиде
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
            Anket.ToString(Anket.Interview());
        }
    }
}
