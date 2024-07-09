using System;

namespace PruebasSwitch
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Console.Writeline nos permite modificar las opciones del menu tanto aumentarlas o disminuirlas
            Console.WriteLine("Elije una opcion del Menu 1-6: \n" + "1.- Hamburguesa $3 \n" + "2.- Papa Asada $4 \n" + "3.- Tacos de Trompo $8\n" + "4.- Pizza $10 \n" + "5.- Tortas $7 \n" + "6.- Papas a la Francesa $2");

            // int op = nos permite digitalizar las opciones mediante los valores asigandos
            int op = Convert.ToInt32(Console.ReadLine());

            Console.Clear();    //Limpia la consola 

            // while nos permite asignar los numeros de opciones del menu
            while (op < 0 || op > 6)
            {
                Console.WriteLine("Elije una opcion del Menu (Digitando el numero de Opcion): \n" + "1.- Hamburguesa $3 \n" + "2.- Papa Asada $4 \n" + "3.- Tacos de Trompo $8\n" + "4.- Pizza $10 \n" + "5.- Tortas $7 \n" + "6.- Papas a la Francesa $2");
                op = Convert.ToInt32(Console.ReadLine());

                Console.Clear();
            }


            Console.WriteLine("Elije una cantidad:");
            // int cantidad = nos permite elegir a nuestra convenienza la cantidad deseada
            int cantidad = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Desea llevar algo mas? TRUE OR FALSE");
            //bool masPedido = nos permite decidir mediante TRUE OR FALSE si queremos pedir otra cosa o dar por terminada la compra
            bool masPedido = Convert.ToBoolean(Console.ReadLine());

            Console.Clear();

            //int cuenta = nos permite multiplicar las opciones del menu por la cantidad y precios del menu
            int cuenta = (Opcion(op) * cantidad);

            //while masPedido = nos da a elegir de nuevo las opciones del menu
            while (masPedido)
            {
                Console.WriteLine("Elije una opcion del Menu 1-6: \n" + "1.- Hamburguesa $3 \n" + "2.- Papa Asada $4 \n" + "3.- Tacos de Trompo $8\n" + "4.- Pizza $10 \n" + "5.- Tortas $7 \n" + "6.- Papas a la Francesa $2");
                op = Convert.ToInt32(Console.ReadLine());

                Console.Clear();
                while (op < 0 || op > 6)
                {
                    Console.WriteLine("Elije una opcion del Menu (Digitando el numero de Opcion): \n" + "1.- Hamburguesa $3 \n" + "2.- Papa Asada $4 \n" + "3.- Tacos de Trompo $8\n" + "4.- Pizza $10 \n" + "5.- Tortas $7 \n" + "6.- Papas a la Francesa $2");
                    op = Convert.ToInt32(Console.ReadLine());

                    Console.Clear();
                }

                Console.WriteLine("Elije una cantidad:");
                cantidad = Convert.ToInt32(Console.ReadLine());

                cuenta += (Opcion(op) * cantidad);

                Console.WriteLine("Desea llevar algo mas? TRUE OR FALSE");
                masPedido = Convert.ToBoolean(Console.ReadLine());

                Console.Clear();
            }
            // Console.WriteLine = nos da el total de nuestra compra mas la cuenta de los articulos del menu
            Console.WriteLine("El total de su cuenta seria de $" + cuenta.ToString());

            Console.ReadKey();
        }

        public static int Opcion(int op)
        {
            //switch = podemos asignar los Id del menu mediante "case" y los "return" nos retornar el valor del product(o)s
            switch (op)
            {
                case 1: return 3;
                case 2: return 4;
                case 3: return 8;
                case 4: return 10;
                case 5: return 7;
                case 6: return 2;
                case 0: return 0;
                default: return 0;
            }
        }
    }
}

