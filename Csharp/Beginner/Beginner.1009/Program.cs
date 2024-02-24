using System;

namespace Beginner._1009
{
    class Program
    {
        static void Main(string[] args)
        {
            string Nome = Console.ReadLine();
            double SalarioFixo = double.Parse(Console.ReadLine());
            double VendasEfetuadas = double.Parse(Console.ReadLine());
        
            double percentual = 0.15;
            double SalarioComComissao = SalarioFixo + (VendasEfetuadas * percentual);
        
            Console.WriteLine($"TOTAL = R$ {SalarioComComissao:F2}");
        }
    }
}