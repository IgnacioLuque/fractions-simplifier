using FractionsSimplifierApp;

namespace FractionsSimplifierTests;

[TestClass]
public class FractionsSimplifierTests
{
    private FractionsSimplifier fractionsSimplifier;

    [TestInitialize]
    public void Setup()
    {
        fractionsSimplifier = new FractionsSimplifier();
    }

    [TestMethod]
    [DataRow(1, 1)]
    [DataRow(2, 2)]
    [DataRow(24, 12)]
    public void Simplifies_fractions_to_integers(int numerator, int denominator)
    {
        (int numerator, int? denominator) result = fractionsSimplifier.SimplifiedFraction(numerator, denominator);

        Assert.AreEqual(0, numerator % denominator);
        Assert.IsNotNull(result.numerator);
        Assert.IsNull(result.denominator);
        Assert.AreEqual(result.numerator, numerator / denominator);
    }

    [TestMethod]
    [DataRow(4, 6, 2, 3)]
    [DataRow(10, 11, 10, 11)]
    [DataRow(100, 400, 1, 4)]
    [DataRow(1000, 400, 5, 2)]
    public void Simplifies_fractions(int numerator, int denominator, int expectedNumerator, int expectedDenominator)
    {
        (int numerator, int? denominator) result = fractionsSimplifier.SimplifiedFraction(numerator, denominator);

        Assert.AreEqual(expectedNumerator, result.numerator);
        Assert.AreEqual(expectedDenominator, result.denominator);
    }
}
