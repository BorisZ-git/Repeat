using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repeat
{
    class Person
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Age { get; set; }
        public int Hight { get; set; }
        public int Weight { get; set; }
    }
    class Respondents
    {
        List<Person> db = new List<Person>();
        public Respondents(params Person[] Args)
        {

            foreach (var e in Args) db.Add(e);
        }
        public List<Person> resp { get { return db; } }
        public static void FullData()
        {
            Respondents data = new Respondents(
        new Person() { Name = "Name1", LastName = "LName1", Age = "20", Hight = 180, Weight = 80 },
        new Person() { Name = "Name2", LastName = "LName2", Age = "25", Hight = 170, Weight = 77 },
        new Person() { Name = "Name3", LastName = "LName3", Age = "22", Hight = 186, Weight = 90 },
        new Person() { Name = "Name4", LastName = "LName4", Age = "18", Hight = 189, Weight = 82 }
        );
        }
        static void Questions()
        {
            
            Console.Write("Введите число респондентов: ");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i != n; i++)
            {
                Person copy = new Person();
                Console.Write("Имя респондента: ");
                copy.Name = Console.ReadLine();
                Console.Write("Имя респондента: ");
                copy.LastName = Console.ReadLine();
                Console.Write("Имя респондента: ");
                copy.Age = Console.ReadLine();
                Console.Write("Имя респондента: ");
                copy.Hight = Convert.ToInt32(Console.ReadLine());
                Console.Write("Имя респондента: ");
                copy.Weight = Convert.ToInt32(Console.ReadLine());
            }

        }
    }
}
