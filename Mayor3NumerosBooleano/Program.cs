using System;

namespace Mayor3Numeros
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresa el número Y: ");
            int y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingresa el número X: ");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingresa el número Z: ");
            int z = Convert.ToInt32(Console.ReadLine());

            switch (true)
            {
                case bool _ when x > y && x > z:
                    Console.WriteLine("El número mayor es: " + x);
                    break;
                case bool _ when y > x && y > z:
                    Console.WriteLine("El número mayor es: " + y);
                    break;
                case bool _ when z > x && z > y:
                    Console.WriteLine("El número mayor es: " + z);
                    break;
                default:
                    Console.WriteLine("Los números son iguales.");
                    break;
            }
        }
    }
}