using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoRemoteData.WCFClient
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var proxy = new AlunoProxy.AlunoServiceClient())
            {
                var alunos = proxy.ObterTodos();
                foreach (var aluno in alunos)
                {
                    Console.WriteLine("Id: {0} - Nome: {1}",
                        aluno.Codigo, aluno.Nome);
                }
            }

            Console.WriteLine("Fim da execução! Press Enter");
            Console.ReadLine();
        }
    }
}
