namespace Semana01Ejemplo01
{
    internal class ListaEnlazada
    {
        public Nodo Cabeza;

        public ListaEnlazada()
        {
            Cabeza = null;
        }

        public void AgregarAlFinal(int dato)
        {
            Nodo nuevoNodo = new Nodo(dato);
            if (Cabeza == null)
            {
                Cabeza = nuevoNodo;
                return; // Termina
            }
            Nodo actual = Cabeza;
            while (actual.Siguiente != null)
            {
                actual = actual.Siguiente;
            }
            actual.Siguiente = nuevoNodo;
        }

        public void Imprimir()
        {
            if (Cabeza == null)
            {
                Console.WriteLine("La lista está vacía.");
                return;
            }
            Nodo actual = Cabeza;
            while (actual != null)
            {
                Console.Write(actual.Dato + " ->");
                actual = actual.Siguiente;
            }
            Console.WriteLine(" NULL");
        }

        public int SumaNodos()
        {
            int suma = 0;
            Nodo actual = Cabeza;
            while (actual != null)
            {
                suma += actual.Dato;
                actual = actual.Siguiente;
            }
            return suma;
        }

        public Nodo Buscar(int dato)
        {
            Nodo encontrado = null; 
            Nodo actual = Cabeza; 
            while (actual != null) { 
                if (actual.Dato == dato) { 
                    encontrado = new Nodo(actual.Dato); 
                    break; 
                } 
                actual = actual.Siguiente; 
            }
            return encontrado;
        }



        public void OrdenamientoBurbuja()
        {
            if (Cabeza == null) return;
            bool hayIntercambio;
            do
            {
                hayIntercambio = false;
                Nodo actual = Cabeza;
                while (actual.Siguiente != null)
                {
                    if (actual.Dato > actual.Siguiente.Dato)
                    {
                        int temp = actual.Dato;
                        actual.Dato = actual.Siguiente.Dato;
                        actual.Siguiente.Dato = temp;
                        hayIntercambio = true;
                    }
                    actual = actual.Siguiente;
                }
            } while (hayIntercambio);
        }

        

    }
}
