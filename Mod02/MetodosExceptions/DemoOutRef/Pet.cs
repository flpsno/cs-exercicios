using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoOutRef
{
    class Pet
    {
        public void VerificarPet(ref string animalzinho)
        {
            if (animalzinho == "cachorro")
            {
                animalzinho = "É um cachorro!";
            }
            else
            {
                animalzinho = "Não é um cachorro";
            }
        }

        public void VerificarPet(int tipo, out string animalzinho)
        {

            if (tipo == 1)
                animalzinho = "é um gatinho";
            else
                animalzinho = "não é um gatinho";

        }

        //public string VerificarPet(string animalzinho)
        //{
        //    if (animalzinho == "cachorro")
        //    {
        //        return "É um cachorro!";
        //    }
        //    else
        //    {
        //        return "Não é um cachorro";
        //    }
        //}
    }
}
