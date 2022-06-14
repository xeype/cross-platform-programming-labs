using System;

namespace Lab01
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Product firstProduct = new();
            Product secondProduct = new("Beer", 1);
            
            Console.Write(firstProduct.ToString());
            Console.Write(secondProduct.ToString());
            
            Car firstCar = new();
            Car secondCar = new ("Toyota Rav 4", 1000, "12345YL", "White", 2.5);

            Console.Write(firstCar.ToString());
            Console.Write(secondCar.ToString());


            Boat firstBoat = new();
            Boat secondBoat = new("Rib 1100-K", 40000, "Electric", 11.51, 2800);
            
            Console.Write(firstBoat.ToString());
            Console.Write(secondBoat.ToString());
        }
    }
}