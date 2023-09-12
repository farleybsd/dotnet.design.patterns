
using ChatJogadores._01;
using ChatJogadores._03;

namespace ChatJogadores._02
{
    public class Jogador1 : Jogador
    {
        public Jogador1(Mediador mediador) : base(mediador) { }

        public void Enviar(string mensagem)
        {
            mediador.Enviar(mensagem, this);
        }

        public void Notificar(string mensagem)
        {
            Console.WriteLine("Mensagem do Jogador 1: " + mensagem);
        }
    }
}
