using DemoRemoteData.Core.Contracts;
using DemoRemoteData.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoRemoteData.Core.EF.Repositories
{
    public abstract class Repository<T>: IRepository<T>
        where T:Entity
    {
        private readonly EscolaDB _ctx = new EscolaDB();

        public IEnumerable<T> Obter()
        {
            return _ctx.Set<T>().ToList();
        }

        public T Obter(int codigo)
        {
            return _ctx.Set<T>().Find(codigo);
        }

        public T Adicionar(T obj)
        {
            _ctx.Set<T>().Add(obj);
            _ctx.SaveChanges();
            return obj;
        }

        public T Editar(T obj)
        {
            _ctx.Entry(obj).State = 
                System.Data.Entity.EntityState.Modified;

            _ctx.SaveChanges();
            return obj;
        }

        public void Delete(T obj)
        {
            _ctx.Set<T>().Remove(obj);
            _ctx.SaveChanges();
        }

        public void Dispose()
        {
            _ctx.Dispose();
        }
    }
}
