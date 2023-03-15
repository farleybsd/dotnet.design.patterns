using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter._3.Adaptee
{
    /*
     *  Adaptee : Define uma interface existente que necessita ser adaptada
     */
    public class Aviao
    {
        public void Voar(string personagem)
        {
            Console.WriteLine(personagem + " VOOU PARA FRENTE!");
        }

        public void SoltarMissil()
        {
            Console.WriteLine("Soltou um míssil no jogo!");
        }
    }
}
