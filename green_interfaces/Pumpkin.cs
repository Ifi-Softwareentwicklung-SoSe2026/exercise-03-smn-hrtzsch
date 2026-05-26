namespace green_interfaces;

public class Pumpkin : Plants, ICookable
{
    public Pumpkin(string name, int ageInYears) : base(name, ageInYears)
    {
    }

    public override string GetDescription() =>
        $"Kürbis \"{Name}\" ist {AgeInYears} Jahr(e) alt.";

    public string GetCookingSuggestion() =>
        "Ideal für Suppe, Ofengemüse oder Püree.";
}
