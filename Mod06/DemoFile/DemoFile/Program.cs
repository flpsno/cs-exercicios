using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoFile
{
    class Program
    {
        static void Main(string[] args)
        {

            CriarPastaSeNaoExistir();
            CriarArquivo();
            LerArquivo();

            Console.ReadLine();

        }

        private static void LerArquivo()
        {
            Console.WriteLine("\nLendo Arquivo...");
            if (File.Exists(@"demo\teste.txt"))
            {
                Console.WriteLine(File.ReadAllText(@"demo\teste.txt"));
            }
            else
            {
                CriarArquivo();
            }
        }

        private static void CriarArquivo()
        {
            Console.WriteLine("\nCriando arquivo...");

            var file = new FileInfo(@"demo\teste.txt");
            if (file.Exists)
                Console.WriteLine("Abortando...\nO arquivo já existe");
            else
            {

                var texto = string.Format("Texto adicionado em {0}{1}",
                    DateTime.Now, Environment.NewLine);
                //File.AppendAllText("demo\\teste.txt", texto);

                File.AppendAllText(@"demo\teste.txt", texto);
                Console.WriteLine("Arquivo criado c/ sucesso");
            }
        }

        private static void CriarPastaSeNaoExistir()
        {
            Console.WriteLine("Criando pasta demo...");

            var folder = new DirectoryInfo("demo");
            if (folder.Exists)
                Console.WriteLine("A pasta demo já existe");
            else
            {
                Directory.CreateDirectory("demo");
                Console.WriteLine("Pasta criada c/ sucesso.");
            }
        }
    }
}
