using System;

namespace Arreglos
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] variable = { 0, 1, 2, 3 };       //int[] Contiene mas de un valor
            string[] variable1 = { "El resultado Mayor: " };

            int[] variable2 = { 10, 11, 12, 13 };
            int[] variable3 = { 22, 33, 44, 55 };
            int[] variable4 = { 33, 44, 55, 66 };

            string[] variable5 = { "A", "B,", "C", "D", };
            string[] variable6 = { "Z", "A", "Q", "W",  };
            string[] variable7 = { "S", "D,", "F", "G", };

            Console.WriteLine(variable.Length);     //length Obtenemos el rango de toda las variables




            Console.WriteLine(variable5[0]);
            Console.ReadKey();
            

            
        }
    }
}
