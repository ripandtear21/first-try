using System;

namespace Task_8
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер заказа:");
            int q = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Введите покупателя:");
            string z = Console.ReadLine();
            Console.WriteLine("Введите поставщика:");
            string b = Console.ReadLine();
            Console.WriteLine("Введите название товара:");
            string u = Console.ReadLine();
            Console.WriteLine("Введите количество:");
            int j = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Введите сумму:");
            int k = Int32.Parse(Console.ReadLine());
            Invoice invoice = new Invoice(q, z, b, u, j, k);
            invoice.Calc();

        }
    }
}
