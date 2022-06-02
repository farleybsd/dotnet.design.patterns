using AbstractFactory.Abstract;
using AbstractFactory.Concreto;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Creators
{
    public class VeiculoCreator
    {
        public static Veiculo Criar(string modelo,EPorte porte)
        {
            switch (porte)
            {
                case EPorte.Pequeno:
                    return new VeiculoPequeno(modelo,porte);
                case EPorte.Medio:
                    return new VeiculoMedio(modelo,porte);
                case EPorte.Grande:
                    return new VeiculoGrande(modelo,porte);
                default:
                    throw new ApplicationException("Porte de veiculo desconhecido.");
            }
        }
    }
}
