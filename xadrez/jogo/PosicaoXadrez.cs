using tabuleiro;

namespace xadrez.jogo {
    class PosicaoXadrez {

        public char coluna { get; set; }
        public int linha { get; set; }

        public PosicaoXadrez(char coluna, int linha) {
            this.coluna = coluna;
            this.linha = linha;
        }

        public Posicao toPosicao() {
            return new Posicao(8 - linha, coluna - 'a'); //se coluna for 'a' vira 0, se for 'b' vira 1, etc
        }

        public override string ToString() {
            return "" + coluna + linha;
        }
    }
}