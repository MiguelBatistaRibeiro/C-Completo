using System;

namespace Matriz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Indique tamanho da matriz: ");
            int n = int.Parse(Console.ReadLine()); // tamanho matriz > ex: 3x3

            int[,] mat = new int[n, n]; // new matriz sendo [3,3]

            // percorre a primeira linha sendo 0 
            for (int i = 0; i < n; i++) 
            {   // cria vetor recebendo tamanho conforme Split(' '). Se ntrada maior 3- Matriz desconsidera
                string[] values = Console.ReadLine().Split(' ');
                // percorre colunas sendo j = 0 -- j = 1 -- j = 2.
                for (int j = 0; j < n; j++)
                {
                    mat[i, j] = int.Parse(values[j]);
                }
            }
            // Percorre todas linhas e imprime apenas onde i = i
            Console.WriteLine("Main diagonal:");
            for (int i = 0; i < n; i++)
            {
                Console.Write(mat[i, i] + " "); // imprime 1e1 2e2 3e3
            }
            Console.WriteLine();

            int count = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (mat[i, j] < 0)
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine("Negative numbers: " + count);
            Console.ReadKey();
        }
    }
}
