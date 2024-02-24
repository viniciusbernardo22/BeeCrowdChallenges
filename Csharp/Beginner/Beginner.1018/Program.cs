using System;

namespace Beginner._1018
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor = int.Parse(Console.ReadLine());

            int[] cedulas = { 100, 50, 20, 10, 5, 2, 1 };

            Console.WriteLine(valor);

            foreach (int cedula in cedulas)
            {
                int quantidadeNotas = valor / cedula;
                Console.WriteLine($"{quantidadeNotas} nota(s) de R$ {cedula},00");
                valor %= cedula;
            }
        }
    }
}