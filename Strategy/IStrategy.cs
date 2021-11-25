using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    //A interface Strategy declara operações comuns a todas as suportadas
    //versões de algum algoritmo O Contexto usa essa interface para chamar o algoritmo definido por Concrete Estratégias.
    public interface IStrategy
    {
        object DoAlgorithm(object data);
    }
   // Estratégias concretas implementam o algoritmo seguindo a baseInterface de estratégia.A interface os torna intercambiáveis no Contexto.
}
