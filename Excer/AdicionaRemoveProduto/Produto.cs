using System;
using System.Globalization;

namespace AdicionaRemoveProduto
{
    class Produto
    {
        // PRIVATE IMPEDE ALTERAÇÃO EM PROGRAM > p._quantidade = 0; 
        // ADICIONA E REMOVE APENAS POR AdicionarProdutos() e RemoverProdutos(). DEFAULT PRIVATE '_atributo'
        private string _nome;
        private double _preco;
        private int _quantidade;
       public Produto(string nome, double preco, int quantidade) 
        {
            _nome = nome;
            _preco = preco;
            _quantidade = quantidade;
        }
        // PARA OBTER O VALOR DE _nome
        public string GetNome()
        {
            return _nome;
        }
        // PARA ALTERAR O VALOR DE _nome
        public void SetNome(string nome)
        {
            _nome = nome;
        }
        // PODEMOS APLICAR UMA LÓGICA 
        public void SetNomeLogica(string nome)
        {   
            if (nome != null & nome.Length > 1) {
                _nome = nome;
            }
        }
        public double ValorTotalEstoque()
        {
            return _preco * _quantidade;
        }
        public void AdicionarProdutos(int quantidade)
        {   
            _quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade)
        {   
            _quantidade -= quantidade;
        }
        public override string ToString()
        {
            return _nome
              + ", $ "
              + _preco.ToString("F2", CultureInfo.InvariantCulture)
              + ", "
              + _quantidade
              + " unidades, Total: $ "
              + ValorTotalEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}

