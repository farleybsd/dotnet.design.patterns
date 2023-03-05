using Composite._1_Abstracao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    /*
     *  No objeto Composite,criamos uma Lista que vai armazenar as fases do jogo
     *  No metodo Adicionar e possivel adicionar nova fase, tal como excluir, no metodo remover
     *  Ja o metodo mostrar recebe como parametro a profudindade que vamos incrementar um -
     *  na tela para facilitar a visualizacao da fase esta dentro da cavera
     *  Compositor que chama a implementacao
     */
    public class Composite : ComponenteFase
    {
        private List<ComponenteFase> fasesjogo= new List<ComponenteFase>();

        public Composite(string nome) : base(nome)
        {

        }
        public override void Adicionar(ComponenteFase c)
        {
            this.fasesjogo.Add(c);
        }

        public override void Mostrar(int profundidade)
        {
            Console.WriteLine(new string('-', profundidade) + nome);

            foreach (ComponenteFase item in this.fasesjogo)
            {
                item.Mostrar(profundidade + 2);
            }
        }

        public override void Remover(ComponenteFase c)
        {
            this.fasesjogo.Remove(c);
        }
    }
}
