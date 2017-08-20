using DemoRemoteData.Core.Contracts;
using DemoRemoteData.Core.EF.Repositories;
using DemoRemoteData.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace DemoRemoteData.WebApiServer.Controllers
{
    public class AlunosController:ApiController
    {

        private readonly IAlunoRepository _alunoRepo =
            new AlunoRepository();

        public IEnumerable<Aluno> Get()
        {
            return _alunoRepo.Obter();
        }


        public Aluno Get(int id)
        {
            return _alunoRepo.Obter(id);
        }

        public Aluno Post(Aluno aluno)
        {
            if (ModelState.IsValid)
            {
                _alunoRepo.Adicionar(aluno);
            }

            return aluno;

        }

        public void Delete(int id)
        {
            var aluno = _alunoRepo.Obter(id);
            if (aluno != null)
            {
                _alunoRepo.Delete(aluno);
            }

        }

        public void Put(int id, Aluno aluno)
        {
            aluno.Codigo = id;
            _alunoRepo.Editar(aluno);
        }





        protected override void Dispose(bool disposing)
        {
            _alunoRepo.Dispose();
        }




    }
}