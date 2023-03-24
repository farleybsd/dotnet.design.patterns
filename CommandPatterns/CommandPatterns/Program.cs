using CommandPatterns._2.ConcreteCommand;
using CommandPatterns._3.Receiver;
using CommandPatterns._4.Ciente;
using CommandPatterns._5.Invoker;

namespace CommandPatterns
{

    /* Encapsular uma solitiacao como um objeto,desta forma permitindo parametrizar
     * clientes com diferentes solitacoes, enfileirar ou fazer registro de log de solicitacoes 
     * e suportar operacoes que podem ser desfeitas 
     * A chave desse padrao e uma classe abstrada Command, a qual declara uma interface para execultar
     * operacoes  e as Claseses concretas de Command e um receptor
     
        ====================== Participantes ===========================
    * 1.Command
        - Declara uma interface para Ececucao de uma operacao

    * 2.ConcreteCommand
        - Define uma vinculacao entre um objeto Receiver e uma acao
        - Implementa Execulta atraves de invoacaoes dos correspodentes operacoes no (Recepetores)

    * 3.Ciente (Aplliacation)
        - Cria um objeto ConcreteCommand e estabelece seu receptor

    * 4.Invoker 
        - Solitica ao Command a execucao da solicitacao

    * 5.Receiver
        - Sabe como execultar as operacoes associadas a uma solicitacao
        - Qualquer Classe pode funcionar como Receiver 

    Soliciante => Classe Controle => Comando
     */

    internal class Program
    {
        static void Main(string[] args)
        {
            /* Hora do Desafio 
             *  Dessenvolver um Controle Remoto  que permita enviar solicitacoes para um 
             *  robo execultar algumas Funcoes  sem que a pessoa que esta ultilizado o controle remoto
             *  precise conhecer o robo 
             */

            Controle controle= new Controle();

            controle.EnviarComandoSimples(new SimplesComando("Dizer Oi!"));

            Receiver receiver = new Receiver();
            controle.EnviarComandoComplexo(new ComplexoComando(receiver, "Abastecer o carro", "Calibrar os pneus do carro"));

            controle.Fazer();
            Console.ReadKey();
        }
    }
}