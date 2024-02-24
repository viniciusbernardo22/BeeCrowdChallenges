using System;
using System.Globalization;

namespace Beginner._1012
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] dimensoes = Console.ReadLine().Split(' ');
            
            double A = double.Parse(dimensoes[0], CultureInfo.CreateSpecificCulture("en-US"));
            double B = double.Parse(dimensoes[1], CultureInfo.CreateSpecificCulture("en-US"));
            double C = double.Parse(dimensoes[2], CultureInfo.CreateSpecificCulture("en-US"));

            double pi = 3.14159;

            double triangulo = (A * C) / 2;
            double circulo = pi * Math.Pow(C, 2);
            double trapezio = ((A + B) * C) / 2;
            double quadrado = Math.Pow(B, 2);
            double retangulo = A * B;

            Console.WriteLine($"TRIANGULO: {triangulo:F3}");
            Console.WriteLine($"CIRCULO: {circulo:F3}");
            Console.WriteLine($"TRAPEZIO: {trapezio:F3}");
            Console.WriteLine($"QUADRADO: {quadrado:F3}");
            Console.WriteLine($"RETANGULO: {retangulo:F3}");
        }
    }
}