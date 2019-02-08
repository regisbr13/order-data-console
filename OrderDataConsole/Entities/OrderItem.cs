using System.Globalization;

namespace OrderDataConsole.Entities
{
    class OrderItem
    {
        public int Quantity { get; set; }
        public Product Product { get; set; }

        public OrderItem()
        {
        }

        public OrderItem(int quantity, Product product)
        {
            Quantity = quantity;
            Product = product;
        }

        public double SubTotal()
        {
            return Quantity * Product.Prince;
        }

        public override string ToString()
        {
            return Product.ToString() + " Quantity: " + Quantity + ", Subtotal: $" + SubTotal().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
