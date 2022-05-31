namespace dplab1;

public class NoChange : IStrategy
{

    public string GetDescription()
    {
        return "No Change";
    }

    public double GetPrice()
    {
        return 1;
    }
}