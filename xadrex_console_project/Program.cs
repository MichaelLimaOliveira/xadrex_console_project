﻿using xadrex_console_project.tabuleiro;
using xadrex_console_project.xadrez;

namespace xadrex_console_project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Tabuleiro tab = new Tabuleiro(8, 8);

                tab.ColocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 0));
                tab.ColocarPeca(new Torre(tab, Cor.Preta), new Posicao(1, 3));
                tab.ColocarPeca(new Rei(tab, Cor.Preta), new Posicao(2, 4));

                Tela.impromirTabuleiro(tab);
            }
            catch (TabuleiroException e)
            {

                Console.WriteLine(e.Message);
            }
        }
    }
}