﻿using System;

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

            if (PrimerValor > SegundoValor)
            {
                case 0:
                    Console.WriteLine(PrimerValor>SegundoValor);
                    break;
                    
                case 1:
                    Console.WriteLine(SegundoValor>PrimerValor);
                    break;

            else if (SegundoValor > PrimerValor)
            {
                Console.WriteLine("eL Numero Mayor es: " +  SegundoValor);
            }

            Console.ReadKey();
        }
        

    }
}
