using Adapter._1.Alvo;
using Adapter._2.Cliente;
using Adapter._3.Adaptee;

namespace Adapter
{
    /*
     *  Converter a interface de uma classe em outra interface,esperada pelos clientes.
     *  O Adapter permite que classes interfaces incompativeis  trabalher em conjuto.
     *  Algumas vezes,uma classe de um tookit, projetada para ser reutilizada nao e reutilizavel
     *  porque sua interface  nao corresponde a interface especifica de um domin
     *  ************************** Participantes ******************************
     *  => Alvo : define a interface escefica do dominio que o cliente usa
     *  => Cliente : Colabora com os objetivos compativeis  com a interface alvo
     *  => Adaptee : Define uma interface existente que necessita ser adaptada
     *  => Adapter : Adapta a interface do Adaptee a interface Alvo
     *  Ou seja o Adpter atua como intermediador, tal como um adaptador e um intermediario entre
     *  tomadas de energia de padroes de pinos Diferentes
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            /************DESAFIO********
             *  Vamos implementar o jogo o jogo Metal Slug. O personagem pode tanto caminhar pelas fases
             *  quanto ultilizar o veiculo de combate, mudando os comandos do jogo. Desafio sera que os
             *  mesmos comandos funcionem quando o personagem  estiver em um veiculo ou em um aviao
             *  exemplo andar tanto o personagem estiver em um aviao ou um veiculo
             */

            Personagem rodrigo = new Personagem();
            Aviao aviao_de_batalha = new Aviao();

            IAcao adaptador = new _4.Adapter.Adaptter(aviao_de_batalha);

            Console.WriteLine("--- CAMINHANDO ---");
            rodrigo.Andar("Rodrigo");
            rodrigo.Atirar();

            Console.WriteLine();

            Console.WriteLine("--- PEGOU UM AVIÃO NO JOGO ---");
            adaptador.Andar("Rodrigo");
            adaptador.Atirar();

            Console.ReadKey();

        }
    }
}