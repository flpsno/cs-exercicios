using DemoRemoteData.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoRemoteData.Core.Contracts
{
    public interface IAlunoRepository : IRepository<Aluno>
    {
        Aluno ObterPorNomeDaMae(string nomeDaMae);
    }
}
