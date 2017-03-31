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
        public bool Identification(string login, string password)
        {
            if (this.login == login) return true;
            else if (this.password == password) return true;
            else return false;
        }
    }
}
