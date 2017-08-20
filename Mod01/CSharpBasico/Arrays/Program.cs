using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array1;
            array1 = new int[5];
            array1[0] = 1;
            array1[1] = 2;
            array1[2] = 3;
            array1[3] = 4;
            array1[4] = 5;
            //array1[5] = 6;
            Console.WriteLine(array1[3]);

            var array2 = new int[3] { 1, 2, 3 };
            Console.WriteLine(array2[2]);

            //Forma mais usada
            string[] nomes = { "Fabiano", "Priscila", "Raphael", "Isabel" };
            Console.WriteLine(nomes[nomes.Length - 1]); //último nome

            //Arrays Multidimensionais
            //var array3 = new int[3,4]
            var array3 = new int[,] { { 1, 2, 3, 4 }, { 5, 6, 7, 8 } };
            Console.WriteLine(array3[0, 0]);
            Console.WriteLine(array3[1, 0]);

            //Jagged --> Array dentro de array
            int[][] jaggedArray = new int[2][];
            jaggedArray[0] = new int[] { 1, 2, 3, 4, 5,6 };
            jaggedArray[1] = new int[] { 6, 7, 8, 9, 10 };
            Console.WriteLine(jaggedArray[0][0]);//Primeiro array dentro do primeiro
            Console.WriteLine(jaggedArray[1][4]); //ùltimo array dentro do segundo array

            Console.ReadLine();
        }
    }
}
