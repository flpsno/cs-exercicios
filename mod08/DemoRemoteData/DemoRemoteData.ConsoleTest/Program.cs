using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoRemoteData.Core.EF;

namespace DemoRemoteData.ConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {

            //using (var ctx = new EscolaDB())
            //{
            //    var alunos = ctx.Alunos.ToList();
            //    foreach (var aluno in alunos)
            //    {
            //        Console.WriteLine("Código: {0} | Nome {1} | Sexo: {2}",
            //            aluno.Codigo, aluno.Nome, aluno.Sexo);
            //    }
            //}

            Console.WriteLine("Fim da execução | Press Enter");
            Console.ReadLine();
        }
    }
}
