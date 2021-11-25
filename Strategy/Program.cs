using System;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            //O código do cliente escolhe uma estratégia concreta e passa para o
            //contexto.O cliente deve estar ciente das diferenças entre
            //estratégias a fim de fazer a escolha certa.

            var context = new Context();
            Console.WriteLine("Client: Strategy is set to normal sorting.");
            context.SetStrategy(new ConcreteStrategyA());
            context.DoSomeBusinessLogic();

            Console.WriteLine();

            Console.WriteLine("Client: Strategy is set to reverse sorting.");
            context.SetStrategy(new ConcreteStrategyB());
            context.DoSomeBusinessLogic();

            Console.ReadKey();
        }
    }
}
