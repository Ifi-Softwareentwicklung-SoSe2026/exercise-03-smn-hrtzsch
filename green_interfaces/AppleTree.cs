namespace green_interfaces;

public class AppleTree : Plants, IWoodProducer
{
    public AppleTree(string name, int ageInYears) : base(name, ageInYears)
    {
    }

    public override string GetDescription() =>
        $"Apfelbaum \"{Name}\" ist {AgeInYears} Jahre alt.";

    public string GetWoodUsage() =>
        "Das Holz kann z. B. für kleine Werkstücke oder als Brennholz genutzt werden.";
}
