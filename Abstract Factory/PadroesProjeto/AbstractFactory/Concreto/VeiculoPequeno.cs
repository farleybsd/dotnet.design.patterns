using AbstractFactory.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Concreto
{
    // Produto Concreto
    public class VeiculoPequeno : Veiculo
    {
        public VeiculoPequeno(string modelo,EPorte porte) : base(modelo,porte)
        {

        }
    }
}
