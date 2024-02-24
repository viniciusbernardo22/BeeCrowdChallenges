using System;

namespace Beginner._1016
{
    class Program
    {
        static void Main(string[] args)
        {
            int distancia = int.Parse(Console.ReadLine());
        
            int velocidadeY = 90;

            int velocidadeX = 60;
            int tempoMinutos = (distancia * 60) / (velocidadeY - velocidadeX);
        
            Console.WriteLine($"{tempoMinutos} minutos");
        }
    }
}