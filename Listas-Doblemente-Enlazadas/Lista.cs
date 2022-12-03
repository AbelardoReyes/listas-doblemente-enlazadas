using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas_Doblemente_Enlazadas
{
    class Lista
    {
        private Nodo primero = new Nodo();
        private Nodo ultimo = new Nodo();

        public Lista()
        {
            primero = null;
            ultimo = null;
        }
        //Lista doble
        public void Insertar()
        {
            Nodo nuevo = new Nodo();
            Console.Write("Ingresa una palabra: ");
            nuevo.Dato = Console.ReadLine();
            if (primero == null)
            {
                primero = nuevo;
                ultimo = primero;
                return;
            }
            if (primero.Dato.CompareTo(nuevo.Dato) > 0)
            {
                nuevo.Siguiente = primero;
                primero.Atras = nuevo;
                primero = nuevo;
                return;
            }

            Nodo actual = new Nodo();
            actual = primero;
            while (actual.Siguiente != null)
            {
                if (actual.Siguiente.Dato.CompareTo(nuevo.Dato) > 0)
                {
                    nuevo.Siguiente = actual.Siguiente;
                    actual.Siguiente.Atras = nuevo;
                    nuevo.Atras = actual;
                    actual.Siguiente = nuevo;
                    return;
                }
                actual = actual.Siguiente;
            }
            ultimo.Siguiente = nuevo;
            nuevo.Atras = ultimo;
            ultimo = nuevo;
        }
        //desplegarListaPrimero
        public void desplegarListaPrimero()
        {
            Nodo actual = new Nodo();
            actual = primero;
            while (actual != null)
            {
                Console.WriteLine(actual.Dato);
                actual = actual.Siguiente;
            }
        }
        //desplegarListaUltimo
        public void desplegarListaUltimo()
        {
            Nodo actual = new Nodo();
            actual = ultimo;
            while (actual != null)
            {
                Console.WriteLine(actual.Dato);
                actual = actual.Atras;
            }
        }
        //buscarPalabra
        public void buscarPalabra()
        {
            Nodo nuevo = new Nodo();
            Console.Write("Ingresa una palabra: ");
            nuevo.Dato = Console.ReadLine();
            Nodo actual = primero;
            while (actual != null)
            {
                if (actual.Dato == nuevo.Dato)
                {
                    Console.WriteLine("La palabra " + nuevo.Dato + " si se encuentra en la lista");
                    return;
                }
                actual = actual.Siguiente;
            }
            Console.WriteLine("La palabra " + nuevo.Dato + " si se encuentra en la lista");
        }
        //vaciarLista
        public void vaciarLista()
        {
            Nodo actual = new Nodo();
            while (actual != null)
            {
                actual = actual.Siguiente;
                actual.Atras = null;
                primero = actual;
            }
        }
        //eliminarPalabra
        public void eliminarPalabra()
        {
            Nodo nuevo = new Nodo();
            Console.Write("Ingresa una palabra: ");
            nuevo.Dato = Console.ReadLine();
            Nodo actual = primero;
            while (actual.Siguiente != null && actual.Dato != nuevo.Dato)
            {
                actual = actual.Siguiente;
            }
            if (actual.Dato == nuevo.Dato)
            {
                if (actual == primero && actual == ultimo)
                {
                    primero = null;
                    ultimo = null;
                    return;
                }
                    if(actual == primero)
                    {
                        primero = actual.Siguiente;
                        primero.Atras = null;
                        return;
                    }
                    if (actual == ultimo)
                    {
                        ultimo = actual.Atras;
                        ultimo.Siguiente = null;
                        return;
                    }
                    Nodo anterior = actual.Atras;
                    Nodo siguiente = actual.Siguiente;
                    anterior.Siguiente = siguiente;
                    siguiente.Atras = anterior;
            }
        }
        public void modificarPalabra()
        {
            eliminarPalabra();
            Insertar();
        }
    }
}