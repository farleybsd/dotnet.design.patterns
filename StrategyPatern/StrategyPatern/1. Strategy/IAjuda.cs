using StrategyPatern._2._ConcreteStrategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPatern._1._Strategy
{
    public interface IAjuda // Estrategia 
    {
        string Ajudar(Ajuda pedido);
    }
}
