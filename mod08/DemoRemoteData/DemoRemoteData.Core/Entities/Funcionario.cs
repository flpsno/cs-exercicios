using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoRemoteData.Core.Entities
{
    public class Funcionario : Entity
    {
        protected Funcionario()
        {

        }

        public Funcionario(string nome, string codFunc)
        {
            Nome = nome;
            CodFunc = codFunc;
        }

        [Required]
        [Column(TypeName = "varchar")]
        [MaxLength(50)]
        public string Nome { get; private set; }

        [Required]
        public string CodFunc { get; private set; }

        [Column(TypeName = "smalldatetime")]
        //public DateTime? DataDemissao { get; set; }
        public Nullable<DateTime> DataDemissao { get; set; }
    }
}
