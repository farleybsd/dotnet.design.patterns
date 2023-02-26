using AbstractracrFactory._3_Interface_FabricaBase;
using AbstractracrFactory._4__Fabrica_De_Personagens;
using System;

namespace AbstractracrFactory
{
    class Program
    {
        /*
            * Neste Desafio, o cenario sera o StarCraft,o classico jogo de estrategia em tempo real, onde existem tres racas de personagens:
            *  1 - Protoss
            *  2 - Terrano
            *  3 - Zergs
            *  Cada raca tem suas unidades e construcoes Diferentes Porem muito Bem Equiblibragas 
            */
        static void Main(string[] args)
        {
            // Usando A Fabrica de Personagem 
            IFabricaBase fabrica;
            Console.Write("Escolha um dos personagens: 1-Protoss | 2-Zergs | 3-Terranos: ");

            switch (Console.ReadLine())
            {
                case "1":
                    fabrica = new FabricaBaseProtoss();
                    break;
                case "2":
                    fabrica = new FabricaBaseSerg();
                    break;
                case "3":
                    fabrica = new FabricaBaseTerran();
                    break;
            }

            Console.ReadLine();
        }
    }
}
