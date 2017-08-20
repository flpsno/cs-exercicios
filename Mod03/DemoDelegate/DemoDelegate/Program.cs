using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoDelegate
{
    class Program
    {

        public delegate void DelegateSimples();
        public delegate string DelegateXPTO(int x);


        static void Main(string[] args)
        {
            //Alerta();
            //Imprimir();

            var @delegate = new DelegateSimples(Alerta);
            @delegate += new DelegateSimples(Imprimir);
            
            @delegate();
            Console.WriteLine("\nRemovendo o método alerta");

            @delegate -= new DelegateSimples(Alerta);
            @delegate();

            Console.WriteLine("\n Add via Action");
            @delegate += new DelegateSimples(() => {
                Console.WriteLine("Criando via Action");
            });
            @delegate();


            Console.WriteLine("\n\nUsuando delegate c/ retorno");
            var delegateXPTO = new DelegateXPTO(XPTO);
            delegateXPTO += new DelegateXPTO((z) => {
                return z + " msg da Function()";
            });

            var retornoDoUltimo = delegateXPTO(66);
            Console.WriteLine(retornoDoUltimo);

            Console.ReadLine();
        }

        static void Alerta()
        {
            Console.WriteLine("Alerta na tela");
        }

        static void Imprimir()
        {
            Console.WriteLine("Imprimindo");
        }

        static string XPTO(int y)
        {
            return y + " :)";
        }





    }
}
