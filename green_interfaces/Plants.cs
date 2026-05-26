namespace green_interfaces;

public abstract class Plants
{
    protected Plants(string name, int ageInYears)
    {
        Name = name;
        AgeInYears = ageInYears;
    }

    public string Name { get; }
    public int AgeInYears { get; }

    public abstract string GetDescription();
}
