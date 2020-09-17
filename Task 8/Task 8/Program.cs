using System;

namespace Task_8
{
    class Program
    {
        class Invoice
        {
            public int account;
            public string customer;
            public string provider;
            private string article;
            private double quantity;
            public double price;
            public double tax;
           
            public Invoice(int a, string c, string p, string r, double q,double pr)
            {
                account = a;
                customer = c;
                provider = p;
                article = r;
                quantity = q;
                price = pr;

                
            }
            public void Calc()
            {
                Console.Clear();
                Console.WriteLine($"Номер заказа: {account}\nПокупатель: {customer}\nПоставщик: {provider}\nТовар: {article}" +
                    $"\nКоличество: {quantity}\nСумма без НДС:{price=price*quantity}\nCумма с НДС:{tax = price*1.1} ");
                
            }


        }
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
