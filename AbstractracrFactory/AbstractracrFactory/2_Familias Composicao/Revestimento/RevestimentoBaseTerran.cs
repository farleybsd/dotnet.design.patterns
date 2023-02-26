using AbstractracrFactory.Interfaces___Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractracrFactory.Familias_Composicao.Revestimento
{
    /*
     *  Seguindo a mesma linha de raciocinio agora iremos a implementacao da interface de revestimento
     *  definindo a particularidade de cada revestimento das bases de cada raca de personagem.
     */
    public class RevestimentoBaseTerran : IRevestimento
    {
        public void Composicao()
        {
            Console.WriteLine("Base revestida pela cor verde");
        }
    }
}
