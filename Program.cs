using System;

namespace Lab1Variant5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введіть значення x:");
            double x = Convert.ToDouble(Console.ReadLine());
            double E = 6.3 * Math.Sin(1.3 * x - Math.PI / 3.0) - x + Math.Sqrt(x + 9.0 / 4.0) + Math.Pow(x + 7.0 / 3.0, 3);
            Console.WriteLine("При x = {0}, значення E = {1}", x, E);
            Console.ReadKey();
        }
    }
}