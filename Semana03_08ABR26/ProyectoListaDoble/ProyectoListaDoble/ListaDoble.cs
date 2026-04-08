using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoListaDoble
{
    internal class ListaDoble
    {

        private NodoDoble Cabeza;
        private NodoDoble Cola;

        // Insertar al final O(1)
        public void InsertarAlFinal(Producto dato)
        {
            var nuevo = new NodoDoble(dato);
            if (Cabeza is null) { 
                Cabeza = Cola = nuevo; 
                return; 
            }
            nuevo.Anterior = Cola;
            Cola.Siguiente = nuevo;
            Cola = nuevo;
        }

        // Insertar al inicio O(1)
        public void InsertarAlInicio(Producto dato)
        {
            /*var nuevo = new NodoDoble(dato);
            if (Cabeza is null)
            {
                Cabeza = Cola = nuevo;
                return;
            }
            nuevo.Anterior = Cola;
            Cola.Siguiente = nuevo;
            Cola = nuevo;*/
        }


        // Recorrer hacia adelante O(n)
        public void MostrarAdelante()
        {
            if (Cabeza is null) {
                Console.Write("La lista esta vacia.\n\n");
                return; 
            }
            var actual = Cabeza;
            while (actual != null)
            {
                Console.Write($"({actual.Dato}) -> ");
                actual = actual.Siguiente;
            }
            Console.WriteLine("NULL\n\n");
        }
    }
}
