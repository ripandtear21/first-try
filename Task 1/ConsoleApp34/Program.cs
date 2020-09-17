using System;

namespace ConsoleApplication34
{
    class Program
    {
        class Address
        {
            private int index;
            private string country;
            private string city;
            private string street;
            private int house;
            private int apartment;
            public Address()
            {
            }
            public int Index
            {
                get { return index; }
                set { index = value; }
            }
            public string Country
            {
                get { return country; }
                set { country = value; }
            }
            public string City
            {
                get { return city; }
                set { city = value; }
            }
            public string Street
            {
                get { return street; }
                set { street = value; }
            }
            public int House
            {
                get { return house; }
                set { house = value; }
            }
            public int Apartment
            {
                get { return apartment; }
                set { apartment = value; }
            }
        }
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