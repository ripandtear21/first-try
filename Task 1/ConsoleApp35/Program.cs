using System;

namespace ConsoleApp35
{
    class Program
    {
        abstract class Book
        {
            public string Title { get; set; }
            public string Author { get; set; }
            public string Content { get; set; }
            
            public Book(string t, string a, string c)
            {
               Title = t;
                Author = a;
                Content = c;

            }
            public abstract void Show();
            
        }

        class Title : Book
        {
            
            public Title(string t, string a, string c):base(t,a,c)
            {
                Title = t;
                
            }
            
            public override void Show()
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(Title);
                Console.ResetColor();
            }
        }

        class Author : Book
        {
            
            public Author(string t, string a, string c): base(t,a,c)
            {
                
                Author = a;
               

            }
            
            public override void Show()
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine(Author);
                Console.ResetColor();
            }
        }
        class Content : Book
        {
             
            public Content(string t, string a, string c):base(t,a,c)
            {

                
                Content = c;
            }

            
            public override void Show()
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(Content);
                Console.ResetColor();
            }
        }



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
