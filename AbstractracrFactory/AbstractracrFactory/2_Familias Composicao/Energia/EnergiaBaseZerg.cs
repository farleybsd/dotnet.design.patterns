using AbstractracrFactory.Interfaces___Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractracrFactory.Familias_Composicao.Energia
{
    /*
     *  Energia e Revestimento sao elementos  que compoem uma base em nosso jogo,mas como temos tres racas diferentes de 
     *  personagens precisamos, implementar essas particularidades para cada uma.
     *  Nesse Caso Comecaremos com a Classe EnergiaBaseTerran
     *  Perceba que a classe EnergiaBaseTerran herda da interface IEnergia implementando o metodo Composicao que define a fonte de energia base para 
     *  os Personagens Terran 
     *  Faremos o Mesmo Para as outras Racas
     */
    public class EnergiaBaseZerg : IEnergia
    {
        public void Composicao()
        {
            Console.WriteLine("Energia de sustentação da base pela terra");
        }
    }
}
