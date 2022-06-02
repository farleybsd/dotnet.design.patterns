using AbstractFactory.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Concreto.GuinchoConcret
{
    // Produto Concreto
    public class GuinchoPequeno : Guincho
    {
        public GuinchoPequeno(EPorte porte) : base(porte) { }

        public override void Socorrer(Veiculo veiculo)
        {
            // Processo de socorro
            Console.WriteLine("Socorrendo Carro Pequeno - Modelo " + veiculo.Modelo);
        }
    }
}
