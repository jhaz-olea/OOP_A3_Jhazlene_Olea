namespace ConsoleApp1
{
    internal class Program
    {

        static void Main(string[] args)
        {
            IWheels honda = new Car();
            IWheels kawasaki = new Tricycle();
            Airplane airplane = new Airplane();

            List<object> vehicles = new();
            vehicles.Add(honda);
            vehicles.Add(kawasaki);
            vehicles.Add(airplane);

            foreach (var i in vehicles)
            {
                if (i is IWheels)
                {
                    Console.WriteLine($"{((IWheels)i).Name} has {((IWheels)i).NumberOfWheels} wheels");
                    string name = $"{i.GetType()}";
                }
            }
        }
    }
}
