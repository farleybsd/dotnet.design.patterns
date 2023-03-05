using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite._1_Abstracao
{
    /*
     *  Primeiro, vamos criar uma classe abastrata que sera herdada pelas fases do nosso jogo
     *  que terao nome e metodos para permitir: 
     *  - Adicionar
     *  - Remover
     *  - Mostrar
     */
    public abstract class ComponenteFase
    {
        protected string nome;

        public ComponenteFase(string nome)
        {
            this.nome = nome;
        }

        public abstract void Adicionar(ComponenteFase c);
        public abstract void Remover(ComponenteFase c);
        public abstract void Mostrar(int profundidade);
    }
}
