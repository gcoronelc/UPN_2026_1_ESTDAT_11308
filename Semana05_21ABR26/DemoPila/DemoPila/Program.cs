using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoPila
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hola Gustavo!!!");
            Console.WriteLine("Que hay de nuevo?");


            Dato pr1 = new Dato("Ceviche", 40.0);
            Console.WriteLine(pr1);

            Console.WriteLine("===============================");

            Pila pila = new Pila();
            Console.WriteLine($"Size: {pila.size()}");

            pila.push(new Dato("Chambar", 43.99));
            Console.WriteLine($"Size: {pila.size()}");

            pila.push(new Dato("Causa Ferreñafana", 60.00));
            Console.WriteLine($"Size: {pila.size()}");

            pila.push(new Dato("Espezado Chiclayano", 50.00));
            Console.WriteLine($"Size: {pila.size()}");

            Nodo o = pila.pop();
            Console.WriteLine(o.dato);
            Console.WriteLine($"Size: {pila.size()}");

        }
    }
}
