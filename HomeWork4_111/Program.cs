using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4_111
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetFullName("Иван", "Иванов", "Иванович"));
            Console.WriteLine(GetFullName("Петр", "Петров", "Петрович"));
            Console.WriteLine(GetFullName("Сидор", "Сидоров", "Сидоврович"));
            Console.ReadKey();
        }

        public static string GetFullName(string firstName, string lastName, string patronymic)
        {
            return lastName + " " + firstName + " " + patronymic;
        }
    }
}
