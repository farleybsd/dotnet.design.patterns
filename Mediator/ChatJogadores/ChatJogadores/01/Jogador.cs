using ChatJogadores._03;

namespace ChatJogadores._01
{
    public abstract class Jogador
    {
        protected Mediador mediador;

        public Jogador(Mediador mediador)
        {
            this.mediador = mediador;
        }
    }
}
