namespace CP4avance
{
    public class Comida
    {
        public string comida { get; set; }
        public double precio { get; set; }

        public Comida() { }

        public Comida(string c, double price)
        {
            this.comida = c;
            this.precio = price;
        }
    }
}