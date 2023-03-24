using CommandPatterns._1.Command;
using CommandPatterns._3.Receiver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPatterns._4.Ciente
{
    public class ComplexoComando : ICommand
    {
        private Receiver _receiver;

        private string a;

        private string b;

        public ComplexoComando(Receiver receiver, string a, string b)
        {
            _receiver = receiver;
            this.a = a;
            this.b = b;
        }

        public void Executar()
        {
            this._receiver.PrimeiroPedido(this.a);
            this._receiver.SegundoPedido(this.b);
        }
    }
}
