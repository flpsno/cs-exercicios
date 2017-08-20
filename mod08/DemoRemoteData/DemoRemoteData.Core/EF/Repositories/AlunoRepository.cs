using DemoRemoteData.Core.Contracts;
using DemoRemoteData.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoRemoteData.Core.EF.Repositories
{
    public class AlunoRepository: Repository<Aluno>, IAlunoRepository
    {
        public Aluno ObterPorNomeDaMae(string nomeDaMae)
        {
            return null;
        }
    }
}
