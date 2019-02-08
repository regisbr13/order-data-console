namespace OrderDataConsole.Entities
{
    class Product
    {
        public string Name { get; set; }
        public double Prince { get; set; }

        public Product()
        {
        }

        public Product(string name, double price)
        {
            Name = name;
            Prince = price;
        }
    }
}
