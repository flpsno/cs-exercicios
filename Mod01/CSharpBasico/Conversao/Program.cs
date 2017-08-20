using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversao
{
    class Program
    {
        static void Main(string[] args)
        {
            //Conversão implícita
            int a = 10;//int.MaxValue;
            long b = a;

            Console.WriteLine("Valor do b: " + b);

            //Conversão explícita
            Int16 c = (short)a;
            Console.WriteLine("Valor do c: " + c);

            //Convert
            string possivelInt = "123456";// "123456Y";
            int convert = Convert.ToInt32(possivelInt);
            Console.WriteLine("Valor do Convert: " + convert);
            

            //Try parse
            string testeParse = "123456Y";
            int num;

            bool cast = int.TryParse(testeParse, out num);
            if (!cast) //(cast == false)
            {
                //Console.WriteLine("Desculpa, mas o " + testeParse + " não é um int!");
                Console.WriteLine("Desculpa, mas o {0} não é um int!", testeParse);
                // No C#6 => Console.WriteLine($"Desculpa, mas o {testeParse} não é um int!");
            }
            else
            {
                Console.WriteLine("Valor do num: " + num);
            }
            Console.ReadLine();
        }
    }
}
