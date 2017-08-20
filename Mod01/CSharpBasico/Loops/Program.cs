using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //for
            Console.WriteLine("For ...");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Valor do i: " + i);
            }

            var nomes = new string[]{"fabiano","priscila", "raphael"};
            for (int i = 0; i < nomes.Length; i++)
            {
                Console.WriteLine(nomes[i]);
            }


            Console.WriteLine("\n For each ...........\n");
            foreach (var item in nomes)
            {
                Console.WriteLine(item);
            }


            Console.WriteLine("\n While ...........\n");
            var contador = 0;
            while (contador<10)
            {
                Console.WriteLine(contador);
                contador++;
            }

            contador = 0;
            while (contador < nomes.Length)
            {
                Console.WriteLine(nomes[contador]);
                contador++;
            }

            contador = 0;
            do
            {
                Console.WriteLine(contador);
                contador++;
            } while (contador<10);



            Console.ReadLine();
        }
    }
}
