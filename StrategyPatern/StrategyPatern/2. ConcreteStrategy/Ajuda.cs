using StrategyPatern._1._Strategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPatern._2._ConcreteStrategy
{
    public class Ajuda
    {
        private IAjuda _IAjuda;
        public Ajuda(IAjuda IAjuda)
        {
            _IAjuda = IAjuda;
        }

        public string Ajudar()
        {
            return _IAjuda.Ajudar(this);
        }
    }
}
