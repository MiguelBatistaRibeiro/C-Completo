using System;
using System.Collections.Specialized;
using System.Globalization;

namespace Vetores
{
    class Program
    {
        static void Main(string[] args)
        {
            // Utilizando uma entrada para definir o tamanho do vetor de tipo double e obtendo a média dos números. 

            // Pede o tamanho do vetor 
          Console.WriteLine("Entre com o tamanho da lista: ");
          int n = int.Parse(Console.ReadLine());
          double[] vetorNumeros = new double[n];

            // inicia com 0, em quanto < que n, n++
            for (int i = 0; i < n; i++)
            {
                // A cada chec, pede o número para incluir no indice
                Console.WriteLine("Insira o número: ");
                vetorNumeros[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }
            // for para soma dos valores do vet
            double sum = 0.0;
            for (int i = 0; i < n; i++)
            {   
                sum += vetorNumeros[i];
            }

            double media = sum / n;

            Console.WriteLine("Média dos números = " + media.ToString("F2", CultureInfo.InvariantCulture));
            Console.ReadKey();
        }
    }
}
