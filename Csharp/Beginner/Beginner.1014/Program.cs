using System;

namespace Beginner._1014
{
    class Program
    {
        static void Main(string[] args)
        {
            int distanciaPercorrida = int.Parse(Console.ReadLine());
            double combustivelGasto = double.Parse(Console.ReadLine());
            double consumoEspecifico = distanciaPercorrida / combustivelGasto;

            Console.WriteLine($"{consumoEspecifico:F3} km/l");
        }
    }
}