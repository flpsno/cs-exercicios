using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            var pedido = new Pedido(10, 1001, 100, TipoCliente.ONG);

            Console.WriteLine("Valor da compra: " + pedido.ValorBruto);

            Console.ReadLine();
        }
    }
}
