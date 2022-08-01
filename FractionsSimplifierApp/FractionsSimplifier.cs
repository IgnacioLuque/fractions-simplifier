namespace FractionsSimplifierApp;

public class FractionsSimplifier
{
    public string ResultMessage((int numerator, int? denominator) result)
    {
        if (result.denominator.HasValue)
            return $"{result.numerator}/{result.denominator}";

        return $"{result.numerator}";
    }

    public (int, int?) SimplifiedFraction(int numerator, int denominator)
    {
        if (numerator >= denominator &&
            numerator % denominator == 0)
        {
            return (numerator / denominator, null);
        }

        var greatestCommonDivisor = GreatestCommonDivisor(numerator, denominator);

        return (numerator / greatestCommonDivisor, denominator / greatestCommonDivisor);
    }

    int GreatestCommonDivisor(int a, int b)
    {
        int remainder;

        while (b != 0)
        {
            remainder = a % b;
            a = b;
            b = remainder;
        }

        return a;
    }
}
