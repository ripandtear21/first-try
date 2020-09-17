using System;

namespace ConsoleApp23
{
    class Program
    {
        
        class Rectangle
        {
            public double side1;
            public double side2;
            double area;
            double perimeter;
            public Rectangle(double s1, double s2)
            {
                side1 = s1;
                side2 = s2;

            }
            
              public double AreaCalculator()
            {
                area = side1 * side2;
                return Area;
            }
            public double PerimeterCalculator()
            {
                perimeter = (2 * side1) + (2 * side2);
                return Perimeter;
            }
            public double Area
            {
                get
                {
                    return area;
                }
            }
            public double Perimeter
            {
                get
                {
                    return perimeter;
                }
            }
        }
        
        
        
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
