using System;
using System.Reflection;

namespace Lab03
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
            
            container.AddObject(firstProduct);
            container.AddObject(firstCar);
            container.AddObject(firstBoat);
            container.AddObject(secondProduct);
            container.AddObject(thirdCar);
            container.AddObject(secondCar);
            
            var bmwCar = container["BMW M4"];
            Console.WriteLine(bmwCar);

            var thirdElement = container[3];
            Console.WriteLine(thirdElement);

            var elementWithPrice10 = container[10m];
            Console.WriteLine(elementWithPrice10);
        }
    }
}