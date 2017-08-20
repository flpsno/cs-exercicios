using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManipulandoStrings
{
    class Program
    {
        static void Main(string[] args)
        {

            //Code smell
            var endereco = "Rua XPTO";
            //endereco = endereco + ", 123";
            endereco += ", 123";
            endereco += " - Centro";
            Console.WriteLine("Endereço: " + endereco);

            //Boa prática
            var novoEndereco = new StringBuilder("Rua Acme");
            novoEndereco.Append(", 123");
            novoEndereco.Append(", ZL");
            Console.WriteLine("Novo Endereço: " + novoEndereco);
            Console.ReadLine();
        }
    }
}
