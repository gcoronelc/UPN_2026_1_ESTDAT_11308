namespace Semana01Ejemplo01
{
    internal class Utilitario
    {

        public static ListaEnlazada mezclar(ListaEnlazada lista1, ListaEnlazada lista2)
        {
            ListaEnlazada listaMezcla = new ListaEnlazada();

            Nodo actual1 = lista1.Cabeza;
            Nodo actual2 = lista2.Cabeza;
            int dato;

            while (actual1 != null && actual2 != null)
            {
                if(actual1.Dato <  actual2.Dato)
                {
                    dato = actual1.Dato;
                    actual1 = actual1.Siguiente;
                } else
                {
                    dato = actual2.Dato;
                    actual2 = actual2.Siguiente;
                }
                listaMezcla.AgregarAlFinal(dato);
            }

            while(actual1 != null)
            {
                listaMezcla.AgregarAlFinal(actual1.Dato);
                actual1 = actual1.Siguiente;
            }

            while (actual2 != null)
            {
                listaMezcla.AgregarAlFinal(actual2.Dato);
                actual2 = actual2.Siguiente;
            }

            return listaMezcla;
        }
    }
}
