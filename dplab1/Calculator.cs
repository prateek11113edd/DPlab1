namespace dplab1;

public class Calculator : PriceCalculator
{

    public Calculator(IStrategy discount) : base(discount) { }
}