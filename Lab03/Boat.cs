namespace Lab03
{
    public class Boat : Product
    {
        public string engineType { get; set; }
        public double length { get; set; }
        public decimal displacementVolume { get; set; }

        public Boat()
        {
            engineType = "unknown";
            length = 0;
            displacementVolume = 0;
        }

        public Boat(string name, decimal price, string engineType, double length, decimal displacementVolume)
        {
            this.name = name;
            this.price = price;
            this.engineType = engineType;
            this.length = length;
            this.displacementVolume = displacementVolume;
        }

        public override string ToString()
        {
            return string.Format("=====================\n" +
                                 "--- Boat ---\n" +
                                 "Model: {0}\n" +
                                 "Price: {1}$\n" +
                                 "Engine type: {2}\n" +
                                 "Length: {3} meters\n" +
                                 "Displacement volume: {4} liters\n" +
                                 "=====================\n", name, price, engineType, length, displacementVolume);
        }
    }
}