using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoReflaction
{
    public class DataCriacaoAtributo:Attribute
    {
        public string DataCriacao { get; set; }

        public DataCriacaoAtributo()
        {
            DataCriacao = DateTime.Now.ToString("dd/MM/yy HH:mm:ss");
        }
    }
}
