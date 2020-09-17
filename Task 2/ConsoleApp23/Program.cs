using System;

namespace ConsoleApp23
{
    class Program
    {
        
       
        
        
        
        static void Main(string[] args)
        {
            Console.WriteLine("Введите сторону A");
            double g = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите сторону B");
            double v = Convert.ToDouble(Console.ReadLine());
            

            Rectangle solution = new Rectangle(g, v);

           
            Console.WriteLine("Значение площади:"+solution.AreaCalculator());
            Console.WriteLine("Значение периметра:"+solution.PerimeterCalculator());
            Console.ReadKey();


        }
    }
}
