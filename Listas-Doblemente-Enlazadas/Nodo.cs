using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas_Doblemente_Enlazadas
{
    class Nodo
    {
        private string dato;
        private Nodo siguiente;
        private Nodo atras;


        public string Dato
        {
            get { return dato; }
            set { dato = value; }
        }
                public Nodo Siguiente
        {
            get { return siguiente; }
            set { siguiente = value; }
        }
                public Nodo Atras
        {
            get { return atras; }
            set { atras = value; }
        }
    }
}
