using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComNewtonSoft
{
    class Program
    {
        static void Main(string[] args)
        {

            var aluno = new Aluno("Fabiano");
            Serializar(aluno);
            Deserializar();
            Console.ReadLine();

        }

        private static void Deserializar()
        {
            var file = File.ReadAllText("aluno.txt");
            var aluno = JsonConvert.DeserializeObject<Aluno>(file);
            Console.WriteLine("Id: {0} - Nome: {1}",aluno.Id, aluno.Nome);
        }

        private static void Serializar(Aluno aluno)
        {
            var json = JsonConvert.SerializeObject(aluno);
            File.WriteAllText("aluno.txt",json);
        }
    }

    class Aluno
    {
        public Aluno(string nome)
        {
            Nome = nome;
            Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }
        public string Nome { get; set; }

    }
}
