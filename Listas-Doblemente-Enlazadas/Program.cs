using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas_Doblemente_Enlazadas
{
    class Program
    {
        static void Main(string[] args)
        {
            Lista Lista = new Lista();
            Console.WriteLine("sigue insertar");
            Lista.Insertar();
            Lista.Insertar();
            Lista.Insertar();
            Lista.Insertar();
            Console.WriteLine("sigue buscar");
            Lista.buscarPalabra();
            Console.WriteLine("sigue eliminar");
            Lista.eliminarPalabra();
            Console.WriteLine("sigue insertar");
            Lista.Insertar();
            Console.WriteLine("sigue modificar");
            Lista.modificarPalabra();
            Console.WriteLine();
            Console.WriteLine("Primero al ultimo");
            Lista.desplegarListaPrimero();
            Console.WriteLine();
            Console.WriteLine("Ultimo al Primero");
            Lista.desplegarListaUltimo();
            Console.ReadKey();
        }
    }
}
