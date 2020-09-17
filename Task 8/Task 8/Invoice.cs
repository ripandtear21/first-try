using System;
using System.Collections.Generic;
using System.Text;

namespace Task_8
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

        public Invoice(int a, string c, string p, string r, double q, double pr)
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
                $"\nКоличество: {quantity}\nСумма без НДС:{price = price * quantity}\nCумма с НДС:{tax = price * 1.1} ");

        }


    }
}
