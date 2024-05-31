using System;

namespace RangoNumeros
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresa un dato X: ");
            int x = Convert.ToInt32(Console.ReadLine()); //Ingresa un dato tipo entero "int"

            Console.WriteLine("Ingresa un dato Y: ");
            int y = Convert.ToInt32(Console.ReadLine());
          

            for (int i = x; i <= y; i++)
            {
                Console.Write("{0} " ,i); //Se llama el metodo
            }



            
            Console.ReadKey();
        }
    }
}
