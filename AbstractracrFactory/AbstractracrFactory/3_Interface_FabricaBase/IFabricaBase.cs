using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractracrFactory._3_Interface_FabricaBase
{
    /*
     *  Agora que temos os elementos que compoem  uma base no nosso jogo (Energia/Revestimento) com base no comportamento de casa persnagem
     *  Agora Iremos criar nossa fabrica para representar o comportamento da fabrica no jogo sendo a nossa fabrica base
     */
    public interface IFabricaBase
    {
        void CriarBase();
    }
}
