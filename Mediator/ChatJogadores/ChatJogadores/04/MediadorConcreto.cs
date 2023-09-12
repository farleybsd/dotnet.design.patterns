using ChatJogadores._01;
using ChatJogadores._02;
using ChatJogadores._03;

namespace ChatJogadores._04
{
    public class MediadorConcreto : Mediador
    {
        private Jogador1 jogador1;
        private JogadorDois jogador2;

        public Jogador1 JogadorUm
        {
            set { jogador1 = value; }
        }

        public JogadorDois JogadorDois
        {
            set { jogador2 = value; }
        }

        public override void Enviar(string mensagem, Jogador jogador)
        {
            if (jogador == jogador2)
                jogador1.Notificar(mensagem);
            else
                jogador2.Notificar(mensagem);
        }
    }
}
