using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoEnum
{
    class Aluno
    {
        public string Nome;
        public int Idade;
        public Status Situacao;
    }

    enum Status //: int
    {
        //Aprovado = 10, Reprovado = 20, Recuperacao = 15
        //Aprovado = 2, Reprovado, Recuperacao
        Aprovado, Reprovado, Recuperacao
    }
}
