using StrategyPatern._1._Strategy;
using StrategyPatern._2._ConcreteStrategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPatern._3._Context
{
    public class Sapo : IAjuda
    {
        public string Ajudar(Ajuda pedido)
        {
            return "Sou um sapo e posso ajudar você a pular bem alto!";
        }
    }
}
