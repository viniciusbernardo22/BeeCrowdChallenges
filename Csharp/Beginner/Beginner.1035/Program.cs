using System;
using System.Collections.Generic;
using System.Linq;

namespace Beginner._1035
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] valores = Console.ReadLine().Split(' ');
            List<int> valoresinteiros = valores.Select(int.Parse).ToList();

            int A = valoresinteiros[0];
            int B = valoresinteiros[1];
            int C = valoresinteiros[2];
            int D = valoresinteiros[3];

            if (B > C && D > A && (C + D > (A + B)) && (C > 0 && D > 0) && A % 2 == 0)
            {
                Console.WriteLine("Valores aceitos");
            }
            else
            {
                Console.WriteLine("Valores nao aceitos");
            }
        }
    }
}