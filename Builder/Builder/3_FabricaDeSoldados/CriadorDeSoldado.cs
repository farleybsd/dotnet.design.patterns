using Builder._1_RepresentarUmSoldado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder._3_FabricaDeSoldados
{
    /*
     * Proximo Passo e construir uma Classe Abstrata que ira fazer construcao dos Soldados
     */
    public abstract class CriadorDeSoldado
    {
        protected Soldado _soldado;

        public Soldado ObterSoldado()
        {
            return _soldado;
        }

        public abstract void Arma();
        public abstract void Transporte();
        public abstract void Foco();
    }
}
