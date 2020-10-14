using GenericsRestrictions.Entities;
using GenericsRestrictions.Services;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace GenericsRestrictions
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            Console.Write("Entre com o número de Produtos: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Exemplo > (produto, 23.90): ");
                string[] vect = Console.ReadLine().Split(',');
                double price = double.Parse(vect[1], CultureInfo.InvariantCulture);
                list.Add(new Product(vect[0], price));
            }
            CalculationService calculationService = new CalculationService();
            
            Product p = calculationService.Max(list); // <Product> is optional

            Console.WriteLine("Mais caro:");
            Console.WriteLine(p);
        }
    }
}
