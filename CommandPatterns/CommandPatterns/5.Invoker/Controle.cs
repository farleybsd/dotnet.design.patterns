using CommandPatterns._1.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPatterns._5.Invoker
{
    public class Controle
    {
        private ICommand comandoSimples;
        
        private ICommand commandoComplexo;

        public void EnviarComandoSimples(ICommand command)
        {
            this.comandoSimples = command;
        }

        public void EnviarComandoComplexo(ICommand command)
        {
            this.commandoComplexo = command;
        }

        public void Fazer()
        {
            Console.WriteLine("Ok, vou executar para você!");

            if(this.comandoSimples is ICommand)
                    this.comandoSimples.Executar();

            if(this.commandoComplexo is ICommand)
                    this.commandoComplexo.Executar();
        }
    }
}
