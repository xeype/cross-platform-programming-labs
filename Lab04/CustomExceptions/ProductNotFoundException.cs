using System;

namespace Lab04.CustomExceptions
{
    public class ProductNotFoundException : Exception
    {
        public ProductNotFoundException()
        {
        }

        public ProductNotFoundException(string name)
            : base($"Product '{name}' not found")
        {
        }

        public ProductNotFoundException(decimal price)
            : base($"Product with price '{price}'$ not found")
        {
        }

        public ProductNotFoundException(int ordinalNum)
            : base($"Product with price '{ordinalNum}'$ not found")
        {
        }
    }
}