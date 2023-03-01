using Builder._1_RepresentarUmSoldado;
using Builder._3_FabricaDeSoldados;
using Builder._4_CriandoSoldadoPelaFabrica;
using Builder._5_OrquestradorDeExercicito;

namespace Builder;
class Program
{
    /* Esse padrao de dessenvolvimento pode ser ultilizado na construcao de objetos
       * complexos, com uma abordagem de dessenvolvimento "POR PARTES"
       * De acordo com o Gof o objetivo Desse padrao e "- separar a construcao de um objeto complexo
       * da sua representacao de modo que o mesmo processo de construcao possa criar diferentes
       * Representacaoes"
       */

    /*************************************DESAFIO***********************************/

    /*
     * Vamos implementar o famoso jogo medalha de Honra
     * Como qualquer jogo de guerra existe diversos tipos de soldados que compoem um exercito
     * como soldados de forcas especiais que atacam pelo solo e pilotos que atacam de aviao
     * O nosso objetivo e Criar um exercicito inteiro para batalha
     */
    static void Main(string[] args)
    {
        // Usando o Design Builder 
        var exercito = new Exercito();
        CriadorDeSoldado criadorDeSoldado;
        Soldado soldado;

        // criando um soldado das Forças Especiais
        criadorDeSoldado = new CriadorForcasEspeciais();
        exercito.ConstruirSoldado(criadorDeSoldado);
        soldado = criadorDeSoldado.ObterSoldado();
        Console.WriteLine("Soldado com as características: {0}, {1}, {2}",
                    soldado.Arma, soldado.Transporte, soldado.Foco);

        // criando o soldado de Infantaria Leve 
        criadorDeSoldado = new CriadorDeInfantariaLeve();
        exercito.ConstruirSoldado(criadorDeSoldado);
        soldado = criadorDeSoldado.ObterSoldado();
        Console.WriteLine("Soldado com as características: {0}, {1}, {2}",
                soldado.Arma, soldado.Transporte, soldado.Foco);

        Console.ReadKey();
    }
}