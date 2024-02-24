using System;

namespace Beginner._1008
{
    class Program
    {
        static void Main(string[] args)
        {
            int FuncNum = int.Parse(Console.ReadLine());
            int HorasTrabalhadas = int.Parse(Console.ReadLine());
            double ValorHora = double.Parse(Console.ReadLine());
        
            double Salario = HorasTrabalhadas * ValorHora;
            Console.WriteLine($"NUMBER = {FuncNum}");
            Console.WriteLine($"SALARY = U$ {Salario:F2}");
        }
    }
}