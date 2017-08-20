using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ComTPL
{
    class Program
    {
        static void Main(string[] args)
        {
            Task<int> resultado =  Task.Factory.StartNew<int>(OperacaoLenta);

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Resultado do método: " + resultado.Result);
            Console.WriteLine("Main foi finalizada na Thread " + Thread.CurrentThread.ManagedThreadId);
            Console.ReadLine();
        }

        private static int OperacaoLenta()
        {
            Console.WriteLine("Método iniciado na Thread " + Thread.CurrentThread.ManagedThreadId);
            Thread.Sleep(2000);
            Console.WriteLine("Método finalizado na Thread " + Thread.CurrentThread.ManagedThreadId);
            return 100;
        }
    }
}
