using System;
using System.Globalization;

namespace AdicionaRemoveProduto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o nome produto: ");
            string nome = Console.ReadLine(); // CRIA UMA VARIAVEL AUXILIAR P RECEBER NOME
            
            Console.WriteLine("Digite o preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); // ...PRECO

            // Uma sobrecarga do construtor com 2 argumentos apenas 
            Produto p = new Produto(nome, preco); 
            Console.WriteLine(p);

           // Instanciando o construtor padrão 
           Produto p2 = new Produto();
                        
            Console.WriteLine("Dados do produto: " + p);
                                        
            Console.WriteLine();
            Console.Write("Adionar quantidade de produtos: ");
            int qtde = int.Parse(Console.ReadLine());
                       
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
