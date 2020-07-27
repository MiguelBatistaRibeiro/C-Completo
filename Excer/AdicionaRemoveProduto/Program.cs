using System;
using System.Globalization;

namespace AdicionaRemoveProduto
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto("TV", 500.00, 10);

            // COM OS ATRIBUTOS PUBLIC É POSSÍVEL A ALTERAÇÃO DESSA FORMA
            //p._quantidade = 2;

            // SENDO ATRIBUTO PRIVATE, O VALOR É ACESSIVEL PELO GET 
            Console.WriteLine(p.GetNome());

            // SENDO ATRIBUTO PRIVATE, O VALOR É ALTERADO PELO SET 
            p.SetNome("TV 4K");
            Console.ReadKey();
        }
    }
}
