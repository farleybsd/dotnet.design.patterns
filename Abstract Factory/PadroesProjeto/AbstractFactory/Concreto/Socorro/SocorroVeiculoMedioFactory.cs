using AbstractFactory.Abstract;
using AbstractFactory.Creators;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Concreto.Socorro
{
    public class SocorroVeiculoMedioFactory : AutoSocorroFactory
    {
        public override Guincho CriarGuincho()
        {
            return GuinchoCreator.Criar(EPorte.Medio);
        }

        public override Veiculo CriarVeiculo(string modelo, EPorte porte)
        {
            return VeiculoCreator.Criar(modelo, porte);
        }
    }
}
