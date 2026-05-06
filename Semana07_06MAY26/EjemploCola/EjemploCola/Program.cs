using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploCola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Es un Gustavo");

            Cola cola = new Cola();

            cola.encolar(new Alumno("Gustavo", 20));
            cola.encolar(new Alumno("Angela", 20));
            cola.encolar(new Alumno("Jafet", 18));
            cola.encolar(new Alumno("Enfrain", 20));
            cola.encolar(new Alumno("Karla", 15));

            Nodo nodo = cola.desencolar();
            while (nodo != null) { 
                Console.WriteLine($"{nodo.dato.nombre} - {nodo.dato.nota}");
                nodo = cola.desencolar();
            }
        }
    }
}
