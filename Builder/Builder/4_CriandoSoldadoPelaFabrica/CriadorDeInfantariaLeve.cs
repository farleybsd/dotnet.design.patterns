using Builder._2_ClassesConcretas;
using Builder._3_FabricaDeSoldados;

namespace Builder._4_CriandoSoldadoPelaFabrica
{
    /*
     * Para cada tipo de soldado iremos implementar sua Classe de Criacao
     */
    public class CriadorDeInfantariaLeve : CriadorDeSoldado
    {
        public CriadorDeInfantariaLeve()
        {
            _soldado = new SoldadoDeInfatariaLeve();
        }
        public override void Arma()
        {
            _soldado.EscolherArmar("Ataque aéreo");
        }
        public override void Transporte()
        {
            _soldado.EscolherTransporte("Helicóptero de ataque do Exército");
        }
        public override void Foco()
        {
            _soldado.DefinirFoco("resposta rápida aérea");
        }
    }
}
