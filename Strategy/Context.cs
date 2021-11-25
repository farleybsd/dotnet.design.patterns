using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class Context
    {
        //O Contexto mantém uma referência a um dos objetos da Estratégia.O
        //O contexto não conhece a classe concreta de uma estratégia.Deveria
        //trabalhar com todas as estratégias através da interface Estratégia.
        private IStrategy _strategy;

        public Context(){}

        //Normalmente, o Contexto aceita uma estratégia através do construtor, mas
        //também fornece um setter para alterá-lo no tempo de execução.
        public Context(IStrategy strategy)
        {
            this._strategy = strategy;
        }

        //Normalmente, o Contexto permite substituir um objeto De estratégia no tempo de execução.
        public void SetStrategy(IStrategy strategy)
        {
            this._strategy = strategy;
        }

        //O Contexto delega algum trabalho para o objeto Estratégia em vez de
        //implementando várias versões do algoritmo por conta própria.
        public void DoSomeBusinessLogic()
        {
            Console.WriteLine("Context: Classificação de dados usando a estratégia (não sei como ele vai fazê-lo)");

            var result = this._strategy.DoAlgorithm(new List<string> { "a", "b", "c", "d", "e" });

            string resultStr = string.Empty;

            foreach (var element in result as List<string>)
            {
                resultStr += element + ",";
            }

            Console.WriteLine(resultStr);
        }
    }
}
