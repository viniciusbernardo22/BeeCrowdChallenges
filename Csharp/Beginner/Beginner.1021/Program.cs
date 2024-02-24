using System;
using System.Collections.Generic;
using System.Globalization;

namespace Beginner._1021
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo culture = new CultureInfo("en-US");
            decimal  valor = decimal .Parse(Console.ReadLine(), culture);

            int[] notas = new[] { 100, 50, 20, 10, 5, 2 };
            decimal [] moedas = new[] { 1, 0.50m, 0.25m, 0.10m, 0.05m, 0.01m };
            
            
            Console.WriteLine("NOTAS:");
            foreach (var nota in notas)
            {
                int quantidadeNotas = (int)(valor / nota);
                valor %= nota;
                Console.WriteLine($"{quantidadeNotas} nota(s) de R$ {nota.ToString("F2")}");
            }
            
            Console.WriteLine("MOEDAS:");
            foreach (var moeda in moedas)
            {
                
                int quantidadeMoedas = (int)(valor / moeda);
                
                valor %= moeda;
                
                Console.WriteLine($"{quantidadeMoedas} moeda(s) de R$ {moeda.ToString("F2")}");
            }
        }
    }
}