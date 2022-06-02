using AbstractFactory;
using AbstractFactory.Abstract;
using AbstractFactory.Client;
using AbstractFactory.Creators;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace TestsAbstractFactory
{
    public class AbstractFactoryTests
    {
        [Fact]
        public void Execultar()
        {
            var veiculosSocorro = new List<Veiculo>
            {

                VeiculoCreator.Criar("Celta",EPorte.Pequeno),
                VeiculoCreator.Criar("Jetta",EPorte.Medio),
                VeiculoCreator.Criar("BMW X6",EPorte.Grande)

            };

            veiculosSocorro.ForEach(v => AutoSocorro.CriarAutoSocorro(v).RealizarAtendimento());
            
        }
    }
}
