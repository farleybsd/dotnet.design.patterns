using AbstractFactory.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Concreto
{
    public class VeiculoGrande : Veiculo
    {
        // Produto Concreto
        public VeiculoGrande(string modelo,EPorte porte) : base(modelo,porte)
        {

        }
    }
}
