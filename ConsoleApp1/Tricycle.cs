namespace ConsoleApp1
{
    class Tricycle : IWheels
    {
        public int NumberOfWheels { get; private set; }
        public string Name => nameof(Tricycle);

        public Tricycle()
        {
            NumberOfWheels = 12;
        }
    }
}
