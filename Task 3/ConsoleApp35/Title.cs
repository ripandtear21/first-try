using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp35
{
    class Title : Book
    {

        public Title(string t, string a, string c) : base(t, a, c)
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
}
