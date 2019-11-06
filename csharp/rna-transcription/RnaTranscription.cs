using System.Linq;

public static class RnaTranscription
{
    private const string DNA = "GCTA";
    private const string RNA = "CGAU";

    public static string ToRna(string nucleotide)
    {
        return string.Join("", nucleotide.Select(n => RNA[DNA.IndexOf(n)]));
    }
}
