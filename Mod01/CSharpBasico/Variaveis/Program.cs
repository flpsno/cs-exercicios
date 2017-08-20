using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variaveis
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
            Comentário
            de várias linhas
            */

            //Como declarar variáveis
            string minhaVariavel;
            minhaVariavel = "Conteúdo da minha variável";
            Console.WriteLine(minhaVariavel);

            //inteiro
            int v1 = 1;
            int v2, v3 = 3, v4;
            Console.WriteLine("Valor da v3: " + v3);


            //var
            var num1 = 10;
            Int32 num2 = 11;

            //byte
            byte bMin = byte.MinValue;
            Byte bMax = byte.MaxValue;
            Console.WriteLine("Valor do bMin: " + bMin);
            Console.WriteLine("Valor do bMax: " + bMax);
            
            Console.WriteLine("\n---------------\n");
            
            //sbyte
            sbyte sbMin = sbyte.MinValue;
            SByte sbMax = SByte.MaxValue;
            Console.WriteLine("Valor do sbMin: " + sbMin);
            Console.WriteLine("Valor do sbMax: " + sbMax);

            Console.WriteLine("\n---------------\n");

            //short
            short shMin = short.MinValue;
            Int16 shMax = Int16.MaxValue;
            Console.WriteLine("Valor shMin: " + shMin);
            Console.WriteLine("Valor shMax: " + shMin);

            Console.WriteLine("\n---------------\n");


            //int
            int iMin = int.MinValue;
            Int32 iMax = int.MaxValue;
            Console.WriteLine("Valor iMin: " + iMin);
            Console.WriteLine("Valor iMax: " + iMax);

            Console.WriteLine("\n---------------\n");

            //long
            long lMin = long.MinValue;
            Int64 lMax = Int64.MaxValue;
            Console.WriteLine("Valor lMin: " + lMin);
            Console.WriteLine("Valor lMax: " + lMax);

            Console.WriteLine("\n---------------\n");
            
            //float
            float fMin = float.MinValue;
            Single fMax = float.MaxValue;
            Console.WriteLine("Valor fMin: " + fMin);
            Console.WriteLine("Valor fMax: " + fMax);

            Console.WriteLine("\n---------------\n");

            //double
            double dMin = double.MinValue;
            Double dMax = Double.MaxValue;
            Console.WriteLine("Valor dMin: " + dMin);
            Console.WriteLine("Valor dMax: " + dMax);

            Console.WriteLine("\n---------------\n");

            //decimal
            decimal mMin = decimal.MinValue;
            Decimal mMax = Decimal.MaxValue;
            Console.WriteLine("Valor mMin: " + mMin);
            Console.WriteLine("Valor mMax: " + mMax);

            Console.WriteLine("\n---------------\n");

            //Boolean
            bool verdadeiro = true;
            Boolean falso = false;

            Console.WriteLine("\n---------------\n");

            //Char -> Caracteres
            var cMin = char.MinValue;
            var cMax = Char.MaxValue;
            Console.WriteLine("Valor cMin: " + cMin);
            Console.WriteLine("Valor cMax: " + cMax);
            Console.WriteLine("Char = A " + (int)'A' );

            Console.WriteLine("\n---------------\n");

            //DateTime
            var dt = DateTime.Now;
            Console.WriteLine("Data / hora do sistema: " + dt);


            Console.ReadLine();

        }
    }
}
