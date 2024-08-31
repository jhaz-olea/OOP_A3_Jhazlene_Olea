using System.Text.Json;

namespace coffee_shop_procedural;

public class Identity
{
    Dictionary<string, string> users = new Dictionary<string, string>();

    public Identity(string usersFile)
    {
        LoadUsers(usersFile);
        SaveUsers(usersFile);
    }
    void SaveUsers(string usersFile)
    {
        string json = JsonSerializer.Serialize(users);
        File.WriteAllText(usersFile, json);
    }


    void LoadUsers(string usersFile)
    {
        if (File.Exists(usersFile))
        {
            string json = File.ReadAllText(usersFile);
            users = JsonSerializer.Deserialize<Dictionary<string, string>>(json);
        }
        else
        {
            users.Add("admin", "password"); // Default user
            SaveUsers(usersFile);
        }
    }


    public string Login(string username, string password)
    {
        if (users.ContainsKey(username) && users[username] == password)
        {
            return username;
        }
        return string.Empty;
    }
}
