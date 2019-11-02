using System;

public static class ResistorColor
{
    private static string[] _colors = new string[] {
        "black",
        "brown",
        "red",
        "orange",
        "yellow",
        "green",
        "blue",
        "violet",
        "grey",
        "white"
    };

    public static int ColorCode(string color)
    {
        return Array.FindIndex(_colors, cv => cv == color.ToLowerInvariant());
    }

    public static string[] Colors()
    {
        return _colors;
    }
}