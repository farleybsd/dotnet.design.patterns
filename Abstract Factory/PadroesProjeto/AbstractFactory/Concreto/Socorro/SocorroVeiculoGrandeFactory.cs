using AbstractFactory.Abstract;
using AbstractFactory.Creators;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Concreto.Socorro
{
    public class SocorroVeiculoGrandeFactory : AutoSocorroFactory
    {
        public override Guincho CriarGuincho()
        {
            return GuinchoCreator.Criar(EPorte.Grande);
        }

        public override Veiculo CriarVeiculo(string modelo, EPorte porte)
        {
            return VeiculoCreator.Criar(modelo, porte);
        }
    }
}
