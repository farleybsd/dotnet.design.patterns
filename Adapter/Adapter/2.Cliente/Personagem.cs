using Adapter._1.Alvo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter._2.Cliente
{
    /*
     * Cliente : Colabora com os objetivos compativeis  com a interface alvo
     * 
     */
    public class Personagem : IAcao
    {
        public void Atirar()
        {
            Console.WriteLine("Atirou no jogo!");
        }

        public void Andar(string personagem)
        {
            Console.WriteLine(personagem + " ANDOU PARA FRENTE!");
        }
    }
}
