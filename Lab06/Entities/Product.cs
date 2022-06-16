using System;
using Lab06.Interfaces;

namespace Lab06
{
    public class Product : IName, INameSecondImplementation<object?>
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

        public int IsNameNotDefault(object? obj)
        {
            if (obj is not Product product) return -1;
            if (product?.name != "Default")
                return 0;

            return -1;
        }

        public int CompareTo(string? objName)
        {
            if (name == objName)
                return 0;
            return -1;
        }
    }
}