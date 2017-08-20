using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace DemoSerializando
{
    class Program
    {
        static void Main(string[] args)
        {

            //var aluno = new Aluno("Raphael Nalin");
            //Console.WriteLine("Id: {0} - Nome {1}",aluno.Id, aluno.Nome);
            //SerializarAluno(aluno);
            LerAlunotxt();


            Console.ReadLine();

        }

        private static void LerAlunotxt()
        {
            var file = File.OpenRead("aluno.txt");
            var json = new DataContractJsonSerializer(typeof(Aluno));
            //Aluno aluno = (Aluno)json.ReadObject(file);
            Aluno aluno = json.ReadObject(file) as Aluno;
            if (aluno != null)
            {
                Console.WriteLine("Id: {0} - Nome {1}", aluno.Id, aluno.Nome);
            }
            else {
                Console.WriteLine("O objeto não é um aluno");
            }
        }

        private static void SerializarAluno(Aluno aluno)
        {
            var json = new DataContractJsonSerializer(typeof(Aluno));
            var file = File.Create("aluno.txt");
            json.WriteObject(file, aluno);

        }
    }

    [Serializable]
    class Aluno : ISerializable
    {
        public Aluno(string nome)
        {
            Nome = nome;
            Id = Guid.NewGuid();
        }

        //Deserializar
        public Aluno(SerializationInfo info, StreamingContext context)
        {
            var _id = info.GetString("Id");//, typeof(string));
            Id = Guid.Parse(_id.ToString());

            //Nome = info.GetValue("Nome", typeof(string)).ToString();
            Nome = info.GetString("Nome");
        }


        public Guid Id { get; set; }
        public string Nome { get; set; }

        //Serializa
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Id", Id);
            info.AddValue("Nome", Nome);
        }
    }
}
