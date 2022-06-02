using AbstractFactory.Abstract;
using AbstractFactory.Concreto.Socorro;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Client
{
    // Client Class
    public class AutoSocorro
    {
        private readonly Veiculo _veiculo;  // Classes Abstradas
        private readonly Guincho _guincho; // Classes Abstradas

        public AutoSocorro(AutoSocorroFactory factory,Veiculo veiculo)
        {
            _veiculo = factory.CriarVeiculo(veiculo.Modelo,veiculo.Porte);
            _guincho = factory.CriarGuincho();
        }

        public void RealizarAtendimento()
        {
            _guincho.Socorrer(_veiculo);
        }

        public static AutoSocorro CriarAutoSocorro(Veiculo veiculo)
        {
            switch (veiculo.Porte)
            {
                case EPorte.Pequeno:
                    return new AutoSocorro(new SocorroVeiculoPequenoFactory(), veiculo);
                case EPorte.Medio:
                    return new AutoSocorro(new SocorroVeiculoMedioFactory(),veiculo);
                case EPorte.Grande:
                    return new AutoSocorro(new SocorroVeiculoGrandeFactory(), veiculo);
                default:
                    throw new ApplicationException("Não foi possível identificar o veículo");
            }
        }
    }
}
// SocorroVeiculoPequenoFactory - Concrete Factory