using Composite._2__Implementacao;

namespace Composite
{
    internal class Program
    {
        /*
             * Quando voce ouvir sobre Design Pattern Composite pense em  uma Arvore 
             * Pois e exatamente essa a representacao hierarquica que esse padrao 
             * estabelece uma vez,que bem como uma arvore e possivel trabalhar com objetos
             *  individuais (nos) ou grupo de objetos Galhos
             */
        static void Main(string[] args)
        {
            /* HORA DO DESAFIO
             *  O classico Super Mario World e composto de varias fases e de mapas diferentes
             *  Cada fase segue o tema do mapa, como fases aquaticas.florestas,caverna etc..
             *  A cada fase que o jogador conclui novas fases sao liberadas no mapa para que
             *  Possamos continuar desbravando o jogo ate o seu final
             */


            /* Usando o Pattern*/
            Composite mapa = new Composite("MAPA DAS CAVERNAS");

            Composite caverna1 = new Composite("Caverna 1");
            caverna1.Adicionar(new FaseJogo("Sub Fase 1"));
            caverna1.Adicionar(new FaseJogo("Sub Fase 2"));
            caverna1.Adicionar(new FaseJogo("Sub Fase 3"));

            Composite caverna2 = new Composite("Caverna 2");
            caverna2.Adicionar(new FaseJogo("Sub Fase 4"));
            caverna2.Adicionar(new FaseJogo("Sub Fase 5"));

            Composite porta_secreta = new Composite("Porta Secreta");
            porta_secreta.Adicionar(new FaseJogo("Sub Fase Secreta X"));

            mapa.Adicionar(caverna1);
            mapa.Adicionar(caverna2);
            caverna2.Adicionar(porta_secreta);

           

            mapa.Mostrar(1);

            Console.ReadKey();
        }
    }
}