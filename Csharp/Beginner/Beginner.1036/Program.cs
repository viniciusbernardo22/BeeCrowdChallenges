using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace Beginner._1036
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] valores = Console.ReadLine().Split(' ');
            CultureInfo culture = new CultureInfo("en-US");
            List<double> valoresDouble = valores.Select(x => double.Parse(x, culture)).ToList();

            double A = valoresDouble[0];
            double B = valoresDouble[1];
            double C = valoresDouble[2];
            double delta = B * B - 4 * A * C;

            if (A == 0 || delta < 0)
            {
                Console.WriteLine("Impossivel calcular");
            }
            else
            {
                double raiz1 = (-B + Math.Sqrt(delta)) / (2 * A);
                double raiz2 = (-B - Math.Sqrt(delta)) / (2 * A);
                
                Console.WriteLine($"R1 = {raiz1:F5}");
                Console.WriteLine($"R2 = {raiz2:F5}");
            }
        }
    }
}