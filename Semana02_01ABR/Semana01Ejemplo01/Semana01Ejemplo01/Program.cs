// Programa principal para probar la lista enlazada

// Importando el namespace para usar las clases Nodo y ListaEnlazada
using Semana01Ejemplo01;

// Crear la lista
ListaEnlazada lista = new ListaEnlazada();

// Insertar 3 elementos
lista.AgregarAlFinal(10);
lista.AgregarAlFinal(30);
lista.AgregarAlFinal(20);
lista.AgregarAlFinal(25);

// Listar elementos
Console.WriteLine("Elementos de la lista enlazada:");
lista.Imprimir();
Console.WriteLine("Suma: " + lista.SumaNodos());

// Buscar
Nodo encontrado = lista.Buscar(33);
string mensaje = (encontrado == null) ? "NULL" : encontrado.Dato.ToString();
Console.WriteLine("Mensaje: " + mensaje);

// Ordenamiento
lista.OrdenamientoBurbuja();
lista.Imprimir();

// Mezcla
Console.WriteLine("Mezcla de listas");
ListaEnlazada lista1 = new ListaEnlazada();
lista1.AgregarAlFinal(30);
lista1.AgregarAlFinal(20);
lista1.AgregarAlFinal(10);
lista1.AgregarAlFinal(50);
ListaEnlazada lista2 = new ListaEnlazada();
lista2.AgregarAlFinal(25);
lista2.AgregarAlFinal(40);
lista2.AgregarAlFinal(15);
lista2.AgregarAlFinal(45);
lista2.AgregarAlFinal(5);
lista2.AgregarAlFinal(35);

lista1.OrdenamientoBurbuja();
lista2.OrdenamientoBurbuja();
ListaEnlazada listaMezcla = Utilitario.mezclar(lista1, lista2);

lista1.Imprimir();
lista2.Imprimir();
listaMezcla.Imprimir();

// Fin del programa
Console.WriteLine("Presione una tecla para salir...");
Console.ReadKey();

