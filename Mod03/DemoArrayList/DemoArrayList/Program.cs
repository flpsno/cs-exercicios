using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoArrayList
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] nomes = { "Fabiano", "Priscila", "Raphael"};
            //nomes.Add("Isabel");

            ArrayList nomesArray = new ArrayList();
            nomesArray.Add("Fabiano");
            nomesArray.Add("Priscila");
            nomesArray.Add(10);
            nomesArray.Add(true);
            nomesArray.Add(new Funcionario { Id = 10, Nome = "Percival" });

            //Perda de perfomance -> leia sobre boxing / unboxing
            var flag = (bool)nomesArray[3];
            //var flag = (bool)nomesArray[4];
            Console.WriteLine("Valor do nomesArray[3]: " + flag);

            Console.ReadLine();
        }

        class Funcionario 
        {
            public int Id { get; set; }
            public string Nome { get; set; }
        }
    }
}
