namespace ConsoleApp1
{
    class Car : IWheels
    {
        private string _color = string.Empty;
        public int NumberOfWheels => 4;
        public string Name => nameof(Car);

        public bool IsHybird { get; set; } 
        public void SetColor(string color) => this._color = color;
        public string GetColor() => this._color;
    }
}
