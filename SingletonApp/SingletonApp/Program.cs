namespace SingletonApp
{
    internal class Program
    {
        /*
         *  O padrao Singletom tem o o seu prososito de criacao e seu escopo e de objeto
         *  Objetivo desse padrao e garantir que apenas uma unica instancia de um objeto seja criada
         */
        static void Main(string[] args)
        {
            /******************** DESAFIO ***************************************
             * 
             *  Desasafio 1 controlar o acesso as instancias da classe, garantindo que um objeto seja 
             *  instanciado apenas uma unica Vez
             *  
             *  Desafio 2 Reduzir a ultilizacao de memoria 
             *  
             *  Desafio 3 Fornecer flexibilidade  para as estruturas instanciar Objetos
             *  
             *  Cenario Iremos usar um jogo de futebol onde a regra e apenas uma unica  bola em campo
             *  indepedente da quantidade de jogadores todos acessam a mesma  bola
             */
            Singleton jogador_1 = Singleton.GetInstancia;
            jogador_1.Mensagem("Jogador 1: A bola está comigo no meio do campo.");

            Singleton jogador_2 = Singleton.GetInstancia;
            jogador_2.Mensagem("Jogador 2: recebeu a bola.");

            Singleton jogador_3 = Singleton.GetInstancia;
            jogador_3.Mensagem("Jogador 3: recebeu o lançamento na linha de fundo.");

            Console.ReadKey();
        }
    }
}