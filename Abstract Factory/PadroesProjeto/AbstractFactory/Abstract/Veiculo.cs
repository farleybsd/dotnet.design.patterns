using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Abstract
{
    // AbstractProduct  
    public abstract class Veiculo
    {
        public string Modelo { get; set; }
        public EPorte Porte { get; set; }
        protected Veiculo(string modelo,EPorte porte)
        {
            this.Modelo = modelo;
            this.Porte = porte;
        }
    }
}
