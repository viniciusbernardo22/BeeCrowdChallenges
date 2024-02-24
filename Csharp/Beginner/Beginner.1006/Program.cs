using System;

namespace Beginner._1006
{
    class Program
    {
        static void Main(string[] args)
        {
            double A = double.Parse(Console.ReadLine());
            double B = double.Parse(Console.ReadLine());
            double C = double.Parse(Console.ReadLine());
        
            int PesoA = 2;
            int PesoB = 3;
            int PesoC = 5;
        
            double MEDIA = (A * PesoA + B * PesoB + C * PesoC) / (PesoA + PesoB + PesoC);
        
            Console.WriteLine($"MEDIA = {MEDIA:F1}");
        }
    }
}