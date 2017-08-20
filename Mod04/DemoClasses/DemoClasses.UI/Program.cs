using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoClasses.Core;

namespace DemoClasses.UI
{
    class Program
    {
        static void Main(string[] args)
        {

            var cliente = new Cliente("Fabiano",37);

            var repositorio = new ClienteRepositorio();
            repositorio.Adicionar(cliente);
            repositorio.Adicionar(new Cliente("Priscila", 39));
            repositorio.Adicionar(new Cliente("Daniel", 40));

            var clientes = repositorio.Obter();
            //clientes.Add(); //Tipo IEnumerable<T> não tem o método Add

            repositorio.Obter().ToList().ForEach(cli => {
                Console.WriteLine("Id: {0} - Nome: {1} - Idade: {2}",
                            cli.Id, cli.Nome, cli.Idade);
            });


            

            Console.ReadLine();

        }
    }
}
