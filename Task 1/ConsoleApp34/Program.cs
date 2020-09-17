using System;

namespace ConsoleApp34
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Address MyAddress = new Address();
            MyAddress.Index = 222222;
            MyAddress.Country = "Ukraine";
            MyAddress.Street = "Kioto";
            MyAddress.City = "Kyiv";
            MyAddress.House = 20;
            MyAddress.Apartment = 18;
            Console.WriteLine("Index: " + MyAddress.Index);
            Console.WriteLine("Country: " + MyAddress.Country);
            Console.WriteLine("City: " + MyAddress.City);
            Console.WriteLine("Street: " + MyAddress.Street);
            Console.WriteLine("House: " + MyAddress.House);
            Console.WriteLine("Apartment: " + MyAddress.Apartment);
            Console.ReadKey();
        }
    }
}