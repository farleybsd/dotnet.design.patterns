using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Abstract
{
    // AbstractProduct 
    public abstract class Guincho
    {
        public EPorte Porte { get; set; }
        protected Guincho(EPorte porte)
        {
            this.Porte = porte;
        }

        public abstract void Socorrer(Veiculo veiculo);
    }
}
