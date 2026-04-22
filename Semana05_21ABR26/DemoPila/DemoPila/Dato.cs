namespace DemoPila
{
    internal class Dato
    {
        public string plato { get; set; }
        public double precio { get; set; }

        public Dato(string plato, double precio)
        {
            this.plato = plato;
            this.precio = precio;
        }

        public override string ToString()
        {
            return $"({this.plato}, {this.precio})";
        }

    }
}
