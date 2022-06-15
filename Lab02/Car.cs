namespace Lab02
{
    public class Car : Product
    {
        public string vinNumber { get; set; }
        public string color { get; set; }
        public double engineCapacity { get; set; }

        public Car()
        {
            vinNumber = "unknown";
            color = "unknown";
            engineCapacity = 0.0;
        }

        public Car(string name, decimal price, string vinNumber, string color, double engineCapacity)
        {
            this.name = name;
            this.price = price;
            this.vinNumber = vinNumber;
            this.color = color;
            this.engineCapacity = engineCapacity;
        }


        public override string ToString()
        {
            return string.Format("=====================\n" +
                                 "--- Car ---\n" +
                                 "Model: {0}\n" +
                                 "Price: {1}$\n" +
                                 "Vin number: {2}\n" +
                                 "Color: {3}\n" +
                                 "Engine capacity: {4}\n" +
                                 "=====================\n", name, price, vinNumber, color, engineCapacity);
        }
    }
}