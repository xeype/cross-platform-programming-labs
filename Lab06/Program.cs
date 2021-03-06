using System;
using Lab06.Containers;

namespace Lab06
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Product firstProduct = new("Apple", 1);
            Car firstCar = new("BMW M4", 40000, "YL56789", "Blue", 2.8);
            Boat firstBoat = new("Test Boat", 3000, "Electric", 1300, 300);
            Product secondProduct = new();
            
            // Entities Part
            EntitiesContainer entitiesContainer = new();

            entitiesContainer.AddObject(firstCar);
            entitiesContainer.AddObject(firstProduct);
            entitiesContainer.AddObject(firstBoat);
            
            entitiesContainer.SortObjectsByPrice();
            
            entitiesContainer.ShowObjects();

            Console.WriteLine(entitiesContainer["BMW M4"]);
            
            Console.WriteLine(firstProduct.IsNameNotDefault(firstProduct));
            // Throws exception:
            // Console.WriteLine(secondProduct.IsNameNotDefault(secondProduct));

            Console.WriteLine("------------------");

            // DLL Part 
            DoubleLinkedList<Product> products = new DoubleLinkedList<Product>();
            products.Add(firstBoat);
            products.AddFirst(firstCar);
            products.Add(firstProduct);

            Console.WriteLine(products[1]);
            
            Console.WriteLine("------------------");
            
            products.Remove(firstBoat);
            Console.WriteLine("is products contain first boat: " + products.Contains(firstBoat));
            
            products.ShowAll();
        }
    }
}