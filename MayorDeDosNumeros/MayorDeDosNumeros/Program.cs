using System;

namespace MayorDeDosNumeros
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el Primer Valor: ");
            int PrimerValor = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Ingrese el Segundo Valor: ");
            int SegundoValor = Convert.ToInt32(Console.ReadLine());

            switch (PrimerValor.CompareTo(SegundoValor))
            {
                case 0:
                    Console.WriteLine("Los números son iguales.");
                    break;
                case 1:
                    Console.WriteLine($"El número mayor es: {PrimerValor}");
                    break;
                case -1:
                    Console.WriteLine($"El número mayor es: {SegundoValor}");
                    break;    
            }

            Console.ReadKey();
        
        }
    }
}
