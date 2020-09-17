using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp35
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
}
