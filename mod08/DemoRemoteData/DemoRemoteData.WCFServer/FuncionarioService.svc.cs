using DemoRemoteData.Core.Contracts;
using DemoRemoteData.Core.EF.Repositories;
using DemoRemoteData.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace DemoRemoteData.WCFServer
{
    public class FuncionarioService : IFuncionarioService
    {
        private readonly IFuncionarioRepository _repo = new
            FuncionarioRepository();


        public IEnumerable<FuncionarioVM> ObterTodos()
        {
            return _repo.Obter()
                .Select(x =>
                    new FuncionarioVM { Codigo = x.Codigo, Nome = x.Nome, CodFunc = x.CodFunc }
                );
        }

        public FuncionarioVM ObterPorId(int cod)
        {
            var func = _repo.Obter(cod);
            return
                new FuncionarioVM { Codigo = func.Codigo, Nome = func.Nome, CodFunc = func.CodFunc };
        }

        public FuncionarioVM Adicionar(FuncionarioVM func)
        {
            _repo.Adicionar(new Funcionario(func.Nome, func.CodFunc));
            return func;
        }

        public void Dispose()
        {
            _repo.Dispose();
        }
    }
}
