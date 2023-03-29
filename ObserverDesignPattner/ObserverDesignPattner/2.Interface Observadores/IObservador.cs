using ObserverDesignPattner._1._Inrterfaces_Personagens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverDesignPattner._2.Interface_Observadores
{
    public interface IObservador
    {
        void Avisar(IPersonagem personagem);
    }
}
