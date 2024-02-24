using System;
using System.Collections.Generic;
using System.Linq;

namespace Beginner._1038
{

    class Lanche
    {
        public int Id { get; set; }
        public decimal Preco { get; set; }
        
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            List<Lanche> lanches = new List<Lanche>
            {
                new Lanche { Id = 1, Preco = 4.00m },
                new Lanche { Id = 2, Preco = 4.50m },
                new Lanche { Id = 3, Preco = 5.00m },
                new Lanche { Id = 4, Preco = 2.00m },
                new Lanche { Id = 5, Preco = 1.50m },
            };

            string[] input = Console.ReadLine().Split(' ');

            int item = int.Parse(input[0]);
            int quantidade = int.Parse(input[1]);
            Lanche itemescolhido = lanches.Find(x => x.Id == item);

            decimal total = quantidade * itemescolhido.Preco;
            
            Console.WriteLine($"Total: R$ {total}");
        }
    }
}