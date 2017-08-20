using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TipoValRef
{
    class Program
    {
        static void Main(string[] args)
        {

            //tipo valor
            int a = 1;
            int b = a;
            Console.WriteLine("Valor do b: " + b);
            a=10;
            Console.WriteLine("Valor do b: " + b);



            Cliente cli = new Cliente();
            cli.id = 1;
            cli.nome = "Fabiano";
            cli.idade = 38;
            cli.Imprimir();

            Cliente cli2 = cli;
            cli2.Imprimir();
            
            cli.id = 20;
            cli.nome = "Nome alterado";
            cli.idade = 120;

            cli2.Imprimir();

            // ctrl + k + c => comenta o código
            // ctrl + k + u => comenta o código
            //var cli2 = new Cliente();
            //cli2.id = 2;
            //cli2.nome = "Priscila";
            //cli2.idade = 39;
            //cli2.Imprimir();
           

            Console.ReadLine();

        }
    }


    class Cliente 
    {
        public int id;
        public string nome;
        public byte idade;

        public void Imprimir()
        {
            Console.WriteLine("Id: {0} - Nome: {1} - Idade: {2}", id, nome, idade);
        }
    }

}
