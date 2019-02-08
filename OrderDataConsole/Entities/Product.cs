using System.Globalization;

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

        public override string ToString()
        {
            return Name + ", $" + Prince.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
