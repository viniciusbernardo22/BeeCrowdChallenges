using System;
using System.Globalization;

namespace Beginner._1037
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo culture = new CultureInfo("en-US");
            double intervalo = Double.Parse(Console.ReadLine(), culture);
            
            if (intervalo >= 0 && intervalo <= 25)
            {
                Console.WriteLine("Intervalo [0,25]");
            } else if (intervalo > 25 && intervalo <= 50)
            {
                Console.WriteLine("Intervalo (25,50]");
            }
            else if(intervalo > 50 && intervalo <= 75)
            {
                Console.WriteLine("Intervalo (50,75]");
            }
            else if(intervalo > 75 && intervalo <= 100)
            {
                Console.WriteLine("Intervalo (75,100]");
            }
            else
            {
                Console.WriteLine("Fora de intervalo");
            }
            
        }
    }
}