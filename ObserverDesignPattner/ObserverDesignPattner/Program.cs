using ObserverDesignPattner._3.Concret_Subject;
using ObserverDesignPattner._4._Concret_Observer;

namespace ObserverDesignPattner
{
    /*  Designer Pattener Observer e um padrao de projeto comportamental, cujo o escopo e de objeto
     *  Esse padrao permite que os objetos sejam informados sobre a mudanca ocorridas em outros objetos
     *  Participantes
     *  
     *  =>>> Subject :
     *          - Conhece seus observadores (Producer)
     
     *  =>>>> Observer (Consumer)
     *          - Define uma interface de atualizacao para objetos que deveriam ser notificados 
     *          - sobre a mudanca de um subject (Producer )
               
     *  =>>>>> Concret Subject :
     *          - Armazena estados de interesse para objetos ConcreteObserver
     *          - Envia uma notificacao para seus observadores quando seu estado Muda
               
     *  =>>>>>>> Concret Observer :
     *           - Mantem uma referencia para um objeto ConcretSubjet 
     *           - Armazena estados que deveriam permanecer consistentes
     *           - Implementa a interface de atualizacao de Observer, para manter seu estado consistente
     *           com o subject
     *           
     *           Observacao:
     *           -referencia cruzada o subject referencia o obserer
     *           -Obserser referencia o subject 
     */
    internal class Program
    {
        /* Desafio
         *  Iremos usar o exemplo do jogo Final Fight aonde quando cada personagem 
         *  Recebe um golpe sua barrinha de vida e dimiuida
         * 
         */
        static void Main(string[] args)
        {
            Cody cody = new Cody();
            Inimigo inimigo1 = new Inimigo(cody);
            Inimigo inimigo2 = new Inimigo(cody);
            Inimigo inimigo3 = new Inimigo(cody);
            while (true)
            {
                Console.WriteLine("Acertar o Cody com um golpe (S ou N)?");

                if (Console.ReadLine() == "s")
                    cody.Golpe_Acertado(true);
                else
                    Console.WriteLine("Você não acertou o Cody!");
            }
        }
    }
}