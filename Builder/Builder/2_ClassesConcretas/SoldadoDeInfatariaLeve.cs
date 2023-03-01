using Builder._1_RepresentarUmSoldado;

namespace Builder._2_ClassesConcretas
{
    /*
     * Implementacao de Tipos de soldados para as Classes:
     * - SoldadoDeInfataria
     * - SoldadoDeForcasEspeciais
     */
    public class SoldadoDeInfatariaLeve : Soldado
    {
        public override void EscolherArmar(string arma)
        {
            Arma = arma;
        }
        public override void EscolherTransporte(string transporte)
        {
            Transporte= transporte; 
        }
        public override void DefinirFoco(string foco)
        {
            Foco= foco; 
        }
    }
}
