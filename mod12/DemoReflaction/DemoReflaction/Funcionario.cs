using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoReflaction
{
    [DataCriacaoAtributo]
    public class Funcionario
    {
        public Funcionario()
        {
            Id = Guid.NewGuid();
            Nome = "Nome do " + Id;
        }

        public Guid Id { get; set; }
        public string Nome { get; set; }
    }
}
