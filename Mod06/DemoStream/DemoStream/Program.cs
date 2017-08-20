using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoStream
{
    class Program
    {
        static void Main(string[] args)
        {
            //EscreverComStream();
            //EscreverSemStream();

            LerComStream();

            //Console.WriteLine("---------------------------------------");

            LerSemStream();

            Console.ReadLine();
        }

        private static void LerSemStream()
        {
           var texto =  File.ReadAllText("meuarquivo.txt");
           Console.WriteLine(texto);
        }

        private static void LerComStream()
        {
            using (var fs = new FileStream("meuarquivo.txt", FileMode.Open, FileAccess.Read))
            {
                using (var reader = new StreamReader(fs, Encoding.UTF8,false,200))
                {
                    Console.WriteLine(reader.ReadToEnd());
                }
            }
        }

        private static void EscreverSemStream()
        {
            for (int i = 0; i < 100; i++)
            {
                File.AppendAllText("meuarquivo2.txt","Escrevendo a linha" + i);
            }
            Console.WriteLine("Fima da escrita");
        }

        private static void EscreverComStream()
        {
            //var fs = new FileStream("meuarquivo.txt", FileMode.Append, FileAccess.Write);
            //o codigo para escrever
            //fs.Dispose();

            using ( var fs = new FileStream("meuarquivo.txt", FileMode.Append, FileAccess.Write))
            {
                using (var write = new StreamWriter(fs,Encoding.UTF8,20))
                {
                    write.WriteLine("***************** Gravando às {0}",DateTime.Now);
                    for (int i = 0; i < 1000; i++)
                    {
                        write.WriteLine("Escrevendo a linha {0}", i);
                    }
                }
            }

            Console.WriteLine("Fim do stream...");
        }
    }
}
