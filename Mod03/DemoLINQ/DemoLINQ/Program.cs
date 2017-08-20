using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLINQ
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] numbers = { 10, 6, 1000, 1, 541 };
            foreach (var num in numbers)
            {
                Console.WriteLine(num);
            }

            //Ordenando com o Linq
            Console.WriteLine("\n\n Números ordenados");
            var numbersOrdenados =
                /*
                from x in numbers
                orderby x
                //orderby x descending
                select x;
                 */
                numbers.OrderBy(x => x);

            foreach (var num in numbersOrdenados)
            {
                Console.WriteLine(num);
            }

            //Pesquisando com o Linq
            var numbersImpares =
                /*
                from x in numbers
                where x % 2 !=0
                orderby x descending
                select x;
                 */
                numbers.Where(xpto => xpto % 2 != 0).OrderByDescending(y => y);

            Console.WriteLine("\n Números ímpares");
            //foreach (var num in numbersImpares)
            //{
            //    Console.WriteLine(num);
            //}
            numbers.ToList().ForEach(batata => Console.WriteLine(batata));

            numbers.ToList().ForEach(batata =>
                {
                    Console.WriteLine(batata);
                    Console.WriteLine("Mais uma linha");
                }

            );


            Console.WriteLine("\n\nTrabalhando linq c/ listas...");

            //var livros = new List<Livro>();
            //var livro1 = new Livro {ISBN="XXYYHH-1", Nome="XPTO", Ano=1999 };
            //livros.Add(livro1);
            //livros.Add(new Livro { ISBN = "XXYYHH-1", Nome = "XPTO", Ano = 1999 });
            //livros.Add(new Livro { ISBN = "YYXXHH-1", Nome = "Senhor dos Aneis - 1578", Ano = 1980 });

            var livros = new List<Livro> { 

                new Livro { ISBN = "XXYYHH-1", Nome = "XPTO", Ano = 1999 },
                new Livro { ISBN = "YYXXHH-1", Nome = "Senhor dos Aneis - 1578", Ano = 1980 },
                new Livro { ISBN = "ZZXXHH-1", Nome = "Cronica de Narnia", Ano = 1998 },
                new Livro { ISBN = "UUXXHH-1", Nome = "Pequeno Príncipe", Ano = 1958 },
                new Livro { ISBN = "UUXXHH-1", Nome = "As tranças do rei careca", Ano = 2017 },
            };

            Console.WriteLine("\nLivros abaixo do ano de 1995");
            var livrosAntigos =

                from livro in livros
                where livro.Ano < 1995
                select livro;
            livrosAntigos.ToList().ForEach(l =>
                Console.WriteLine("ISBN: {0} - Nome: {1} - Ano {2}", l.ISBN, l.Nome, l.Ano)
            );

            //fazendo o mesmo só que sem gerar nova variável
            livros
                .Where(livro => livro.Ano < 1995)
                .OrderByDescending(l => l.Ano)
                .ToList().ForEach(l =>
                    Console.WriteLine("ISBN: {0} - Nome: {1} - Ano {2}", l.ISBN, l.Nome, l.Ano)
                );



            Console.ReadLine();

        }
    }

    class Livro
    {
        public string ISBN { get; set; }
        public string Nome { get; set; }
        public int Ano { get; set; }
    }
}
