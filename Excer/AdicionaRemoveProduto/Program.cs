using System;
using System.Globalization;

namespace AdicionaRemoveProduto
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto("TV", 500.00, 10);

            // EFETUANDO O SET 
            p.Nome = "TV 4K";

            // EFETUANDO O GET 
            Console.WriteLine(p.Nome);
            Console.ReadKey();
        }
    }
}
