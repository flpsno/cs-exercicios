using DemoRemoteData.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace DemoRemoteData.WCFServer
{
    [ServiceContract]
    public interface IFuncionarioService:IDisposable
    {
        [OperationContract]
        IEnumerable<FuncionarioVM> ObterTodos();

        [OperationContract]
        FuncionarioVM ObterPorId(int cod);

        [OperationContract]
        FuncionarioVM Adicionar(FuncionarioVM func);
    }
}
