using AbstractracrFactory._3_Interface_FabricaBase;
using AbstractracrFactory.Familias_Composicao.Energia;
using AbstractracrFactory.Familias_Composicao.Revestimento;
using System;

namespace AbstractracrFactory._4__Fabrica_De_Personagens
{
    /*
    * Responsavel para criar a base de acordo com o personagem solicitado dinamicamente. 
    * Cada Personagem Tera sua Fabrica 
    */
    public class FabricaBaseSerg : IFabricaBase
    {
        public FabricaBaseSerg()
        {
            CriarBase();
        }
        public void CriarBase()
        {
            Console.WriteLine("Base Zerg criada com sucesso!");

            RevestimentoBaseZerg revestimento = new RevestimentoBaseZerg();
            revestimento.Composicao();

            EnergiaBaseZerg energia = new EnergiaBaseZerg();
            energia.Composicao();
        }
    }
}
