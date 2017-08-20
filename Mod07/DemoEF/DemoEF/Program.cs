using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoEF
{
    class Program
    {
        static void Main(string[] args)
        {
            var ctx = new CadCliDB();
            var clientes = ctx.Clientes.ToList();
            ctx.Dispose();

            foreach (var cli in clientes)
            {
                Console.WriteLine("Id: {0} | Nome: {1} | Idade:{2}",cli.Id,cli.Nome,cli.Idade);
            }

            Console.ReadLine();

        }
    }
}
