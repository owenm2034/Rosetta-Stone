using System;

internal class DotProduct
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Calculates dot product of hardcoded decimals");
        Console.WriteLine(dotProduct(new List<decimal> { 1, 3, 5 }, new List<decimal> { 3, 5, 8 }));
    }

    public static decimal dotProduct(List<decimal> a, List<decimal> b)
    {
        if (a.Count() != b.Count())
        {
            throw new DotProductError("a & b must have the same length.");
        }
        return a.Zip(b, (x, y) => x * y).Sum();
    }

    public class DotProductError : Exception
    {
        string? What { get; set; }

        public DotProductError(string what)
        {
            if (what == null)
            {
                What = "not-specified";
            }
            else
            {
                What = what;

            }
        }

        public string GetWhat()
        {
            return What;
        }
    }
}