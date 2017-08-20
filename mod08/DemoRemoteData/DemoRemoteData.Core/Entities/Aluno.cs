using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoRemoteData.Core.Entities
{
    [Table("tblAluno")]
    public class Aluno : Entity
    {

        [Required]
        [Column(TypeName = "varchar")]
        [MaxLength(50)]
        public string Nome { get; set; }

        [Column("Age")]
        [Range(6, 18)]
        public int Idade { get; set; }

        public Sexo Sexo { get; set; }

    }
}
