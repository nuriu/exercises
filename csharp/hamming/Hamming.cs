using System;
using System.Linq;

public static class Hamming
{
    public static int Distance(string firstStrand, string secondStrand)
    {
        if (firstStrand.Length != secondStrand.Length)
        {
            throw new ArgumentException("Strands must be equal!");
        }

        return firstStrand.Zip(secondStrand).Count(p => p.First != p.Second);
    }
}
