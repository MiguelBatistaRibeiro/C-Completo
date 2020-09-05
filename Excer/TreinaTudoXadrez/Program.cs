using System;
using TreinaTudoXadrez.tabuleiro;

namespace TreinaTudoXadrez
{
    class Program
    {
        static void Main(string[] args)
        {
            Posicao P = new Posicao(2, 4);  

            Console.WriteLine("Posição: " + P);
            Console.ReadLine();
        }
    }
} 
