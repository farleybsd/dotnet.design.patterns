using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter._1.Alvo
{
    /*
     *  Iremos definir os dois metodos que sera Andar e Atirar (Alvo)
     *  Alvo : define a interface escefica do dominio que o cliente usa
     */
    public interface IAcao
    {
        void Andar(string jogador);
        void Atirar();
    }
}
