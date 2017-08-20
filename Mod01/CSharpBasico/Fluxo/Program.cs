using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fluxo
{
    class Program
    {
        static void Main(string[] args)
        {
            //if - else
            var campeaoDosCampeoes = "Corinthians";
            if (campeaoDosCampeoes == "Corinthians")
            {
                Console.WriteLine("campeaoDosCampeos está correto");
            }
            else 
            {
                Console.WriteLine("campeaoDosCampeos está incorreto");
            }

            //if - else if - else
            if (campeaoDosCampeoes == "Corinthians")
            {
                Console.WriteLine("campeaoDosCampeos está correto");
            }
            else if(campeaoDosCampeoes == "Parmeira")
            {
                Console.WriteLine("Sem mundial");
            }
            else
            {
                Console.WriteLine("campeaoDosCampeos está incorreto");
            }



            //switch == select
            switch (campeaoDosCampeoes)
            {
                case "Corinthians": // || "Coringão"
                case "Coringão":
                    Console.WriteLine("Correto!");
                    break;
                case "São Paulo":
                    Console.WriteLine("Bi rebaixado");
                    break;
                default:
                    Console.WriteLine("Não sei");
                    break;
            }


            Console.WriteLine("---------------");
            Console.Write("Informe a nota do aluno: ");
            int nota = Convert.ToInt32(Console.ReadLine());

            //Se a nota > 8 = Muito bem
            //Se a nota < 8 and nota >= 6 --> Razoável
            //Caso contrário -> Vai estudar vagabundo
            if (nota >= 8) 
            {
                Console.WriteLine("Muito bem");
            }
            else if (nota < 8 && nota >= 6) //||
            {
                Console.WriteLine("Razoável");
            }
            else{
                Console.WriteLine("Vai estudar vagabundo");

            }

            
            Console.WriteLine("Valor da nota: " + nota);


            //ternário ==> iif
            Console.WriteLine("xpto" == "xpto"?"XPTO tá certo":"XPTO errado");



            Console.ReadLine();
        }
    }
}
