using System;
using System.Runtime.InteropServices;

namespace Mayor3Numeros
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresa el Numero Y: ");
            int y = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Ingresa el Numero X: ");
            int z = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Ingresa el numero Z: "); 
            int x = Convert.ToInt32(Console.ReadLine());

            if (x > y && x > z)
            {
                Console.Clear();
                Console.WriteLine("El numero mayor es: " + x);
                
                
            }
            else if (y > x && y > z) 
            {
                Console.Clear();
                Console.WriteLine("El numero menor es: " + y); 
                
                
            }
            else if ( z>x&&z>y ) 
            {
                Console.Clear();
                Console.WriteLine("El numero mayor es: " + z); 
                
                
            }
            else
            {
                Console.WriteLine(x);
            }
            Console.ReadKey();
        }
    }
}
