using System;
using System.Globalization;
namespace AdicionaRemoveProduto
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto();

            Console.WriteLine("Digite o nome produto: ");
            p.Nome = Console.ReadLine();

            Console.WriteLine("Digite o preço: ");
            p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Digite a quantidade no estoque: ");
            p.Quantidade = int.Parse(Console.ReadLine());

            // Ou p.ToString(). p Concatena com string e chama a funçao ToString automaticamente
            Console.WriteLine("Dados do produto: " + p);

            Console.WriteLine();
            Console.Write("Adionar quantidade de produtos: ");
            int qtde = int.Parse(Console.ReadLine());

            // funçao soma valor atual + entrada do objeto
            p.AdicionarProdutos(qtde);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados " + p);

            Console.WriteLine();
            Console.Write("Remover produtos: ");
            int qtdeRemover = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qtdeRemover);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados " + p);

            Console.ReadKey();
        }
    }
}
