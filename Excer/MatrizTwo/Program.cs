using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrizTwo
{
    class Program
    {
        static void Main(string[] args)
        {   // m - linha, n - coluna. Cria vetor para m e n valor 
            Console.WriteLine("Defini nº(tamanho) linha e nº(tamanho) coluna: ");
            string[] line = Console.ReadLine().Split(' ');
            int m = int.Parse(line[0]);
            int n = int.Parse(line[1]);
            // recebe vetor sendo valor m e n 
            int[,] mat = new int[m, n];
            // percorre linha sendo m 
            for (int i = 0; i < m; i++)
            {
                string[] values = Console.ReadLine().Split(' '); 
                for (int j = 0; j < n; j++) // percorre coluna sendo n 
                {   
                    mat[i, j] = int.Parse(values[j]); // para cada n sendo i, adiciona m sendo j
                }
            }
            Console.WriteLine("Procurar número: ");
            int x = int.Parse(Console.ReadLine());  // x recebe nº para buscar 

            // se logica usada para adicionar, logica usada para percorrer. Como for acima
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (mat[i, j] == x) // se em umas das posições encontrar um x nº
                    {
                        Console.WriteLine("Position " + i + "," + j + ":"); // informe a posição i e j da matriz
                        if (j > 0) // se j coluna > 0
                        {
                            Console.WriteLine("Left: " + mat[i, j - 1]); // i linha tal e j - 1 o da esquerda
                        }
                        if (i > 0) // se linha i > 0
                        {
                            Console.WriteLine("Up: " + mat[i - 1, j]); // i - 1 mostra Up e j coluna tal
                        }
                        if (j < n - 1) // se n até 3, então n sendo 3 - n será 2. sendo n < j(2)
                        {
                            Console.WriteLine("Right: " + mat[i, j + 1]); // j + 1 exibe Right
                        }
                        if (i < m - 1) // se m até 3, então m sendo 3 - m será 2. sendo m < i(2)
                        {
                            Console.WriteLine("Down: " + mat[i + 1, j]); // i + 1 exibe Down
                        }
                    }
                }
            }
        }
    }
}
