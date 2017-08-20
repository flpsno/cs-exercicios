using DemoRemoteData.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace DemoRemoteData.WCFServer
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IAlunoService" in both code and config file together.
    [ServiceContract]
    public interface IAlunoService : IDisposable
    {
        [OperationContract]
        IEnumerable<AlunoVM> ObterTodos();

        [OperationContract]
        Aluno ObterPorId(int codigo);

        [OperationContract]
        Aluno Adicionar(Aluno aluno);

    }
}
