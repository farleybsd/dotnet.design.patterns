using Adapter._1.Alvo;
using Adapter._3.Adaptee;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter._4.Adapter
{
    /*
     * Adapter : Adapta a interface do Adaptee a interface Alvo
     */
    public class Adaptter : IAcao
    {
        Aviao aviao;

        public Adaptter(Aviao novo_aviao)
        {
            this.aviao = novo_aviao;
        }

        public void Andar(string jogador)
        {
            this.aviao.Voar("Rodrigo");
        }

        public void Atirar()
        {
            this.aviao.SoltarMissil();
        }
    }
}
