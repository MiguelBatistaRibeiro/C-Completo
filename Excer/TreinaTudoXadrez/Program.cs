using System;
using TreinaTudoXadrez.tabuleiro;
using TreinaTudoXadrez.xadrez;

namespace TreinaTudoXadrez
{
    class Program
    {
        static void Main(string[] args)
        {
            PosicaoXadrez pos = new PosicaoXadrez('c', 7);
            Console.WriteLine(pos);

            Console.WriteLine(pos.toPosicao());

            Console.ReadLine();
        }
    }
} 
