using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoHeranca
{
    class Program
    {
        static void Main(string[] args)
        {

            //Console.WriteLine("Usando a class Pai");
            //var pai = new Pai("Fabiano", "Nalin");
            //pai.Nome = "Fabiano";
            //pai.SobreNome = "Nalin";
            
            //Console.WriteLine(pai.MetodoNomeCompletoQueVaiSerSobescrito());
            //Console.WriteLine(pai);


            try
            {
                Console.WriteLine("\n\nUsando a class Filha");

                var filho = new Filho("Raphael", "Nalin", 17, "123456");
                //filho.Idade = 20;
                //filho.Nome = "Raphael";
                //filho.SobreNome = "Nalin";
                Console.WriteLine(filho.MetodoNomeCompletoQueVaiSerSobescrito());
                Console.WriteLine(filho);
                Console.WriteLine(filho.ObterIdade());
                filho.ExibirSenha();

                Console.Write("\n\nInforme a senha:");
                var senha = Console.ReadLine();
                Console.WriteLine(filho.Autenticar(senha)?"Vc está autenticado":"Senha inválida");

                Console.WriteLine("\n\nUsando a class Neto");

                var neto = new Neto(null, "Nalin");
                Console.WriteLine(neto.MetodoNomeCompletoQueVaiSerSobescrito());
                Console.WriteLine(neto);

                neto.Validar();

            }
            catch (ValidacaoException ex)
            {
                Console.WriteLine(ex.Message);
            }


            Console.ReadLine();

        }
    }

    //abstract => não permite mais a instancia da classe (new ())
    abstract class Pai //:object (por default toda classe deriva de object)
    {
        public Pai(string nome, string sobrenome, int idade = 0, string senha = null)
        {
            Nome = nome;
            SobreNome = sobrenome;
            Idade = idade;
            Senha = senha;

            if (string.IsNullOrWhiteSpace(nome) || string.IsNullOrWhiteSpace(sobrenome))
            {
                Erros.Add("O nome e o sobrenome são obrigatórios");
            }

           
        }

        protected List<string> Erros = new List<string>();

        public string Nome { get; set; }
        public string SobreNome { get; set; }
        protected int Idade { get; set; } // protected => torna o objeto privado para fora e public internamente por que herda 
        public string Senha { get; set; }
        public int ObterIdade() 
        {
            return Idade;
        }

        public virtual string MetodoNomeCompletoQueVaiSerSobescrito() 
        {
            return Nome + " " + SobreNome;
        }

        public void ExibirSenha()
        {
            Console.WriteLine(Senha);
        }

        public bool Autenticar(string senha)
        {
            return senha.Encrypt() == Senha;
        }


        public sealed override string ToString() //sealed -> desativa o overload
        {
            return base.ToString() + " - " + DateTime.Now;
        }

        //Força a sues filhos implementarem
        public abstract void MetodoAbstrato();
        public abstract void Validar();

    }

    class Filho : Pai
    {
        public Filho(string nome, string sobrenome, int idade = 0, string senha = null)
            :base(nome,sobrenome) //repassando ao construtor da classe base
        {
            Nome = nome;
            SobreNome = sobrenome;
            Idade = idade;
            //Senha = Utils.Encrypt(senha);
            Senha = senha.Encrypt();

            if (idade <= 17) Erros.Add("Idade Não permitida");

        }


        public sealed override string MetodoNomeCompletoQueVaiSerSobescrito()
        {
            return base.MetodoNomeCompletoQueVaiSerSobescrito() + " - "
                + DateTime.Now;
        }


        public override void MetodoAbstrato()
        {
            return;//pára por aqui
        }




        public override void Validar()
        {
            if (Erros.Count > 0)
                throw new ValidacaoException(Erros);
        }
    }

    class Neto:Filho
    {
        public Neto(string nome, string sobrenome)
            :base(nome,sobrenome) //repassando ao construtor da classe base
        {
            Nome = nome;
            SobreNome = sobrenome;
            
        }
    }

    class ValidacaoException : Exception
    {

        public ValidacaoException(List<string> Erros)
            :base(string.Join(" | ",Erros))
        {

        } 

    }

}
