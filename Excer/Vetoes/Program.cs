using System;
using System.Collections.Specialized;
using System.Globalization;
using Vetoes;

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



            // Fazer um programa para ler um numero inteiro N e os dados (nome e preço) de N Produtos. Armazene
            // os N produtos em um vetor. Em seguida, mostrar o preço médio dos produtos.
            Console.WriteLine("ENTRE COM O TAMANHO DA LISTA DE PRODUTOS: ");
            int qtdProdutos = int.Parse(Console.ReadLine());

            // cria vetor produto recebendo o numeroProdutos
            Produto[] vetProd = new Produto[qtdProdutos];

            for (int i = 0; i < qtdProdutos; i++)
            {
                // A cada chec, pede o nome e preco e insere no vetor produto
                Console.WriteLine("Insira o nome do Produto: ");
                string nome = Console.ReadLine();

                Console.WriteLine("Insira o preço : ");
                double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                // inicializa as variaveis como n
                vetProd[i] = new Produto { Nome = nome, Preco = preco };
            }
            double soma = 0.0;
            for (int i = 0; i < qtdProdutos; i++)
            {
                soma += vetProd[i].Preco;
            }

            double mediaProd = sum / qtdProdutos;
            Console.WriteLine($"A média dos preços é {mediaProd.ToString("F2", CultureInfo.InvariantCulture)}");

            Console.ReadKey();
        }
    }
}
