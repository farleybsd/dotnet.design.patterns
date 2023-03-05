using Composite._1_Abstracao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite._2__Implementacao
{
    /*
     * Agora,podemos criar o objeto concreto que implementara a representacao da fase do jogo
     *  que criamos anteriormente chamaremos essa classe de FaseJogo
     */
    public class FaseJogo : ComponenteFase 
    {
        public FaseJogo(string nome) : base(nome)
        {

        }
        public override void Adicionar(ComponenteFase c)
        {
            Console.WriteLine("Não é possível adicionar a fase no jogo!");
        }

        public override void Mostrar(int profundidade)
        {
            Console.WriteLine(new string('-', profundidade) + nome);
        }

        public override void Remover(ComponenteFase c)
        {
            Console.WriteLine("Não é possível remover a fase do jogo!");
        }
    }
}
