using AbstractracrFactory.Interfaces___Base;
using System;

namespace AbstractracrFactory.Familias_Composicao.Revestimento
{
    /*
    *  Como Fizemos Com a interface IEnergia para cada personagem Iremos Fazer o mesmo para Revestimento
    */
    public class RevestimentoBaseZerg : IRevestimento
    {
        public void Composicao()
        {
            Console.WriteLine("Base revestida pela cor vermelha");
        }
    }
}
