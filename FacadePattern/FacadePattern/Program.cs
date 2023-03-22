using FacadePattern._2__Faxada;

namespace FacadePattern
{
    /*
         * Fornecer uma interface para um conjunto de interfaces em um subsistema
         * Facede define uma interface de nivel mais alto que torna o subsistema mais facil de ser usado
         * Reduz a complexibilidade
         * Reduz a depedencia entre sistemas
         * Fornece uma Interface Unica simplificada para os subsistemas
          
            ================== PARTICIPANTES ========
        
          ====================> Faxada
         * Conhece quais as classes do subsistemas sao responsaveis pelo entedimento de uma solicitacao
         * Delega soliticacoes de clientes e objetos apropiados do subsistema
         
         ====================> Clases de Subsistema  
         *  Implenetam a funcionalidade do subistema
         *  encarregam-se do trabalho atribuido a elas pelo objeto Facade
         *  Nao  tem conhecimento do objeto Facade
         * 
    */
    internal class Program
    {
        /*
         * DESAFIO 
         * Criar uma estrutura que oculte como as operacoes internas sao execultadas
         * permitindo que o centro de controle apens mande Execultala
         */
        static void Main(string[] args)
        {
            Facade facade = new Facade();
            facade.OperacaoA();
            facade.OperacaoB();

            Console.ReadKey();
        }
    }
}