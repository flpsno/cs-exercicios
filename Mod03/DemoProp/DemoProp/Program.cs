using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProp
{
    class Program
    {

        //Sem propriedades
        /*
        static void Main(string[] args)
        {

            var cli1 = new Cliente();// {Nome="Fabiano", Idade=37 };
            Console.Write("Informe o nome: ");
            cli1.Nome = Console.ReadLine();

            Console.Write("\nInforme a idade: ");
            cli1.Idade = Convert.ToInt32(Console.ReadLine());

            if (string.IsNullOrWhiteSpace(cli1.Nome))
            {
                throw new Exception("Nome inválido");
            }


            if (cli1.Idade < 18)
            {
                throw new Exception("Idade inválida");
            }

            Console.WriteLine("Cliente validado c/ sucesso");

            Console.ReadLine();

        }

        class Cliente
        {
            public string Nome;
            public int Idade;
        }
        */


        //Com propriedades
        static void Main()
        {
            var loop = true;
            while (loop)
            {
                try
                {
                    var cli1 = new Cliente();// {Nome="Fabiano", Idade=37 };
                    Console.Write("Informe o nome: ");
                    cli1.Nome = Console.ReadLine();

                    Console.Write("\nInforme a idade: ");
                    cli1.Idade = Convert.ToInt32(Console.ReadLine());


                    Console.WriteLine("Cliente validado c/ sucesso");

                }
                catch
                {
                    Console.WriteLine("Dados inválidos");
                }
                Console.Write("Deseja gravar um novo Cliente (S | N)");
                if (Console.ReadLine().ToLower() != "s")
                    loop = false;
            }


            Console.ReadLine();

        }

        class Cliente
        {
            private string nome;
            public string Nome
            {
                get { return nome; }
                set
                {
                    if (string.IsNullOrWhiteSpace(value))
                        throw new Exception("Nome inválido");

                    nome = value;
                }
            }

            private int idade;
            public int Idade
            {
                get
                {
                    return idade;
                }
                set
                {

                    if (idade < 18)
                    {
                        throw new Exception("Idade inválida");
                    }
                    idade = value;
                }
            }
        }

        class ClienteAutoPropertie
        {
            public string Nome { get; set; }
            public int Idade { get; set; }
        }

        class ClienteFullPropertie
        {
            private string nome;
            public string Nome
            {
                get { return nome; }
                set { nome = value; }
            }

            //Code Snipped==> propfull
            private int idade;
            public int Idade
            {
                get { return idade; }
                set { idade = value; }
            }


        }



    }


}
