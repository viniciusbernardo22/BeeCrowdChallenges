using System;

namespace Beginner._1010
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] dadosPeca1 = Console.ReadLine().Split(' ');

            int codigoPeca1 = int.Parse(dadosPeca1[0]);
            int quantidadePeca1 = int.Parse(dadosPeca1[1]);
            double valorUnitarioPeca1 = double.Parse(dadosPeca1[2]);

            string[] dadosPeca2 = Console.ReadLine().Split(' ');

            int codigoPeca2 = int.Parse(dadosPeca2[0]);
            int quantidadePeca2 = int.Parse(dadosPeca2[1]);
            double valorUnitarioPeca2 = double.Parse(dadosPeca2[2]);

            double totalPeca1 = quantidadePeca1 * valorUnitarioPeca1;
            double totalPeca2 = quantidadePeca2 * valorUnitarioPeca2;
            double valorTotal = totalPeca1 + totalPeca2;

            Console.WriteLine($"VALOR A PAGAR: R$ {valorTotal:F2}");
        }
    }
}