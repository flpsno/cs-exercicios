using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoRemoteData.Core.Entities
{
    public abstract class Entity
    {
        public Entity()
        {
            DataCadastro = DateTime.Now;
        }

        [Key]
        public int Codigo { get; set; }

        [Column(TypeName="smalldatetime")]
        public DateTime DataCadastro { get; private set; }
    }
}
