using AbstractFactory.Abstract;
using AbstractFactory.Concreto.GuinchoConcret;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Creators
{
    public class GuinchoCreator
    {
        public static Guincho Criar(EPorte porte)
        {
            switch (porte)
            {
                case EPorte.Pequeno:
                    return new GuinchoPequeno(porte);
                case EPorte.Medio:
                    return new GuinchoMedio(porte);
                case EPorte.Grande:
                    return new GuinchoGrande(porte);
                default:
                    throw new ApplicationException("Porte de Guincho desconhecido.");
            }
        }
    }
}
