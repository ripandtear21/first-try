using System;

namespace ConsoleApp26
{
    class Program
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
                Console.WriteLine("Дата:"+thisDay.ToString());
            }
        }
        
        
        
        static void Main(string[] args)
        {
            Console.WriteLine("Введите логин:");
            string q = Console.ReadLine();
            Console.WriteLine("Введите имя:");
            string z = Console.ReadLine();
            Console.WriteLine("Введите фамилия:");
            string b = Console.ReadLine();
            Console.WriteLine("Введите возраст:");
            int j = Int32.Parse(Console.ReadLine());


            User username = new User(q,z,b,j);
            Console.Clear();
            username.GetInfo();
        }
    }
}
