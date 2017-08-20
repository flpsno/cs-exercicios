using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoReflaction
{
    public class FuncionarioService
    {

        private static List<Funcionario> _funcs =
            new List<Funcionario>();

        public Funcionario Adicionar(Funcionario func)
        {
            _funcs.Add(func);
            return func;
        }

        public IEnumerable<Funcionario> ObterTodos()
        {
            return _funcs;
        }




    }
}
