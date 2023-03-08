using FactoryMethod._1_Interface;
using FactoryMethod._3_Fabrica;
namespace FactoryMethod
{
    internal class Program
    {
        /*
         *  Definir um interface para criar um objeto,mas deixa as subclasses decidirem que classe
         *  instaciar
         *  Responsavel pela manufatura de um objeto 
         *  Para que isso aconteca o FactoryMethod dispoe de uma interface, e sao subclasses que
         *  decidiram qual classe concreta devera ser istanciada 
         */
        static void Main(string[] args)
        {
            /*
             *  O nosso desafio sera o classico dos jogos de luta motal combate
             *  Esse jogo possui varios personagens disponiveis para ser escolhido
             *  Mas apenas um persongem pode ser escolhido por vez 
             */

            FactoryMethodPersonagem fm = new FactoryMethodPersonagem();

            Console.WriteLine("Liu Kang | SubZero | Scorpion");
            Console.WriteLine();

            Console.Write("Escolha seu Personagem: ");
            string escolha = Console.ReadLine();

            IPersonagem personagem = fm.EscolherPersonagem(escolha);
            Console.WriteLine();
            Console.Write("Você vai jogar com ");
            personagem.Escolhido();


            Console.ReadKey();
        }
    }
}