using System.Runtime.InteropServices.WindowsRuntime;

namespace TreinaTudoXadrez.tabuleiro
{
    class Tabuleiro
    {
        public int linhas { get; set; }
        public int colunas { get; set; }
        private Peca[,] Pecas;
        public Tabuleiro(int linhas, int colunas)
        {
            this.linhas = linhas;
            this.colunas = colunas;
            Pecas = new Peca[linhas, colunas];
        }
        public Peca Peca(int linha, int coluna)
        {
            return Pecas[linha, coluna];
        }
        public Peca Peca(Posicao pos)
        {
            return Pecas[pos.linha, pos.coluna];
        }
        public bool existePeca(Posicao pos)
        {
            validaPosicao(pos);
            return Peca(pos) != null;
        }
        public void colocarPeca(Peca p, Posicao pos)
        {
            if (existePeca(pos))
            {
                throw new TabuleiroException("Já existe uma peça nessa posição!");
            }
            Pecas[pos.linha, pos.coluna] = p;
            p.posicao = pos;
        }
        // testar se está dentro do 8,8 - de 0 a 7 é diferente de >= 8
        public bool posicaoValida(Posicao pos)
        {
            if(pos.linha < 0 || pos.linha >= linhas || pos.coluna < 0 || pos.coluna >= colunas)
            {
                return false;
            }   
                // nao precisa de else - return acima corta a excecução 
                return true;
        }
        // se posição não for válida, lança exceção
        public void validaPosicao(Posicao pos)
        {
            if (!posicaoValida(pos))
            {
                throw new TabuleiroException("Posição inválida");
            }
        }
    }
}