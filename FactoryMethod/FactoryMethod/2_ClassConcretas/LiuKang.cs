using FactoryMethod._1_Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod._2_ClassConcretas
{
    /*
     *  Ira implementar o metodo Escolhido que descreve o nome do personagem na tela 
     */
    public class LiuKang : IPersonagem
    {
        public void Escolhido()
        {
            Console.Write("Liu Kang");
        }
    }
}
