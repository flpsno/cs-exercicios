using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DemoRemoteData.WCFServer
{
    //Criei uma ViewModel pois o WCF não está serializando o DataCadastro Datetime
    public class AlunoVM
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string DataCadastro { get; set; }
    }
}