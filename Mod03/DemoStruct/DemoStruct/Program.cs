using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoStruct
{
    class Program
    {
        static void Main(string[] args)
        {
            var funcs = new FuncionarioStruct() { Id = 1, Nome="Func Struct"};
            var funcsClone = funcs;
            Console.WriteLine("Nome do funcs: " + funcs.Nome);
            Console.WriteLine("Nome do funcsClone: " + funcsClone.Nome);

            funcsClone.Nome = "Nome alterado";
            Console.WriteLine("Nome do funcs: " + funcs.Nome);
            Console.WriteLine("Nome do funcsClone: " + funcsClone.Nome);

            Console.WriteLine("\n\n\n----------- Testando c/ Classe");

            var funcc = new FuncionarioClass() { Id = 1, Nome = "Func Class" };
            var funccClone = funcc;
            Console.WriteLine("Nome do funcs: " + funcc.Nome);
            Console.WriteLine("Nome do funcsClone: " + funccClone.Nome);

            funccClone.Nome = "Nome alterado";
            Console.WriteLine("Nome do funcs: " + funcc.Nome);
            Console.WriteLine("Nome do funcsClone: " + funccClone.Nome);

            Console.ReadLine();
        }

        struct FuncionarioStruct 
        {
            public int Id;
            public string Nome;
        }

        class FuncionarioClass
        {
            public int Id;
            public string Nome;
        }

    }
}
