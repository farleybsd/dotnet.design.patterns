using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonApp
{
    /*
     *  Primeiro Passo e criar uma classe chamada Singleton e com ela vamos criar o nosso objeto (bola)
     *  Iremos criar essa  uma operacao responsavel e garantir sua unica instancia
     *  Vale destacar o modificador de Acesso SELEAD que impede que outras classes herdem a nossa classe
     */
    public sealed  class Singleton
    {
        private static Singleton instance = null;

        public static Singleton GetInstancia { 
            get {
            
                if(instance == null)
                {
                    instance = new Singleton();
                    Console.WriteLine("Bola em Jogo");
                }

                return instance;
            } 
        }

        public void Mensagem(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}
