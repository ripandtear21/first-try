using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp35
{
    class Content : Book
    {

        public Content(string t, string a, string c) : base(t, a, c)
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
}
