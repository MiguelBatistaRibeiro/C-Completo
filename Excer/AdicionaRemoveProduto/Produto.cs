using System.Globalization;

namespace AdicionaRemoveProduto
{
    class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        // Um construtor padrão inicializando Quantidade = 0;
        public Produto()
        {
            Quantidade = 0;
        }
        // Com : this() referencia construtor padrao que inciciou valor 'Quantidade'
        public Produto(string nome, double preco) : this()
        {
            Nome = nome;
            Preco = preco;
        }
        // Da mesma forma usa o construtor acima que contém Nome = nome e Preco = preco
        public Produto(string nome, double preco, int quantidade) : this(nome, preco)
        {
            Quantidade = quantidade;
        }
        public double ValorTotalEstoque()
        {
            return Preco * Quantidade;
        }
        public void AdicionarProdutos(int quantidade)
        {   
            Quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade)
        {   
            Quantidade -= quantidade;
        }
        public override string ToString()
        {
            return Nome
              + ", $ "
              + Preco.ToString("F2", CultureInfo.InvariantCulture)
              + ", "
              + Quantidade
              + " unidades, Total: $ "
              + ValorTotalEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}

