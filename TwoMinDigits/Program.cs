using TwoMinDigits;

public class Program
{
    public static void Main()
    {
        var result = TwoMinCalculator.SumOfTwoMin(new [] { 1, int.MaxValue });
        Console.WriteLine(result);
    }
}
