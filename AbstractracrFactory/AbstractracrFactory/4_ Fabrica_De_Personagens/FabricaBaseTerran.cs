using AbstractracrFactory._3_Interface_FabricaBase;
using AbstractracrFactory.Familias_Composicao.Energia;
using AbstractracrFactory.Familias_Composicao.Revestimento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractracrFactory._4__Fabrica_De_Personagens
{
    /*
     * Responsavel para criar a base de acordo com o personagem solicitado dinamicamente. 
     * Cada Personagem Tera sua Fabrica 
     */
    public class FabricaBaseTerran : IFabricaBase
    {
        public FabricaBaseTerran()
        {
            CriarBase();
        }

        public void CriarBase()
        {
            Console.WriteLine("Base Terran criada com sucesso!");

            RevestimentoBaseTerran revestimento = new RevestimentoBaseTerran();
            revestimento.Composicao();

            EnergiaBaseTerran energia = new EnergiaBaseTerran();
            energia.Composicao();
        }
    }
}
