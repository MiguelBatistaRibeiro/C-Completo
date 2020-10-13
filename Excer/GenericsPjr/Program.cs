using System;

namespace GenericsPjr
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintService<int> printService = new PrintService<int>();

            Console.Write("Quantos valores? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Digite posição {i}: ");
                int x = int.Parse(Console.ReadLine()); // se elementos for string (ñ typesafety) - cria outra classe
                printService.AddValue(x);
            }
            printService.Print();
            Console.WriteLine("Primeiro: " + printService.First());

            Console.ReadLine();
        }
    }
}
