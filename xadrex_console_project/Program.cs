using xadrex_console_project.tabuleiro;

namespace xadrex_console_project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tabuleiro tab = new Tabuleiro(8, 8);

            Tela.impromirTabuleiro(tab);
        }
    }
}