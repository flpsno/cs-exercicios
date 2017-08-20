using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoEnum
{
    class Program
    {
        static void Main(string[] args)
        {

            Aluno aluno1 = new Aluno();
            aluno1.Nome = "Rebeca";
            aluno1.Idade = 10;
            aluno1.Situacao = Status.Aprovado;

            VerificarStatus(aluno1);

            Aluno aluno2 = new Aluno();
            aluno2.Nome = "Vinicius";
            aluno2.Idade = 11;
            aluno2.Situacao = Status.Reprovado;
            VerificarStatus(aluno2);

            Aluno aluno3 = new Aluno() { Nome = "Raphael", Idade = 17, Situacao = Status.Recuperacao };
            //aluno3.Nome = "Raphael";
            //aluno3.Idade = 17;
            //aluno3.Situacao = Status.Recuperacao;
            VerificarStatus(aluno3);

            Console.ReadLine();

        }

        private static void VerificarStatus(Aluno aluno)
        {
            switch (aluno.Situacao)
            {
                case Status.Aprovado:
                    Console.WriteLine("Parabéns, você foi aprovado");
                    break;
                case Status.Reprovado:
                    Console.WriteLine("Seu vagabundo, vai apanhar em casa");
                    break;
                case Status.Recuperacao:
                    Console.WriteLine("Putz grila, vai apanhar um pouco");
                    break;
                default:
                    Console.WriteLine("Deu ruim");
                    break;
            }
        }
    }
}
