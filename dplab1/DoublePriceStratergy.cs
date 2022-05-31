namespace dplab1;

public class DoublePrice : IStrategy
{

    public string GetDescription()
    {
        return "Price double";
    }

    public double GetPrice()
    {
        return 2;
    }
}