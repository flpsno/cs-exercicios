using CadCli.DAL;
using CadCli.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadCli
{
    class Program
    {
        static void Main(string[] args)
        {
            var dal = new ClienteDAL();

            AddCliente("Tospericageja", "Canarinho", 40, dal);
            AddCliente("Crayson", "Silva", 4, dal);
            AddCliente("Asdrubal", "Sousa", 40, dal);


            //ctrl + k + s (Envolve o código)

            Console.ReadLine();

        }

        static void AddCliente(string nome, string sobrenome, byte idade, ClienteDAL dal = null)
        {
            var cliente = new Cliente();
            cliente.Nome = nome;
            cliente.SobreNome = sobrenome;
            cliente.Idade = idade;

            if (dal == null)
            {
                dal = new ClienteDAL();
            }

            try
            {
                dal.EnderecoServidor = "10.0.0.1";
                dal.Conectar();

                dal.Adicionar(cliente);

                Console.WriteLine("Total de clientes: " + dal.Contar());
                Console.WriteLine("Id: {0} - Nome: {1} - Idade: {2}", cliente.Id, cliente.Nome,
                    cliente.Idade);
            }
            catch (ArgumentException aex)
            {
                //to do Cadastrar log
                DispararErro(aex.Message);
            }
            catch (Exception ex)
            {
                DispararErro(ex.Message);
            }
            finally
            {
                dal.Desconectar();
            }

        }

        static void DispararErro(string msg)
        {
            Console.WriteLine("Erro ao tentar cadastrar o cliente\nMensagem:"
                    + msg);
        }



    }
}
