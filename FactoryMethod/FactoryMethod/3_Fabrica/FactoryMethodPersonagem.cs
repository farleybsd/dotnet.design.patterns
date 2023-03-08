using FactoryMethod._1_Interface;
using FactoryMethod._2_ClassConcretas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod._3_Fabrica
{
    /*
     * Agora Iremos criar a classe FactoryMethod que e responsavel por indetificar que tipo
     * De classe deve ser instanciada baseada no personagem escolhido
     * De acordo com o personagem indetificado ira retornar a classe correta
     */

    public class FactoryMethodPersonagem
    {
        public IPersonagem EscolherPersonagem(string personagem)
        {
            switch (personagem)
            {
                case "Liu Kang": return new LiuKang();
                case "SubZero": return new SubZero();
                case "Scorpion": return new Scorpion();
                default: return null;
            }
        }
    }
}
