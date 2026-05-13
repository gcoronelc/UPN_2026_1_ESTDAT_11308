using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArbolBinario
{
    public class ArbolBinario
    {

        public Nodo Raiz { get; set; }

        public ArbolBinario()
        {
            this.Raiz = null;
        }

        public void AgregarNodo(int dato)
        {
            Raiz = AgregarRecursivo(this.Raiz,dato);
         }

        public Nodo AgregarRecursivo(Nodo raiz, int valor)
        {
            if(raiz == null)
            {
               return new Nodo(valor);
            }
            if(valor < raiz.Dato)
            {
                raiz.Izquierda = AgregarRecursivo(raiz.Izquierda, valor);
            }
            else if(valor > raiz.Dato)
            {
                raiz.Derecha = AgregarRecursivo(raiz.Derecha, valor);
            }
            return raiz;
        }


        public void MostrarArbol()
        {
            MostrarArbol(this.Raiz, "", true);
        }

        private void MostrarArbol(Nodo nodo, string espacio, bool esUltimo)
        {
            if (nodo == null)
            {
                return;
            }

            Console.Write(espacio);

            if (esUltimo)
            {
                Console.Write("└── ");
                espacio += "    ";
            }
            else
            {
                Console.Write("├── ");
                espacio += "│   ";
            }

            Console.WriteLine(nodo.Dato);

            bool tieneIzquierdo = nodo.Izquierda != null;
            bool tieneDerecho = nodo.Derecha != null;

            if (tieneIzquierdo && tieneDerecho)
            {
                MostrarArbol(nodo.Izquierda, espacio, false);
                MostrarArbol(nodo.Derecha, espacio, true);
            }
            else if (tieneIzquierdo)
            {
                MostrarArbol(nodo.Izquierda, espacio, true);
            }
            else if (tieneDerecho)
            {
                MostrarArbol(nodo.Derecha, espacio, true);
            }
        }


        public void ImprimirInOrden()
        {
            Console.Write("Recorrido InOrden: ");
            ImprimirInOrdenRecursivo(this.Raiz);
            Console.WriteLine();
        }

        private void ImprimirInOrdenRecursivo(Nodo raiz)
        {
            if(raiz != null)
            {
                ImprimirInOrdenRecursivo(raiz.Izquierda);
                Console.Write(raiz.Dato + " ");
                ImprimirInOrdenRecursivo(raiz.Derecha);
            }
        }


        public void ImprimirPreOrden()
        {
            Console.Write("Recorrido PreOrden: ");
            ImprimirPreOrdenRecursivo(this.Raiz);
            Console.WriteLine();
        }

        private void ImprimirPreOrdenRecursivo(Nodo raiz)
        {
            if(raiz != null)
            {
                Console.Write(raiz.Dato + " ");
                ImprimirPreOrdenRecursivo(raiz.Izquierda);
                ImprimirPreOrdenRecursivo(raiz.Derecha);
            }
        }

        public void ImprimirPostOrden()
        {
            Console.Write("Recorrido PostOrden: ");
            ImprimirPostOrdenRecursivo(this.Raiz);
            Console.WriteLine();
        }

        public void ImprimirPostOrdenRecursivo(Nodo raiz)
        {
            if(raiz != null)
            {
                ImprimirPostOrdenRecursivo(raiz.Izquierda);
                ImprimirPostOrdenRecursivo(raiz.Derecha);
                Console.Write(raiz.Dato + " ");
            }
        }


    }
}
