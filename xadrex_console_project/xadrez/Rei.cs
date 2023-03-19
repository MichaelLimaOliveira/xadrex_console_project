using xadrex_console_project.tabuleiro;

namespace xadrex_console_project.xadrez
{
    class Rei : Peca
    {
        public Rei(Tabuleiro tab, Cor cor) : base (cor, tab)
        {

        }

        public override string ToString()
        {
            return "R";
        }
    }
}
