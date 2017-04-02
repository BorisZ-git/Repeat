using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{
    class Personal
    {
        string login, password;
        public static double weight, growth;
        /// <summary>
        /// Конструктор для роста и массы
        /// </summary>
        /// <param name="m">масса</param>
        /// <param name="h">рост</param>
        public Personal(double m,double h)
        {
            weight = m;
            growth = h/100;
        }
        /// <summary>
        /// Конструктор для логина и пароля
        /// </summary>
        /// <param name="login">логин</param>
        /// <param name="password">пароль</param>
        public Personal(string login,string password)
        {
            this.login = login;
            this.password = password;
        }
        /// <summary>
        /// Программа входа
        /// </summary>
        public void Identification()
        {
            int count = 3;
            string log = null;
            string pass = null;
            while (count!=0)
            {
                while (true)
                {
                    if (Check(log)) break;
                    if (count == 0) break;
                    else
                    {
                        log = Console.ReadLine();
                        if (Check(log)) break;
                        else count--;
                    }
                }
                if (count == 0) break;
                pass = Console.ReadLine();
                if (!Check(pass))
                {
                    count--;
                    continue;
                }
                break;
            }
            if (count == 0) Console.WriteLine($"count = {count}");
            Console.WriteLine("You Pass!");
        }
        /// <summary>
        /// Проверка логина или пароля
        /// </summary>
        /// <param name="str">введенные данные</param>
        /// <returns>правда или нет</returns>
        public bool Check(string str)
        {
            if (this.login == str) return true;
            else if (this.password == str) return true;
            else return false;
        }

        //IMT
        /// <summary>
        /// рассчет имт
        /// </summary>
        /// <returns>ИМТ</returns>
        public double IMT()
        {
            return weight / (growth * growth);
        }
        /// <summary>
        /// Интерпретация ИМТ
        /// </summary>
        /// <returns>текущий ИМТ</returns>
        public string IMT_Interpret()
        {
            double i = IMT();
            string str = null;
            if (i < 16) str = "Выраженный дефицит массы тела";
            if (i > 16 && i < 18.5) str = "Недостаточная (дефицит) масса тела";
            if (i >= 18.5 && i < 25)  str = "Норма";
            if (i >= 25 && i < 30) str = "Избыточная масса тела (предожирение)";
            if (i > 30 && i < 35) str = "Ожирение первой степени";
            if (i > 35 && i < 40) str = "Ожирение второй степени";
            if (i > 40) str = "Ожирение третьей степени (морбидное)";
            return str;
        }
        /// <summary>
        /// ИМТ до нормы
        /// </summary>
        /// <returns>сколько нужно</returns>
        public string IMT_Weight()
        {
            double i = IMT();
            int count = 0;
            string str = "Все в норме";
            if (i < 18.5)
            {
                while (i < 18.5)
                {
                    weight++;
                    i = IMT();
                    count++;
                }
                str = $"Вам нужно набрать {count} кг, для нормализации IMT";
            }
            else if (i > 25)
            {
                while (i > 25)
                {
                    weight--;
                    i = IMT();
                    count++;
                }
                str = $"Вам нужно сбросить {count} кг, для нормализации IMT";
            }
            return str;
        }
    }

}
