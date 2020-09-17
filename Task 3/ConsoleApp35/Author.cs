using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp35
{
    class Author : Book
    {

        public Author(string t, string a, string c) : base(t, a, c)
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
}
