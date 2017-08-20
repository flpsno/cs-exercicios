using CadCli.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadCli.DAL
{
    class ClienteDAL
    {
        public string EnderecoServidor;
        private bool conectado = false;

        public void Conectar()
        {
            if (string.IsNullOrWhiteSpace(EnderecoServidor)) 
            {
                throw new ArgumentException("Endereço do servidor não foi informado");
            }

            conectado = true;

        }


        private List<Cliente> clientes = new List<Cliente>();

        public Cliente Adicionar(Cliente cli)
        {

            if (!conectado)
            {
                throw new InvalidOperationException("Você não se conectou!");
            }

            //Para auto identicar => ctrl + k + d
            if (clientes.Count >= 2)
            {
                throw new Exception("Limite excedido");
            }
            cli.Id = clientes.Count + 1;
            clientes.Add(cli);
            return cli;
        }

        public int Contar()
        {
            return clientes.Count();
        }

        public void Desconectar()
        {
            conectado = false;
        }


    }
}
