public class Castle {
    private King _king;
    private List<Villager> _villagerList;

    public Castle(string king)
    {
        _king = new King(king);
        _villagerList = new List<Villager>();
    }

    public King GetKing() => _king;

    public void InviteVillager(Villager villager)
    {
        _villagerList.Add(villager);
    }

    public List<Villager> GetVillagerList() => _villagerList;

    public GateKeeper GetGateKeeper() => new GateKeeper(this);
}


