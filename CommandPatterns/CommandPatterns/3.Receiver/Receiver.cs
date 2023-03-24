using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPatterns._3.Receiver
{
    public class Receiver
    {
        public void PrimeiroPedido(string a)
        {
            Console.WriteLine("Comando Recebido: " + a);
        }

        public void SegundoPedido(string b)
        {
            Console.WriteLine("Outro Comando Recebido: " + b);
        }
    }
}
