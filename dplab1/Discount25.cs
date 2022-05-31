namespace dplab1;

public class Discount25 : IStrategy
{

    public string GetDescription()
    {
        return "25 percent discount";
    }

    public double GetPrice()
    {
        return 0.75;
    }
}
