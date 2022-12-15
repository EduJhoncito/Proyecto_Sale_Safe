namespace Sale_Save.Models
{
    public class CarritoItem
    {
        private carrito prod;
        private int cant;

        public carrito Producto
        {
            get { return prod; }
            set { prod = value; }
        }
        public int Cantidad
        {
            get { return cant; }
            set { cant = value; }
        }


        public CarritoItem()
        {
        }


        public CarritoItem(carrito prod, int cant)
        {
            this.prod = prod;   
            this.cant = cant;   
        }

    }
}
