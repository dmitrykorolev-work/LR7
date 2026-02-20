namespace LR7E3;

internal class Program
{
    static void Main(string[] args)
    {
        Func<double, double> discountCalculator = null;

        discountCalculator += price => price * 0.95; // 5% discount
        discountCalculator += price => price * 0.9; // 10% discount
        discountCalculator += price => price - 100; // -100 discount

        double price = 1000;

        //price = discountCalculator( price ); // Will call only the last assigned lambda expression (price - 100)

        foreach ( Func<double, double> f in discountCalculator.GetInvocationList() )
        {
            price = f(price); // Apply each discount in the invocation list
        }

        Console.WriteLine(price);
    }
}
