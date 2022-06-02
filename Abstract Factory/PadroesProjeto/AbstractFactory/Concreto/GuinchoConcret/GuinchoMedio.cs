using AbstractFactory.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Concreto.GuinchoConcret
{
    // Produto Concreto
    public class GuinchoMedio :Guincho
    {
        public GuinchoMedio(EPorte porte):base(porte){}

        public override void Socorrer(Veiculo veiculo)
        {
            // Processo de socorro
            Console.WriteLine("Socorrendo Carro Medio - Modelo " + veiculo.Modelo);
        }
    }
}
