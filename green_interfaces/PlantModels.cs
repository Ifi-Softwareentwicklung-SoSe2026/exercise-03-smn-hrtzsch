namespace green_interfaces;

public abstract class Plants
{
    public string Name { get; }
    public int AgeInYears { get; }

    protected Plants(string name, int ageInYears)
    {
        Name = name;
        AgeInYears = ageInYears;
    }

    public virtual string GetDescription() => $"{GetType().Name}: {Name}, Alter {AgeInYears} Jahre";
}

public interface ICookable
{
    string GetCookingSuggestion();
}

public interface IWoodProducer
{
    string GetWoodUsage();
}

public sealed class AppleTree : Plants, IWoodProducer
{
    public AppleTree(string name, int ageInYears) : base(name, ageInYears) { }

    public string GetWoodUsage() => "Schnittreste koennen als kleines Brennmaterial genutzt werden.";
}

public sealed class Pumpkin : Plants, ICookable
{
    public Pumpkin(string name, int ageInYears) : base(name, ageInYears) { }

    public string GetCookingSuggestion() => "Ideal fuer Suppe und Ofengemuese.";
}

public sealed class ChestnutTree : Plants, ICookable, IWoodProducer
{
    public ChestnutTree(string name, int ageInYears) : base(name, ageInYears) { }

    public string GetCookingSuggestion() => "Maronen koennen geroestet oder gekocht werden.";

    public string GetWoodUsage() => "Liefert robustes Holz fuer den Aussenbereich.";
}
