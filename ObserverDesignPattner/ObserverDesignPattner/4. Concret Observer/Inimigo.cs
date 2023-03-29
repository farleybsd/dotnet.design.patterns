using ObserverDesignPattner._1._Inrterfaces_Personagens;
using ObserverDesignPattner._2.Interface_Observadores;
using ObserverDesignPattner._3.Concret_Subject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverDesignPattner._4._Concret_Observer
{
    public class Inimigo : IObservador
    {
        // Referencia Subject
        private Cody personagemObservado;

        public void Avisar(IPersonagem personagem)
        {
            if (personagem == personagemObservado)
            {
                Console.WriteLine("o Cody foi acertado com um golpe, agora sua vida de jogo é de: " + personagemObservado.getVida());
            }
        }

        public Inimigo(Cody cody)
        {
            personagemObservado = cody;
            personagemObservado.RegistrarObservador(this);
        }
    }
}
