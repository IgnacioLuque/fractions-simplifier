using FractionsSimplifierApp;

string[] fractionParts = args[0].Split('/');

if (fractionParts.Count() != 2)
    throw new FormatException("The received fraction has an invalid format");

int numerator;
int denominator;

var numeratorSuccess = int.TryParse(fractionParts[0], out numerator);
var denominatorSuccess = int.TryParse(fractionParts[1], out denominator);

if (!numeratorSuccess || !denominatorSuccess)
    throw new InvalidCastException("The received fraction does not have valid integer parts");

if (denominator == 0)
    throw new ArithmeticException("Denominator is 0");

var fractionsSimplifier = new FractionsSimplifier();
var simplifiedFraction = fractionsSimplifier.SimplifiedFraction(numerator, denominator);

Console.WriteLine(fractionsSimplifier.ResultMessage(simplifiedFraction));
