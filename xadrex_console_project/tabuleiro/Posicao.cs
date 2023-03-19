namespace xadrex_console_project.tabuleiro
{
    class Posicao
    {
        public int Linha { get; set; }
        public int Coluna { get; set; }


        public Posicao(int linha, int coluna)
        {
            Linha = linha;
            Coluna = coluna;
        }
    }
}
