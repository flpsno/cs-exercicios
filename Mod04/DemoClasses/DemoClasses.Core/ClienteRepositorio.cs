using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoClasses.Core
{
    public class ClienteRepositorio
    {
        //private IList<Cliente> _clientes = new MinhaLista<Cliente>();
        private IList<Cliente> _clientes = new List<Cliente>();
        public void Adicionar(Cliente cliente)
        {
            _clientes.Add(cliente);
        }

        public void Excluir(Cliente cliente)
        {
            _clientes.Remove(cliente);
        }

        public IEnumerable<Cliente> Obter()
        {
            return _clientes;
        }
    }

}
