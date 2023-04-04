using StrategyPatern._2._ConcreteStrategy;
using StrategyPatern._3._Context;

namespace StrategyPatern
{
    internal class Program
    {
        /*
         * Permite que o algoritmo varie indepedente dos clientes que o ultilizam
         * Sao criadas subclasses que implementam as estrategias
         * Permite criar uma classe Flexivel e ter varios comportamentos ora seja sapo outra avestruz 

         *  Strategy(Compositor)
         *      - Define uma interface comum para todos os algoritmos suportados
         *      - Usa essa interface para chamar o Algortimo definido por uma ConcreteStrategy
         
         *  ConcreteStrategy
         *   - Implementa o algoritmo usando a interface de Strategy 
         
         * Context(Composition)
         *  - E configurado como um objeto ConcreteStrategy
         *  - mantem uma referencia para um objeto Strategy
         *  - Pode Definir uma interface que permite a Strategy acessar seus dados
         */
        static void Main(string[] args)
        {
            // Desafio : criar uma classe Flexivel e ter varios comportamentos ora seja sapo outra avestruz 

            var papagaio = new Ajuda(new Papagaio());
            Console.WriteLine(papagaio.Ajudar());

            var sapo = new Ajuda(new Sapo());
            Console.WriteLine(sapo.Ajudar());

            Console.ReadKey();
        }
    }
}