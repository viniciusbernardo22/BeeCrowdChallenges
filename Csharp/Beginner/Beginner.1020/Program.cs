using System;

namespace Beginner._1020
{
    class Program
    {
        static void Main(string[] args)
        {
            int idadeEmDias = int.Parse(Console.ReadLine());

            int anos = idadeEmDias / 365;
            int meses = (idadeEmDias % 365) / 30;
            int dias = (idadeEmDias % 365) % 30;
            
            Console.WriteLine($"{anos} ano(s)");
            Console.WriteLine($"{meses} mes(es)");
            Console.WriteLine($"{dias} dia(s)");
        }
    }
}