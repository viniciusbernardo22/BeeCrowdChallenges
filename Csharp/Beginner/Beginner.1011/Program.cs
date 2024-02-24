using System;

namespace Beginner._1011
{
    class Program
    {
        static void Main(string[] args)
        {
            int raio = int.Parse(Console.ReadLine());
            double pi = 3.14159;
            double RaioCubo = Math.Pow(raio, 3);
    
            double volume = (4.0/3.0) * pi * RaioCubo;
    
            Console.WriteLine($"VOLUME = {volume:F3}");
        }
    }
}