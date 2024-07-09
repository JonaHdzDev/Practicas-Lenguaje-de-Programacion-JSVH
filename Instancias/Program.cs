using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Instancias
{
    public class Program
    {
        static void Main(string[] args)
        {

            ProductosID productosID2 = new ProductosID();  //Crea la instancia "ProductosID" y la convierte en objeto "productosID2();" 

            productosID2.ID = " A ";                          //productosID2.ID esta llamando lo que tenga el ID "A"

            productosID2.name = " B ";

            Console.WriteLine(productosID2.name + productosID2.ID);
            Console.ReadKey();
        }
    }
}
