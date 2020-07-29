using System.Globalization;

namespace AdicionaRemoveProduto
{
    class Produto
    {
        // PUBLIC NOS ATRIBUTOS, PORÉM PRIVATE NO ACESSADOR SET - NÃO PERMITE ALTERAÇÃO
        public string Nome { get; private set; }
        public double Preco { get; private set; }
        public int Quantidade { get; private set; }

        public Produto(string nome, double preco, int quantidade) 
        {
            Nome = nome;
            Preco = preco;
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

