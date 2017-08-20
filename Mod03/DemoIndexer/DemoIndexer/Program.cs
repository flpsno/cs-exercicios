using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoIndexer
{
    class Program
    {
        static void Main(string[] args)
        {
            var bebidas = new string[] { "Café", "Chocolate", "Refrigerante" };
            var cardapio = new Cardapio(bebidas);

            Console.WriteLine("Total de bebidas: " + cardapio.TamanhoTotal);

            foreach (var item in cardapio.ObterTodas())
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Buscando por índice 1: " + cardapio[1]);

            Console.ReadLine();
        }

    }

    struct Cardapio
    {

        //public Cardapio(){} -> Struct não aceita construtor padrão (sem argumentos)

        public Cardapio(string[] bebidas)
        {
            Bebidas = bebidas;
        }

        private string[] Bebidas;

        public int TamanhoTotal
        {
            get { return Bebidas.Length; }
        }

        //indexando por bebidas
        public string this[int index]
        {
            get
            {
                return Bebidas[index];
            }
            set
            {
                Bebidas[index] = value;
            }
        }

        public string[] ObterTodas()
        {
            return Bebidas;
        }

    }

}
