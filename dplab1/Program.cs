namespace dplab1;

public static class Program
{
    public static void Main(string[] args)
    {
        IStrategy discount25 = new Discount25();
        IStrategy doublePrice = new DoublePrice();
        IStrategy noChange = new NoChange();

        Console.WriteLine("Enter one for December");
        Console.WriteLine("Enter two for June or July");
        Console.WriteLine("Enter three for Other Months");
        Console.Write("Enter your choice: ");
        int month = int.Parse(Console.ReadLine() ?? string.Empty);

        PriceCalculator calculator = new Calculator(noChange);
        if (month == 1)
        {
            calculator.SetStrategy(discount25);
        }
        else if (month == 2)
        {
            calculator.SetStrategy(doublePrice);
        }
        else if (month == 3)
        {
            calculator.SetStrategy(noChange);
        }
        else
        {
            Console.WriteLine("Invalid choice");
        }
        Console.WriteLine(calculator.GetDescription());
        Console.WriteLine(calculator.GetPrice());
    }
}
