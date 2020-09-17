using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp35
{
    class Program
    {
        

        static void Main(string[] args)
        {
            Console.WriteLine("Введите ваше имя:");
            string g = Console.ReadLine();
            Console.WriteLine("Введите вашу фамилию:");
            string x = Console.ReadLine();
            Console.WriteLine("Введите вашу зарплату:");
            int j = Int32.Parse(Console.ReadLine());

            Employee emp = new Employee(g, x, j);
            
            emp.SalaryTax();
            Console.ReadKey();
        }
    }
}