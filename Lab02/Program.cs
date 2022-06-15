using System;
using System.Reflection;

namespace Lab02
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Container container = new Container();

            Product firstProduct = new("Apple", 1);
            Product secondProduct = new("Beer", 10);

            Car firstCar = new("Toyota Rav 4", 28000, "1234YL", "White", 2.5);
            Car secondCar = new("Mercedes-Benz CLS 63", 80000, "4321LY", "Black", 3.5);
            Car thirdCar = new("BMW M4", 40000, "YL2314", "Blue", 2.8);

            Boat firstBoat = new("Rib 1100-K", 43000, "Electric", 11.51, 2800);


            container.AddObject(secondProduct);
            container.AddObject(firstCar);
            container.AddObject(firstBoat);
            container.AddObject(firstProduct);
            container.AddObject(thirdCar);
            container.AddObject(secondCar);

            Console.WriteLine("!!!!!!!! BEFORE REMOVE !!!!!!!!");
            container.ShowObjects();

            container.RemoveObjectByIndex(1);

            Console.WriteLine("!!!!!!!! AFTER REMOVE !!!!!!!!");
            container.ShowObjects();

            container.SortObjectsByPrice();

            Console.WriteLine("!!!!!!!! AFTER SORT !!!!!!!!");
            container.ShowObjects();
        }
    }
}