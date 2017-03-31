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
        public Personal(string login,string password)
        {
            this.login = login;
            this.password = password;
        }
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
        public bool Check(string str)
        {
            if (this.login == str) return true;
            else if (this.password == str) return true;
            else return false;
        }
    }
}
