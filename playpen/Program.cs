var castle = new Castle("Arthur");
GateKeeper gateKeeper = castle.GetGateKeeper();

Villager goodVillager = new("Bob");
goodVillager.Message = "hello";
goodVillager.Gift = "apple";

Villager badVillager = new("Joe");
badVillager.Message = "word";
goodVillager.Gift = "relic";

gateKeeper.DeliverMessage(goodVillager, "");
gateKeeper.DeliverMessage(badVillager, "apple");

foreach(var villager in gateKeeper.GetInvitedList())
{
    Console.WriteLine($"Villager {villager.Name} is invited");
}