using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ContarCaracteres
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce un texto: ");
            string texto = Console.ReadLine();
            int contador = ContarCaracteres(texto);
            Console.WriteLine();
            Console.WriteLine();


            Console.WriteLine("La cadena " + texto + " " + " contiene " + contador + " caracteres " );
            Console.ReadKey();
        }

        static int ContarCaracteres(string cadena)
        {
            return cadena.Length;
        }

    }
}
