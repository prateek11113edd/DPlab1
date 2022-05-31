using System.Configuration;
namespace dplab1;

public abstract class PriceCalculator
{
    private IStrategy _discount;
    private readonly double _basePrice = Convert.ToDouble(ConfigurationManager.AppSettings["BasePrice"]);

    protected PriceCalculator(IStrategy discount)
    {
        _discount = discount;
    }

    public string GetDescription()
    {
        return _discount.GetDescription();
    }

    public double GetPrice()
    {
        return _basePrice * _discount.GetPrice();
    }

    public void SetStrategy(IStrategy discount)
    {
        _discount = discount;
    }
}
