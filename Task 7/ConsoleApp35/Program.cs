using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        class Employee
        {
            public string name;
            public string surname;
            public double salary;
            public double tax;
            public Employee(string n, string s, int t)
            {
                name = n;
                surname = s;
                salary = t;
            }

            public void SalaryTax()
            {
                Console.WriteLine("Выберите должность:1-Директор 2-Зам.Директора 3-Обычный работник");
                int switcher = Int32.Parse(Console.ReadLine());
                switch (switcher)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine($"Имя: {name}\nФамилия: {surname}\nДолжность:Директор\nЗарплата: {salary}\nНалог: {tax = salary / 10} ");

                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine($"Имя: {name}\nФамилия: {surname}\nДолжность:Зам.Директора\nЗарплата: {salary}\nНалог: {tax = salary / 10} ");

                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine($"Имя: {name}\nФамилия: {surname}\nДолжность:Обычный работник\nЗарплата: {salary}\nНалог: {tax = salary / 10} ");

                        break;

                }

            }
        }

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