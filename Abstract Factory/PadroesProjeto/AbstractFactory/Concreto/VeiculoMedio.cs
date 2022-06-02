using AbstractFactory.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Concreto
{
    // Produto Concreto
    public class VeiculoMedio : Veiculo
    {
        public VeiculoMedio(string modelo,EPorte porte) :base(modelo,porte)
        {

        }
    }
}
