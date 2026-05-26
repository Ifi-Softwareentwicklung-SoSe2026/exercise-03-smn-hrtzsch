namespace green_interfaces;

public class ChestnutTree : Plants, ICookable, IWoodProducer
{
    public ChestnutTree(string name, int ageInYears) : base(name, ageInYears)
    {
    }

    public override string GetDescription() =>
        $"Kastanienbaum \"{Name}\" ist {AgeInYears} Jahr(e) alt.";

    public string GetCookingSuggestion() =>
        "Die Kastanien können geröstet oder gekocht werden.";

    public string GetWoodUsage() =>
        "Das Holz eignet sich z. B. für Pfähle oder Brennholz.";
}
