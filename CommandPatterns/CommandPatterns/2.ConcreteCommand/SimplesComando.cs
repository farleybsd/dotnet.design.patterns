using CommandPatterns._1.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPatterns._2.ConcreteCommand
{
    public class SimplesComando : ICommand
    {
        private string _solicitacao = string.Empty;

        public SimplesComando(string solicitacao)
        {
            _solicitacao = solicitacao;
        }

        public void Executar()
        {
            Console.WriteLine("Estou executando Comando de " + this._solicitacao);
        }
    }
}
