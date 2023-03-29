using ObserverDesignPattner._2.Interface_Observadores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverDesignPattner._1._Inrterfaces_Personagens
{
    public interface IPersonagem
    {
        void RegistrarObservador(IObservador observador);
        void NotificarPersonagens();
    }
}
