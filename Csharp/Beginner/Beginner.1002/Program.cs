using System;

namespace Beginner._1002
{
    class Program
    {
        static void Main(string[] args)
        {
            double raio = Convert.ToDouble(Console.ReadLine());
            double pi = 3.14159;
            double area = pi * Math.Pow(raio, 2);

            Console.WriteLine($"A={area:F4}");
        }
    }
}