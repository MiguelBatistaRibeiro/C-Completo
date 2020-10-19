using HashComparison.Entities;
using System;
using System.Collections.Generic;

namespace HashComparison
{
    class Program
    { 
        static void Main(string[] args)
        {
            // dois produtos adicionados ao conjunto
            HashSet<Product> a = new HashSet<Product>();
            a.Add(new Product("TV", 900.00));
            a.Add(new Product("Nootbook", 1200.00));
            // dois pointos adicionados ao conjunto
            HashSet<Point> b = new HashSet<Point>();
            b.Add(new Point(3, 4));
            b.Add(new Point(5, 10));

            Product prod = new Product("Notebook", 1200.00); // referencia diferente na variavel
            Console.WriteLine(a.Contains(prod)); // false - class tipo referencia (compara referencia) 

            Point point = new Point(5, 10); // valor igual na variavel
            Console.WriteLine(b.Contains(point));

            Console.ReadLine();
        }
    }
}
