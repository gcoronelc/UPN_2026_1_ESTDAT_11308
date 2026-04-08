namespace ProyectoListaDoble
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ListaDoble lista = new ListaDoble();

            lista.MostrarAdelante();

            lista.InsertarAlFinal(new Producto("Teclado",75.00));
            lista.InsertarAlFinal(new Producto("Monitor", 180.00));
            lista.InsertarAlInicio(new Producto("Impresora", 570.00));

            lista.MostrarAdelante();

        }
    }
}
