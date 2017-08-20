using DemoRemoteData.Core.Contracts;
using DemoRemoteData.Core.EF;
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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "AlunoService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select AlunoService.svc or AlunoService.svc.cs at the Solution Explorer and start debugging.
    public class AlunoService : IAlunoService
    {

        private readonly IAlunoRepository _repo = new AlunoRepository();

        public IEnumerable<AlunoVM> ObterTodos()
        {
            //_ctx = new EscolaDB(); => readonly não permite
            var alunos = _repo.Obter()
                .Select(x => new AlunoVM { 
                    Codigo = x.Codigo,
                    Nome = x.Nome,
                    DataCadastro = x.DataCadastro.ToString("dd/MM/yyyy HH:mm:ss")
                });
            return alunos;
            
        }

        public Aluno ObterPorId(int codigo)
        {
            return _repo.Obter(codigo);
        }

        public Aluno Adicionar(Aluno aluno)
        {
            _repo.Adicionar(aluno);
            return aluno;
        }
        
        public void Dispose()
        {
            _repo.Dispose();
        }
    }

    
}
