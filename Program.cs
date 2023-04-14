using System;

namespace Lr1_3_Dor
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введите три числа.");
                double a = Convert.ToDouble(Console.ReadLine());
                double b = Convert.ToDouble(Console.ReadLine());
                double c = Convert.ToDouble(Console.ReadLine());
                double polP = (a + b + c) / 2;
                double S = Math.Round(Math.Sqrt(polP * (polP - a) * (polP - b) * (polP - c)), 2);

                if ((a > 0 | b > 0 | c > 0) && (a < b + c && b < a + c && c < a + b))
                {
                    if ((c * c) < (a * a + b * b))
                    {
                        Console.WriteLine($"Треугольник остроугольный. Его площадь: {S}");
                    }

                    if ((c * c) == (a * a + b * b))
                    {
                        Console.WriteLine($"Треугольник прямоугольный. Его площадь: {S}");
                    }

                    if ((c * c) > (a * a + b * b))
                    {
                        Console.WriteLine($"Треугольник тупоугольный. Его площадь: {S}");
                    }
                }
                else
                {
                    Console.WriteLine("Такого треугольника не существует!");
                }
            }
            catch 
            {
                Console.WriteLine("Ошибка! Проверьте вводимые данные.");
            }
        }
    }
}
