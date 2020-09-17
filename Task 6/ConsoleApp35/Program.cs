using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {

        class Converter
        {
            public double dollar;
            public double euro;
            public double ruble;
            double convertedUsd;
            double convertedEur;
            double convertedRub;

            public Converter(double usd, double eur, double rub)
            {
                dollar = usd;
                euro = eur;
                ruble = rub;

            }

            public double UsdConverter(int klo)
            {
                if (klo == 1)

                {
                    convertedUsd = dollar / 28;
                    return convertedUsd;
                }
                else if (klo == 2)
                {
                    convertedUsd = dollar * 28;
                    return convertedUsd;
                }
                else { return 0; }
            }
            public double EurConverter(int klo)
            {
                if (klo == 1)

                {
                    convertedEur = euro / 28;
                    return convertedEur;
                }
                else if (klo == 2)
                {
                    convertedEur = euro * 28;
                    return convertedEur;
                }
                else { return 0; }
            }
            public double RubConverter(int klo)
            {
                if (klo == 1)

                {
                    convertedRub = ruble / 28;
                    return convertedRub;
                }
                else if (klo == 2)
                {
                    convertedRub = ruble * 28;
                    return convertedRub;
                }
                else { return 0; }
            }



        }

        static void Main(string[] args)
        {
            double g = 0;
            double v = 0;
            double j = 0;
            int fok = 0;
            Converter solution = new Converter(g, v, j);
            Console.WriteLine("Выберите валюту для перевода:1-Доллар,2-Евро,3-Рубли");
            int iswitch = Convert.ToInt32(Console.ReadLine());
            switch (iswitch)
            {
                case 1:
                    Console.WriteLine("Введите число для перевода:");

                    g = Convert.ToDouble(Console.ReadLine());
                    solution = new Converter(g, v, j);
                    Console.WriteLine("Выберите операцию:1-Перевод из гривны в доллар\n"
                    + "Выберите операцию:2-Перевод из доллара в гривны");
                    fok = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Сумма в долларах:");
                    Console.WriteLine(solution.UsdConverter(fok));

                    break;
                case 2:
                    Console.WriteLine("Введите число для перевода:");
                    v = Convert.ToDouble(Console.ReadLine());
                    solution = new Converter(g, v, j);
                    Console.WriteLine("Выберите операцию:1-Перевод из гривны в евро\n"
                    + "Выберите операцию:2-Перевод из евро в гривны");
                    fok = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Сумма в евро:");
                    Console.WriteLine(solution.EurConverter(fok));

                    break;
                case 3:
                    Console.WriteLine("Введите число для перевода:");
                    j = Convert.ToDouble(Console.ReadLine());
                    solution = new Converter(g, v, j);
                    Console.WriteLine("Выберите операцию:1-Перевод из гривны в рубль\n"
                    + "Выберите операцию:2-Перевод из рубля в гривны");
                    fok = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Сумма в рублях:");
                    Console.WriteLine(solution.RubConverter(fok));
                    break;
            }




            Console.ReadKey();


        }
    }
}