using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploCola
{
    internal class Cola
    {
        private Nodo cabeza;
        private Nodo cola;


        public Cola()
        {
            this.cabeza = null;
            this.cola = null;
        }

        public void encolar(Alumno dato)
        {
            Nodo nodo = new Nodo(dato);
            // Caso 1: Cola vacia
            if (this.cabeza == null)
            {
                this.cabeza = nodo;
                this.cola = nodo;
                return;
            }
            // Caso 2: Cola con nodos
            cola.siguiente = nodo;
            cola = nodo;
        }

        public Nodo desencolar()
        {
            // Caso 1: Cola sin nodos
            if(this.cabeza == null)
            {
                return null;
            }
            Nodo nodo;
            // Caso 2: Cola con un solo nodo
            if (this.cabeza == this.cola)
            {
                nodo = this.cabeza;
                this.cola = null;
                this.cabeza = null;
                return nodo;
            }
            //Caso 3: Cola con varios nodos
            nodo = this.cabeza;
            this.cabeza = nodo.siguiente;
            nodo.siguiente = null;
            return nodo;
        }
    }
}
