using System;
using tabuleiro;
using xadrez;

namespace Xadrez_console
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Tabuleiro tab = new Tabuleiro(8, 8);

                tab.colocaPeca(new Torre(tab, Cor.Preta), new Posicao(0, 0));
                tab.colocaPeca(new Torre(tab, Cor.Preta), new Posicao(1, 9));
                tab.colocaPeca(new Rei(tab, Cor.Preta), new Posicao(0, 2));

                Tela.ImprimirTabuleiro(tab);
            }
            catch(TabuleiroException ex)
            {
                Console.WriteLine(ex.Message);
            }

            
                  
        }
    }
}
