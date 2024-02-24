using System;

namespace Beginner._1017
{
    class Program
    {
        static void Main(string[] args)
        {
            int tempogasto = int.Parse(Console.ReadLine());
            int velocidadeMedia = int.Parse(Console.ReadLine());
  
            double litros = (tempogasto * velocidadeMedia) / 12.0;

            Console.WriteLine($"{litros:F3}");
        }
    }
}