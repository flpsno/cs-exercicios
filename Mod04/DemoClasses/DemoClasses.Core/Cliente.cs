using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoClasses.Core
{
    public class Cliente
    {
        //public Cliente()
        //{
        //    Id = Guid.NewGuid();
        //}

        public Cliente(string nome, int idade)
        {
            Id = Guid.NewGuid();
            Nome = nome;
            Idade = idade;
        }


        public Guid Id { get; private set; }//fechando o set para fora da classe
        //public Guid Id { get; } = Guid.NewGuid(); //c#6
        public string Nome { get; set; }
        public int Idade { get; set; }

        class ClasseInterna 
        {
            public int Id { get; set; }
        }

    }
}
