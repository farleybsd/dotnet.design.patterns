using ObserverDesignPattner._1._Inrterfaces_Personagens;
using ObserverDesignPattner._2.Interface_Observadores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverDesignPattner._3.Concret_Subject
{
    public class Cody : IPersonagem
    {
        // Referencia Observer
        private List<IObservador> inimigos = new List<IObservador>();

        public int vida = 100;

        public void NotificarPersonagens()
        {
            foreach (IObservador i in inimigos)
            {
                i.Avisar(this);
            }
        }

        public void RegistrarObservador(IObservador observador)
        {
            inimigos.Add(observador);
        }

        public void Golpe_Acertado(bool golpe)
        {
            if (golpe)
                vida -= 10;

            NotificarPersonagens();    
        }

        public int getVida()
        {
            return vida;
        }
    }
}
