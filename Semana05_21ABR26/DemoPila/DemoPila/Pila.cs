using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoPila
{
    internal class Pila
    {

        private Nodo top;
        private int _size;

        public Pila()
        {
            this.top = null;
            this._size = 0;
        }

        public void push(Dato dato)
        {
            Nodo nodo = new Nodo(dato);
            nodo.siguiente = this.top;
            this.top = nodo;
            this._size++;
        }

        public int size()
        {
            return this._size;
        }

        public Nodo pop()
        {
            if (this.top == null)
            {
                return null;
            }
            Nodo nodo = this.top;
            this.top = nodo.siguiente;
            nodo.siguiente = null;
            this._size--;
            return nodo;
        }

    }
}
