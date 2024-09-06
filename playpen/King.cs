public class King {
    private string _name;
    private string _mood;

    private string[] preferredGifts = [ "apple", "gold", "sword" ];

    public King(string name)
    {
        _name = name;
        _mood = "Content";
    }

    public string GetMood() => _mood;

    public string[] GetPreferredGift() => preferredGifts;

    public string Name => _name;

    public void ReceiveMessage(string message, string? gift = null)
    {
        Console.WriteLine($"King {_name} received the message: {message}");

        _mood = gift == null ? _mood : "Happy";
    }
}


