using System;
using tabuleiro;
using xadrez.jogo;

namespace xadrez {
    class Program {
        static void Main(string[] args) {
            PartidaDeXadrez partida = new PartidaDeXadrez();
            Tela.imprimirTabuleiro(partida.tab);

            Console.ReadLine();
        }
    }
}
