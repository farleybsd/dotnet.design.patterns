using Builder._3_FabricaDeSoldados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder._5_OrquestradorDeExercicito
{
    /*
     *  Finalmente podemos criar nossa Classe que fica responsavel por criar
     *  o Exercito de Batalha 
     */
    public class Exercito
    {
        public void ConstruirSoldado(CriadorDeSoldado criadorDeSoldado)
        {
            criadorDeSoldado.Arma();
            criadorDeSoldado.Transporte();
            criadorDeSoldado.Foco();
        }
    }
}
