using Lab05.Interfaces;

namespace Lab05
{
    public class Product : IName
    {
        public string name { get; set; }
        public decimal price { get; set; }

        public Product()
        {
            name = "Default";
            price = 0;
        }

        public Product(string name, decimal price)
        {
            this.name = name;
            this.price = price;
        }

        public override string ToString()
        {
            return string.Format("=====================\n" +
                                 "--- Product ---\n" +
                                 "Product Name: {0}\n" +
                                 "Price: {1}$\n" +
                                 "=====================\n", name, price);
        }

        public int CompareTo(string? objName)
        {
            if (name == objName)
                return 0;
            return -1;
        }
    }
}