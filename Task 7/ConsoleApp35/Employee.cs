using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp35
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
}
