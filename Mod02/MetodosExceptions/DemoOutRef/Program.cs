using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoOutRef
{
    class Program
    {
        static void Main(string[] args)
        {
            var pet = new Pet();

            var animal = "calopsita";
            pet.VerificarPet(ref animal);

            Console.WriteLine(animal);


            pet.VerificarPet(1, out animal);
            Console.WriteLine(animal);


            Console.ReadLine();
        }
    }



}
