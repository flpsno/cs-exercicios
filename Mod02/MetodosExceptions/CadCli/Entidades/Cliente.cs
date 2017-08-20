using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadCli.Entidades
{
    class Cliente
    {
        public int Id;
        public string Nome;
        public string SobreNome;
        public byte Idade;

        public string NomeCompleto()
        {
            return Nome + " " + SobreNome;
        }

        public bool MaiorDeIdade()
        {
            return Idade >= 18;
        }
    }
}
