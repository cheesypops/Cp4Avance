namespace CP4avance
{
    public class Pedido : Comida
    {
        public int cantidad { get; set; }
        public Comida plato { get; set; }

        public Pedido() { }

        public Pedido(Comida c, int canti)
        {
            this.cantidad = canti;
            this.plato = c;
        }
    }
}