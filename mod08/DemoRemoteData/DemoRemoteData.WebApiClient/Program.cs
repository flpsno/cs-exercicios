using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading;

namespace DemoRemoteData.WebApiClient
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Esperando a api subir");
            //Thread.Sleep(3000);

            //Console.WriteLine("\n\nObtendo alunos...");
            //ObterAlunos();

            //Console.WriteLine("\n\nObtendo aluno 1...");
            //ObterAluno(1);

            //Console.WriteLine("\n\nAdicionando Aluno...");
            //var idade = new Random().Next(6, 18);
            //AdicionarAluno(new Aluno
            //{
            //    Nome = "Testando às " + DateTime.Now,
            //    Idade = idade,
            //    Sexo = new Random().Next(1, 2)
            //});

            //Console.WriteLine("\n\nExcluindo aluno...");
            //Console.Write("Informe o id do aluno: ");
            //var id = int.Parse(Console.ReadLine());
            //ExcluirAluno(id);

            //Console.WriteLine("\n\nAtualizando aluno...");
            //Console.Write("Informe o id do aluno: ");
            //id = int.Parse(Console.ReadLine());
            //AtualizarAluno(id,new Aluno
            //{
            //    Nome = "Testando às " + DateTime.Now,
            //    Idade = idade,
            //    Sexo = new Random().Next(1, 2)
            //});

            Console.WriteLine("\n\nPesquisando no ViaCEP");
            Console.Write("Informe o CEP: ");
            var cep = Console.ReadLine();
            ObterDadosDoCEP(cep);


            Console.WriteLine("Fim da execução!");
            Console.ReadLine();
        }

        private static void ObterDadosDoCEP(string cep)
        {
            using (var http = new HttpClient())
            {
                var resposta = http.GetAsync("https://viacep.com.br/ws/" + cep + "/json").Result;
                var data = resposta.Content.ReadAsStringAsync().Result;

                var dados =
                    JsonConvert.DeserializeObject<VIACEP>(data);


                Console.WriteLine("Dados recebidos");

                Console.WriteLine("Endereco: {0} - Cidade: {1}",
                    dados.Logradouro, dados.Localidade);
            }
        }

        private static void AtualizarAluno(int id, Aluno aluno)
        {
            using (var client = new HttpClient())
            {
                var json = JsonConvert.SerializeObject(aluno);
                var resposta = client.PutAsync(url + id,
                    new StringContent(json, Encoding.UTF8, "application/json")
                    ).Result;

                if (resposta.IsSuccessStatusCode)
                {
                    Console.WriteLine("Aluno atualizado");
                    ObterAlunos();
                }
                else
                {
                    Console.WriteLine("Erro ao cadastrar aluno");
                }

            }
        }

        private static void ExcluirAluno(int id)
        {
            using (var http = new HttpClient())
            {
                var resposta = http.DeleteAsync(url + id).Result;
                if (resposta.IsSuccessStatusCode)
                {
                    Console.WriteLine("Aluno excluído c/ sucesso");
                }
            }
        }

        private static void AdicionarAluno(Aluno aluno)
        {
            using (var client = new HttpClient())
            {
                var json = JsonConvert.SerializeObject(aluno);
                var resposta = client.PostAsync(url,
                    new StringContent(json,Encoding.UTF8,"application/json")
                    ).Result;

                if (resposta.IsSuccessStatusCode)
                {
                    Console.WriteLine("Aluno cadastrado");
                    ObterAlunos();
                }
                else
                {
                    Console.WriteLine("Erro ao cadastrar aluno");
                }

            }
        }

        private static string url = "http://localhost:5854/api/alunos/";

        private static void ObterAlunos()
        {
            using (var http = new HttpClient())
            {
                var resposta = http.GetAsync(url).Result;
                var data = resposta.Content.ReadAsStringAsync().Result;

                var alunos =
                    JsonConvert.DeserializeObject<List<Aluno>>(data);


                Console.WriteLine("Dados recebidos");
                foreach (var aluno in alunos)
                {
                    Console.WriteLine("Id: {0} - Nome: {1}",
                        aluno.Codigo, aluno.Nome);
                }
            }
        }

        private static void ObterAluno(int id)
        {
            using (var http = new HttpClient())
            {
                var resposta = http.GetAsync(url + id).Result;
                var data = resposta.Content.ReadAsStringAsync().Result;

                var aluno =
                    JsonConvert.DeserializeObject<Aluno>(data);


                Console.WriteLine("Dados recebidos");

                Console.WriteLine("Id: {0} - Nome: {1}",
                    aluno.Codigo, aluno.Nome);
            }
        }




    }

    class Aluno
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public int Sexo { get; set; }
        public DateTime DataCadastro { get; set; }
    }

 
    class VIACEP
    {
        public string Cep { get; set; }
        public string Logradouro { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Localidade { get; set; }
        public string UF { get; set; }
        public string Unidade { get; set; }
        public string IBGE { get; set; }
        public string Gia { get; set; }

    }


}
