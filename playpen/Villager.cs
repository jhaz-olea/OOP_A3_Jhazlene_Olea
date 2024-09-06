public class Villager
{
    string _name;
    
    public Villager(string name) => _name = name;
    public string Name => _name;
    public string Message { get; set; }
    public string? Gift { get; set; }
    public bool IsArrested { get; set; }
}