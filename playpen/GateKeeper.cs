public class GateKeeper
{
    private Castle _castle;

    public GateKeeper(Castle castle)
    {
        _castle = castle;
    }

    public string GetKingsName() => _castle.GetKing().Name;

    public void DeliverMessage(Villager villager, string? gift = null)
    {
        if (villager.Message.Contains("bad"))
        {
            villager.IsArrested = true;
            return;
        }
        _castle.GetKing().ReceiveMessage(villager.Message, gift);

        if(IsKingHappy())
        {
            Invite(villager);
        }
    }

    public bool IsKingHappy() => _castle.GetKing().GetMood() == "Happy";

    public bool Invite(Villager villager)
    {
        string[] preferredGifts = _castle.GetKing().GetPreferredGift();
        if (preferredGifts.Contains(villager.Message))
        {
            DeliverMessage(villager, villager.Message);
            return true;
        }
        return false;
    }

    public List<Villager> GetInvitedList() => _castle.GetVillagerList();
}


