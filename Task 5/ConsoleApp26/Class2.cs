using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp26
{
    class User
    {
        public string login;
        public string name;
        public string surname;
        public int age;

        DateTime thisDay = DateTime.Now;
        public User(string l, string n, string s, int a)
        {
            login = l;
            name = n;
            surname = s;
            age = a;


        }



        public void GetInfo()
        {
            Console.WriteLine($"Имя: {name}\nФамилия: {surname}\nВозраст: {age}\nЛогин: {login} ");
            Console.WriteLine("Дата:" + thisDay.ToString());
        }
    }
}
