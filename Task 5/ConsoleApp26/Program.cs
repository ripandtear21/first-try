using System;

namespace ConsoleApp26
{
    class Program
    {
        

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


            User username = new User(q, z, b, j);
            Console.Clear();
            username.GetInfo();
        }


    }
}
