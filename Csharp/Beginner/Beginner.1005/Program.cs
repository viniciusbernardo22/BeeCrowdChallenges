using System;

namespace Beginner._1005
{
    class Program
    {
        static void Main(string[] args)
        {
            double NOTA1 = double.Parse(Console.ReadLine());
            double NOTA2 = double.Parse(Console.ReadLine());
        
            double pesoA = 3.5;
            double pesoB = 7.5;
        
            double MEDIA = (NOTA1 * pesoA + NOTA2 * pesoB) / (pesoA + pesoB);
        
            Console.WriteLine($"MEDIA = {MEDIA:F5}");
        }
    }
}