using System;
using System.Diagnostics;
using System.Numerics;

#if DEBUG
    Console.WriteLine("----------------------------------------------------------");
    Console.WriteLine("WARNING: DEBUG MODE IS ON, CALCULATING WILL BE MUCH SLOWER");
    Console.WriteLine("----------------------------------------------------------");
#endif

Console.WriteLine("Number of iterations, more iterations means more precision");
Console.WriteLine("Počet iterací, více iterací znamená větší přesnost");

Console.Write("Enter number of iterations / ");
Console.Write("Zadejte počet iterací: ");
string input = Console.ReadLine();

BigInteger iterations = BigInteger.Parse(input);
double ludolfo = CalculateLudolph(iterations);
Console.WriteLine($"Ludolfovo číslo s {iterations} iteracemi: {ludolfo}");

static double CalculateLudolph(BigInteger iterations)
{
    double result = 0.0;
    for (int i = 0; i < iterations; i++)
    {
        Debug.WriteLine(4 * result);
        double term = 1.0 / (2 * i + 1);
        if (i % 2 == 0)
            result += term;
        else
            result -= term;
    }
    return 4 * result;
}