using xadrex_console_project.tabuleiro;
using xadrex_console_project.xadrez;

namespace xadrex_console_project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                PartidaDeXadrez partida = new PartidaDeXadrez();

                Tela.impromirTabuleiro(partida.Tab);
            }
            catch (TabuleiroException e)
            {

                Console.WriteLine(e.Message);
            }

            Console.ReadLine();
        }
    }
}