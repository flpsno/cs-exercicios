using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ComAsync
{
    class Program
    {
        static void Main(string[] args)
        {
            var resultado = OperacaoLentaAsync();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Resultado do método: " + resultado.Result);
            Console.WriteLine("Main foi finalizada na Thread " + Thread.CurrentThread.ManagedThreadId);
            Console.ReadLine();
        }

        private static async Task<int> OperacaoLentaAsync()
        {
            Console.WriteLine("Método iniciado na Thread " + Thread.CurrentThread.ManagedThreadId);
            await Task.Delay(2000);
            Console.WriteLine("Método finalizado na Thread " + Thread.CurrentThread.ManagedThreadId);
            return 100;
        }
    }
}
