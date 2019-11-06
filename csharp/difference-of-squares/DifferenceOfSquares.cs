using System;
using System.Linq;

public static class DifferenceOfSquares
{
    public static int CalculateSquareOfSum(int max)
    {
        int sum = Enumerable.Range(1, max).Sum();

        return (int)Math.Pow(sum, 2);
    }

    public static int CalculateSumOfSquares(int max)
    {
        var arr = Enumerable.Range(1, max);
        return arr.Aggregate((sum, x) => sum + (int)Math.Pow(x, 2));
    }

    public static int CalculateDifferenceOfSquares(int max) => CalculateSquareOfSum(max) - CalculateSumOfSquares(max);
}
