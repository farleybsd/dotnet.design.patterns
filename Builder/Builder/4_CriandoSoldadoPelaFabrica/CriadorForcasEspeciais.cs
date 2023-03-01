using Builder._2_ClassesConcretas;
using Builder._3_FabricaDeSoldados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder._4_CriandoSoldadoPelaFabrica
{
    /*
     * Para cada tipo de soldado iremos implementar sua Classe de Criacao
     */
    public class CriadorForcasEspeciais : CriadorDeSoldado
    {
        public CriadorForcasEspeciais()
        {
            _soldado = new SoldadoDeForcaEspeciais();
        }
        public override void Arma()
        {
            _soldado.EscolherArmar("Fuzil");
        }
        public override void Transporte()
        {
            _soldado.EscolherTransporte("Carro de operações especiais");
        }
        public override void Foco()
        {
            _soldado.DefinirFoco("combate em solo");
        }
    }
}
