using Microsoft.Office.Interop.Word;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoDynamic
{
    class Program
    {
        static void Main(string[] args)
        {

            dynamic word = new Application();
            //word.Teste();
            //var resultado = word.Batata.Testando();
            dynamic doc = word.Documents.Open(@"c:\dev\teste.docx");
            int count = doc.Words.Count;
            Console.WriteLine("Total de palavras: " + count);
            word.Quit();
            Console.WriteLine("Fim");
            Console.ReadLine();

        }
    }
}
