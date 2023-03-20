namespace xadrex_console_project.tabuleiro
{
    abstract class Peca
    {
        public Posicao Posicao { get; set; }
        public Cor Cor { get; protected set; }
        public int quantidadeMovimentos { get; protected set; }
        public Tabuleiro Tab { get; protected set; }

        public Peca(Cor cor, Tabuleiro tab)
        {
            Posicao = null;
            Cor = cor;
            Tab = tab;
            this.quantidadeMovimentos = 0;
        }

        public void IncrementarQuantidadeMovimentos()
        {
            quantidadeMovimentos++;
        }

        public abstract bool[,] MovimentosPosiveis();
    }
}
