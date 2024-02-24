using System;
using System.Collections.Generic;
using System.Linq;

namespace Beginner._1013
{
    class Program
    {
        static void Main(string[] args)
        {
            string [] numeros = Console.ReadLine().Split(' ');
            List<int> arrInt = new List<int>();
        
            foreach (var num in numeros){
                arrInt.Add(int.Parse(num));
            }
        
            int maiorNum = arrInt.Max();
            Console.WriteLine($"{maiorNum} eh o maior");
        }
    }
}