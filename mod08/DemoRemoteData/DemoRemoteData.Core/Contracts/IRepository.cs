using DemoRemoteData.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoRemoteData.Core.Contracts
{
    public interface IRepository<T> : IDisposable
        where T : Entity
    {
        IEnumerable<T> Obter();
        T Obter(int codigo);
        T Adicionar(T obj);
        T Editar(T obj);
        void Delete(T obj);
    }
}
