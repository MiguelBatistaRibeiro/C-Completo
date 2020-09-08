using System;
using TreinaTudoXadrez.tabuleiro;

namespace TreinaTudoXadrez
{
   class Tela
    {
        public static void imprimirTabuleiro(Tabuleiro tab)
        {
            for (int i = 0; i < tab.linhas; i++)
            {
                Console.Write(8 - i + " "); // Imprime numero linhas
                for (int j = 0; j < tab.colunas; j++)
                {   

                    if (tab.Peca(i,j) == null)
                    {
                        Console.Write("- ");
                    }
                    else
                    {
                        imprimirPeca(tab.Peca(i, j));
                        Console.Write(" ");
                    }
                }   
                Console.WriteLine();
            }
            Console.WriteLine("  A B C D E F G H");
        }
        // para mudar a cor da preta
        public static void imprimirPeca(Peca peca) { 
            if (peca.cor == Cor.Branca)
            {
                Console.Write(peca);
            } else
            {
                ConsoleColor aux = Console.ForegroundColor; // guarda padrao em aux
                Console.ForegroundColor = ConsoleColor.Yellow; // primeiro plano yellow
                Console.Write(peca);
                Console.ForegroundColor = aux; // volta ao padrao
            }
        }
    }
}
