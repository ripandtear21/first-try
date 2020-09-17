using System;

namespace ConsoleApp35
{
    class Program
    {









        static void Main(string[] args)
        {
            Console.WriteLine("Введите название книги:");

            string h = Console.ReadLine();
            Console.WriteLine("Введите автора книги:");
            string k = Console.ReadLine();
            Console.WriteLine("Введите описание книги:");
            string l = Console.ReadLine();
            Book title = new Title(h, k, l);
            Book author = new Author(h, k, l);
            Book content = new Content(h, k, l);
            Console.Clear();
            Console.WriteLine("Название книги:");
            title.Show();
            Console.WriteLine("Автор книги:");
            author.Show();
            Console.WriteLine("Описание книги:");
            content.Show();
        }
    }
}
