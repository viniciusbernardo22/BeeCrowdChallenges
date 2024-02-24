using System;
using System.Collections.Generic;
using System.Linq;

namespace Beginner._2006
{
    class Program
    {
        static void Main(string[] args)
        {
            int tipoCha = int.Parse(Console.ReadLine());
            string[] stringparticipantes = Console.ReadLine().Split(' ');

            List<int> intParticipantes = stringparticipantes.Select(int.Parse).ToList();

            int numeroAcertos = 0;
            
            for (int i = 0; i < intParticipantes.Count; i++)
            {
                if (intParticipantes[i] == tipoCha)
                {
                    numeroAcertos++;
                }
            }
            
            Console.WriteLine(numeroAcertos);
      

        }
    }
}