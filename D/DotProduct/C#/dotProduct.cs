﻿using System;

internal class DotProduct
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Calculates dot product of hardcoded decimals");
        Console.WriteLine(dotProduct(new List<decimal> { 1, 3, 5 }, new List<decimal> { 3, 5, 8 }));
    }

    public static decimal dotProduct(List<decimal> a, List<decimal> b)
    {
        return a.Zip(b, (x, y) => x * y).Sum();
    }
}