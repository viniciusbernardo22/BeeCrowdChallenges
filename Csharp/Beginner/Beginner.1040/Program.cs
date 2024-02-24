using System;
using System.Globalization;

namespace Beginner._1040
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            CultureInfo culture = CultureInfo.InvariantCulture;
            double nA = double.Parse(input[0], culture);
            double nB = double.Parse(input[1], culture);
            double nC = double.Parse(input[2], culture);
            double nD = double.Parse(input[3], culture);
            
           
            int pesoA = 2;
            int pesoB = 3;
            int pesoC = 4;
            int pesoD = 1;
            
        
            double media = (nA * pesoA + nB * pesoB + nC * pesoC + nD * pesoD) / (pesoA + pesoB + pesoC + pesoD);
            Console.WriteLine($"Media: {media:F1}");
            if (media > 7.0)
            {
                Console.WriteLine("Aluno aprovado.");
                Environment.Exit(0);
            }
            else if(media < 5.0)
            {
                Console.WriteLine("Aluno reprovado.");
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("Aluno em exame.");
                double NotaExame = double.Parse(Console.ReadLine(), new CultureInfo("en-US"));
                Console.WriteLine($"Nota do exame: {NotaExame:F1}");
                
                double novaMedia = (NotaExame + media) / 2;
                
               
                if (novaMedia >= 5.0)
                {
                    Console.WriteLine("Aluno aprovado.");
                }
                else
                {
                    Console.WriteLine("Aluno reprovado.");
                }
                
                Console.WriteLine($"Media final: {novaMedia:F1}");
            }
          
        }
    }
}