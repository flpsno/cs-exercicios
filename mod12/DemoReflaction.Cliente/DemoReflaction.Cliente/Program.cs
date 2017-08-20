using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DemoReflaction.Cliente
{
    class Program
    {
        static void Main(string[] args)
        {

            //Carregar a dll
            var gestorRH = Assembly.LoadFrom("DemoReflaction.dll");

            //Obter as classes do assembly
            var funcServ = gestorRH.GetType("DemoReflaction.FuncionarioService");
            var funcionario = gestorRH.GetType("DemoReflaction.Funcionario");

            //Instanciado
            var funcServInstance = Activator.CreateInstance(funcServ);

            //Descobrir os métodos
            var metodos = funcServ.GetMethods();

            //Propriedades
            var props = funcionario.GetProperties();

            //Adicionar Funcionario
            var addFunc1 = 
                metodos[0].Invoke(funcServInstance,new object[]{Activator.CreateInstance(funcionario)});

            var addFunc2 =
                metodos[0].Invoke(funcServInstance, new object[] { Activator.CreateInstance(funcionario) });

            var addFunc3 =
                metodos[0].Invoke(funcServInstance, new object[] { Activator.CreateInstance(funcionario) });

            dynamic todos = metodos[1].Invoke(funcServInstance,new object[]{});
            foreach (var item in todos)
            {
                Console.WriteLine("Id: {0} - Nome: {1}",item.Id, item.Nome);
            }

            Console.ReadLine();

        }
    }
}
